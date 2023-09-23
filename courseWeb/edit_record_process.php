<!DOCTYPE html>
<html>
<head>
    <title>Редактирование записи</title>
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

        .message {
            text-align: center;
            margin: 20px;
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
</head>
<body>
    <h1>Редактирование записи в базе данных</h1>
    <div class="message">
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

$success = false; // Переменная для отслеживания успешности операции редактирования

// Обработка данных из формы
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $id = filter_input(INPUT_POST, 'id', FILTER_VALIDATE_INT);
    $ipAddress = isset($_POST['ip_address']) ? htmlspecialchars($_POST['ip_address'], ENT_QUOTES, 'UTF-8') : '';
    $port = isset($_POST['port']) ? htmlspecialchars($_POST['port'], ENT_QUOTES, 'UTF-8') : '';
    $readingId = isset($_POST['reading_id']) ? htmlspecialchars($_POST['reading_id'], ENT_QUOTES, 'UTF-8') : '';



    // Проверяем, что данные были корректно обработаны
    if ($id !== false && $ipAddress !== null && $port !== false && $readingId !== false) {
        // Выполните операцию UPDATE записи в базе данных, используя полученные данные и ID
        $query = "UPDATE main_ip SET ip_address = :ip_address, port = :port, reading_id = :reading_id WHERE id = :id";
        $statement = $db->prepare($query);
        $statement->bindParam(':ip_address', $ipAddress);
        $statement->bindParam(':port', $port);
        $statement->bindParam(':reading_id', $readingId);
        $statement->bindParam(':id', $id);

        if ($statement->execute()) {
            $success = true; // Устанавливаем флаг успешного редактирования
        } else {
            $success = false; // Устанавливаем флаг ошибки редактирования
        }
    } else {
        // Обработка случая, если данные из формы не прошли фильтрацию
        echo "Некорректные данные из формы.";
    }
}

// Закрытие соединения с базой данных
$db = null;
        if ($success) {
            echo "Запись успешно обновлена в базе данных.";
            header("Location: index.php"); // Замените "index.php" на путь к вашей домашней странице
            exit;
        } else {
            echo "Произошла ошибка при редактировании записи в базе данных.";
            header("Location: index.php"); // Замените "index.php" на путь к вашей домашней странице
            exit;
        }
        ?>
</div>
    
<a href="index.php" class="button">Вернуться к списку записей</a>
</body>
</html>
