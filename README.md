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
when you use async keyword in method definition, you must use await keyword in method body thats required. if the method is async also the method should be return a task. if the method returns data-type like int, string or another types, the task should be generic syntax 
Example if the method is async and retuning-value-type  use this syntax
```C#
private async Task<data_type> methodName()
{
   await Task.Run(()=>{
         // do something
   });

}

```
Example if the method is async and void-type  use this syntax
```C#
private async Task  methodName()
{
   await Task.Run(()=>{
         // do something
   });

}

```
There is Two Task Object one is generic and another is not generic<br>
<kbd>Task<data_type> </kbd> this is generic type if you dont know what is generic plz read this article [Read]<br>
<kbd>Task </kbd> this is Not generic type, It is used for void methods  [View]<br>

When you call async method in otehr method or event-handler you should be wait until the task is compelete,<br>
Example Calling Async Method :

```C#
private async void LoadAsycnMethods()
{
   // if the method is void async use this 
   await methodName(params);
   
   // if the method returns value use this
   
   Task<return_type> variableName = methodName(params);
   
   data_type variableName = await taskName;
   Console.WriteLine(result);
}
```

By Reality 

```C#
private async void DisplayName()
{
  Task<string>  task = GetName("abdulrahman");
  
  string name = await task;
  Console.WriteLine(name);
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
