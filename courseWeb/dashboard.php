<?php
error_reporting(0);

$host = $_COOKIE['host'];
$port = $_COOKIE['port'];
$username = $_COOKIE['username'];
$password = $_COOKIE['password'];
$dbname = $_COOKIE['dbname'];
$table = $_COOKIE['table'];

try {
    $db = new PDO("pgsql:host=$host;port=$port;dbname=$dbname;user=$username;password=$password");
    $db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
} catch (PDOException $e) {
    die("Ошибка подключения к базе данных: " . $e->getMessage());
}

$tableName = $table; // Замените на имя вашей таблицы
$query = "SELECT column_name FROM information_schema.columns WHERE table_name = :tableName";
$statement = $db->prepare($query);
$statement->bindParam(':tableName', $tableName, PDO::PARAM_STR);
$statement->execute();
$tableColumns = $statement->fetchAll(PDO::FETCH_COLUMN);

// Получение параметров сортировки из URL
$sortColumn = isset($_GET['sort_column']) ? $_GET['sort_column'] : null;
$sortOrder = isset($_GET['sort_order']) ? $_GET['sort_order'] : 'ASC';

// Взять имя первичного ключа из имени первого столбца
if (!empty($tableColumns)) {
    $primaryKeyName = reset($tableColumns);
    setcookie("primaryKeyName", $primaryKeyName);
} 
//  количество записей на одной странице
$itemsPerPage = 5; 

$currentPage = isset($_GET['page']) ? intval($_GET['page']) : 1;

//  смещение для SQL-запроса
$offset = ($currentPage - 1) * $itemsPerPage;

// Выполнение SQL-запроса для получения данных с учетом сортировки и пагинации
$queryData = "SELECT * FROM $tableName";

if ($sortColumn) {
    $queryData .= " ORDER BY $sortColumn $sortOrder";
}

$queryData .= " LIMIT $itemsPerPage OFFSET $offset";

$dataStatement = $db->query($queryData);

if ($dataStatement === false) {
    die("Ошибка выполнения запроса данных: " . $db->errorInfo()[2]);
}
//  запрос для подсчета общего количества записей
$countQuery = "SELECT COUNT(*) FROM $tableName";
$totalCount = $db->query($countQuery)->fetchColumn();

//  общее количество страниц
$totalPages = ceil($totalCount / $itemsPerPage);
?>

<!DOCTYPE html>
<html>
<head>
    <title>Просмотр базы данных</title>
    <style>
        body {
            background-color: #222;
            color: #fff;
            font-family: Arial, sans-serif;
        }

        h1 {
            text-align: center;
            margin: 20px;
        }

        table {
            width: 80%;
            margin: 0 auto;
            border-collapse: collapse;
        }

        th, td {
            padding: 10px;
            text-align: left;
            border-bottom: 1px solid #444;
        }

        th {
            background-color: #333;
        }

        tr:nth-child(even) {
            background-color: #444;
        }

        tr:hover {
            background-color: #0056b3; /* Изменение цвета при наведении */
        }

        a {
            color: #00f;
            text-decoration: none;
        }

        a:hover {
            text-decoration: underline;
        }

        .button {
            background-color: #000080;
            color: #fff;
            border: solid;
            padding: 5px 10px;
            cursor: pointer;
            text-decoration: none;
            width: 100px;
            user-select: none;
            margin-top: 5px;
            margin-bottom: 5px;
        }

        .button:hover {
            background-color: #0056b3;
        }
        /* Стили для перемещенной строки и кнопки поиска */
        .header {
            display: flex;
            justify-content: space-between;
            align-items: center;
            padding: 20px;
        }

        .search-container {
            text-align: right;
        }

        .search-input {
            width: 200px;
            padding: 5px;
        }

        .search-button {
            background-color: #000080;
            color: #fff;
            border: solid;
            padding: 5px 10px;
            cursor: pointer;
            text-decoration: none;
        }

        .search-button:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <h1>Просмотр данных из базы данных <?php echo $dbname?> (Таблица: <?php echo $tableName; ?>)</h1>
   
    <!-- Кнопка для добавления записи -->
    <form action="add_record.php" method="post">
        <input type="hidden" name="table" value="<?php echo $tableName; ?>">
        <button type="submit" class="button add-button">Добавить запись</button>
    </form>

    <button type="button" onclick="window.location.href='index.php'">Разлогиниться</button>
<!-- Перемещенная строка и кнопка поиска -->
<div class="search-container">
        <form action="search.php" method="get">
            <input type="text" class="search-input" name="search_query" placeholder="Введите запрос для поиска">
            <button type="submit" class="search-button">Поиск</button>
        </form>
    </div>
    <table>
        <tr>
            <?php
            // Вывод заголовков столбцов
            foreach ($tableColumns as $column) {
                echo "<th><a href='dashboard.php?sort_column=$column&sort_order=";
                
                // Определяем направление сортировки для данного столбца
                if ($column === $sortColumn) {
                    // Если столбец сортируется, меняем направление сортировки
                    $newSortOrder = ($sortOrder === 'ASC') ? 'DESC' : 'ASC';
                    echo $newSortOrder;
                } else {
                    // Если столбец не сортируется, начинаем сортировку по возрастанию
                    echo 'ASC';
                }

                echo "'>$column</a></th>";
            }
            ?>
        </tr>
    
        <?php
        if ($dataStatement) { 
            while ($row = $dataStatement->fetch(PDO::FETCH_ASSOC)) {
                echo "<tr>";
                foreach ($tableColumns as $column) {
                    echo "<td>" . $row[$column] . "</td>";
                }
                
                // Получение ID для текущей строки
                $id = $row[$primaryKeyName];

                // Кнопки для изменения и удаления записи
                echo "<td>";
                echo "<form action='edit_record.php' method='post'>";
                echo "<input type='hidden' name='id' value='$id'>";
                echo "<button type='submit' class='button'>Изменить</button>";
                echo "</form>";

                echo "<form action='delete_record.php' method='post'>";
                echo "<input type='hidden' name='id' value='$id'>"; // Включение ID в форму удаления
                echo "<button type='submit' class='button'>Удалить</button>";
                echo "</form>";
                echo "</td>";

                echo "</tr>";
            }
        }
        ?>
    </table>
     
</form>
<!-- Пагинация -->
<div class="pagination">
        <?php
        // Выводите ссылку на предыдущую страницу, если она доступна
        if ($currentPage > 1) {
            echo "<a href='dashboard.php?sort_column=$sortColumn&sort_order=$sortOrder&page=" . ($currentPage - 1) . "' class='button'>Предыдущая</a>";
        }

        // Выводите ссылку на следующую страницу, если она доступна
        if ($currentPage < $totalPages) {
            echo "<a href='dashboard.php?sort_column=$sortColumn&sort_order=$sortOrder&page=" . ($currentPage + 1) . "' class='button'>Следующая</a>";
        }
        ?>
    </div>
</body>
</html>

<?php
$db = null; // Закрываем соединение с базой данных
?>
