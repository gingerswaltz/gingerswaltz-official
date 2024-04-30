import React, { useState, useEffect } from "react";
import {
  View,
  Text,
  TextInput,
  TouchableOpacity,
  ScrollView,
} from "react-native";
import io from "socket.io-client";

const socket = io.connect("http://192.168.0.12");

const Chat = ({ navigation, route }) => {
  const [message, setMessage] = useState("");
  const [state, setState] = useState([]);
  const [users, setUsers] = useState(0);

  useEffect(() => {
    // Событие приема сообщения от сервера
    socket.on("message", (data) => {
      // Обновление состояния с полученным сообщением
      setState([...state, data]);
    });

    // Событие приема списка пользователей от сервера
    socket.on("room", (data) => {
      // Обновление количества пользователей в комнате
      setUsers(data.users.length);
    });

    // Отправка события присоединения к комнате на сервер
    socket.emit("join", { name: route.params.name, room: route.params.room });

    // Очистка слушателей событий при размонтировании компонента
    return () => {
      socket.off("message");
      socket.off("room");
    };
  }, []);

  // Обработчик изменения текста в поле ввода сообщения
  const handleChange = (text) => {
    setMessage(text);
  };

  // Обработчик нажатия на кнопку отправки сообщения
  const handleSubmit = () => {
    // Отправка сообщения на сервер
    socket.emit("sendMessage", { message, params: route.params });
    // Очистка поля ввода после отправки сообщения
    setMessage("");
  };

  // Обработчик нажатия на кнопку покидания комнаты
  const leftRoom = () => {
    // Отправка события покидания комнаты на сервер
    socket.emit("leftRoom", { params: route.params });
    // Переход на предыдущий экран
    navigation.goBack();
  };

  return (
    <View style={{ flex: 1 }}>
      <View
        style={{
          flexDirection: "row",
          justifyContent: "space-between",
          alignItems: "center",
          padding: 10,
        }}
      >
        <Text>{route.params.room}</Text>
        <Text>{users} users in this room</Text>
        <TouchableOpacity onPress={leftRoom}>
          <Text>Left the room</Text>
        </TouchableOpacity>
      </View>
      <ScrollView style={{ flex: 1 }}>
        {state.map((msg, index) => (
          <Text key={index}>
            {msg.data.user.name}: {msg.data.message}
          </Text>
        ))}
      </ScrollView>
      <View style={{ flexDirection: "row", alignItems: "center", padding: 10 }}>
        <TextInput
          style={{
            flex: 1,
            borderWidth: 1,
            borderColor: "#ccc",
            borderRadius: 5,
            padding: 10,
          }}
          placeholder="What do you want to say?"
          value={message}
          onChangeText={handleChange}
          autoCompleteType="off"
          autoCapitalize="none"
          required
        />
      </View>
      <TouchableOpacity
        style={{ backgroundColor: "blue", padding: 10, alignItems: "center" }}
        onPress={handleSubmit}
      >
        <Text style={{ color: "#fff", fontSize: 16 }}>Send a message</Text>
      </TouchableOpacity>
    </View>
  );
};

export default Chat;
