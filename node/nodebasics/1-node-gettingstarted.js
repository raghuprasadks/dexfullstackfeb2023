var http = require('http');

var dt = require('./myfirstmodule')

http.createServer(function (req, res) {
    console.log("received request at :: "+dt.myDateTime())

    res.writeHead(200, {'Content-Type': 'text/plain'});
    res.write("Hello from server")
    res.write(req.url);
   // res.end('Hello World!');
   res.end();
}).listen(8080,function(){
    console.log("server started")
});