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
    $table_name = $_POST['table_name']; // Получаем имя таблицы
    $data = $_POST['data']; // Получаем структуру данных в виде ассоциативного массива

    // Подготавливаем запрос для вставки данных в указанную таблицу
    $placeholders = implode(', ', array_fill(0, count($data), '?'));
    $query = "INSERT INTO $table_name (" . implode(', ', array_keys($data)) . ") VALUES ($placeholders)";
    
    // Выполняем вставку данных
    $statement = $db->prepare($query);
    $values = array_values($data);
    if ($statement->execute($values)) {
        echo "Запись успешно добавлена в таблицу $table_name.";
        header("Location: index.php"); // Замените "index.php" на путь к вашей домашней странице
        exit;
    } else {
        echo "Произошла ошибка при добавлении записи в таблицу $table_name.";
        header("Location: index.php"); // Замените "index.php" на путь к вашей домашней странице
        exit;
    }
}

// Закрытие соединения с базой данных
$db = null;
?>
