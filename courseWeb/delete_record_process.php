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

// Проверка наличия ID записи для удаления
if (isset($_POST['id'])) {
    $id = $_POST['id'];

    // Подготовка SQL-запроса для удаления записи
    $query = "DELETE FROM main_ip WHERE id = :id";
    $statement = $db->prepare($query);
    $statement->bindParam(':id', $id, PDO::PARAM_INT);

    // Выполнение запроса
    if ($statement->execute()) {
        echo "Запись успешно удалена из базы данных.";
        header("Location: index.php"); // Замените "index.php" на путь к вашей домашней странице
        exit;
    } else {
        echo "Произошла ошибка при удалении записи из базы данных.";
        header("Location: index.php"); // Замените "index.php" на путь к вашей домашней странице
        exit;
    }
} else {
    echo "ID записи не указано.";
    header("Location: index.php"); // Замените "index.php" на путь к вашей домашней странице
    exit;
}

// Закрытие соединения с базой данных
$db = null;
?>
