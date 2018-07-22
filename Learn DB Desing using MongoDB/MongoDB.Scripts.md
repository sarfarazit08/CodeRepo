Microsoft Windows [Version 10.0.17134.112]
(c) 2018 Microsoft Corporation. All rights reserved.

C:\Users\sarfa>mongo
MongoDB shell version v4.0.0
connecting to: mongodb://127.0.0.1:27017
MongoDB server version: 4.0.0
Server has startup warnings:
2018-07-04T19:54:13.251+0530 I CONTROL  [initandlisten]
2018-07-04T19:54:13.251+0530 I CONTROL  [initandlisten] ** WARNING: Access control is not enabled for the database.
2018-07-04T19:54:13.251+0530 I CONTROL  [initandlisten] **          Read and write access to data and configuration is unrestricted.
2018-07-04T19:54:13.251+0530 I CONTROL  [initandlisten]
---
Enable MongoDB's free cloud-based monitoring service to collect and display
metrics about your deployment (disk utilization, CPU, operation statistics,
etc).

The monitoring data will be available on a MongoDB website with a unique
URL created for you. Anyone you share the URL with will also be able to
view this page. MongoDB may use this information to make product
improvements and to suggest MongoDB products and deployment options to you.

To enable free monitoring, run the following command:
db.enableFreeMonitoring()
---

> show dbs
admin   0.000GB
config  0.000GB
local   0.000GB

> use users
switched to db users

> db.createUser({user:"sarfuit08",pwd:"sarfuit08@123", roles:["readWrite","dbAdmin"]});
Successfully added user: { "user" : "sarfuit08", "roles" : [ "readWrite", "dbAdmin" ] }

> db.user.insert({name:"sarfaraz",title:"TA", company:"Infy"})
WriteResult({ "nInserted" : 1 })

> show dbs
admin   0.000GB
config  0.000GB
local   0.000GB
users   0.000GB

> db.user.find()
{ "_id" : ObjectId("5b3cf4517ca929b341bb0f20"), "name" : "sarfaraz", "title" : "TA", "company" : "Infy" }

> show collections
user

> db.createCollection('Employees')
{ "ok" : 1 }

> show collections
Employees
user

> db.Employees.insert({name:"sarfaraz",title:"TA", company:"Infy"})
WriteResult({ "nInserted" : 1 })

> db.getCollection('user').drop()
true

> show collections
Employees

> sahil = {
... name:"Sahil",
... title:"SSE",
... company:"Infy"}
{ "name" : "Sahil", "title" : "SSE", "company" : "Infy" }

> db.Employees.save(sahil)
WriteResult({ "nInserted" : 1 })

> db.Employees.find()
{ "_id" : ObjectId("5b3cf59d7ca929b341bb0f21"), "name" : "sarfaraz", "title" : "TA", "company" : "Infy" }
{ "_id" : ObjectId("5b3cf6347ca929b341bb0f22"), "name" : "Sahil", "title" : "SSE", "company" : "Infy" }

> db.Employees.find().pretty()
{
        "_id" : ObjectId("5b3cf59d7ca929b341bb0f21"),
        "name" : "sarfaraz",
        "title" : "TA",
        "company" : "Infy"
}
{
        "_id" : ObjectId("5b3cf6347ca929b341bb0f22"),
        "name" : "Sahil",
        "title" : "SSE",
        "company" : "Infy"
}

> db.Employees.insert({name:"Murari",title:"TA", company:"Tieto", location:"Wagholi"})
WriteResult({ "nInserted" : 1 })

> db.Employees.find().pretty()
{
        "_id" : ObjectId("5b3cf59d7ca929b341bb0f21"),
        "name" : "sarfaraz",
        "title" : "TA",
        "company" : "Infy"
}
{
        "_id" : ObjectId("5b3cf6347ca929b341bb0f22"),
        "name" : "Sahil",
        "title" : "SSE",
        "company" : "Infy"
}
{
        "_id" : ObjectId("5b3cf9cd7ca929b341bb0f23"),
        "name" : "Murari",
        "title" : "TA",
        "company" : "Tieto",
        "location" : "Wagholi"
}

> db.Employees.find({}, {_id:0})
{ "name" : "sarfaraz", "title" : "TA", "company" : "Infy" }
{ "name" : "Sahil", "title" : "SSE", "company" : "Infy" }
{ "name" : "Murari", "title" : "TA", "company" : "Tieto", "location" : "Wagholi" }

> db.Employees.find({}, {name:1, title:1,company:1, location:1, _id:0})
{ "name" : "sarfaraz", "title" : "TA", "company" : "Infy" }
{ "name" : "Sahil", "title" : "SSE", "company" : "Infy" }
{ "name" : "Murari", "title" : "TA", "company" : "Tieto", "location" : "Wagholi" }

> newEmp = { name : "Abbas", title : "SSE",
... company: "ZS", skills : ["DS", "Angular", "MongoDB"]}
{
        "name" : "Abbas",
        "title" : "SSE",
        "company" : "ZS",
        "skills" : [
                "DS",
                "Angular",
                "MongoDB"
        ]
}

> db.Employees.save(newEmp)
WriteResult({ "nInserted" : 1 })

> db.Employees.find().pretty()
{
        "_id" : ObjectId("5b3cf59d7ca929b341bb0f21"),
        "name" : "sarfaraz",
        "title" : "TA",
        "company" : "Infy"
}
{
        "_id" : ObjectId("5b3cf6347ca929b341bb0f22"),
        "name" : "Sahil",
        "title" : "SSE",
        "company" : "Infy"
}
{
        "_id" : ObjectId("5b3cf9cd7ca929b341bb0f23"),
        "name" : "Murari",
        "title" : "TA",
        "company" : "Tieto",
        "location" : "Wagholi"
}
{
        "_id" : ObjectId("5b543e9adf0f195e0295fe54"),
        "name" : "Abbas",
        "title" : "SSE",
        "company" : "ZS",
        "skills" : [
                "DS",
                "Angular",
                "MongoDB"
        ]
}

> db.createCollection('squares')
{ "ok" : 1 }

> for( var i = 0; i < 10; i++){ db.squares.save({n: i, square: i*i}) }
WriteResult({ "nInserted" : 1 })

> db.squares.find().pretty()
{ "_id" : ObjectId("5b543d57df0f195e0295fe4a"), "n" : 0, "square" : 0 }
{ "_id" : ObjectId("5b543d57df0f195e0295fe4b"), "n" : 1, "square" : 1 }
{ "_id" : ObjectId("5b543d57df0f195e0295fe4c"), "n" : 2, "square" : 4 }
{ "_id" : ObjectId("5b543d57df0f195e0295fe4d"), "n" : 3, "square" : 9 }
{ "_id" : ObjectId("5b543d57df0f195e0295fe4e"), "n" : 4, "square" : 16 }
{ "_id" : ObjectId("5b543d57df0f195e0295fe4f"), "n" : 5, "square" : 25 }
{ "_id" : ObjectId("5b543d57df0f195e0295fe50"), "n" : 6, "square" : 36 }
{ "_id" : ObjectId("5b543d57df0f195e0295fe51"), "n" : 7, "square" : 49 }
{ "_id" : ObjectId("5b543d57df0f195e0295fe52"), "n" : 8, "square" : 64 }
{ "_id" : ObjectId("5b543d57df0f195e0295fe53"), "n" : 9, "square" : 81 }

