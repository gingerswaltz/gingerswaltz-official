// React Native
import React, { useState } from "react";
import {
  View,
  Text,
  TextInput,
  TouchableOpacity,
  StyleSheet,
} from "react-native";

const Main = ({ navigation }) => {
  const [name, setName] = useState("");
  const [room, setRoom] = useState("");

  const handlePress = () => {
    // Обработка нажатия кнопки
    if (!name || !room) return;
    navigation.navigate("Chat", {
      name: name,
      room: room,
    });
  };

  return (
    <View style={styles.container}>
      <Text style={styles.heading}>Join</Text>
      <TextInput
        style={styles.input}
        placeholder="Username"
        value={name}
        onChangeText={setName}
        autoCompleteType="username"
        autoCapitalize="none"
        autoFocus={true}
      />
      <TextInput
        style={styles.input}
        placeholder="Room"
        value={room}
        onChangeText={setRoom}
        autoCompleteType="off"
        autoCapitalize="none"
      />
      <TouchableOpacity style={styles.button} onPress={handlePress}>
        <Text style={styles.buttonText}>Sign In</Text>
      </TouchableOpacity>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: "center",
    alignItems: "center",
    padding: 20,
  },
  heading: {
    fontSize: 24,
    marginBottom: 20,
  },
  input: {
    width: "100%",
    height: 40,
    borderWidth: 1,
    borderColor: "#ccc",
    borderRadius: 5,
    paddingHorizontal: 10,
    marginBottom: 10,
  },
  button: {
    backgroundColor: "blue",
    paddingVertical: 10,
    paddingHorizontal: 20,
    borderRadius: 5,
  },
  buttonText: {
    color: "#fff",
    fontSize: 16,
    textAlign: "center",
  },
});

export default Main;
