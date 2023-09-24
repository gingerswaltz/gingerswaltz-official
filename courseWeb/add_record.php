<!DOCTYPE html>
<html>
<head>
    <title>Добавление записи</title>
    <style>
        /* Стиль CSS */
        body {
            background-color: #222;
            color: #fff;
            font-family: Arial, sans-serif;
        }

        h1 {
            text-align: center;
            margin: 20px;
        }

        form {
            width: 80%;
            margin: 0 auto;
        }

        label {
            display: block;
            margin-bottom: 10px;
        }

        input[type="text"] {
            width: 100%;
            padding: 5px;
            margin-bottom: 10px;
        }

        input[type="number"] {
            width: 100%;
            padding: 5px;
            margin-bottom: 10px;
        }

        .button {
            background-color: #000080;
            color: #fff;
            border: solid;
            padding: 5px 10px;
            cursor: pointer;
            text-decoration: none;
            width: auto;
            user-select: none;
            margin-bottom: 10px;
        }
        
        a{
            position: relative;
            margin-top: 15px;
            margin-left: 141px;
            color:#fff;
        }

        .button:hover {
            background-color: #0056b3;
        }
    </style>





<body>
    <?php 

    $host = $_COOKIE['host'];
    $port = $_COOKIE['port'];
    $username = $_COOKIE['username'];
    $password = $_COOKIE['password'];
    $dbname = $_COOKIE['dbname'];
    try {
        $db = new PDO("pgsql:host=$host;port=$port;dbname=$dbname;user=$username;password=$password");
        $db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    } catch (PDOException $e) {
    die("Ошибка подключения к базе данных: " . $e->getMessage());
    }
    $tableName=$_COOKIE['table'];
    ?>

<h1 id="table-heading">Добавление записи в базу данных (Таблица: <?php echo $tableName ?>)</h1>;
<?php    
    $query = "SELECT column_name, data_type FROM information_schema.columns WHERE table_name = :tableName";
    $statement = $db->prepare($query);
    $statement->bindParam(':tableName', $tableName, PDO::PARAM_STR);
    $statement->execute();
    $tableColumns = $statement->fetchAll(PDO::FETCH_ASSOC);

//  HTML-форма с полями ввода на основе полученной информации
    echo '<form action="add_record_process.php" method="post">';
    foreach ($tableColumns as $column) {
    $columnName = $column['column_name'];
    $dataType = $column['data_type'];
    
    // Генерация полей ввода в зависимости от типа данных
    if ($dataType == 'text') {
        echo "<input type='text' name='$columnName' placeholder='$columnName'>";
    } elseif ($dataType == 'integer') {
        echo "<input type='number' name='$columnName' placeholder='$columnName'>";
    } else {
        echo "<input type='text' name='$columnName' placeholder='$columnName'>";
    }
}
    echo '<input type="submit" value="Добавить запись">';
    echo '</form>';
?>    
<a href="dashboard.php">Вернуться к списку записей</a>
</body>
</html>
