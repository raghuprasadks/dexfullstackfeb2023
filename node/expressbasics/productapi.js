var express = require('express')

var app = express()

var products=[]

// middleware
app.use(express.json())

app.post('/api/product',function(req,res){
    var product = req.body
    console.log('post emp ',product)
    products.push(product)
    res.send(product)
})

app.get('/api/product',function(req,res){
    console.log('get ')
    res.send(products)    
})

app.get('/api/product/:code',function(req,res){
    console.log('get with code')
    var code  =req.params.code
    var filteredproduct = products.filter((product)=>product.code==code)

    res.send(filteredproduct)    
})



app.listen(8080,function(err){
    if(err)
        console.log(err)
    console.log('Server is started')

})