<?php
session_start();
error_reporting(0);

$host = $_COOKIE['host'];
$port = $_COOKIE['port'];
$username = $_COOKIE['username'];
$password = $_COOKIE['password'];
$dbname = $_COOKIE['dbname'];
$table=$_COOKIE['table'];

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
// Выполнение SQL-запроса для получения данных
$queryData = "SELECT * FROM $tableName"; 
$queryArray = explode(" ", $queryData);
$dataStatement = $db->query($queryData);

if ($dataStatement === false) {
    die("Ошибка выполнения запроса данных: " . $db->errorInfo()[2]);
}
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
        }

        .button:hover {
            background-color: #0056b3;
        }
    </style>




<body>
    <h1>Просмотр данных из базы данных <?php echo $dbname?> (Таблица: <?php echo $tableName; ?>)</h1>
   
    <!-- Кнопка для добавления записи -->
    <form action="add_record.php" method="post">
        <input type="hidden" name="table" value="<?php echo $tableName; ?>">
        <button type="submit" class="button add-button">Добавить запись</button>
    </form>

    <button type="button" onclick="window.location.href='index.php'">Разлогиниться</button>

    <table>
        <tr>
            <?php
            // Вывод заголовков столбцов
            foreach ($tableColumns as $column) {
                echo "<th>$column</th>";
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
        $id = $row['id'];

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
</body>
</html>

<?php
$db = null; // Закрываем соединение с базой данных
?>

