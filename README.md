# Lab-7-Enumerator-and-Enumerable




Lab 7 - Enumerator and Enumerable
General Learning Objectives

Use a modern operating system and utilities.

Use an integrated development environment to develop a program.

Solve problems and develop programs using the control structures of sequence, selection, and repetition, following a disciplined approach.

Objectives
Understand the principle and benefits of enumerators.
Gain more practice implementing interfaces and using generics.
Gain more experience working with references.
Step 1: Read

The C# standard library's System.Collections.Generic.IEnumerable<T> defines an interface which supports simple iteration over a collection of a specified type.

foreach loops in C# are based on the idea of Enumerators --- something that can keep track of where we are in traversing a collection of values.

Step 2: Set Up the Environment
Accept the GitHub Classroom Assignment
Copy the contents of your repo from last week into your new git repo
Add the recently copied files to the git repo (git add .)
Make a commit titled 'lab-09 code'
Step 3: Code

Using the same groups from last lab, extend your DoublyLinkedList class to implement the IEnumerable<T> interface. That will require you to write a LinkedListEnumerator<T> class (which itself implements IDisposable, IEnumerator, and IEnumerator<T>).

The constructor of your LinkedListEnumerator<T> will take a DoublyLinkedListNode<T> as a constructor parameter that points to the first node in your list as a parameter.

You'll need to keep track of both the first node as well as the current node.

MoveNext will need to determine if the currentNode is null or not. If so, initialize currentNode to firstNode and return true. If currentNode is not null, check to see if currentNode.Next is not null. If not, set currentNode = currentNode.Next and return true; if currentNode.Next is null then return false (because you're done processing).

Clear out the Dispose method so it's empty (but leave the method there).




Implement the Current property as follows: if currentNode is null, return default(t), otherwise return currentNode.Value

Step 4: Add a Main / Driver / UI / Console Program (whatever term you want to use)

Create a console project (or Blazor if you're super ambitious) to your solution. Add a reference to your class library. Add the console project to your solution. Add the UI code required to allow your user the following options:

Add an item at the beginning of the list
Add an item at the end of the list
Print out the current contents of the list (something like foreach(var value in list){ Console.Write($"{Value}, ")} would work)
Press a certain key (of your choosing) to end the program

Loop the program until the user says they choose to exit, thus allowing them to add to the front, add to the back, or print the list as many times as they want in whatever combination they want.

 
