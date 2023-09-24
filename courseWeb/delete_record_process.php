<?php
// Подключение к базе данных (по аналогии с вашим кодом подключения)
        // Успешное подключение, сохраняем данные о подключении в сессии
        $host  = $_COOKIE['host'];
        $port = $_COOKIE['port'];
        $username  = $_COOKIE['username'];
        $password = $_COOKIE['password'];
        $dbname = $_COOKIE['dbname'];
        $table= $_COOKIE['table'];

try {
    $db = new PDO("pgsql:host=$host;port=$port;dbname=$dbname;user=$username;password=$password");
} catch (PDOException $e) {
    die("Ошибка подключения к базе данных: " . $e->getMessage());
}

// Проверка наличия ID записи для удаления
if (isset($_POST['id'])) {
    $id = $_POST['id'];

    // Подготовка SQL-запроса для удаления записи
    $query = "DELETE FROM $table WHERE id = :id";
    $statement = $db->prepare($query);
    $statement->bindParam(':id', $id, PDO::PARAM_INT);

    // Выполнение запроса
    if ($statement->execute()) {
        echo "Запись успешно удалена из базы данных.";
        header("Location: dashboard.php"); 
        exit;
    } else {
        echo "Произошла ошибка при удалении записи из базы данных.";
        header("Location: dashboard.php"); 
        exit;
    }
} else {
    echo "ID записи не указано.";
    header("Location: dashboard.php"); 
    exit;
}

// Закрытие соединения с базой данных
$db = null;
?>
