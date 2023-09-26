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
        }

        .button:hover {
            background-color: #0056b3;
        }
    </style>

<?php
error_reporting(0);

// Подключение к базе данных (добавьте свои данные для подключения)
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

// Получение названий столбцов из таблицы
$tableName = $table; // Замените на имя вашей таблицы
$query = "SELECT column_name FROM information_schema.columns WHERE table_name = :table";
$statement = $db->prepare($query);
$statement->bindParam(':table', $tableName, PDO::PARAM_STR);
$statement->execute();

$tableColumns = [];
while ($row = $statement->fetch(PDO::FETCH_ASSOC)) {
    $tableColumns[] = $row['column_name'];
}

// Получение запроса из формы поиска
$searchQuery = isset($_GET['search_query']) ? $_GET['search_query'] : '';

// Разделение запроса по символу '='
$searchParts = explode('=', $searchQuery);

if (count($searchParts) === 2) {
    $columnName = trim($searchParts[0]);
    $columnValue = trim($searchParts[1]);

    // Проверка, что название столбца совпадает с одним из существующих
    if (in_array($columnName, $tableColumns)) {
        // Формирование SQL-запроса для поиска
        $query = "SELECT * FROM $tableName WHERE $columnName = :columnValue";

        // Подготовка и выполнение запроса
        $statement = $db->prepare($query);
        $statement->bindParam(':columnValue', $columnValue, PDO::PARAM_STR);
        $statement->execute();

        // Отображение результатов поиска
        echo "<h2>Результаты поиска:</h2>";
        echo "<table border='1'>";
        echo "<tr><th>$primaryKeyName</th>";
        foreach ($tableColumns as $column) {
            echo "<th>$column</th>";
        }
        echo "</tr>";

        while ($row = $statement->fetch(PDO::FETCH_ASSOC)) {
            echo "<tr>";
            echo "<td>" . $row[$primaryKeyName] . "</td>";
            foreach ($tableColumns as $column) {
                echo "<td>" . $row[$column] . "</td>";
            }
            echo "</tr>";
        }

        echo "</table>";
    } else {
        echo "Неверное название столбца: $columnName";
    }
} else {
    echo "Неверный формат запроса. Используйте формат 'название столбца=значение'.";
}

// Закрытие соединения с базой данных
$db = null;
?>
<a href="dashboard.php">Вернуться к списку записей</a>
