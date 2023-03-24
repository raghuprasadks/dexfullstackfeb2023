var express = require('express')
//var MongoClient = require('mongodb').MongoClient;
const { MongoClient } = require('mongodb');
// Connection URL
const url = 'mongodb://127.0.0.1:27017';
//const client = new MongoClient(url);



var app = express()




app.use(express.json())

async function getDBConnection(url,dbName) {
    // Use connect method to connect to the server
    const client = new MongoClient(url);
    await client.connect();
    console.log('Connected successfully to server');
    const db = client.db(dbName);
    const collection = db.collection('product');
    //const collection = db.collection('product');
  
    // the following code examples can be pasted here...
  
    return collection;
  }
  
/**
function  getDBConnection(url,databaseobj){

    
    MongoClient.connect(url, function(err, db) {
        if (err) throw err;
        var dbo = db.db(databaseobj);
        return dbo
})}
 */


async function insert (product){
    const client = new MongoClient(url);
await client.connect();
client.db().collection('product').insertOne(product);

try {
  await collection.insertOne(product);
  //await collection.insertOne({ _id: 1 }); // duplicate key error
} catch (error) {
  if (error instanceof MongoServerError) {
    console.log(`Error worth logging: ${error}`); // special case for some reason
  }
  throw error; // still want to crash
}
}
app.post('/api/productdb',(req,res)=>{

    console.log('post')

    var prod=req.body

    var severres;

    insert()

    //const collection =  getDBConnection(url,"mongodbdemo")

    

  //  collection.insertOne(prod, function(err, res) {
   // if (err) throw err;
   // console.log("1 document inserted:res ",res);
    //severres=res
    //db.close();
   // })
      res.send(prod)

})


app.listen(8080,()=>{
    console.log('Server started')
})