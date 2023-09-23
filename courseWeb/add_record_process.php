<?php
// Подключение к базе данных (по аналогии с вашим кодом подключения)
$host = "localhost";
$port = "5432";
$dbname = "DBForWebServer";
$user = "postgres";
$password = "1";

try {
    $db = new PDO("pgsql:host=$host;port=$port;dbname=$dbname;user=$user;password=$password");
} catch (PDOException $e) {
    die("Ошибка подключения к базе данных: " . $e->getMessage());
}

// Обработка данных из формы
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $ipAddress = $_POST['ip_address'];
    $port = $_POST['port'];
    $readingId = $_POST['reading_id'];

    // Выполните вставку записи в базу данных, используя полученные данные
    $query = "INSERT INTO main_ip (ip_address, port, reading_id) VALUES (:ip_address, :port, :reading_id)";
    $statement = $db->prepare($query);
    $statement->bindParam(':ip_address', $ipAddress);
    $statement->bindParam(':port', $port);
    $statement->bindParam(':reading_id', $readingId);

    if ($statement->execute()) {
        echo "Запись успешно добавлена в базу данных.";
        header("Location: index.php"); // Замените "index.php" на путь к вашей домашней странице
        exit;
    } else {
        echo "Произошла ошибка при добавлении записи в базу данных.";
        header("Location: index.php"); // Замените "index.php" на путь к вашей домашней странице
        exit;
    }
}

// Закрытие соединения с базой данных
$db = null;
?>
