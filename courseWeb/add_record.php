<!DOCTYPE html>
<html>
<head>
    <title>Добавление записи</title>
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
    <h1>Добавление записи в базу данных</h1>
    <!-- Форма для добавления записи -->
    <form action="add_record_process.php" method="post">
        <label for="ip_address">IP Address:</label>
        <input type="text" name="ip_address" required><br>
        
        <label for="port">Port:</label>
        <input type="text" name="port" required><br>
        
        <label for="reading_id">Reading ID:</label>
        <input type="text" name="reading_id" required><br>
        
        <input type="submit" value="Добавить запись" class="button">
    </form>
    
    <a href="index.php">Вернуться к списку записей</a>
</body>
</html>
