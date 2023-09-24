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

<!DOCTYPE html>
<html>
<head>
    <title>Страница входа</title>
</head>
<body>
    <h1>Вход в систему</h1>
    <form action="login.php" method="post">
        <label for="host">Хост:</label>
        <input type="text" name="host" required><br>
        
        <label for="port">Порт:</label>
        <input type="text" name="port" required><br>
        
        <label for="username">Имя пользователя:</label>
        <input type="text" name="username" required><br>
        
        <label for="password">Пароль:</label>
        <input type="password" name="password" required><br>
        
        <label for="dbname">Имя базы данных:</label>
        <input type="text" name="dbname" required><br>
        
        <label for="table">Таблица:</label>
        <input type="text" name="table" required><br>
        
        <input type="submit" value="Войти">
    </form>
</body>
</html>
