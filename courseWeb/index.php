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
        <select name="table" required id="tableSelect">
            <option value="" disabled selected>Выберите таблицу</option>
        </select><br>
        
        <input type="submit" value="Войти">
        <button type="button" id="checkConnectionButton">Проверить подключение</button>
    </form>
    
    <script>
        document.addEventListener("DOMContentLoaded", function () {
            // Обработчик события для кнопки "Проверить подключение"
            document.getElementById("checkConnectionButton").addEventListener("click", function () {
                // Получаем значения хоста, порта, пользователя и пароля из инпутов
                const host = document.querySelector("input[name='host']").value;
                const port = document.querySelector("input[name='port']").value;
                const username = document.querySelector("input[name='username']").value;
                const password = document.querySelector("input[name='password']").value;
                const dbname = document.querySelector("input[name='dbname']").value;

                // Создаем объект FormData для отправки данных
                const formData = new FormData();
                formData.append("host", host);
                formData.append("port", port);
                formData.append("username", username);
                formData.append("password", password);
                formData.append("dbname", dbname);

                // Создаем асинхронный запрос к check_connection.php
                const xhr = new XMLHttpRequest();
                xhr.open("POST", "check_connection.php", true);
                xhr.setRequestHeader("X-Requested-With", "XMLHttpRequest");

                // Отправляем данные и обрабатываем ответ
                xhr.onload = function () {
                    if (xhr.status === 200) {
                        // Если запрос успешен, обновляем список таблиц
                        const tableSelect = document.getElementById("tableSelect");
                        tableSelect.innerHTML = "<option value='' disabled selected>Выберите таблицу</option>";
                        const tables = JSON.parse(xhr.responseText);
                        tables.forEach(function (table) {
                            const option = document.createElement("option");
                            option.value = table;
                            option.textContent = table;
                            tableSelect.appendChild(option);
                        });
                    } else {
                        // Если запрос не удался, выводим сообщение об ошибке
                        alert("Ошибка при проверке подключения: " + xhr.responseText);
                    }
                };

                // Отправляем запрос
                xhr.send(formData);
            });
        });
    </script>
</body>
</html>

