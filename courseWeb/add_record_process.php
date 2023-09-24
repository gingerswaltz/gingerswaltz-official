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

$tableName = $table;

// Создайте массив для хранения данных, которые будут вставлены в таблицу
$dataToInsert = [];

// Получите значения из POST-запроса и добавьте их в массив данных
foreach ($_POST as $columnName => $value) {
    $dataToInsert[$columnName] = $value;
}

// Генерируйте SQL-запрос на основе данных из массива
$columns = implode(', ', array_keys($dataToInsert));
$values = ':' . implode(', :', array_keys($dataToInsert));
$query = "INSERT INTO $tableName ($columns) VALUES ($values)";

try {
    $statement = $db->prepare($query);
    $statement->execute($dataToInsert);
    header("Location: dashboard.php");
    exit;
} catch (PDOException $e) {
    echo "Ошибка при добавлении записи: " . $e->getMessage();
}

$db = null; // Закрываем соединение с базой данных
?>
