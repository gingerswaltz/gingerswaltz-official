<!DOCTYPE html>
<html>
<head>
    <title>Редактирование записи</title>
    <style>
        /* Ваш стиль CSS здесь */
    </style>
</head>
<body>
    <h1>Редактирование записи</h1>
    
    <?php
    // Подключение к базе данных и получение данных для редактирования
    $dbHost = 'localhost';
    $dbUsername = 'postgres';
    $dbPassword = '1';
    $dbName = 'DBForWebServer';
    try {
        $pdo = new PDO("pgsql:host=$dbHost;dbname=$dbName", $dbUsername, $dbPassword);
        $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

        // Получение данных для редактирования
        $id = $_POST['id']; // Получаем ID из предыдущей страницы
        $query = "SELECT * FROM main_ip WHERE id = :id";
        $statement = $pdo->prepare($query);
        $statement->bindParam(':id', $id);
        $statement->execute();
        $row = $statement->fetch(PDO::FETCH_ASSOC);



        if ($_SERVER['REQUEST_METHOD'] === 'POST') {
            $id = $_POST['id'];
            $newIpAddress = $_POST['ip_address'];
            $newPort = $_POST['port'];
            $newReadingId = $_POST['reading_id'];
        
            // Обновление данных в базе данных
            $updateQuery = "UPDATE main_ip SET ip_address = :ip_address, port = :port, reading_id = :reading_id WHERE id = :id";
            $updateStatement = $db->prepare($updateQuery);
            $updateStatement->bindParam(':ip_address', $newIpAddress);
            $updateStatement->bindParam(':port', $newPort);
            $updateStatement->bindParam(':reading_id', $newReadingId);
            $updateStatement->bindParam(':id', $id);
        
            if ($updateStatement->execute()) {
                echo "<p>Данные успешно обновлены.</p>";
            } else {
                echo "<p>Произошла ошибка при обновлении данных.</p>";
            }
        }
        
        // Обработка формы после отправки
        if ($_SERVER['REQUEST_METHOD'] === 'POST') {
            $newIpAddress = $_POST['ip_address'];
            $newPort = $_POST['port'];
            $newReadingId = $_POST['reading_id'];

            // Обновление данных в базе данных
            $updateQuery = "UPDATE main_ip SET ip_address = :ip_address, port = :port, reading_id = :reading_id WHERE id = :id";
            $updateStatement = $pdo->prepare($updateQuery);
            $updateStatement->bindParam(':ip_address', $newIpAddress);
            $updateStatement->bindParam(':port', $newPort);
            $updateStatement->bindParam(':reading_id', $newReadingId);
            $updateStatement->bindParam(':id', $id);

            if ($updateStatement->execute()) {
                echo "<p>Данные успешно обновлены.</p>";
            } else {
                echo "<p>Произошла ошибка при обновлении данных.</p>";
            }
        }
    } catch (PDOException $e) {
        die("Ошибка подключения к базе данных: " . $e->getMessage());
    }
    ?>

    <!-- Форма редактирования данных -->
    <form action="edit_record.php" method="post">
    <input type="hidden" name="id" value="<?php echo $id; ?>">
    <label for="ip_address">IP Address:</label>
    <input type="text" name="ip_address" value="<?php echo $row['ip_address']; ?>"><br>
    <label for="port">Port:</label>
    <input type="text" name="port" value="<?php echo $row['port']; ?>"><br>
    <label for="reading_id">Reading ID:</label>
    <input type="text" name="reading_id" value="<?php echo $row['reading_id']; ?>"><br>
    <input type="submit" value="Сохранить изменения">
</form>

    
    <a href="index.php">Вернуться к списку записей</a>
</body>
</html>
