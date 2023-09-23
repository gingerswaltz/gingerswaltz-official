<!DOCTYPE html>
<html>
<head>
    <title>Удаление записи</title>
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

        .container {
            width: 80%;
            margin: 0 auto;
        }

        .message {
            text-align: center;
            margin: 20px;
            color: #ff0000;
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
            margin-left: 50%;
        }
        

        a{
            position: relative;
            margin-top: 15px;
            color:#fff;

        }
        .button:hover {
            background-color: #cc0000;
        }
    </style>
</head>
<body>
    <div class="container">
        <h1>Удаление записи из базы данных</h1>
        
        <?php
        // Проверка наличия ID записи для удаления
        if (isset($_POST['id'])) {
            $id = $_POST['id'];
            echo "<p class='message'>Вы уверены, что хотите удалить запись с ID $id?</p>";
            echo "<form action='delete_record_process.php' method='post'>";
            echo "<input type='hidden' name='id' value='$id'>";
            echo "<button type='submit' class='button'>Удалить</button>";
            echo "</form>";
        } else {
            echo "<p class='message'>ID записи не указано.</p>";
        }
        ?>
        
        <a href="index.php">Вернуться к списку записей</a>
    </div>
</body>
</html>
