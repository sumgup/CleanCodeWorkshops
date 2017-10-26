**ABOUT**

This sample demonstrates refactoring an imperative style code to functional.  Non-Functional style has following problems associated

1. Order in which methods are called ->  Once a consumer of code makes a mistake of not calling the methods in order it will result in Nullreference

2. State -  We are creating a state for lists.  This can be a problem in multi threaded environment.  

   At the end program demonstrated how to avoid creating state.

   **TODO:** :

   Demonstrate how this code is a problem in a multi threaded environment