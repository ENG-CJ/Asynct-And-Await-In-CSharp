# Asynct-And-Await-In-CSharp
Import Topic in C# asynchorouns programing using  async and await to make your app reponsive

# What is Asynchronous
An efficient approach towards activities blocked or access is delayed. Also This Non-Blocking Modal Means Operations Or Programs Can Run As parallel.

# In C# To Make Asynchronous 
Use  Async and Wait Modifiers based on task<br>
Example:
```C#
private async Task loadLoop()
{
   await Task.Run(()=>{
   
    for(int i=0; i<=10; i++)
         lbl.Text=i.ToString();
         Thread.Sleep(1000);
   });

}

```
# Task In Async
A task in C# is used to implement Task-based Asynchronous Programming , <br>
he Task object is typically executed asynchronously on a thread pool thread rather than synchronously on the main thread of the application.

# Source
for More Details About Async And Await [Click Here] <br>
U can download this source for practical use.😊

# Any Help
email : abdulrahmandev10@gmail.com
