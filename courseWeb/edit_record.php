<?php
// Подключение к базе данных и запрос на получение данных по ID
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

$id = $_POST['id']; // Получаем ID записи из запроса или из другого источника

$query = "SELECT * FROM main_ip WHERE id = :id";
$statement = $db->prepare($query);
$statement->bindParam(':id', $id);
$statement->execute();

if ($row = $statement->fetch(PDO::FETCH_ASSOC)) {
    // Полученные данные записываем в переменные
    $id = $row['id'];
    $ip_address = $row['ip_address'];
    $port = $row['port'];
    $reading_id = $row['reading_id'];

    // Теперь можно использовать переменные для предзаполнения полей формы
} else {
    // Обработка случая, если запись не найдена
    echo "Запись не найдена.";
    exit;
}
?>


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

        form {
            width: 80%;
            margin: 0 auto;
        }

        label {
            display: block;
            margin-bottom: 10px;
        }

        input[type="text"] {
            width: 100%;
            padding: 5px;
            margin-bottom: 10px;
        }

        .button {
            background-color: #000080;
            color: #fff;
            border: solid;
            padding: 5px 10px;
            cursor: pointer;
            text-decoration: none;
            width: auto;
            user-select: none;
            margin-bottom: 5px;
        }
        

        a{
            position: relative;
            margin-top: 15px;
            margin-left: 141px;
            color:#fff;

        }

        .button:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <h1>Редактирование записи в базе данных</h1>
    <!-- Форма для редактирования записи -->
    <form action="edit_record_process.php" method="post">
        <input type="hidden" name="id" value="<?php echo $row['id']; ?>">
        
        <label for="ip_address">IP Address:</label>
        <input type="text" name="ip_address" value="<?php echo $row['ip_address']; ?>" required><br>
        
        <label for="port">Port:</label>
        <input type="text" name="port" value="<?php echo $row['port']; ?>" required><br>
        
        <label for="reading_id">Reading ID:</label>
        <input type="text" name="reading_id" value="<?php echo $row['reading_id']; ?>" required><br>
        
        <input type="submit" value="Сохранить" class="button">
    </form>
    
    <a href="index.php">Вернуться к списку записей</a>
</body>
</html>
