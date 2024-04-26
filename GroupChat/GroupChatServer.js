const net = require("net");

class GroupChatServer {
  constructor(port) {
    this.port = port;
    this.clients = [];
    this.server = null;
  }

  start() {
    this.server = net.createServer(this.onClientConnected.bind(this));
    this.server.listen(this.port, () => {
      console.log(`Server started on port ${this.port}`);
    });
  }

  stop() {
    if (this.server) {
      this.server.close();
      console.log("Server stopped");
    }
  }

  onClientConnected(socket) {
    console.log("Client connected:", socket.remoteAddress, socket.remotePort);
    this.clients.push(socket);

    socket.on("data", this.onClientData.bind(this, socket));
    socket.on("close", this.onClientDisconnected.bind(this, socket));
    socket.on("error", this.onClientError.bind(this, socket));
  }
  onClientData(socket, data) {
    const message = data.toString().trim(); // Преобразование буфера данных в строку и удаление лишних пробелов

    // Здесь можно добавить логику обработки полученного сообщения, например, передать его методу broadcast
    this.broadcast(message, socket);
  }

  onClientDisconnected(socket) {
    console.log(
      "Client disconnected:",
      socket.remoteAddress,
      socket.remotePort
    );
    this.clients.splice(this.clients.indexOf(socket), 1);
  }

  onClientError(socket, err) {
    console.error("Client error:", err);
  }

  broadcast(message, senderSocket) {
    this.clients.forEach((client) => {
      if (client !== senderSocket) {
        client.write(message);
      }
    });
  }

  // Другие методы, включая аутентификацию, обработку команд и т. д.
}

module.exports = GroupChatServer;
const PORT = 3000; // Порт, на котором будет работать сервер

const server = new GroupChatServer(PORT);
server.start();