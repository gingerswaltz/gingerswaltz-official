<?php

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    // Здесь определите значения переменных $host, $port, $username, $password и $dbname
    $host = $_POST['host'];
    $port = $_POST['port'];
    $username = $_POST['username'];
    $password = $_POST['password'];
    $dbname = $_POST['dbname'];
    $table=$_POST['table'];

    try {
        $db = new PDO("pgsql:host=$host;port=$port;dbname=$dbname;user=$username;password=$password");
        // Установите атрибуты PDO, например, обработку ошибок
        $db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        session_start(); // Начало сессии

        // Успешное подключение, сохраняем данные о подключении в сессии
        setcookie("host", $host);
        setcookie("port", $port);
        setcookie("username", $username);
        setcookie("password", $password);
        setcookie("dbname", $dbname);
        setcookie("table",$table);
        header("Location: dashboard.php"); // Перенаправляем на другую страницу
        exit;
    } catch (PDOException $e) {
        $error = "Ошибка подключения: " . $e->getMessage();
    }
}
?>
<a href="index.php">Вернуться к логину</a>
