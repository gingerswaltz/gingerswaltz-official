# University Coursework: Databases, Networks and Application Development

Lab work and course projects from my Computer Engineering studies at Transbaikal State University (2022–2024).

## Contents

| Folder | What's inside | Stack |
| --- | --- | --- |
| `DataBase` | Database for a retail-space rental business: schema design (pgModeler, UML), complex queries (joins, subqueries, `ARRAY_AGG`), PL/pgSQL functions and triggers (e.g. a trigger that rejects overlapping lease dates), MongoDB aggregation with `$lookup`, and a desktop client app | PostgreSQL, MongoDB, C# (WinForms, Npgsql) |
| `CourseNetwork` | Real-time chat with rooms: Express + Socket.IO server with logging, mobile client | Node.js, Socket.IO, React Native (Expo) |
| `courseWeb` | Web app for viewing, searching, adding, editing and deleting database records, with login | PHP, PDO, PostgreSQL |
| `BankApp` | Bank deposit application with input validation and unit tests | C#, WinForms, MSTest |
| `ChatBot` | Desktop chatbot: arithmetic, greetings, current time, message history | C#, WinForms |
| `CurrencyExchange_Android` | Currency converter that loads live rates from a REST API | C#, Xamarin.Android, HttpClient, JSON |
| `Signal_Slots_QT`, `zadachaa9_qt` | GUI apps using Qt signals and slots | C++, Qt |
| `saod_tree` | Binary tree implementation | C++ |
| `Theory`, `MyTopics` | Notes: OOP, regular expressions, console compilation, Android, installers, STM32 | — |

## Known issues (kept as written for coursework)

- Some database queries in the C# client are built with string interpolation. Production code should use parameterized queries, as the PHP app does with PDO.
- Database credentials are hard-coded for a local lab setup.
