<?php
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $host = $_POST['host'];
    $port = $_POST['port'];
    $username = $_POST['username'];
    $password = $_POST['password'];
    $dbname = $_POST['dbname'];

    try {
        $db = new PDO("pgsql:host=$host;port=$port;dbname=$dbname;user=$username;password=$password");
        $db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

        // Запрос для получения списка таблиц
        $query = "SELECT table_name FROM information_schema.tables WHERE table_schema = 'public'";
        $statement = $db->prepare($query);
        $statement->execute();
        $tables = $statement->fetchAll(PDO::FETCH_COLUMN);

        // Возвращаем список таблиц в формате JSON
        echo json_encode($tables);
    } catch (PDOException $e) {
        echo "Ошибка подключения к базе данных: " . $e->getMessage();
    }
}
?>
