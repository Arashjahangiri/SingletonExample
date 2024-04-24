# DesignPattern Singleton
Hello Guys, in this sample we want to review Singleton Design Pattern..

Description:

Singleton pattern is one of the simplest design patterns , This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.
This pattern involves a single class which is responsible to create an object while making sure that only single object gets created. This class provides a way to access its only object which can be accessed directly without need to instantiate the object of the class.


Golden Notes:

A)  Sealed Class

a sealed class in C# is a class that cannot be extended or inherited. 

public sealed class Singleton
{
}

B) Private Constractor

A private constructor is a special instance constructor in C# that restricts the creation of objects from outside the class it is defined in. It is usually used in classes that only contain static members. If a class has one or more private constructors and no public constructors, other classes (except nested classes cannot create instances of this class. 


private Singleton() {}


c)lock statement

The lock statement acquires the mutual-exclusion lock for a given object, executes a statement block, and then releases the lock. While a lock is held, the thread that holds the lock can again acquire and release the lock. Any other thread is blocked from acquiring the lock and waits until the lock is released. The lock statement ensures that at maximum only one thread executes its body at any time moment.


public static object _lock=new object();


lock (_lock)
{
    // Your code...
}


Singleton Class Example:


/************************************************/

 public sealed class Singleton
 {

     public static Singleton _instance;
     public static object _lock = new object();




     private Singleton() {}


     public static Singleton GetInstance()
     {

       if (_instance==null)
         {
             lock (_lock)
             {

                 if (_instance==null)
                 {

                     _instance = new Singleton();
                 }
             }
         }
         return _instance;

     }




 }//////////////End of class

/************************************************/



