var express = require('express');
var app = express();
var server = require('http').createServer(app);
var io = require('socket.io').listen(server);
users = [];
connections = [];

server.listen(process.env.PORT || 3000);
console.log('Server functional');

app.get('/', function(rec, res){
    res.sendfile(__dirname + '/index.html');
});

io.sockets.on('connection', function(socket){
    connections.push(socket);
    console.log('Connected: %s socket connected', connections.lenght);

    //Disconect

    connections.splice(connections.indexOf(socket), 1);
    console.log('Diconnected: %s socket connected', connections.lenght);
});