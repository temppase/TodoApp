# Todo App
Todo app for mongo db test purpose.
Requires mongodb installed on the local computer.


Some remarks I made about mongodb:
* Saves DateTime.Now at UTC time.
* The library dependency in the application is significantly different from SQL.
* You do not need to design the database separately but build it with the models you use.

So if you need time, you need to figure out how to fix UTC. There can be many possibilities, but for example, 
increasing or decreasing hours is problematic because summer and winter time are also used in Finland. 
I looked a little at MongoDb's configuration tables and noticed that the local time is stored in them as a string. 
I think that's a pretty good practice.



