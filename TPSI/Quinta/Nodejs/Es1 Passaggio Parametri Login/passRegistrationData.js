const http = require('node:http');
const fs = require('node:fs');

http.createServer((req,res) => 
{
    if(req.url === '/a')
    {
        res.writeHead(200, {'Content-Type':'text/html'});
        let readStream = fs.createReadStream('index.html','utf8');
        readStream.pipe(res);
        console.log("Bella ciaone");
    }
    if(req.url === '/')
    {
        res.write('fiore di loto');
        res.end();
    }
}).listen(3000);

console.log("Server acceso");