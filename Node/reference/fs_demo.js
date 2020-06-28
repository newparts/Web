const fs = require('fs');
const path = require('path');

// Create folder
// fs.mkdir(path.join(__dirname, '/test'), {}, err => {
//     if (err) throw err;
//     console.log('Fisier creat');
// });


// Create file
fs.writeFile(path.join(__dirname, '/test', 'hello.txt'), 'Salut', err => {
    if (err) throw err;
    console.log('File creat');
});