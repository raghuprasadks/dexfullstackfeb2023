var express = require('express')
var app=express()
//http://localhost:8080
app.get('/',function(req,res){
    console.log('recevied get request')
    res.send('Getting Started')
})
//http://localhost:8080/welcome
app.get('/welcome',function(req,res){
    res.send('Welcome to express')
})
//http://localhost:8080/1
app.get('/welcome/:id',function(req,res){
    var parmid = req.params.id
    var msg = 'Your id is '+parmid
    res.send(msg)
})

// Get with queryparameters http://localhost:8080/welcomeparams?name=raghu&city=Bengaluru
app.get('/welcomeparams',function(req,res){
	var query = req.query;
	console.log(query);
	var message = 'your details are :Name ' +query.name +' City :'+query.city; 
	res.send(message);
});


// Body Parser Middleware
app.use(express.json());

app.post('/employee',function(req,res){
    var emp = req.body
    console.log(emp);
    res.send(emp)
})

app.listen(8080,function(err){
    if (err)
        console.log(err)

    console.log('server has started')
})