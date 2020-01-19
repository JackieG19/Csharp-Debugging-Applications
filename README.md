## Technique to debug the application

**Breakpoint**
- indicates where Visual Studio should suspend your running code so you can take a look at the values 
of variables, or the behavior of memory, or whether or not a branch of code is getting run.

**Locals window**
- shows you the variables that are in the current scope, that is, the current execution context.

**Watch**
- a window to specify a variable (or an expression) that you want to keep 
an eye on and see its value change as you move through the debugger.

**Call stock**
- shows the order in which methods and functions are getting called and 
is a good way to examine and understand the execution flow of an app.

**Autos window**
- shows all variables used on the current line or the preceding line.

[source for definition](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-debugger?view=vs-2019)
___

**Commands**

F9: Breakpoint
- Set a breakpoint on the variable declaration, the for loop, or any code inside the for loop. 
- Cannot set a breakpoint on the namespace or class declarations, or on the method signature.

F5: Run in the debug mode
-  Starts the app with the debugger attached to the app process
  
Ctrl + F5: 
- Run without debug

F10: Step Over
- Advances the debugger without stepping into functions or methods in your app code
  
F11: Step into
- Advances the app execution one statement at a time
  
Shift + F11: Step Over
- This command resumes app execution (and advances the debugger) until the current function returns.

[source for definition](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-debugger?view=vs-2019)
