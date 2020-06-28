const http = require('http');

http.createServer((req, res) => {
    res.write('heloo');
    res.end()
}).listen(5000, () => console.log('S'));
