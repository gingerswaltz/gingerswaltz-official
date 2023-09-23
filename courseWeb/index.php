<?php
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
?>
<?php
$query = "SELECT * FROM main_ip";
$result = $db->query($query);
?>




<!DOCTYPE html>
<html>
<head>
    <title>Просмотр базы данных</title>
    <style>
        body {
            background-color: #222; /* Цвет фона */
            color: #fff; /* Цвет текста */
            font-family: Arial, sans-serif; /* Шрифт */
        }

        h1 {
            text-align: center;
            margin: 20px;
        }

        table {
            width: 80%;
            margin: 0 auto;
            border-collapse: collapse;
        }

        th, td {
            padding: 10px;
            text-align: left;
            border-bottom: 1px solid #444; /* Горизонтальные линии */
        }

        th {
            background-color: #333; /* Цвет заголовков */
        }

        tr:nth-child(even) {
            background-color: #444; /* Цвет четных строк */
        }

        a {
            color: #00f; /* Цвет ссылок */
            text-decoration: none;
        }

        a:hover {
            text-decoration: underline;
        }

        .button {
            background-color: #000080	;
            color: #fff	;
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
    <h1>Просмотр данных из базы данных</h1>
   
    <!-- Кнопка для добавления записи -->
   <form action="add_record.php" method="post">
        <button type="submit" class="button add-button">Добавить запись</button>
    </form>
    <table>
    <tr>
        <th>ID</th>
        <th>ip_address</th>
        <th>port</th>
        <th>reading_id</th>
    </tr>
    
   <?php
    while ($row = $result->fetch(PDO::FETCH_ASSOC)) {
        echo "<tr>";
        echo "<td>" . $row['id'] . "</td>";
        echo "<td>" . $row['ip_address'] . "</td>";
        echo "<td>" . $row['port'] . "</td>";
        echo "<td>" . $row['reading_id'] . "</td>";
         // Кнопки для изменения и удаления записи
         echo "<td>";
         echo "<form action='edit_record.php' method='post'>";
         echo "<input type='hidden' name='id' value='" . $row['id'] . "'>";
         echo "<button type='submit' class='button'>Изменить</button>";
         echo "</form>";

         echo "<form action='delete_record.php' method='post'>";
         echo "<input type='hidden' name='id' value='" . $row['id'] . "'>";
         echo "<button type='submit' class='button'>Удалить</button>";
         echo "</form>";
         echo "</td>";

         echo "</tr>";
    }
    ?>
    </table>
</body>
</html>






<?php
$db = null; // Закрываем соединение с базой данных
?>