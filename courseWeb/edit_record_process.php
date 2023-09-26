<?php
error_reporting(0);

$host = $_COOKIE['host'];
$port = $_COOKIE['port'];
$username = $_COOKIE['username'];
$password = $_COOKIE['password'];
$dbname = $_COOKIE['dbname'];
$table = $_COOKIE['table'];
$id = $_POST['id'];
$primaryKeyName = $_COOKIE['primaryKeyName'];
try {
    $db = new PDO("pgsql:host=$host;port=$port;dbname=$dbname;user=$username;password=$password");
    $db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
} catch (PDOException $e) {
    die("Ошибка подключения к базе данных: " . $e->getMessage());
}

$tableName = $table;

// Создайте массив для хранения данных, которые будут обновлены в таблице
$dataToUpdate = [];

// Получите значения из POST-запроса и добавьте их в массив данных
foreach ($_POST as $columnName => $value) {
    $dataToUpdate[$columnName] = $value;
}
// Вывод данных для отладки
echo "<pre>";
print_r($dataToUpdate);
echo "</pre>";
// Добавьте имя первичного ключа в массив данных
$dataToUpdate[$primaryKeyName] = $id;

// Генерируйте SQL-запрос на основе данных из массива
$setClause = implode(', ', array_map(function ($column) {
    return "$column = :$column";
}, array_keys($dataToUpdate)));

$query = "UPDATE $tableName SET $setClause WHERE $primaryKeyName = :id";

try {
    $statement = $db->prepare($query);

    // Привязать параметр :id
    $statement->bindParam(':id', $dataToUpdate[$primaryKeyName], PDO::PARAM_INT);

    // Привязать параметры для остальных столбцов
    foreach (array_keys($dataToUpdate) as $column) {
        $statement->bindParam(":$column", $dataToUpdate[$column]);
    }

    $statement->execute();
    header("Location: dashboard.php");
} catch (PDOException $e) {
    echo "Ошибка при обновлении записи: " . $e->getMessage();
}

$db = null; // Закрываем соединение с базой данных
?>  

<a href="dashboard.php">Вернуться к списку записей</a>
