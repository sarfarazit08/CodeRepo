1. What is .NET Framework?
.NET Framework is a complete environment that allows developers to develop, run, and deploy the following applications:
+ Console applications
+ Windows Forms applications
+ Windows Presentation Foundation (WPF) applications
+ Web applications (ASP.NET applications)
+ Web services
+ Windows services
+ Service-oriented applications using Windows Communication Foundation (WCF)
+ Workflow-enabled applications using Windows Workflow Foundation (WF)
.NET Framework also enables a developer to create sharable components to be used in distributed computing architecture. .NET Framework supports the object-oriented programming model for multiple languages, such as Visual Basic, Visual C#, and Visual C++. .NET Framework supports multiple programming languages in a manner that allows language interoperability. This implies that each language can use the code written in some other language.

2. What are the main components of .NET Framework?
.NET Framework provides enormous advantages to software developers in comparison to the advantages provided by other platforms. Microsoft has united various modern as well as existing technologies of software development in .NET Framework. These technologies are used by developers to develop highly efficient applications for modern as well as future business needs. The following are the key components of .NET Framework:
+ .NET Framework Class Library
+ Common Language Runtime (CLR) – a managed execution environment
+ Dynamic Language Runtimes (DLR)
+ Application Domains
+ Runtime Host
+ Common Type System (CTS)
+ Metadata and Self-Describing Components
+ Cross-Language Interoperability (CLI)
+ .NET Framework Security
+ Profiling
+ Side-by-Side Execution

3. List the new features added in .NET Framework 4.0.
The following are the new features of .NET Framework 4.0:
+ Improved Application Compatibility and Deployment Support
+ Dynamic Language Runtime
+ Managed Extensibility Framework (MEF)
+ Parallel Programming framework
+ Improved Security Model
+ Networking Improvements
+ Improved Core ASP.NET Services
+ Improvements in WPF 4
+ Improved Entity Framework (EF)
+ Integration between WCF and WF

4. What is an IL?
Intermediate Language is also known as MSIL (Microsoft Intermediate Language) or CIL (Common Intermediate Language). All .NET source code is compiled to IL. IL is then converted to machine code (binary file) at the point where the software is installed, or at run-time by a Just-In-Time (JIT) compiler.

5. What is Manifest?
Assembly metadata is stored in Manifest. Manifest contains all the metadata needed to do the following things
+ Version of assembly.
+ Security identity.
+ Scope of the assembly.
+ Resolve references to resources and classes.
The assembly manifest can be stored in a PE file either (an .exe or) .dll with Microsoft intermediate language (MSIL code with Microsoft intermediate language (MSIL) code or in a stand-alone PE file, that contains only assembly manifest information.

6. What are code contracts?
Code contracts help you to express the code assumptions and statements stating the behavior of your code in a language-neutral way. The contracts are included in the form of pre-conditions, post-conditions and object-invariants. The contracts help you to improve-testing by enabling run-time checking, static contract verification, and documentation generation.
The System.Diagnostics.Contracts namespace contains static classes that are used to express contracts in your code.

7. Name the classes that are introduced in the System.Numerics namespace.
The following two new classes are introduced in the System.Numerics namespace:
+ BigInteger - Refers to a non-primitive integral type, which is used to hold a value of any size. It has no lower and upper limit, making it possible for you to perform arithmetic calculations with very large numbers, even with the numbers which cannot hold by double or long.
+ Complex - Represents complex numbers and enables different arithmetic operations with complex numbers. A number represented in the form a + bi, where ‘a’ is the real part, and b is the imaginary part, is a complex number.

8. What is managed extensibility framework?
Managed extensibility framework (MEF) is a new library that is introduced as a part of .NET 4.0 and Silverlight 4. It helps in extending your application by providing greater reuse of applications and components. MEF provides a way for host application to consume external extensions without any configuration requirement.

9. Explain memory-mapped files.
Memory-mapped files (MMFs) allow you map the content of a file to the logical address of an application. These files enable the multiple processes running on the same machine to share data with each Other. The MemoryMappedFile.CreateFromFile() method is used to obtain a MemoryMappedFile object that represents a persisted memory-mapped file from a file on disk.
These files are included in the System.IO.MemoryMappedFiles namespace. This namespace contains four classes and three enumerations to help you access and secure your file mappings.

10. What is Common Type System (CTS)?
CTS is the component of CLR through which .NET Framework provides support for multiple languages because it contains a type system that is common across all the languages. Two CTS-compliant languages do not require type conversion when calling the code written in one language from within the code written in another language. CTS provide a base set of data types for all the languages supported by.NET Framework. This means that the size of integer and long variables is same across all .NET-compliant programming languages. However, each language uses aliases for the base data types provided by CTS. For example, CTS uses the data type system. Int32 to represent a 4 byte integer value; however, Visual Basic uses the alias integer for the same; whereas, C# uses the alias int. This is done for the sake of clarity and simplicity.

11. Give a brief introduction on side-by-side execution. Can two applications, one using private assembly and the other using the shared assembly be stated as side-by-side executables?
Side-by-side execution enables you to run multiple versions of an application or component and CLR on the same computer at the same time. As versioning is applicable only to shared assemblies and not to private assemblies, two applications, one using a private assembly and other using a shared assembly, cannot be stated as side-by-side executables.

12. Which method do you use to enforce garbage collection in .NET?
The System.GC.Collect() method.

13. State the differences between the Dispose() and Finalize().
CLR uses the Dispose and Finalize methods to perform garbage collection of run-time objects of .NET applications.

The Finalize method is called automatically by the runtime. CLR has a garbage collector (GC), which periodically checks for objects in heap that are no longer referenced by any object or program. It calls the Finalize method to free the memory used by such objects. The Dispose method is called by the programmer. Dispose is another method to release the memory used by an object. The Dispose method needs to be explicitly called in code to dereference an object from the heap. The Dispose method can be invoked only by the classes that implement the IDisposableinterface.

14. What is code access security (CAS)?
Code access security (CAS) is part of the .NET security model that prevents unauthorized access of resources and operations, and restricts the code to perform particular tasks.

15. Differentiate between managed and unmanaged code?
Managed code is the code that is executed directly by the CLR instead of the operating system. The code compiler first compiles the managed code to intermediate language (IL) code, also called as MSIL code. This code doesn't depend on machine configurations and can be executed on different machines.
Unmanaged code is the code that is executed directly by the operating system outside the CLR environment. It is directly compiled to native machine code which depends on the machine configuration.
In the managed code, since the execution of the code is governed by CLR, the runtime provides different services, such as garbage collection, type checking, exception handling, and security support. These services help provide uniformity in platform and language-independent behavior of managed code applications. In the unmanaged code, the allocation of memory, type safety, and security is required to be taken care of by the developer. If the unmanaged code is not properly handled, it may result in memory leak. Examples of unmanaged code are ActiveX components and Win32 APIs that execute beyond the scope of native CLR.

16. What are tuples?
Tuple is a fixed-size collection that can have elements of either same or different data types. Similar to arrays, a user must have to specify the size of a tuple at the time of declaration. Tuples are allowed to hold up from 1 to 8 elements and if there are more than 8 elements, then the 8th element can be defined as another tuple. Tuples can be specified as parameter or return type of a method.

17. How can you turn-on and turn-off CAS?
You can use the Code Access Security Tool (Caspol.exe) to turn security on and off.

To turn off/on security, type the following command at the command prompt:
caspol -security off/on
In the .NET Framework 4.0, for using Caspol.exe, you first need to set the element to true.

18. What is garbage collection? Explain the difference between garbage collections in .NET 4.0 and earlier versions.
Garbage collection prevents memory leaks during execution of programs. Garbage collector is a low-priority process that manages the allocation and deallocation of memory for your application. It checks for the unreferenced variables and objects. If GC finds any object that is no longer used by the application, it frees up the memory from that object.
GC has changed a bit with the introduction of .NET 4.0. In .NET 4.0, the GC.Collect() method contains the following overloaded methods:
GC.Collect(int)
GC.Collect(int, GCCollectionMode)

Another new feature introduced in .NET is to notify you when the GC.Collect() method is invoked and completed successfully by using different methods. The .NET 4.0 supports a new background garbage collection that replaces the concurrent garbage collection used in earlier versions. This concurrent GC allocates memory while running and uses current segment (which is 16 MB on a workstation) for that. After that, all threads are suspended. In case of background GC, a separate ephemeral GC - gen0 and gen1 can be started, while the full GC - gen0, 1, and 2 - is already running.

19. How does CAS (Code Access Security) works?
There are two key concepts of CAS security policy- code groups and permissions. A code group contains assemblies in it in a manner that each .NET assembly is related to a particular code group and some permissions are granted to each code group. For example, using the default security policy, a control downloaded from a Web site belongs to the Zone, 

Internet code group, which adheres to the permissions defined by the named permission set. (Normally, the named permission set represents a very restrictive range of permissions.)
Assembly execution involves the following steps:
1. Evidences are gathered about assembly.
2. Depending on the gathered evidences, the assembly is assigned to a code group.
3. Security rights are allocated to the assembly, depending on the code group.
4. Assembly runs as per the rights assigned to it.

20. What is Difference between NameSpace and Assembly?
Following are the differences between namespace and assembly:
+ Assembly is physical grouping of logical units, Namespace, logically grouped classes.
+ Namespace can span multiple assembly.

21. Mention the execution process for managed code.
A piece of managed code is executed as follows:
+ Choosing a language compiler
+ Compiling the code to MSIL
+ Compiling MSIL to native code
+ Executing the code.

22. Is there a way to suppress the finalize process inside the garbage collector forcibly in .NET?
Use the GC.SuppressFinalize() method to suppress the finalize process inside the garbage collector forcibly in .NET.

23. How can you instantiate a tuple?
The following are two ways to instantiate a tuple:
+ Using the new operator. For example,
Tuple t = new Tuple ("Hellow", 2);
+ Using the Create factory method available in the Tuple class. For example,
Tuple t = Tuple.Create (2, 4, 5);

24. Which is the root namespace for fundamental types in .NET Framework?
System.Object is the root namespace for fundamental types in .NET Framework.

25. What are the improvements made in CAS in .NET 4.0?
The CAS mechanism in .NET is used to control and configure the ability of managed code. Earlier, as this policy was applicable for only native applications, the security guarantee was limited. Therefore, developers used to look for alternating solutions, such as operating system-level solutions. This problem was solved in .NET Framework 4 by turning off the machine-wide security. The shared and hosted Web applications can now run more securely. The security policy in .NET Framework 4 has been simplified using the transparency model. This model allows you to run the Web applications without concerning about the CAS policies.
As a result of security policy changes in .NET Framework 4.0, you may encounter compilation warnings and runtime exceptions, if your try to use the obsolete CAS policy types and members either implicitly or explicitly. However, you 
can avoid the warnings and errors by using the configuration element in the runtime settings schema to opt into the obsolete CAS policy behavior.

26. What is Microsoft Intermediate Language (MSIL)?
The .NET Framework is shipped with compilers of all .NET programming languages to develop programs. There are separate compilers for the Visual Basic, C#, and Visual C++ programming languages in .NET Framework. Each .NET compiler produces an intermediate code after compiling the source code. The intermediate code is common for all languages and is understandable only to .NET environment. This intermediate code is known as MSIL.

27. What is lazy initialization?
Lazy initialization is a process by which an object is not initialized until it is first called in your code. The .NET 4.0 introduces a new wrapper class, System.Lazy, for executing the lazy initialization in your application. Lazy initialization helps you to reduce the wastage of resources and memory requirements to improve performance. It also supports thread-safety.

28. How many types of generations are there in a garbage collector?
Memory management in the CLR is divided into three generations that are build up by grouping memory segments. Generations enhance the garbage collection performance. The following are the three types of generations found in a garbage collector:
+ Generation 0 - When an object is initialized, it is said to be in generation 0.
+ Generation 1 - The objects that are under garbage collection process are considered to be in generation 1.
+ Generation 2 - Whenever new objects are created and added to the memory, they are added to generation 0 and the old objects in generation 1 are considered to be in generation 2.

29. Explain covariance and contra-variance in .NET Framework 4.0. Give an example for each.
In .NET 4.0, the CLR supports covariance and contravariance of types in generic interfaces and delegates. Covariance enables you to cast a generic type to its base types, that is, you can assign a instance of type IEnumerable to a variable of type IEnumerable where, T1 derives from T2. For example,
IEnumerable str1= new List ();
IEnumerable str2= str1;

Contravariance allows you to assign a variable of Action to a variable of type Action. For example,
IComparer obj1 = GetComparer()
IComparer obj2 = obj1;

.NET framework 4.0 uses some language keywords (out and in) to annotate covariance and contra-variance. Out is used for covariance, while in is used for contra-variance.
Variance can be applied only to reference types, generic interfaces, and generic delegates. These cannot be applied to value types and generic types.

30. How do you instantiate a complex number?
The following are the different ways to assign a value to a complex number:
By passing two Double values to its constructor. The first value represents the real, and the second value represents imaginary part of a complex number.
For example,
Complex c1 = new Complex(5, 8); /* It represents (5, 8) */

By assigning a Byte, SByte, Intl6, UIntl6, Int32, UInt32, Int64, UInt64, Single, or Double value to aComplex object. The assigned value represents the real part of the complex number, and its imaginary part becomes0. For example,
Complex c2 = 15.3; /* It represents (15.3, 0) */

By casting a Decimal or BigInteger value to a Complex object.
For example,
Complex c3 = (Complex) 14.7; /* It represents (14.7, 0) */

Assigning the value returned by an operator to a Complex variable.
For example,
Complex c4 = c1 + c2; /* It represents (20.3, 8) */

31. What is Common Language Specification (CLS)?
CLS is a set of basic rules, which must be followed by each .NET language to be a .NET- compliant language. It enables interoperability between two .NET-compliant languages. CLS is a subset of CTS; therefore, the languages supported by CLS can use each other's class libraries similar to their own. Application programming interfaces (APIs), which are designed by following the rules defined in CLS can be used by all .NET-compliant languages.

32. What is the role of the JIT compiler in .NET Framework?
The JIT compiler is an important element of CLR, which loads MSIL on target machines for execution. The MSIL is stored in .NET assemblies after the developer has compiled the code written in any .NET-compliant programming language, such as Visual Basic and C#.
JIT compiler translates the MSIL code of an assembly and uses the CPU architecture of the target machine to execute a .NET application. It also stores the resulting native code so that it is accessible for subsequent calls. If a code executing on a target machine calls a non-native method, the JIT compiler converts the MSIL of that method into native code. JIT compiler also enforces type-safety in runtime environment of .NET Framework. It checks for the values that are passed to parameters of any method.
For example, the JIT compiler detects any event, if a user tries to assign a 32-bit value to a parameter that can only accept 8-bit value.

33. What is difference between System.String and System.StringBuilder classes?
String and StringBuilder classes are used to store string values but the difference in them is that String is immutable (read only) by nature, because a value once assigned to a String object cannot be changed after its creation. When the value in the String object is modified, a new object is created, in memory, with a new value assigned to the String object. On the other hand, the StringBuilder class is mutable, as it occupies the same space even if you change the value. The StringBuilder class is more efficient where you have to perform a large amount of string manipulation.

34. Describe the roles of CLR in .NET Framework.
CLR provides an environment to execute .NET applications on target machines. CLR is also a common runtime environment for all .NET code irrespective of their programming language, as the compilers of respective language in .NET Framework convert every source code into a common language known as MSIL or IL (Intermediate Language).
CLR also provides various services to execute processes, such as memory management service and security services. CLR performs various tasks to manage the execution process of .NET applications.
The responsibilities of CLR are listed as follows:
+ Automatic memory management
+ Garbage Collection
+ Code Access Security
+ Code verification
+ JIT compilation of .NET code

35. What is the difference between int and int32?
There is no difference between int and int32. System.Int32 is a .NET Class and int is an alias name for System.Int32.

---

1. What is object-oriented programming (OOP)?
OOP is a technique to develop logical modules, such as classes that contain properties, methods, fields, and events. An object is created in the program to represent a class. Therefore, an object encapsulates all the features, such as data and behavior that are associated to a class. OOP allows developers to develop modular programs and assemble them as software. Objects are used to access data and behaviors of different software modules, such as classes, namespaces, and sharable assemblies. .NET Framework supports only OOP languages, such as Visual Basic .NET, Visual C#, and Visual C++.

2. What is a class?
A class describes all the attributes of objects, as well as the methods that implement the behavior of member objects. It is a comprehensive data type, which represents a blue print of objects. It is a template of object.
A class can be defined as the primary building block of OOP. It also serves as a template that describes the properties, state, and behaviors common to a particular group of objects.
A class contains data and behavior of an entity. For example, the aircraft class can contain data, such as model number, category, and color and behavior, such as duration of flight, speed, and number of passengers. A class inherits the data members and behaviors of other classes by extending from them.

3. What is an object?
They are instance of classes. It is a basic unit of a system. An object is an entity that has attributes, behavior, and identity. Attributes and behavior of an object are defined by the class definition.

4. What is the relationship between a class and an object?
A class acts as a blue-print that defines the properties, states, and behaviors that are common to a number of objects. An object is an instance of the class. For example, you have a class called Vehicle and Car is the object of that class. You can create any number of objects for the class named Vehicle, such as Van, Truck, and Auto.
The new operator is used to create an object of a class. When an object of a class is instantiated, the system allocates memory for every data member that is present in the class.

5. Explain the basic features of OOPs.
The following are the four basic features of OOP:
+ Abstraction - Refers to the process of exposing only the relevant and essential data to the users without showing unnecessary information.
+ Polymorphism - Allows you to use an entity in multiple forms.
+ Encapsulation - Prevents the data from unwanted access by binding of code and data in a single unit called object.
+ Inheritance - Promotes the reusability of code and eliminates the use of redundant code. It is the property through which a child class obtains all the features defined in its parent class. When a class inherits the common properties of another class, the class inheriting the properties is called a derived class and the class that allows inheritance of its common properties is called a base class.

6. What is the difference between arrays and collection?
Array:
1. You need to specify the size of an array at the time of its declaration. It cannot be resized dynamically.
2. The members of an array should be of the same data type.
Collection:
1. The size of a collection can be adjusted dynamically, as per the user's requirement. It does not have fixed size.
2. Collection can have elements of different types.

7. What are collections and generics?
A collection can be defined as a group of related items that can be referred to as a single unit. TheSystem.Collections namespace provides you with many classes and interfaces. Some of them are - ArrayList,List, Stack, ICollection, IEnumerable, and IDictionary. Generics provide the type-safety to your class at the compile time. While creating a data structure, you never need to specify the data type at the time of declaration. The System.Collections.Generic namespace contains all the generic collections.

8. How can you prevent your class to be inherited further?
You can prevent a class from being inherited further by defining it with the sealed keyword.

9. What is the index value of the first element in an array?
In an array, the index value of the first element is 0 (zero).

10. Can you specify the accessibility modifier for methods inside the interface?
All the methods inside an interface are always public, by default. You cannot specify any other access modifier for them.

11. Is it possible for a class to inherit the constructor of its base class?
No, a class cannot inherit the constructor of its base class.

12. How is method overriding different from method overloading?
Overriding involves the creation of two or more methods with the same name and same signature in different classes (one of them should be parent class and other should be child).
Overloading is a concept of using a method at different places with same name and different signatures within the same class.

13. What is the difference between a class and a structure?
##### Class:
+ A class is a reference type.
+ While instantiating a class, CLR allocates memory for its instance in heap.
+ Classes support inheritance.
+ Variables of a class can be assigned as null.
+ Class can contain constructor/destructor.

##### Structure:
+ A structure is a value type.
+ In structure, memory is allocated on stack.
+ Structures do not support inheritance.
+ Structure members cannot have null values.
+ Structure does not require constructor/destructor and members can be initialiazed automatically.

14. What are similarities between a class and a structure?
Structures and classes are the two most important data structures that are used by programmers to build modular programs by using OOP languages, such as Visual Basic .NET, and Visual C#. The following are some of the similarities between a class and a structure:
+ Access specifiers, such as public, private, and protected, are identically used in structures and classes to restrict the access of their data and methods outside their body.
+ The access level for class members and struct members, including nested classes and structs, is private by default. Private nested types are not accessible from outside the containing type.
+ Both can have constructors, methods, properties, fields, constants, enumerations, events, and event handlers.
+ Both structures and classes can implement interfaces to use multiple-inheritance in code.
+ Both structures and classes can have constructors with parameter.
+ Both structures and classes can have delegates and events.

15. What is a multicast delegate?
Each delegate object holds reference to a single method. However, it is possible for a delegate object to hold references of and invoke multiple methods. Such delegate objects are called multicast delegates or combinable delegates.

16. Can you declare an overridden method to be static if the original method is not static?
No. Two virtual methods must have the same signature.

17. Why is the virtual keyword used in code?
The virtual keyword is used while defining a class to specify that the methods and the properties of that class can be overridden in derived classes.

18. Can you allow a class to be inherited, but prevent a method from being overridden in C#?
Yes. Just declare the class public and make the method sealed.

19. Define enumeration?
Enumeration is defined as a value type that consists of a set of named values. These values are constants and are called enumerators. An enumeration type is declared using the enum keyword. Each enumerator in an enumeration is associated with an underlying type that is set, by default, on the enumerator. The following is an example that creates an enumeration to store different varieties of fruits:
enum Fruits {Mango, Apple, orange, Guava};
In the preceding example, an enumeration Fruits is created, where number 0 is associated with Mango, number 1with Apple, number 2 with Orange, and number 3 with Guava. You can access the enumerators of an enumeration by these values.

20. In which namespace, all .NET collection classes are contained?
The System.Collections namespace contains all the collection classes.

21. Is it a good practice to handle exceptions in code?
Yes, you must handle exceptions in code so that you can deal with any unexpected situations that occur when a program is running. For example, dividing a number by zero or passing a string value to a variable that holds an integer value would result in an exception.

22. Explain the concept of constructor?
Constructor is a special method of a class, which is called automatically when the instance of a class is created. It is created with the same name as the class and initializes all class members, whenever you access the class. The main features of a constructor are as follows:
+ Constructors do not have any return type.
+ Constructors can be overloaded.
+ It is not mandatory to declare a constructor; it is invoked automatically by .NET Framework.

23. Can you inherit private members of a class?
No, you cannot inherit private members of a class because private members are accessible only to that class and not outside that class.

24. Does .NET support multiple inheritance?
.NET does not support multiple inheritance directly because in .NET, a class cannot inherit from more than one class. .NET supports multiple inheritance through interfaces.

25. How has exception handling changed in .NET Framework 4.0?
In .NET 4.0, a new namespace, System.Runtime.ExceptionServices, has been introduced which contains the following classes for handling exceptions in a better and advanced manner:
+ HandleProcessCorruptedStateExceptionsAttribute Class - Enables managed code to handle the corrupted state exceptions that occur in an operating system. These exceptions cannot be caught by specifying the try...catch block. To handle such exceptions, you can apply this attribute to the method that is assigned to handle these exceptions.
+ FirstChanceExceptionEventArgs Class - Generates an event whenever a managed exception first occurs in your code, before the common language runtime begins searching for event handlers.

26. What is a delegate?
A delegate is similar to a class that is used for storing the reference to a method and invoking that method at runtime, as required. A delegate can hold the reference of only those methods whose signatures are same as that of the delegate. Some of the examples of delegates are type-safe functions, pointers, or callbacks.

27. What is the syntax to inherit from a class in C#?
When a class is derived from another class, then the members of the base class become the members of the derived class. The access modifier used while accessing members of the base class specifies the access status of the base class members inside the derived class.
The syntax to inherit a class from another class in C# is as follows:
class MyNewClass : MyBaseclass

28. State the features of an interface.
An interface is a template that contains only the signature of methods. The signature of a method consists of the numbers of parameters, the type of parameter (value, reference, or output), and the order of parameters. An interface has no implementation on its own because it contains only the definition of methods without any method body. An interface is defined using the interface keyword. Moreover, you cannot instantiate an interface. The various features of an interface are as follows:
+ An interface is used to implement multiple inheritance in code. This feature of an interface is quite different from that of abstract classes because a class cannot derive the features of more than one class but can easily implement multiple interfaces.
+ It defines a specific set of methods and their arguments.
+ Variables in interface must be declared as public, static, and final while methods must be public and abstract.
+ A class implementing an interface must implement all of its methods.
+ An interface can derive from more than one interface.

29. Can you use the 'throws' clause to raise an exception?
No, the throws clause cannot be used to raise an exception. The throw statement signals the occurrence of an exception during the execution of a program. When the program encounters a throw statement, the method terminates and returns the error to the calling method.

30. Define an array.
An array is defined as a homogeneous collection of elements, stored at contiguous memory locations, which can be referred by the same variable name. All the elements of an array variable can be accessed by index values. An Index value specifies the position of a particular element in an array variable.

31. What are methods?
Methods are the building blocks of a class, in which they are linked together to share and process data to produce the result. In other words, a method is a block of code that contains a series of statements and represents the behavior of a class. While declaring a method you need to specify the access specifier, the return value, the name of the method, and the method parameters. All these combined together is called the signature of the method.

32. What is a namespace?
Namespace is considered as a container that contains functionally related group of classes and other types.

33. Do events have return type?
No, events do not have return type.

34. What is the function of the Try-Catch-Finally block?
The try block encloses those statements that can cause exception and the catch block handles the exception, if it occurs. Catch block contains the statements that have to be executed, when an exception occurs. The finally block always executes, irrespective of the fact whether or not an exception has occurred. The finally block is generally used to perform the cleanup process. If any exception occurs in the try block, the program control directly transfers to its corresponding catch block and later to the finally block. If no exception occurs inside the try block, then the program control transfers directly to the finally block.

35. How can you prevent a class from overriding in C# and Visual Basic?
You can prevent a class from overriding in C# by using the sealed keyword; whereas, the NotInheritablekeyword is used to prevent a class from overriding in Visual Basic.

36. What are abstract classes? What are the distinct characteristics of an abstract class?
An abstract class is a class that cannot be instantiated and is always used as a base class.
The following are the characteristics of an abstract class:
+ You cannot instantiate an abstract class directly. This implies that you cannot create an object of the abstract class; it must be inherited.
+ You can have abstract as well as non-abstract members in an abstract class.
+ You must declare at least one abstract method in the abstract class.
+ An abstract class is always public.
+ An abstract class is declared using the abstract keyword.
The basic purpose of an abstract class is to provide a common definition of the base class that multiple derived classes can share.

37. Give a brief description of properties in C# and the advantages that are obtained by using them in programs.
In C#, a property is a way to expose an internal data element of a class in a simple and intuitive manner. In other words, it is a simple extension of data fields. You can create a property by defining an externally available name and then writing the set and get property accessors. The get property accessor is used to return the property value. The set property accessor is used to assign a new value to the property.

38. Explain different types of inheritance.
Inheritance in OOP is of four types:
+ Single inheritance - Contains one base class and one derived class
+ Hierarchical inheritance - Contains one base class and multiple derived classes of the same base class
+ Multilevel inheritance - Contains a class derived from a derived class
+ Multiple inheritance - Contains several base classes and a derived class
All .NET languages supports single, hierarchical, and multilevel inheritance. They do not support multiple inheritance because in these languages, a derived class cannot have more than one base class. However, you can implement multiple inheritance in.NET through interfaces.

39. You have defined a destructor in a class that you have developed by using the C# programming language, but the destructor never executed. Why did the destructor not execute?
The runtime environment automatically invokes the destructor of a class to release the resources that are occupied by variables and methods of an object. However, in C#, programmers cannot control the timing for invoking destructors, as Garbage Collector is only responsible for releasing the resources used by an object. Garbage Collector automatically gets information about unreferenced objects from .NET's runtime environment and then invokes the Finalize()method.

Although, it is not preferable to force Garbage Collector to perform garbage collection and retrieve all inaccessible memory, programmers can use the Collect() method of the Garbage Collector class to forcefully execute Garbage Collector.

40. What is a hashtable?
Hashtable is a data structure that implements the IDictionary interface. It is used to store multiple items and each of these items is associated with a unique string key. Each item can be accessed using the key associated with it. In short, hashtable is an object holding the key-value pairs.

41. Can users define their own exceptions in code?
Yes, customized exceptions can be defined in code by deriving from the System.Exception class.

42. Is it possible to execute two catch blocks?
You are allowed to include more than one catch block in your program; however, it is not possible to execute them in one go. Whenever, an exception occurs in your program, the correct catch block is executed and the control goes to the finally block.

43. What do you mean by data encapsulation?
Data encapsulation is a concept of binding data and code in single unit called object and hiding all the implementation details of a class from the user. It prevents unauthorized access of data and restricts the user to use the necessary data only.

44. What is the difference between procedural and object-oriented programming?
Procedural programming is based upon the modular approach in which the larger programs are broken into procedures. Each procedure is a set of instructions that are executed one after another. On the other hand, OOP is based upon objects. An object consists of various elements, such as methods and variables.

Access modifiers are not used in procedural programming, which implies that the entire data can be accessed freely anywhere in the program. In OOP, you can specify the scope of a particular data by using access modifiers - public,private, internal, protected, and protected internal.

45. Explain the concept of destructor?
A destructor is a special method for a class and is invoked automatically when an object is finally destroyed. The name of the destructor is also same as that of the class but is followed by a prefix tilde (~).

A destructor is used to free the dynamic allocated memory and release the resources. You can, however, implement a custom method that allows you to control object destruction by calling the destructor.

The main features of a destructor are as follows:
+ Destructors do not have any return type
+ Similar to constructors, destructors are also always public
+ Destructors cannot be overloaded.

46. Can you declare a private class in a namespace?
The classes in a namespace are internal, by default. However, you can explicitly declare them as public only and not as private, protected, or protected internal. The nested classes can be declared as private,protected, or protected internal.

47. A structure in C# can implement one or more interfaces. Is it true or false?
Yes, it is true. Like classes, in C#, structures can implement one or more interfaces.

48. What is a static constructor?
Static constructors are introduced with C# to initialize the static data of a class. CLR calls the static constructor before the first instance is created.

The static constructor has the following features:
+ No access specifier is required to define it.
+ You cannot pass parameters in static constructor.
+ A class can have only one static constructor.
+ It can access only static members of the class.
+ It is invoked only once, when the program execution begins.

49. What are the different ways a method can be overloaded?
The different ways to overload a method are given as follows:
+ By changing the number of parameters used
+ By changing the order of parameters
+ By using different data types for the parameters

50. Differentiate between an abstract class and an interface.
##### Abstract Class:
+ A class can extend only one abstract class
+ The members of abstract class can be private as well as protected.
+ Abstract classes should have subclasses
+ Any class can extend an abstract class.
+ Methods in abstract class can be abstract as well as concrete.
+ There can be a constructor for abstract class.
+ The class extending the abstract class may or may not implement any of its method.
+ An abstract class can implement methods.

##### Interface
+ A class can implement several interfaces
+ An interface can only have public members.
+ Interfaces must have implementations by classes
+ Only an interface can extend another interface.
+ All methods in an interface should be abstract
+ Interface does not have constructor.
+ All methods of interface need to be implemented by a class implementing that interface.
+ Interfaces cannot contain body of any of its method.

51. What are queues and stacks?
Stacks refer to a list in which all items are accessed and processed on the Last-In-First-Out (LIFO) basis. In a stack, elements are inserted (push operation) and deleted (pop operation) from the same end called top.

Queues refer to a list in which insertion and deletion of an item is done on the First-In-First-Out (FIFO) basis. The items in a queue are inserted from the one end, called the rear end, and are deleted from the other end, called thefront end of the queue.

52. Define an event.
Whenever an action takes place in a class, that class provides a notification to other classes or objects that are assigned to perform particular tasks. These notifications are called events. For example, when a button is clicked, the class generates an event called Click. An event can be declared with the help of the event keyword.

53. What are structures?
Structure is a heterogeneous collection of elements referenced by the same name. A structure is declared using the struct keyword. The following is an example that creates a structure to store an employee's information:

`
struct emp
{
fixed int empID[15];
fixed char name[30];
fixed char addr[50];
fixed char dept[15];
fixed char desig[15];
}
`
The preceding example defines a structure emp and the members of this structure specify the information of an employee.

54. When do you really need to create an abstract class?
We define abstract classes when we define a template that needs to be followed by all the derived classes.

---

1. What is the full form of ADO?
The full form of ADO is ActiveX Data Object.

2. Explain ADO.NET in brief.
ADO.NET is a very important feature of .NET Framework, which is used to work with data that is stored in structured data sources, such as databases and XML files. The following are some of the important features of ADO.NET:
+ Contains a number of classes that provide you with various methods and attributes to manage the communication between your application and data source.
+ Enables you to access different data sources, such as Microsoft SQL Server, and XML, as per your requirements.
+ Provides a rich set of features, such as connection and commands that can be used to develop robust and highly efficient data services in .NET applications.
+ Provides various data providers that are specific to databases produced by various vendors. For example, ADO.NET has a separate provider to access data from Oracle databases; whereas, another provider is used to access data from SQL databases.

3. What are major difference between classic ADO and ADO.NET?
Following are some major differences between both
+ In ADO we have recordset and in ADO.NET we have dataset.
+ In recordset we can only have one table. If we want to accommodate more than one tables. We need to do inner join and fill the recordset. Dataset can have multiple tables.
+ All data persist in XML as compared to classic ADO where data persisted in Binary format also.

4. What are the two fundamental objects in ADO.NET?
DataReader and DataSet are the two fundamental objects in ADO.NET.

5. What are the benefits of using of ADO.NET in .NET 4.0.
The following are the benefits of using ADO.NET in .NET 4.0 are as follows:
+ Language-Integrated Query (LINQ) - Adds native data-querying capabilities to .NET languages by using a syntax similar to that of SQL. This means that LINQ simplifies querying by eliminating the need to use a separate query language. LINQ is an innovative technology that was introduced in .NET Framework 3.5.
+ LINQ to DataSet - Allows you to implement LINQ queries for disconnected data stored in a dataset. LINQ to DataSet enables you to query data that is cached in a DataSet object. DataSet objects allow you to use a copy of the data stored in the tables of a database, without actually getting connected to the database.
+ LINQ to SQL - Allows you to create queries for data stored in SQL server database in your .NET application. You can use the LINQ to SQL technology to translate a query into a SQL query and then use it to retrieve or manipulate data contained in tables of an SQL Server database. LINQ to SQL supports all the key functions that you like to perform while working with SQL, that is, you can insert, update, and delete information from a table.
+ SqlClient Support for SQL Server 2008 - Specifies that with the starting of .NET Framework version 3.5 Service Pack (SP) 1, .NET Framework Data Provider for SQL Server (System.Data.SqlClient namespace) includes all the new features that make it fully compatible with SQL Server 2008 Database Engine.
+ ADO.NET Data Platform - Specifies that with the release of .NET Framework 3.5 Service Pack (SP) 1, an Entity Framework 3.5 was introduced that provides a set of Entity Data Model (EDM) functions. These functions are supported by all the data providers; thereby, reducing the amount of coding and maintenance in your application. In .NET Framework 4.0, many new functions, such as string, aggregate, mathematical, and date/time functions have been added.
6. Which namespaces are required to enable the use of databases in ASP.NET pages?
The following namespaces are required to enable the use of databases in ASP.NET pages:
+ The System.Data namespace.
+ The System.Data.OleDb namespace (to use any data provider, such as Access, Oracle, or SQL)
+ The System.Data.SQLClient namespace (specifically to use SQL as the data provider)

7. Explain the DataAdapter.Update() and DataSet.AcceptChanges() methods.
The DataAdapter.Update() method calls any of the DML statements, such as the UPDATE, INSERT, or DELETEstatements, as the case may be to update, insert, or delete a row in a DataSet. The DataSet.Acceptchanges()method reflects all the changes made to the row since the last time the AcceptChanges() method was called.

8. What is the meaning of object pooling?
Object pooling is a concept of storing a pool (group) of objects in memory that can be reused later as needed. Whenever, a new object is required to create, an object from the pool can be allocated for this request; thereby, minimizing the object creation. A pool can also refer to a group of connections and threads. Pooling, therefore, helps in minimizing the use of system resources, improves system scalability, and performance.

9. Which properties are used to bind a DataGridView control?
The DataSource property and the DataMember property are used to bind a DataGridView control.

10. What property must be set and what method must be called in your code to bind the data from some data source to the Repeater control?
You must set the DataSource property and call the DataBind() method.

11. Mention the namespace that is used to include .NET Data Provider for SQL server in .NET code.
The System.Data.SqlClient namespace.

12. What is the difference between OLEDB Provider and SqlClient?
With respect to usage, there is no difference between OLEDB Provider and SqlClient. The difference lies in their performance. SqlClient is explicitly used to connect your application to SQL server directly, OLEDB Provider is generic for various databases, such as Oracle and Access including SQL Server.

Therefore, there will be an overhead which leads to performance degradation.

13. Name the two properties of the GridView control that have to be specified to turn on sorting and paging.
The properties of the GridView control that need to be specified to turn on sorting and paging are as follows:
+ The AllowSorting property of the Gridview control indicates whether sorting is enabled or not. You should set the AllowSorting property to True to enable sorting.
+ The AllowPaging property of the Gridview control indicates whether paging is enabled or not. You should set the AllowPaging property to True to enable paging.

14. Mention different types of data providers available in .NET Framework.
+ .NET Framework Data Provider for SQL Server - Provides access to Microsoft SQL Server 7.0 or later version. It uses the System.Data.SqlClient namespace.
+ .NET Framework Data Provider for OLE DB - Provides access to databases exposed by using OLE DB. It uses the System.Data.OleDb namespace.
+ .NET Framework Data Provider for ODBC - Provides access to databases exposed by using ODBC. It uses theSystem.Data.Odbc namespace.
+ .NET Framework Data Provider for Oracle - Provides access to Oracle database 8.1.7 or later versions. It uses the System.Data.OracleClient namespace.

15. Which architecture does Datasets follow?
Datasets follow the disconnected data architecture.

16. What is the role of the DataSet object in ADO.NET?
One of the major component of ADO.NET is the DataSet object, which always remains disconnected from the database and reduces the load on the database.

17. What is a DataReader object?
The DataReader object helps in retrieving the data from a database in a forward-only, read-only mode. The base class for all the DataReader objects is the DbDataReader class.

The DataReader object is returned as a result of calling the ExecuteReader() method of the Command object. TheDataReader object enables faster retrieval of data from databases and enhances the performance of .NET applications by providing rapid data access speed. However, it is less preferred as compared to the DataAdapter object because the DataReader object needs an Open connection till it completes reading all the rows of the specified table.

An Open connection to read data from large tables consumes most of the system resources. When multiple client applications simultaneously access a database by using the DataReader object, the performance of data retrieval and other related processes is substantially reduced. In such a case, the database might refuse connections to other .NET applications until other clients free the resources.

18. How can you identify whether or not any changes are made to the DataSet object since it was last loaded?
The DataSet object provides the following two methods to track down the changes:
+ The GetChanges() method - Returns the DataSet object, which is changed since it was loaded or since theAcceptChanges() method was executed.
+ The HasChanges() method - Indicates if any changes occurred since the DataSet object was loaded or after a call to the AcceptChanges() method was made.

If you want to revert all changes since the DataSet object was loaded, use the RejectChanges() method.

19. Which property is used to check whether a DataReader is closed or opened?
The IsClosed property is used to check whether a DataReader is closed or opened. This property returns a truevalue if a Data Reader is closed, otherwise a false value is returned.

20. Name the method that needs to be invoked on the DataAdapter control to fill the generated DataSet with data?
The Fill() method is used to fill the dataset with data.

21. What is the use of the Connection object?
The Connection object is used to connect your application to a specific data source by providing the required authentication information in connection string. The connection object is used according to the type of the data source. For example, the OleDbConnection object is used with an OLE-DB provider and the SqlConnection object is used with an MS SQL Server.

22. What is the use of the CommandBuilder class?
The CommandBuilder class is used to automatically update a database according to the changes made in a DataSet.

This class automatically registers itself as an event listener to the RowUpdating event. Whenever data inside a row changes, the object of the CommandBuilder class automatically generates an SQL statement and uses theSelectCommand property to commit the changes made in DataSet.

OLEDB provider in .NET Framework has the OleDbCommandBuiider class; whereas, the SQL provider has theSqlCommandBuilder class.

23. Explain the architecture of ADO.NET in brief.
AD0.NET consists of two fundamental components:
+ The DataSet, which is disconnected from the data source and does not need to know where the data that it holds is retrieved from.
+ The .net data provider, which allows you to connect your application to the data source and execute the SQL commands against it.

The data provider contains the Connection, Command, DataReader, and DataAdapter objects. The Connectionobject provides connectivity to the database. The Command object provides access to database commands to retrieve and manipulate data in a database. The DataReader object retrieves data from the database in the readonly and forward-only mode. The DataAdapter object uses Command objects to execute SQL commands. The DataAdapterobject loads the DataSet object with data and also updates changes that you have made to the data in the DataSetobject back to the database.

24. Describe the disconnected architecture of ADO.NET's data access model.
ADO.NET maintains a disconnected database access model, which means, the application never remains connected constantly to the data source. Any changes and operations done on the data are saved in a local copy (dataset) that acts as a data source. Whenever, the connection to the server is re-established, these changes are sent back to the server, in which these changes are saved in the actual database or data source.

25. What are the usages of the Command object in ADO.NET?
The following are the usages of the Command object in AD0.NET:

The Command object in AD0.NET executes a command against the database and retrieves a DataReader or DataSetobject.
+ It also executes the INSERT, UPDATE, or DELETE command against the database.
+ All the command objects are derived from the DbCommand class.
+ The command object is represented by two classes: SqlCommand and OleDbCommand.
+ The Command object provides three methods to execute commands on the database:
+ The ExecuteNonQuery() method executes a Transact-SQL statement against the connection and returns the number of rows affected.
+ The ExecuteScalar() method returns a single value from a database query.
+ The ExecuteReader() method returns a result set by using the DataReader object.

26. What are the pre-requisites for connection pooling?
The prerequisites for connection pooling are as follows:
+ There must be multiple processes to share the same connection describing the same parameters and security settings.
+ The connection string must be identical.

27. What is connection pooling?
Connection pooling refers to the task of grouping database connections in cache to make them reusable because opening new connections every time to a database is a time-consuming process. Therefore, connection pooling enables you to reuse already existing and active database connections, whenever required, and increasing the performance of your application.

You can enable or disable connection pooling in your application by setting the pooling property to either true or false in connection string. By default, it is enabled in an application.

28. What are the various methods provided by the DataSet object to generate XML?
The various methods provided by the DataSet object to generate XML are:
+ ReadXml() - Reads XML document into a DataSet object.
+ GetXml() - Returns a string containing an XML document.
+ WriteXml() - Writes an XML data to disk.

29. Out of Windows authentication and SQL Server authentication, which authentication technique is considered as a trusted authentication method?
The Windows authentication technique is considered as a trusted authentication method because the username and password are checked with the Windows credentials stored in the Active Directory.

The SQL Server Authentication technique is not trusted as all the values are verified by SQL Server only.

30. How would you connect to a database by using .NET?
The connection class is used to connect a .NET application with a database.

31. Which adapter should you use, if you want to get the data from an Access database?
OleDbDataAdapter is used to get the data from an Access database.

32. Which object is used to add a relationship between two DataTable objects?
The DataRelation object is used to add relationship between two DataTable objects.

33. What are different types of authentication techniques that are used in connection strings to connect .NET applications with Microsoft SQL Server?
.NET applications can use two different techniques to authenticate and connect with SQL Server. These techniques are as follows:
+ The Windows Authentication option
+ The SQL Server Authentication option

34. Explain the new features in ADO.NET Entity Framework 4.0.
ADO.NET Entity Framework 4.0 is introduced in .NET Framework 4.0 and includes the following new features:
+ Persistence Ignorance - Facilitates you to define your own Plain Old CLR Objects (POCO) which are independent of any specific persistence technology.
+ Deferred or Lazy Loading - Specifies that related entities can be loaded automatically whenever required. You can enable lazy loading in your application by setting the DeferredLoadingEnabled property to true.
+ Self-Tracking Entities - Refers to the entities that are able to track their own changes. These changes can be passed across process boundaries and saved to the database.
+ Model-First Development - Allows you to create your own EDM and then generate relational model (database) from that EDM with matching tables and relations.
+ Built-in Functions - Enables you to use built-in SQL Server functions directly in your queries.
+ Model-Defined Functions - Enables you to use the functions that are defined in conceptual schema definition language (CSDL).

35. What is the difference between the Clone() and Copy() methods of the DataSet class?
The Clone() method copies only the structure of a DataSet. The copied structure includes all the relation, constraint, and DataTable schemas used by the DataSet. The Clone() method does not copy the data, which is stored in the DataSet.

The Copy() method copies the structure as well as the data stored in the DataSet.

36. What is the use of DataView?
User-defined view of a table is contained in a DataView. A complete table or a small section of table depending on some criteria can be presented by an object of the DataView class. You can use this class to sort and find data withinDataTable.

The DataView class has the following methods:
+ Find() - Finds a row in a DataView by using sort key value.
+ FindRows() - Uses the sort key value to match it with the columns of DataRowView objects. It returns an array of all the corresponding objects of DataRowView whose columns match with the sort key value.
+ AddNew() - Adds a new row to the DataView object.
+ Delete() - Deletes the specified row from the DataView object according to the specified index.

37. What are the parameters that control most of connection pooling behaviors?
The parameters that control most of connection pooling behaviors are as follows:
+ Connect Timeout
+ Max Pool Size
+ Min Pool Size
+ Pooling

38. How can you add or remove rows from the DataTable object of DataSet?
The DataRowCollection class defines the collection of rows for the DataTable object in a DataSet. TheDataTable class provides the NewRow() method to add a new DataRow to DataTable. The NewRow method creates a new row, which implements the same schema as applied to the DataTable. The following are the methods provided by the DataRowCollection object:
+ Add() - Adds a new row to DataRowCollection.
+ Remove()- Removes a DataRow object from DataRowCollection.
+ RemoveAt() - Removes a row whose location is specified by an index number.

39. Explain in brief DataAdapter class in ADO.NET.
The DataAdapter class retrieves data from the database, stores data in a dataset, and reflects the changes made in the dataset to the database. The DataAdapter class acts as an intermediary for all the communication between the database and the DataSet object. The DataAdapter Class is used to fill a DataTable or DataSet Object with data from the database using the Fill() method. The DataAdapter class applies the changes made in dataset to the database by calling the Update() method.

The DataAdapter class provides four properties that represent the database command:

SelectCommand, InsertCommand, DeleteCommand, and UpdateCommand.

---

1. What is Dynamic Language Runtime (DLR)?
DLR is a runtime environment that allows you to integrate dynamic languages with the Common Language Runtime (CLR) by adding a set of services, such as expression trees, call site caching, and dynamic object interoperability to the CLR.

The System.Dynamic and System.Runtime.CompilerServices namespaces are used to hold the classes for DLR. It also provides dynamic features to statically-typed languages, such as C# and Visual Basic to enable their interoperation with dynamic languages.

2. What are the advantages of DLR?
The various advantages provided by DLR are:
+ Allows you to easily implement the dynamic languages to the .NET Framework.
+ Provides dynamic features to statically-typed languages. The statically-typed .NET Framework languages, such as C# and Visual Basic can create dynamic objects and use them together with statically-typed objects.
+ Implements sharing of libraries and objects, which means that the objects and libraries implemented in one language can be used by other languages using DLR. The DLR also enables interoperation between statically-typed and dynamic languages.
+ Enables fast execution of dynamic operations by supporting advance caching.

3. Give a brief introduction to Binders.
Binders are used by DLR to communicate with not the .NET Framework but also with various other services, such as Silverlight and COM. These services represent language-specific semantics and specify how a particular operation can be performed at the call site.

Call sites refer to the area in the code where logical and mathematical operations, such as a + b or a.b() are performed on dynamic objects.

4. Explain the different services provided by DLR to CLR.
The services provided by DLR to CLR are used for supporting dynamic languages. These services include the following:
+ Expression Trees - Refers to the representation of code in a data structure similar to a tree. However, expression trees in DLR are the advanced version of the expression trees that were introduced with LINQ in .NET 3.5. Therefore, DLR has extended the functionalities of Language Integrated Query (LINQ) expression trees, such as control flow, assignment, and other language-modeling nodes to a dynamic language. These expression trees define the semantics of a language in form of an abstract syntax tree (AST). AST enables the DLR to dynamically generate code, which the CLR executes at runtime.
+ Call Site Caching - Enables the DLR to store the information of the operations and characteristics of the variables, such as their data type. The call site caching services also enables to check whether such operations have been performed previously to retrieve all the information about the variable. The place where DLR stores these values is called a call site.
+ Dynamic Object Interoperability - Enables the DLR to provide a set of classes and interfaces that represent dynamic objects and operations. These classes and interfaces can be used to create classes for dynamic libraries, which can be used in static and dynamic type languages.

5. Name the binders provided by .NET Framework 4.0.
.NET Framework 4.0 provides the following binders:
+ Object Binder - Enables to communicate with .NET objects.
+ JavaScript Binder - Enables to communicate with JavaScript in Silverlight.
+ Python Binder - Enables to communicate with IronPython.
+ Ruby Binder - Enables to communicate with IronRuby.
+ COM Binder - Enables to communicate with COM.

6. Explain ExpandoObject and DynamicObject classes.
The ExpandoObject class refers to a class whose members can be explicitly added and removed at runtime. In other words, the ExpandoObject class allows dynamic binding of the objects, which enables you to use standard syntax, similar to the dynobj.Method method instead of using more complex syntax, such asdynobj.getAttribute("Method").

The DynamicObject class enables you to define the dynamic behavior for an object at run time. This class cannot be instantiated directly; therefore, to implement the dynamic behavior, you must inherit from the DynamicObject class and override the necessary methods. It allows you to define the specific operations that can be performed on dynamic objects as well the methods to perform those operations.

7. What is the difference between dynamic and var data types?
The difference between the var and dynamic data types is that the var data type is strongly type checked at the compile time; whereas, the dynamic data type is type checked by the compiler only at run time. After declaring a var data type, you cannot explicitly change its type throughout the execution of the program; however, a variable of the dynamic data type can be changed during runtime. Another major difference between the two is that dynamic type can also be used as the return type for methods, for which var cannot be used.

8. Which class is used for converting the data types?
The System.Convert class provides a complete set of methods for converting the data types.

---

1. What is ASP?
Active Server Pages (ASP), also known as Classic ASP, is a Microsoft's server-side technology, which helps in creating dynamic and user-friendly Web pages. It uses different scripting languages to create dynamic Web pages, which can be run on any type of browser. The Web pages are built by using either VBScript or JavaScript and these Web pages have access to the same services as Windows application, including ADO (ActiveX Data Objects) for database access, SMTP (Simple Mail Transfer Protocol) for e-mail, and the entire COM (Component Object Model) structure used in the Windows environment. ASP is implemented through a dynamic-link library (asp.dll) that is called by the IIS server when a Web page is requested from the server.
2. What is ASP.NET?
ASP.NET is a specification developed by Microsoft to create dynamic Web applications, Web sites, and Web services. It is a part of .NET Framework. You can create ASP.NET applications in most of the .NET compatible languages, such as Visual Basic, C#, and J#. The ASP.NET compiles the Web pages and provides much better performance than scripting languages, such as VBScript. The Web Forms support to create powerful forms-based Web pages. You can use ASP.NET Web server controls to create interactive Web applications. With the help of Web server controls, you can easily create a Web application.
3. What is the basic difference between ASP and ASP.NET?
The basic difference between ASP and ASP.NET is that ASP is interpreted; whereas, ASP.NET is compiled. This implies that since ASP uses VBScript; therefore, when an ASP page is executed, it is interpreted. On the other hand, ASP.NET uses .NET languages, such as C# and VB.NET, which are compiled to Microsoft Intermediate Language (MSIL).
4. In which event are the controls fully loaded?
Page load event guarantees that all controls are fully loaded. Controls are also accessed in Page_Init events but you will see that view state is not fully loaded during this event
5. How can we identify that the Page is Post Back?
Page object has an "IsPostBack" property, which can be checked to know that is the page posted back.
6. What is the lifespan for items stored in ViewState?
The items stored in ViewState live until the lifetime of the current page expires including the postbacks to the same page.
7. How information about the user's locale can be accessed?
The information regarding a user's locale can be accessed by using the System.Web.UI.Page.Culture property.
8. What is the difference between SQL notification and SQL invalidation?
The SQL cache notification generates notifications when the data of a database changes, on which your cache item depends. The SQL cache invalidation makes a cached item invalid when the data stored in a SQL server database changes.
9. Which is the parent class of the Web server control?
The System.Web.UI.Control class is the parent class for all Web server controls.
10. Can you set which type of comparison you want to perform by the CompareValidator control?
Yes, by setting the Operator property of the CompareValidator control.
11. What is the behavior of a Web browser when it receives an invalid element?
The behavior of a Web browser when it receives an invalid element depends on the browser that you use to browse your application. Most of the browsers ignore the invalid element; whereas, some of them display the invalid elements on the page.
12. What are the advantages of the code-behind feature?
The code-behind feature of ASP.NET offers a number of advantages:
+ Makes code easy to understand and debug by separating application logic from HTML tags
+ Provides the isolation of effort between graphic designers and software engineers
+ Removes the problems of browser incompatibility by providing code files to exist on the Web server and supporting Web pages to be compiled on demand.
+ 13. How do you sign out from forms authentication?
+ The FormsAuthentication.Signout() method is used to sign out from the forms authentication.
+ 14. What is AutoPostBack?
+ If you want a control to postback automatically when an event is raised, you need to set the AutoPostBack property of the control to True.
+ 15. What is the function of the ViewState property?
+ The ASP.NET 4.0 introduced a new property called ViewStateMode for the Control class. Now you can enable the view state to an individual control even if the view state for an ASP.NET page is disabled.
+ 16. Why do you use the App_Code folder in ASP.NET?
+ The App_Code folder is automatically present in the project. It stores the files, such as classes, typed data set, text files, and reports. If this folder is not available in the application, you can add this folder. One of the important features of the App_Code folder is that only one dll is created for the complete folder, irrespective of how many files it contains.
+ 17. Define a multilingual Web site.
+ A multilingual Web site serves content in a number of languages. It contains multiple copies for its content and other resources, such as date and time, in different languages.
+ 18. What is an ASP.NET Web Form?
+ ASP.NET Web forms are designed to use controls and features that are almost as powerful as the ones used with Windows forms, and so they are called as Web forms. The Web form uses a server-side object model that allows you to create functional controls, which are executed on the server and are rendered as HTML on the client. The attribute,runat="server", associated with a server control indicates that the Web form must be processed on the server.
19. What is the difference between a default skin and a named skin?
The default skin is applied to all the Web server controls in a Web form, which are of similar type, and it does not provide a Skin ID attribute. The named skin provides a Skin ID attribute and users have to set the Skin ID property to apply it.
20. What is IIS? Why is it used?
Internet Information Services (IIS) is created by Microsoft to provide Internet-based services to ASP.NET Web applications. It makes your computer to work as a Web server and provides the functionality to develop and deploy Web applications on the server. IIS handles the request and response cycle on the Web server. It also offers the services of SMTP and FrontPage server extensions. The SMTP is used to send emails and use FrontPage server extensions to get the dynamic features of IIS, such as form handler.
21. What is Query String? What are its advantages and limitations?
The Query String helps in sending the page information to the server.

The Query String has the following advantages:
+ Every browser works with Query Strings.
+ It does not require server resources and so does not exert any kind of burden on the server.

The following are the limitations of Query String:
+ Information must be within the limit because URL does not support many characters.
+ Information is clearly visible to the user, which leads to security threats.
22. What is actually returned from server to the browser when a browser requests an .aspx file and the file is displayed?
When a browser requests an .aspx file then the server returns a response, which is rendered into a HTML string.
23. How can you display all validation messages in one control?
The ValidationSummary control displays all validation messages in one control.
24. Which two new properties are added in ASP.NET 4.0 Page class?
The two new properties added in the Page class are MetaKeyword and MetaDescription.
25. What is tracing? Where is it used?
Tracing displays the details about how the code was executed. It refers to collecting information about the application while it is running. Tracing information can help you to troubleshoot an application. It enables you to record information in various log files about the errors that might occur at run time. You can analyze these log files to find the cause of the errors.

In .NET, we have objects called Trace Listeners. A listener is an object that gets the trace output and stores it to different places, such as a window, a file on your locale drive, or a SQL Server.

The System.Diagnostics namespace contains the predefined interfaces, classes, and structures that are used for tracing. It supplies two classes, Trace and Debug, which allow you to write errors and logs related to the application execution. Trace listeners are objects that collect the output of tracing processes.
26. What is the difference between authentication and authorization?
Authentication verifies the identity of a user and authorization is a process where you can check whether or not the identity has access rights to the system. In other words, you can say that authentication is a procedure of getting some credentials from the users and verify the user's identity against those credentials. Authorization is a procedure of granting access of particular resources to an authenticated user. You should note that authentication always takes place before authorization.
27. How can you register a custom server control to a Web page?
You can register a custom server control to a Web page using the @Register directive.
28. Which ASP.NET objects encapsulate the state of the client and the browser?
The Session object encapsulates the state of the client and browser.
29. Differentiate globalization and localization.
The globalization is a technique to identify the specific part of a Web application that is different for different languages and make separate that portion from the core of the Web application. The localization is a procedure of configuring a Web application to be supported for a specific language or locale.
30. What is ViewState?
The ViewState is a feature used by ASP.NET Web page to store the value of a page and its controls just before posting the page. Once the page is posted, the first task by the page processing is to restore the ViewState to get the values of the controls.
31. Which method is used to force all the validation controls to run?
The Page.Validate() method is used to force all the validation controls to run and to perform validation.
32. Which method has been introduced in ASP.NET 4.0 to redirect a page permanently?
The RedirectPermanent() method added in ASP.NET 4.0 to redirect a page permanently. The following code snippet is an example of the RedirectPermanent() method:

RedirectPermanent("/path/Aboutus.aspx");
33. How can you send an email message from an ASP.NET Web page?
You can use the System.Net.Mail.MailMessage and the System.Net.Mail.SmtpMail classes to send an email in your Web pages. In order to send an email through your mail server, you need to create an object of theSmtpClient class and set the server name, port, and credentials.
34. What is the difference between the Response.Write() and Response.Output.Write() methods?
The Response.Write() method allows you to write the normal output; whereas, the Response.Output.Write()method allows you to write the formatted output.
35. What does the Orientation property do in a Menu control?
Orientation property of the Menu control sets the horizontal or vertical display of a menu on a Web page. By default, the orientation is vertical.
36. Differentiate between client-side and server-side validations in Web pages.
Client-side validations take place at the client end with the help of JavaScript and VBScript before the Web page is sent to the server. On the other hand, server-side validations take place at the server end.
37. How does a content page differ from a master page?
A content page does not have complete HTML source code; whereas a master page has complete HTML source code inside its source file.
38. Suppose you want an ASP.NET function (client side) executed on the MouseOver event of a button. Where do you add an event handler?
The event handler is added to the Add() method of the Attributes property.
39. What is the default timeout for a Cookie?
The default time duration for a Cookie is 30 minutes.
40. What are HTTP handlers in ASP.NET?
HTTP handlers, as the name suggests, are used to handle user requests for Web application resources. They are the backbone of the request-response model of Web applications. There is a specific event handler to handle the request for each user request type and send back the corresponding response object.

Each user requests to the IIS Web server flows through the HTTP pipeline, which refers to a series of components (HTTP modules and HTTP handlers) to process the request. HTTP modules act as filters to process the request as it passes through the HTTP pipeline. The request, after passing through the HTTP modules, is assigned to an HTTP handler that determines the response of the server to the user request. The response then passes through the HTTP modules once again and is then sent back to the user.

You can define HTTP handlers in the element of a configuration file. The element tag is used to add new handlers and the element tag is used to remove existing handlers. To create an HTTP handler, you need to define a class that implements the IHttpHandler interface.
41. What are the events that happen when a client requests an ASP.NET page from IIS server?
The following events happen when a client requests an ASP.NET page from the IIS server:
1. User requests for an application resource.
2. The integrated request-processing pipeline receives the first user request.
3. Response objects are created for each user request.
4. An object of the HttpApplication class is created and allocated to the Request object.
5. The HttpApplication class processes the user request.
42. Explain file-based dependency and key-based dependency.
In file-based dependency, you have to depend on a file that is saved in a disk. In key-based dependency, you have to depend on another cached item.
43. How can you implement the postback property of an ASP.NET control?
You need to set the AutoPostBack property to True to implement the PostBack property of controls.
44. Explain how Cookies work. Give an example of Cookie abuse.
The server tells the browser to put some files in a cookie, and the client then sends all the cookies for the domain in each request. An example of cookie abuse is large cookies affecting the network traffic.
45. Explain login controls.
Login controls are built-in controls in ASP.Net for providing a login solution to ASP.NET application. The login controls use the membership system to authenticate a user credentials for a Web site.

There are many controls in login controls.
+ ChangePassword control - Allows users to change their password.
+ CreateUserWizard control - Provides an interface to the user to register for that Web site.
+ Login control - Provides an interface for user authentication. It consists of a set of controls, such asTextBox, Label, Button, CheckBox, HyperLink.
+ LoginView control - Displays appropriate information to different users according to the user's status.
+ LoginStatus control - Shows a login link to users, who are not authenticated and logout link, who are authenticated
+ LoginName control - Displays a user name, if the user logs in.
+ PasswordRecovery control - Allows users to get back the password through an e-mail, if they forget.
46. What is the use of PlaceHolder control? Can we see it at runtime?
The PlaceHolder control acts as a container for those controls that are dynamically generated at runtime. We cannot see it at runtime because it does not produce any visible output. It used only as a container.
47. What setting must be added in the configuration file to deny a particular user from accessing the secured resources?
To deny a particular user form accessing the secured resources, the web.config file must contain the following code:

48. What are the event handlers that can be included in the Global.asax file?
The Global.asax file contains some of the following important event handlers:
+ Application_Error
+ Application_Start
+ Application_End
+ Session_Start
+ Session_End
49. What is the difference between page-level caching and fragment caching?
In the page-level caching, an entire Web page is cached; whereas, in the fragment caching, a part of the Web page, such as a user control added to the Web page, is cached.
50. Make a list of all templates of the Repeater control.
The Repeater control contains the following templates:
+ ItemTemplate
+ AlternatingltemTemplate
+ SeparatorTemplate
+ HeaderTemplate
+ FooterTemplate
51. Describe the complete lifecycle of a Web page.
When we execute a Web page, it passes from the following stages, which are collectively known as Web page lifecycle:
+ Page request - During this stage, ASP.NET makes sure the page either parsed or compiled and a cached version of the page can be sent in response
+ Start - During this stage sets the Request and Response page properties and the page check the page request is either a postback or a new request
+ Page Initialization - During this stage, the page initialize and the control's Unique Id property are set
+ Load - During this stage, if the request is postback, the control properties are loaded without loading the view state and control state otherwise loads the view state
+ Validation - During this stage, the controls are validated
+ Postback event handling - During this stage, if the request is a postback, handles the event
+ Rendering - During this stage, the page invokes the Render method to each control for return the output
+ Unload - During this stage, when the page is completely rendered and sent to the client, the page is unloaded.
52. How can you assign page specific attributes in an ASP.NET application?
The @Page directive is responsible for this.
53. Which method is used to post a Web page to another Web page?
The Respose.Redirect method is used to post a page to another page, as shown in the following code snippet:Response.Redirect("DestinationPageName.aspx");
54. What is a Cookie? Where is it used in ASP.NET?
Cookie is a lightweight executable program, which the server posts to client machines. Cookies store the identity of a user at the first visit of the Web site and validate them later on the next visits for their authenticity. The values of a cookie can be transferred between the user's request and the server's response.
55. What are Custom User Controls in ASP.NET?
The custom user controls are the controls that are defined by developers. These controls are a mixture of custom behavior and predefined behavior. These controls work similar to other Web server controls.
56. What does the .WebPart file do?
The .WebPart file explains the settings of a Web Parts control that can be included to a specified zone on a Web page.
57. How can you enable impersonation in the web.config file?
To enable impersonation in the web.confing file, you need to include the element in the web.configfile and set the impersonate attribute to true as shown in the following code snippet:

58. How can you identify that the page is PostBack?
The Page object uses the IsPostBack property to check whether the page is posted back or not. If the page is postback, this property is set to true.
59. In which database is the information, such as membership, role management, profile, and Web parts personalization, stored?
The aspnetdb database stores all information.
60. What is State Management? How many ways are there to maintain a state in .NET?
State management is used to store information requests. The state management is used to trace the information or data that affect the state of the applications.

There are two ways to maintain a state in .NET, Client-Based state management and Server-Based state management.

The following techniques can be used to implement the Client-Based state management:
+ View State
+ Hidden Fields
+ Cookies
+ Query Strings
+ Control State

The following techniques can be used to implement Server-Based state management:
+ Application State
+ Session State
+ Profile Properties
61. What do you understand by aggregate dependency?
Aggregate dependency allows multiple dependencies to be aggregated for content that depends on more than one resource. In such type of dependency, you need to depend on the sum of all the defined dependencies to remove a data item from the cache.
62. How can you ensure that no one has tampered with ViewState in a Web page?
To ensure that no one has tampered with ViewState in a Web page, set the EnableViewStateMac property toTrue.
63. What is the difference between adding items into cache through the Add() method and through theInsert() method?
Both methods work in a similar way except that the Cache.Add() function returns an object that represents the item you added in the cache. The Cache.Insert() function can replace an existing item in the cache, which is not possible using the Cache.Add() method.
64. Explain the cookie less session and its working.
ASP.NET manages the session state in the same process that processes the request and does not create a cookie. It is known as a cookie less session. If cookies are not available, a session is tracked by adding a session identifier to the URL. The cookie less session is enabled using the following code snippet:
65. What is a round trip?
The trip of a Web page from the client to the server and then back to the client is known as a round trip.
66. What are the major built-in objects in ASP.NET?
The major built-in objects in ASP.NET are as follows:
+ Application
+ Request
+ Response
+ Server
+ Session
+ Context
+ Trace

67. Where should the data validations be performed-at the client side or at the server side and why?
Data validations should be done primarily at the client side and the server-side validation should be avoided because it makes server task overloaded. If the client-side validation is not available, you can use server-side validation. When a user sends a request to the server, the validation controls are invoked to check the user input one by one.
68. Why do we need nested master pages in a Web site?
When we have several hierarchical levels in a Web site, then we use nested master pages in the Web site.
69. How can you dynamically add user controls to a page?
User controls can be dynamically loaded by adding a Web User Control page in the application and adding the control on this page.
70. What is the appSettings Section in the web.config file?
The web.config file sets the configuration for a Web project. The appSettings block in configuration file sets the user-defined values for the whole application.

For example, in the following code snippet, the specified ConnectionString section is used throughout the project for database connection:

...
71. What type of code, client-side or server-side, is found in a code-behind file of a Web page?
A code-behind file contains the server-side code, which means that the code contained in a code-behind file is executed at the server.
72. To which class a Web form belongs to in the .NET Framework class hierarchy?
A Web form belongs to the System.Web.UI.Page class.
73. What does the "EnableViewState" property do? Why do we want it On or Off?
The EnableViewState property enables the ViewState property on the page. It is set to On to allow the page to save the users input between postback requests of a Web page; that is, between the Request and correspondingResponse objects. When this property is set to Off, the page does not store the users input during postback.
74. Which event determines that all the controls are completely loaded into memory?
The Page_Load event determines that all the controls on the page are fully loaded. You can also access the controls in the Page_Init event; however, the ViewState property does not load completely during this event.
75. What is the function of the CustomValidator control?
It provides the customize validation code to perform both client-side and server-side validation.
76. What is Role-based security?
In the Role-based security, you can assign a role to every user and grant the privilege according to that role. A role is a group of principal that restricts a user's privileges. Therefore, all the organization and applications use role-based security model to determine whether a user has enough privileges to perform a requested task.
77. Which data type does the RangeValidator control support?
The data types supported by the RangeValidator control are Integer, Double, String, Currency, and Date.
78. What are the HTML server controls in ASP.NET?
HTML server controls are similar to the standard HTML elements, which are normally used in HTML pages. They expose properties and events that can be used programmatically. To make these controls programmatically accessible, you need to specify that the HTML controls act as a server control by adding the runat="server" attribute.
79. Why a SiteMapPath control is referred to as breadcrumb or eyebrow navigation control?
The SiteMapPath control displays a hierarchical path to the root Web page of the Web site. Therefore, it is known as the breadcrumb or eyebrow navigation control.
80. Where is the ViewState information stored?
The ViewState information is stored in the HTML hidden fields.
81. Which namespaces are necessary to create a localized application?
The System.Globalization and System.Resources namespaces are essential to develop a localized application.
82. What is the difference between an HtmlInputCheckBox control and an HtmlInputRadioButton control?
You can select more than one HtmlInputCheckBox control from a group of HtmlInputCheckBox controls; whereas, you can select only a single HtmllnputRadioButton control from a group of HtmlInputRadioButtoncontrols.
83. What is the difference between HTML and Web server controls?
HTML controls are client-side controls; therefore, all the validations for HTML controls are performed at the client side. On the other hand, Web server controls are server-side controls; therefore, all the validations for Web server controls are performed at the server side.
84. Explain the AdRotator Control.
The AdRotator is an ASP.NET control that is used to provide advertisements to Web pages. The AdRotator control associates with one or many advertisements, which randomly displays one by one at a time when the Web page is refreshed. The AdRotator control advertisements are associated with links; therefore, when you click on an advertisement, it redirects you to other pages.

The AdRotator control is associated with a data source, which is normally an xml file or a database table. A data source contains all the information, such as advertisement graphics reference, link, and alternate text. Therefore, when you use the AdRotator control, you should first create a data source and then associate it with theAdRotator control.
85. What do you understand by the culture?
The culture denotes a combination of a language and optionally a region or a country. The contents of a Web page of a multilingual Web site are changed according to the culture defined in the operating system of the user accessing the Web page.
86. What is the difference between absolute expiration and sliding-time expiration?
The absolute expiration expires a cached item after the provided expiration time. The sliding time does not expire the cached items because it increments the specified time.
87. What is the code-behind feature in ASP.NET?
The code-behind feature of ASP.NET enables you to divide an ASP.NET page into two files - one consisting of the presentation data, and the second, which is also called the code-behind file, consisting of all the business logic. The presentation data contains the interface elements, such as HTML controls and Web server controls, and the code-behind contains the event-handling process to handle the events that are fired by these controls. The file that contains the presentation data has the .aspx extension. The code behind file has either the .cs extension (if you are using the programming language C#) or the .vb (if you are using the programming language Visual Basic .NET) extension.
88. How can you check if all the validation controls on a Web page are valid and proper?
You can determine that all the validation controls on a Web page are properly working by writing code in the source file of the Web page using a scripting language, such as VBScript or JavaScript. To do this task, you have to loop across validators collection of pages and check the IsValid property of each validation control on the Web page to check whether or not the validation test is successful.
89. Explain the validation controls. How many validation controls in ASP.NET 4.0?
Validation controls are responsible to validate the data of an input control. Whenever you provide any input to an application, it performs the validation and displays an error message to user, in case the validation fails.

ASP.NET 4.0 contains the following six types of validation controls:
+ CompareValidator - Performs a comparison between the values contained in two controls.
+ CustomValidator - Writes your own method to perform extra validation.
+ RangeValidator- Checks value according to the range of value.
+ RegularExpressionValidator - Ensures that input is according to the specified pattern or not.
+ RequiredFieldValidator - Checks either a control is empty or not.
+ ValidationSummary - Displays a summary of all validation error in a central location.
90. What is difference between a Label control and a Literal control?
The Label control's final html code has an HTML tag; whereas, the Literal control's final html code contains only text, which is not surrounded by any HTML tag.
91. How many types of Cookies are available in ASP.NET?
There are two types of Cookies available in ASP.NET:
+ Session Cookie - Resides on the client machine for a single session until the user does not log out.
+ Persistent Cookie - Resides on a user's machine for a period specified for its expiry, such as 10 days, one month, and never.

The user can set this period manually.
92. What is the use of the Global.asax file?
The Global.asax file executes application-level events and sets application-level variables.
93. What are the Culture and UICulture values?
The Culture value determines the functions, such as Date and Currency, which are used to format data and numbers in a Web page. The UICulture value determines the resources, such as strings or images, which are loaded for a Web page in a Web application.
94. What is the difference between ASP session and ASP.NET session?
ASP does not support cookie-less sessions; whereas, ASP.NET does. In addition, the ASP.NET session can span across multiple servers.
95. Which control will you use to ensure that the values in two different controls match?
You should use the CompareValidator control to ensure that the values in two different controls match.
96. What is the difference between a page theme and a global theme?
A page theme is stored inside a subfolder of the App_Themes folder of a project and applied to individual Web pages of that project. Global themes are stored inside the Themes folder on a Web server and apply to all the Web applications on the Web server.
97. What do you mean by a neutral culture?
When you specify a language but do not specify the associated country through a culture, the culture is called as a neutral culture.
98. What is the use of the tag in the web.config file?
The tag is used to configure the session state features. To change the default timeout, which is 20 minutes, you have to add the following code snippet to the web.config file of an application:
99. Can you post and access view state in another application?
Yes, you can post and access a view state in other applications. However, while posting a view state in another application, the PreviousPage property returns null.
100. Which method do you use to kill explicitly a users session?
The Session.Abandon() method kills the user session explicitly.
101. Which class is inherited when an ASP.NET server control is added to a Web form?
The System.Web.UI.WebControls class is inherited when an ASP.NET server control is added to a Web form.
102. What events are fired when a page loads?
The following events fire when a page loads:
+ Init() - Fires when the page is initializing.
+ LoadViewState() - Fires when the view state is loading.
+ LoadPostData() - Fires when the postback data is processing.
+ Load() - Fires when the page is loading.
+ PreRender() - Fires at the brief moment before the page is displayed to the user as HTML.
+ Unload() - Fires when the page is destroying the instances of server controls.

103. Write three common properties of all validation controls.
Three common properties of validation controls are as follows:
+ ControlToValidate - Provides a control to validate
+ ErrorMessage - Displays an error message
+ IsValid - Specifies if the control's validation has succeeded or not
+ Text - Displays a text for validation control before validation
104. What are navigation controls? How many navigation controls are there in ASP.NET 4.0?
Navigation controls help you to navigate in a Web application easily. These controls store all the links in a hierarchical or drop-down structure; thereby facilitating easy navigation in a Web application.

There are three navigation controls in ASP.Net 4.0.
+ SiteMapPath
+ Menu
+ TreeView
105. What happens if an ASP.NET server control with event-handling routines is missing from its definition?
The compilation of the application fails.
106. What are server-side comments?
Server-side comments are included in an ASP.NET page for the purpose of documentations as shown in the following code snippet:

The server-side comments begin with .
107. How can we provide the WebParts control functionality to a server control?
We can provide the WebParts controls functionality to a server control by setting the CreateWebPart property ofWebPartManger.
108. How do you prevent a validation control from validating data at the client end?
You can prohibit a validation control to validate data at the client side by setting the EnableClientScript property to False.
109. What is cross-page posting in ASP.NET?
The Server.Transfer() method is used to post data from one page to another. In this case, the URL remains the same. However, in cross page posting, data is collected from different Web pages and is displayed on a single page. To do so, you need to set the PostBackUrl property of the control, which specifies the target page. In the target page, you can access the PreviousPage property. For this, you need to use the @PreviousPageType directive. You can access the controls of previous page by using the FindControl() method.
110. Which ASP.NET configuration options are supported in the ASP.NET implementation on the shared Web hosting platform?
There are many ASP.NET configuration choices, which are not able to configure at the site, application, or child directory level on the shared hosting environment. Some options can produce security, performance, and stability problem to the server and therefore cannot be changed.

The following settings are the only ones that can be changed in the web.config file(s) of your Web site:
+ browserCaps
+ clientTarget
+ pages
+ customErrors
+ globalization
+ authorization
+ authentication
+ webControls
+ webServices
111. Explain the Application and Session objects in ASP.NET.
Application state is used to store data corresponding to all the variables of an ASP.NET Web application. The data in an application state is stored once and read several times. Application state uses the HttpApplicationState class to store and share the data throughout the application. You can access the information stored in an application state by using the HttpApplication class property. Data stored in the application state is accessible to all the pages of the application and is the same for all the users accessing the application. The HttpApplicationState class provides a lock method, which you can use to ensure that only one user is able to access and modify the data of an application at any instant of time.

Each client accessing a Web application maintains a distinct session with the Web server, and there is also some specific information associated with each of these sessions. Session state is defined in the element of the web.config file. It also stores the data specific to a user session in session variables. Different session variables are created for each user session. In addition, session variables can be accessed from any page of the application. When a user accesses a page, a session ID for the user is created. The session ID is transferred between the server and the client over the HTTP protocol using cookies.
112. How will you differentiate a submaster page from a top-level master page?
Similar to a content page, a submaster page also does not have complete HTML source code; whereas, a top-level master page has complete HTML source code inside its source file.
113. What are Web server controls in ASP.NET?
The ASP.NET Web server controls are objects on the ASP.NET pages that run when the Web page is requested. Many Web server controls, such as button and text box, are similar to the HTML controls. In addition to the HTML controls, there are many controls, which include complex behavior, such as the controls used to connect to data sources and display data.
114. What is the difference between a HyperLink control and a LinkButton control?
A HyperLink control does not have the Click and Command events; whereas, the LinkButton control has these events, which can be handled in the code-behind file of the Web page.
115. What are the various ways of authentication techniques in ASP.NET?
There are various techniques in ASP.NET to authenticate a user. You can use one of the following ways of authentication to select a built-in authentication provider:
+ Windows Authentication - This mode works as the default authentication technique. It can work with any form of Microsoft Internet Information Services (IIS) authentication, such as Basic, Integrated Windows authentication (NTLM/Kerberos), Digest, and certificates. The syntax of Windows authentication mode is given as follows:
+ Forms Authentication - You can specify this mode as a default authentication mode by using the following code snippet:
+ Passport - This mode works with Microsoft Passport authentication, as shown in the following code snippet:
116. What are the different ways to send data across pages in ASP.NET?
The following two ways are used to send data across pages in ASP.NET:
+ Session
+ Public properties
117. What does the WebpartListUserControlPath property of a DeclarativeCatalogPart control do?
The WebpartListUserControlPath property sets the route of the user defined control to aDeclarativeCatalogPart control.
118. What do you mean by the Web Part controls in ASP.NET?
The Web Part controls are the integrated controls, which are used to create a Web site. These controls allow the users to change the content, outlook, and state of Web pages in a Web browser.
119. What type of the CatalogPart control enables users to restore the Web Parts that have been removed earlier by the user?
The PageCatalogPart control.
120. What is the use of web.config? What is the difference between machine.config and web.config?
ASP.NET configuration files are XML-based text files for application-level settings and are saved with the name web.config. These files are present in multiple directories on an ASP.NET Web application server. The web.config file sets the configuration settings to the directory it is placed in and to all the virtual sub folders under it. The settings in sub directories can optionally override or change the settings specified in the base directory.

The difference between the web.config and machine.config files is given as follows:
+ \Microsoft.NET\Framework\\config\machine.config provides default configuration settings for the entire machine. ASP.NET configures IIS to prohibit the browser directly from accessing the web.config files to make sure that their values cannot be public. Attempts to access those files cause ASP.NET to return the 403: Access Forbidden error.
+ ASP.NET uses these web.config configuration files at runtime to compute hierarchically a sole collection of settings for every URL target request. These settings compute only once and cached across further requests. ASP.NET automatically checks for changing file settings and do not validate the cache if any of the configuration changes made.

121. Explain the concept of states in ASP.NET.
State is quite an innovative concept in Web development because it eliminates the drawback of losing state data due to reloading of a Web page. By using states in a Web application, you can preserve the state of the application either at the server or client end. The state of a Web application helps you to store the runtime changes that have been made to the Web application. For example, as already described earlier, a change in the data source of the Web application might be initiated by a user when he/she selects and saves some products in the shopping cart.

If you are not using states, these changes are discarded and are not saved. You may think that the whole concept of storing states is optional. However, under certain circumstances, using states with applications is imperative. For example, it is necessary to store states for Web applications, such as an e-commerce shopping site or an Intranet site of a company, to keep track of the requests of the users for the items they have selected on the shopping site or the days requested for vacation on the Intranet site.
122. Can we validate a DropDownList by RequiredFieldValidator?
Yes, we can validate a DropDownList by RequiredFieldValidator. To perform this validation, we have to set theInitialValue property of RequiredFieldValidator control.
123. List the features of the Chart control.
The following are the features of the Chart control:
+ Bounds a chart with any data source.
+ Simple manipulation of chart data, such as copying, merging, grouping, sorting, searching, and filtering.
+ Support many statistical and financial formulas for data analysis.
+ Provide advanced chart outlook, such as 2-D, 3-D, lighting, and perspective.
+ Support events and customizations.
+ Includes interactivity with Microsoft AJAX.
+ Supports AJAX Content Delivery Network (CDN).

---

1. What is deployment?
Deployment refers to the distribution of an application among various end-users. It is a process that makes software available for use by just installing it on the client computer.
2. List different ways of deployment that are supported by .NET Framework 4.0.
+ Windows Installer
+ ClickOnce
+ XCOPY
+ Copy Web Site
+ Publish Web Site tool
3. What is XCOPY?
XCOPY enables you to deploy an application by copying the application directory and all subdirectories to the target computer and then executing the application on the client. The application starts executing on the target computer by using its assembly file, which is a self-description file that contains all the information about the application. The XCOPY deployment does not make any impact on the target system while configuring the components and registering entries, and is therefore known as zero-impact installation.
4. Does XCOPY copy the hidden and system files?
No. By default, XCOPY excludes the hidden and system files. However, you can include the hidden and system files using the /h switch.
5. Why do you use Windows Installer?
The Windows Installer deployment technique allows you to deploy Windows-based and Web applications by creating a Windows Installer Package. The installer package has an extension of .msi and it contains the application, any dependent files, registry entries, and the rest. The installer package can then be distributed to various end-users by simply copying it on the target computers.

The end-users can then run the installer package to install the application anywhere in their computers. The installation takes place using the installation wizard; therefore, the users can easily install the application on their system. Once your application is installed on the target computer, end-users can open the application from the installed location.
6. Can you deploy an ASP.NET Web application project using the Copy Web Site option?
No. The Copy Web Site option can only be used to deploy the Web sites.
7. How can you determine whether you should deploy the application or publish the application?
If you want to host the application on a shared hosting environment, you should use publishing; whereas, if you want to create a Web application that is downloaded from a Web site, you should deploy the application to create a setup.exe file.
8. How can you deploy an ASP.NET Web application?
You can deploy an ASP.NET Web application using either the Windows Installer deployment or ClickOnce deployment technique.
9. What is Application Cache?
When a ClickOnce application is installed locally or hosted online, it is stored in the ClickOnce application cache of the client computer. The ClickOnce application cache is a set of hidden directories placed under the Local Settings directory of the current user's Documents and Settings folder. The application cache contains all the application files, assemblies, configuration files, application and user settings, and data directory. In case the ClickOnce applications are hosted online, the size of the ClickOnce application cache gets limited to a specified amount; whereas, the installed applications do not restrict to the cache size limitation. The cache storage quota is responsible to determine the size of the application cache.
10. What are the enhancements in ClickOnce deployment in .NET 4.0?
In .NET 4.0, the ClickOnce deployment technology is enhanced with the following features:
+ Support for .NET Framework 4.0 version - Creates applications by using Visual Studio 2010 that can target .NET Framework 4.0 and its new features.
+ Support for multiple versions of the .NET Framework - Creates applications that are compatible with multiple versions of the .NET Framework. You can specify the target framework for an application as .NET Framework 3.5 or .NET Framework 4 while creating the application.
+ Enhanced logging feature - Stores logging information that includes various parameters passed to the ClickOnce runtime, the browser settings, and ClickOnce security options.
+ Custom Installer and User Interface - Allows you to create a custom graphical user interface for installing and updating the .exe applications. In addition, the custom installer can have custom dialog boxes for security and maintenance operations.
11. What is the difference between deploying and publishing an application?
In deployment, you can create a new setup and deployment project. In this project, you can add the project output and create a setup.exe file. After creating an executable file, you need to login into the server and execute the setup.exe file to install the application. On the other hand, in publishing, you need to right-click the application in the Solution Explorer and select Publish to publish the application. Then, you specify a location where the application is to be published. The users can then install the application from the location where you have published it and run locally even when the computer is offline.
12. What do you mean by Merge Module projects?
Merge Module projects are used to package the files and components that are shared between multiple applications. The Merge Module project file contains the .msm extension. The .msm file includes files, resources, registry entries, and setup logic. This file is merged with a Windows installer (.msi) file to correctly install the shared files. If a single merge module is used by more than one application, then you need to add that merge module in the package only once.
13. What is the need of Copy Web Site?
Copy Web Site is a tool used to deploy the Web site by copying its content files. The Copy Web Site tool also checks whether or not the latest version of a file is present at the destination. If files of the most recent version are found at the destination, then the Copy Web Site tool does not superimpose the older version of files. The Copy Web Site deployment tool consists of the following main entities:
+ Project source - Specifies the source directory, which contains the contents and references of a Web site at development time. In simple words, you can say that the project source specifies the site that you currently have opened in Visual Studio 2010. The Copy Web Site tool picks all the files for deployment from this location.
+ Project destination - Specifies the destination folder where you have to deploy the application. This destination directory can be placed on remote computers or servers, which allow you to copy the Web site contents using the Front Page Server Extensions, FTP, or HTTP protocol implementations for content transfer.
+ Synchronizing two Web sites - Synchronizes two Web sites by copying each other's files. Synchronization checks the files on the local and remote sites and ensures that all files on both sites are up to date.
14. What is the use of the Copy Project command?
The Copy Project command copies only the files required to run the project and pastes it on the target server. It does not deploy the complete project; therefore, IIS directory settings are not automatically configured.
15. Can Windows applications and the Web applications be deployed using the same template of Setup and Deployment project?
No. the Windows applications use the Setup Project template; whereas, the Web applications use the Web Setup Project template. After the deployment, their installation takes place in the similar way.
16. Explain the .NET Framework deployment features.
In a general context, .NET Framework includes the following deployment features:
+ No-impact applications - Provides application isolation and removes DLL conflicts.
+ Private components by default - Enables the components to deploy to the application directory and to be visible only to the containing application.
+ Side-by-side versioning - Enables you to select one of the multiple versions.
+ XCOPY deployment and replication - Refers to the self-descriptive application that is deployed without the need to store registry entries.
+ On-the-fly updates - Allows for the updating of the DLLs of the remote computers.
+ Integration with the Microsoft Windows Installer - Makes the features, such as advertising, publishing, repairing, and install-on-demand available during deployment of an application.
+ Enterprise deployment - Eases the task of software distribution.
+ Downloading and caching - Specifies that downloads are kept smaller and the components are isolated for application use.
+ Partially trusted code - Enables code-based identification.
1. What is Windows Workflow Foundation (WF)?
Windows Workflow Foundation (WF) is a technology that was first introduced in .NET Framework 3.0. WF consists of a programming model, a workflow runtime engine, workflow designer, a rules engine, and tools to quickly build workflow-based applications on Windows. WF facilitates the separation between the business process code and the actual implementation code.
2. What are the components of WF 4.0?
WF consists of several components that work together to create desired workflow. The components of WF are given as follows:
+ Workflows and activities
+ Base activity library
+ Custom activities
+ Host process
+ Activity data mode!
+ Runtime engine
+ Runtime services
3. What is a workflow?
A workflow is a collection of actions (called activities) that presents the model of a process. A workflow provides a way to describe the order of the execution of a long running process and relationships between different activities. Multiple instances of a workflow may be active at any given moment in an application.
4. What are the different types of workflow in WF?
In WF 4.0, the following two types of workflows are used:
+ Flowchart workflows - Helps you to create workflows using the common flowchart elements. In WF, the Flowchart activity is generally used to implement a non-sequential workflow, and occasionally it implements sequential workflows in case the FlowDecision nodes are not used. The Flowchart activity contains a collection of flow nodes, which inherit from the FlowNode class. The following types of nodes or elements can be a part of a flowchart:
+ FlowStep - Executes activities of a flowchart in a sequence.
+ FlowDecision - Shows the execution on the basis of a Boolean condition. It is similar to the If construct.
+ FlowSwitch - Shows the execution on the basis of an exclusive switch. It is similar to the Switch construct.
+ Procedural workflows - Helps you to create workflows using basic and sequential execution standards. In WF, procedural workflows use flow control constructs, such as While, Switch, ForEach, and If, to execute activities. These flow control constructs are similar to those found in procedural languages. Procedural workflows can also contain other flow control activities, such as Flowchart and Sequence.
5. What are the four workflow principles?
According to Microsoft, there are four major principles that explain the behavior and working of workflows. Developers can use these principles while developing workflow-based applications. The four principles are as follows:
+ Workflows help in coordinating the work performed by people and software.
+ Workflows are long-running and stateful.
+ Workflows are based on extensible models.
+ Workflows remain transparent and dynamic throughout their lifecycle.
6. What is a base activity library?
The base activity library is a collection of activities used to create workflows.
7. What are XOML files?
WF provides developers a declarative way to create workflows by using extensible Application Markup Language (XAML). The files used to store such workflow markups are known as extensible Object Markup Language (XOML) files.
8. Can you integrate workflow applications with some other application, such as Windows Forms applications and Web applications?
Yes.
9. What is the difference between a system workflow and a human workflow?
A system workflow is a workflow that is developed to automate interactions among applications. Such workflow is usually static and predictable. On the other hand, a human workflow is a workflow that coordinates interactions of applications with people. As human workflows involve both software and people, they need to be more flexible than system workflows.
10. How can you implement a condition in a workflow?
You can implement a condition by using either of the following ways:
+ By creating a rule condition - Specifies that you can implement conditions either directly in code or by using a tool, called the Rule Condition Editor. Rule conditions are stored in a separate Extensible Markup Language (XML) file. When a rule condition occurs in a workflow, the expression in a condition is evaluated and a Boolean value is returned.
+ By creating a code condition - Refers to defining a condition directly in code. A code condition can be created by writing a method in the code. The method contains code for the condition and returns a Booleanvalue.
11. What is the function of the Rule Condition Editor dialog box in WF?
You can create and modify declarative rule conditions by using the Rule Condition Editor dialog box.
12. Explain the concept of Bookmarks in WF 4.0.
In WF 4.0, a bookmark is a mechanism that enables an activity to wait for an input without interrupting a workflow thread. When an activity signals that it is waiting for the input from a user, it can create a bookmark. A bookmark is created by using the BookmarkOptions class. This class provides the following bookmark types:
+ None - Represents a bookmark that can be resumed exactly once. This is the default bookmark type.
+ MultipleResume - Refers to a bookmark that you can resume multiple times.
+ NonBlocking - Refers to a bookmark that does not block the functioning of the workflow.

13. What is a host process?
A host process is an executable program that hosts a workflow. It may be a Windows Forms application, a Web application, or a Web service application. You can use Web services in the host process or remoting to enable other applications to communicate with the workflow.
14. What are runtime services?
Runtime services consist of predefined and user-defined classes that are available to the workflow runtime engine during execution to customize the behavior of workflow runtime. Some of the runtime services available in WF 4.0 are as follows:
+ Scheduling services - Enable creating and scheduling new workflow instances for execution.
+ Work batch services - Enable behavior to maintain a stable and consistent execution environment.
+ Persistence services - Enable you to save or restore the state of a running workflow for later use. You can restart the saved workflow anytime in future, even after weeks of inactivity.
+ Tracking services - Enable you to monitor the state of the workflows. This is particularly useful when you have multiple workflows active at the same time (for example, in a shopping cart application).
+ Timer service - Manages the timing required by the DelayActivity activity.
+ Transactions services - Provide the transaction support needed for data integrity.
+ Data exchange services - Manage custom communication services.
+ Threading services - Administer physical threads used to execute workflow instances.
15. Which component of WF architecture is responsible to execute each workflow instance?
WF runtime engine is responsible to execute each workflow instance.
16. Which option do you need to select for the Condition property, if you want to create a code condition?
You can select the Code Condition option to create a code condition.
17. Explain Custom Activities.
In addition to the standard activities available within the base activity library, you can create new activities to meet specific business needs. Creating custom activities may be required to support a particular application that you want to integrate with WF. Custom activities are generally created through attributes and inheritance. You can create two types of custom activities, base and composite. You can create basic custom activity by inheriting the Activity class and custom composite activity by inheriting the compositeActivity class or a derived type.
18. What is a dynamic update?
Dynamic update is a powerful feature of WF that describes the ability of WF to modify the execution path of a running workflow. This feature is used in circumstances that call for extraneous behavior that was not modeled by the original workflow developer.
19. What is a runtime engine?
A runtime engine of WF provides the basic functionality to execute and manage the workflow lifetime. It runs within the host process and is responsible for executing each workflow instance. A host process can interact with multiple runtime engines at a time, where each engine executes multiple workflow instances. The host process interacts with runtime engine by using any of the following classes:
+ WorkflowInvoker - Invokes a workflow as its method.
+ WorkflowApplication - Controls the execution of a single workflow instance explicitly.
+ WorkflowServiceHost - Hosts the workflows and allows sending and receiving messages among various instances of workflows.
20. What is an activity?
In Windows Workflow Foundation 4.0, an activity is the basic unit of composition and execution of a workflow. Each activity in a workflow consists of its own variables and arguments and is a subclass of the Activity class. These activities provide facilities for flow control, exception handling, data persistency, loading or unloading workflows, tracking, and transaction flow.
21. Explain why workflows are based on Extensible Models.
Workflows serve the purpose of automating business processes. Now, since each type of business has a wide range of problems; therefore, a workflow platform needs to be extensible. WF provides you with a set of base activities, such as IfElse, Code, and Delay, to build a workflow. You can extend these activities or build new activities to meet your requirements. Besides activities, you can also extend services, such as tracking, management, and persistence, provided by the runtime engine.
22. Write the steps that are involved in the sequential workflow, by default.
By default, a sequential workflow has only two steps:
+ Start
+ Finish

1. What is cloud computing?
The cloud computing is the computing which is completely based on the Internet. It can also be defined as the next stage in the evolution of the Internet. The cloud computing uses the cloud (Internet) that provides the way to deliver the services whenever and wherever the user of the cloud needs. Companies use the cloud computing to fulfill the needs of their customers, partners, and providers. The cloud computing includes vendors, partners, and business leaders as the three major contributors. The vendors are the one who provide applications and their related technology, infrastructure, hardware, and integration.

The partners are those who offer cloud services demand and provide support service to the customers. The business leaders are the ones who use or evaluate the cloud service provided by the partners. The cloud computing enables the companies to treat their resources as a pool and not as independent resources.
2. What is a cloud?
A cloud is a combination of hardware, networks, storage, services, and interfaces that helps in delivering computing as a service. It has broadly three users which are end user, business management user, and cloud service provider. The end user is the one who uses the services provided by the cloud. The business management user in the cloud takes the responsibility of the data and the services provided by the cloud. The cloud service provider is the one who takes care or is responsible for the maintenance of the IT assets of the cloud. The cloud acts as a common center for its users to fulfill their computing needs.
3. What are the basic characteristics of cloud computing?
The four basic characteristics of cloud computing are given as follows:
+ Elasticity and scalability.
+ Self-service provisioning and automatic de-provisioning.
+ Standardized interfaces.
+ Billing self-service based usage model.
4. What is a Cloud Service?
A cloud service is a service that is used to build cloud applications. This service provides the facility of using the cloud application without installing it on the computer. It reduces the maintenance and support of the application as compared to those applications that are not developed using the cloud service. The different kinds of users can use the application from the cloud service, which may be public or private application.
5. What are main features of cloud services?
Some important features of the cloud service are given as follows:
+ Accessing and managing the commercial software.
+ Centralizing the activities of management of software in the Web environment.
+ Developing applications that are capable of managing several clients.
+ Centralizing the updating feature of software that eliminates the need of downloading the upgrades.
6. How many types of deployment models are used in cloud?
There are 4 types of deployment models used in cloud:
1. Public cloud
2. Private cloud
3. Community cloud
4. Hybrid cloud

7. What is the AppFabric component?
The AppFabric component is used to create access control and distribute messages across clouds and enterprises. It has a service-oriented architecture, and can be considered as the backbone of the Windows Azure platform. It provides connectivity and messaging among distributed applications. It also has the capabilities of integrating the applications and the business processes between cloud services and also between cloud services and global applications.

The AppFabric component provides a development environment that is integrated with Visual Studio 2010.TheWindows Communication Foundation (WCF) services built in VS 2010 can be published on cloud from the Visual Studio design environment.

The two important services of AppFabric are as follows:
+ Access Control Service (ACS) - Allows rules-driven and claims-based access control for distributed applications. These claims-based rules and authorization roles can be defined in the cloud for accessing on-premise and cloud services. The claim can be a user or application attribute, which the service application expects, such as e-mail address, phone number, password, and role, for appropriate access control. When any application wants to use the Web service, it sends the required claims to ACS for requesting a token. ACS converts the input claims into output claims by following the rules of mapping. These rules are created during the configuration of ACS. The ACS issues a token containing the output claims for the consumer application. This application uses this token in the request header and sends to the Web service. This service validates the claims in the token and gives suitable access to the user.
+ Service bus - Provides messaging between cross-enterprise and cross-cloud scenarios. It provides publish/subscribe, point-to-point, and queues message patterns for exchange of messages across distributed applications in the cloud. It integrates with the Access Control service to establish secure relay and communication.
8. Why does an organization need to manage the workloads?
The workload can be defined as an independent service or a set of code that can be executed. It can be everything from a data-intensive workload to storage or a transaction processing workload and does not rely upon the outside elements. The workload can be considered as a small or complete application.

The organization manages workloads because of the following reasons:
+ To know how their applications are running.
+ To know what functions they are performing.
+ To know the charges of the individual department according to the use of the service.
9. Which services are provided by Window Azure operating system?
Windows Azure provides three core services which are given as follows:
+ Compute
+ Storage
+ Management
10. Explain hybrid and community cloud.
The hybrid cloud consists of multiple service providers. This model integrates various cloud services for Hybrid Web hosting. It is basically a combination of private and public cloud features. It is used by the company when a company has requirements for both the private and public clouds. Consider an example when an organization wants to implement the SaaS (Software as a Service) application throughout the company. The implementation requires security that can be provided by the private cloud used inside the firewall. The additional security can be provided by the VPN on requirement. Now, the organization has both the private and public cloud features.

The community cloud provides a number of benefits, such as privacy and security. This model, which is quite expensive, is used when the organizations having common goals and requirements are ready to share the benefits of the cloud service.
11. Explain public and private cloud.
The public cloud (or external cloud) is freely available for access. You can use a public cloud to collect data of the purchasing of items from a Web site on the Internet. You can also use public cloud for the reasons, which are given as follows:
+ Helps when an application is to be used by a large number of people, such as an e-mail application, on the Internet.
+ Helps when you want to test the application and also needs to develop the application code.
+ Helps when you want to implement the security for the application.
+ Helps when you want to increase the computing capacity.
+ Helps when you are working on the projects in collaboration.
+ Helps when you are developing the project on an ad-hoc basis by using PaaS.

The private cloud allows the usage of services by a single client on a private network. The benefits of this model are data security, corporate governance, and reliability concerns. The private cloud is used by the organization when it has a huge, well-run data center having a lot of spare capacity. It is also used when an organization is providing IT services to its clients and the data of organization is highly important. It is best suited when the requirements are critical.

The characteristics of this model are given as follows:
+ Provides capability to internal users and allows provision of services.
+ Automates the tasks of management and provides the billing of consumption of a particular service.
+ Offers a well-managed environment.
+ Enables the optimization of computational resources, such as servers.
+ Manages the workload of the hardware.
+ Offers self-service based provisioning of hardware resources and software.
12. Give a brief introduction of Windows Azure operating system.
The Windows Azure operating system is used for running cloud services on the Windows Azure platform, as it includes necessary features for hosting your services in the cloud. It also provides runtime environment that consists of Web server, computational services, basic storage, queues, management services, and load balancers. The operating system provides development. Fabric for development and testing of services before their deployment on the Windows Azure in the cloud.
13. What are the advantages of cloud services?
Some of the advantages of cloud service are given as follows:
+ Helps in the utilization of investment in the corporate sector; and therefore, is cost saving.
+ Helps in the developing scalable and robust applications. Previously, the scaling took months, but now, scaling takes less time.
+ Helps in saving time in terms of deployment and maintenance.
1. What is Extensible Markup Language (XML).
XML is a simple and flexible markup language in the text format. Nowadays, it is widely used to exchange a large variety of data over the Internet. XML consists of data as text in well-defined customized layouts by using self-defining tags. These user-defined tags are user friendly because they contain the name given by the user and make the information easily understandable to a user. These user-friendly features made XML to be widely used as a standard data-interchange format. The World Wide Web Consortium (W3C) frequently develops new standard for XML usage by different software vendors and solution providers. XML plays a very significant role with respect to .NET Framework 4.0. .NET Framework 4.0 provides us with a namespace called System.Xml, which includes classes that are used to work with XML.
2. What is the version information in XML?
"Version" tag shows which version of XML is used.
3. If XML does not have closing tag will it work?
No, every tag in XML, which is opened, should have a closing tag.
4. Is XML case sensitive?
Yes, XML is case sensitive.
5. Explain the difference between XML and HTML.
+ XML describes data while HTML describes how the data should be displayed. Therefore, HTML is about displaying information while XML is about describing information.
+ XML supports user-defined tags while HTML provides pre-defined tags.
+ XML is a case-sensitive language while HTML language is not case-sensitive.
+ In XML, all tags must be closed; while in HTML, it is not necessary to close each tag.
6. What is XML DOM?
The DOM stands for Document Object Model, which describes the logical formation of documents and provides the way to access and manipulate a document. It supplies an Application Programming Interface (API) to XML documents. It is built around the object-oriented design; therefore, it is known as DOM. The DOM model considers an XML document as a composition of objects and every object consists of properties and behaviors that can be manipulated by the DOM methods. The DOM allows creating and building XML documents, navigating the structure of documents, and managing the elements and their data. You can use the DOM methods and objects with any language, such as C#, VB, JavaScript, and VBScript.
7. Which namespaces in .NET are used for XML?
The System.xml.dll is the real physical file, which contains the XML implementation. Some of the other namespaces that allow .NET to use XML are as follows:
+ System.Xml
+ System.Xml.Schema
+ System.Xml.XPath
+ System.Xml.Xsl
8. Explain different types of XML Application Programming Interface (API).
The following are two main types of XML parsers:
+ Tree-based API - Compiles an XML document into a tree structure and loads it into memory. You can traverse and change the tree structure. The DOM is an example of a tree-based API.
+ Event-based API - Provides the report to an application about the parsing events by a set of built-in callback functions. An example of the event-based API is SAX.
9. Explain the XmlReader class.
The XmlReader class is used to read XML data in a fast, forward-only, and non-cached manner.
To work with XmlReader class in .NET, you need to import the following namespace:

In C#:
using System.Xml;

In VB:
Imports System.Xml
10. Describe the XmlWriter class.
The XmlWriter class is used to write XML to a stream, a file, or a Textwriter object. This class works in a forward-only, non-cached manner. You can configure the XmlWriter object up to a large extent. With this object, you can specify a few things, such as whether to indent content or not, the amount to indent, what quote character to use in attribute values, and whether or not namespaces are supported.
11. What is XPath?
XPath stands for XML Path. It is a language used to access different parts of an XML document, such as elements and attributes.
12. What is an XML attribute?
An XML attribute contains additional information regarding that particular element. The XML attributes use the name-value pair. For example, the element student has an attribute called id and the value of this attribute is set to s01, as shown in the following code snippet:

...

13. The XML elements cannot be empty. Is it true?
No, it is not true.
14. Describe the role that XSL can play while dynamically generating HTML pages from a relational database.
The SQLXML 3.0 and advanced versions provide the facility of mapping the SQL queries output with XSLT templates. It uses XSLT to present the records that are retrieved from databases on Web pages (HTML pages).

An application can use XSLT to modify the output that is retrieved from data sources and display the output by XSL templates. The XSLT displays data without affecting the database query and the code of application.
15. What are the advantages of DOM?
The following are the advantages of DOM:
+ DOM stores the entire XML document into memory before processing. Therefore, the XML structure can be easily modified and values can be added, changed, and removed.
+ DOM enables to traverse the XML structure in any direction. It means that you can access any node of the XML structure by traversing through the XML structure.
16. Give an example of a DOM-enabled XML parser.
The XML parser is MSXML, which is fully DOM-enabled.
17. What is an XML schema?
An XML schema provides the definition of an XML document. This implies that an XML schema defines the following in an XML document:
+ The elements that can appear in an XML document.
+ The attributes that can appear in an XML document.
+ The elements that are child elements.
+ The order of child elements.
+ The number of child elements.
+ Whether an element is empty or it includes some text.
+ The data types for elements and attributes.
18. State the advantages of XML schemas over DTD.
Microsoft developed a language known as the XML Schema Definition (XSD) to describe the schema to an XML document. The following are the advantages of XML schemas over DTDs:
+ XSD keeps much better control over types of data than the DTD.
+ DTD does not allow creating customized data types while the XSD provides full support to create customized data types.
+ XSD allows you to specify restrictions on data. It means that you can define the type of data that should be stored in an element, for example numbers or alphabets.
+ The XSD is quite easy to learn and to understand because its syntax is same as that of the XML document.

19. Using XSLT, how would you extract the value of a specific attribute from an element in an XML document?
The components necessary for the above mentioned operation are as follows:
+ The template element - Matches the correct XML element.
+ The value-of element - Selects the attribute value.
+ The optional apply-templates element - Allows continuous processing of the document
20. Which classes are supported to make an XML DOM?
The following are the different classes in the System.Xml namespace that make up the XML DOM:
+ The XmlNode class
+ The XmlDocument Class
+ The XmlElement Class
+ The XmlAttribute Class
+ The XmlText class
+ The XmlComment class
+ The XmlNodeList Class
21. Which class is used to encode and decode XML names and contains different methods to convert between CLR types and XSD types.
The XmlConvert Class.
22. What is the DTD?
The DTD is Document Type Definition that describes the formation of the content of an XML document. The DTD manages the data to store in a consistent format. It defines the XML elements and attributes about how they should be present in XML documents and what relation they should have with other elements and attributes. The DTD also allows you to mention whether an XML element is optional or not. If the XML documents are not according to the DTD rules, they are not considered valid.
23. Is it true that the XML's goal is to replace HTML?
No, it is not true. Both are necessary in their respective fields.
24. What is XSLT?
XSLT is Extensible Stylesheet Language Transformations that is a part of XML, which is a mechanism to transform an XML document into another XML or HTML document.
25. Describe the rules and regulations that must be followed while creating a well-formed XML document.
The following are the rules and regulations that are necessary to follow while creating a well-formed XML document:
+ Every start tag must end with an end tag.
+ A root element should be included for enclosing other child elements.
+ XML tags are case-sensitive; therefore, start and end tags must be of same spelling and the casing should also be the same.
+ XML's empty tags are necessary to close with a forward slash (/).
+ XML's attributes values are necessary to enclose within double quotation marks.
+ XML tags must be properly nested. It means starting tags should be closed in the reverse order in which they present.
26. What are the naming conventions required for XML elements tags?
The following are the naming conventions that need to be followed for XML elements tags:
+ Element names should contain only characters, numbers, hyphens, and periods.
+ Element names cannot not begin with a number or punctuation character.
+ Element names must not start with the word xml (or XML, or Xml).
+ Element names cannot consist spaces.
+ Element names can be used any words except xml, XML, or Xml because no words are reserved in XML.
27. The XML preserves white spaces. Is it true?
Yes, it is true.
28. Explain the XML elements.
The elements are the central units of an XML document that explain and identify data. The elements are represented by the tags. You can also make your own tags, which make XML a user-friendly language. By creating custom meaningful elements, you can improve readability of the document. XML elements can be nested and the nested elements are known as child elements.
1. What is Language Integrated Query (LINQ)?
LINQ is a programming model that is the composition of general-purpose standard query operators that allow you to work with data, regardless of the data source in any .NET based programming language. It is the name given to a set of technologies based on the integration of query capabilities into any .NET language.
2. What are LINQ query expressions?
A LINQ query, also known as a query expression, consists of a combination of query clauses that identify the data sources for the query. It includes instructions for sorting, filtering, grouping, or joining to apply to the source data. The LINQ query expressions syntax is similar to the SQL syntax. It specifies what information should be retrieved from the data source.
3. Write the basic steps to execute a LINQ query.
The following are the three basic steps to execute a LINQ query:
+ Obtain the data source (The data source can be either an SQL database or an XML file)
+ Create a query
+ Execute the query
4. Write the basic syntax of a LINQ query in Visual Basic as well as in C#.
In Visual Basic, the basic syntax of a LINQ query starts with the From clause and ends with the Select or Group Byclause. In addition, you can use the Where, Order By, and Order By Descending clauses to perform additional functions, such as filtering data and generating the data in a specific order.

In C#, the basic syntax of a LINQ query starts with the From clause and ends with the Select or group by clause. In addition, you can use the where, orderby, and Orderby descending clauses to perform additional functions, such as filtering data and generating the data in a specific order.
5. In which statement the LINQ query is executed?
A LINQ query is executed in the For Each statement in Visual Basic and in the foreach statement in C#.
6. In LINQ, lambda expressions underlie many of the standard query operators. Is it True or False?
It is true.
7. What is PLINQ?
PLINQ stands for Parallel Language Integrated Query. It is the parallel implementation of LINQ, in which a query can be executed by using multiple processors. PLINQ ensures the scalability of software on parallel processors in the execution environment. It is used where data grows rapidly, such as in telecom industry or where data is heterogeneous.

PLINQ also supports all the operators of LINQ. In addition, you can query 'collections by using PLINQ. It can also run several LINQ queries simultaneously and makes use of the processors on the system. Apart from this, PLINQ uses parallel execution, which helps in running the queries quickly. Parallel execution provides a major performance improvement to PLINQ over certain types of legacy code, which takes too much time to execute.
8. What are the different Visual Basic features that support LINQ?
Visual Basic includes the following features that support LINQ:
+ Anonymous types - Enables you to create a new type based on a query result.
+ Implicitly typed variables - Enables the compiler to infer and assign a type when you declare and initialize a variable.
+ Extension method - Enables you to extend an existing type with your own methods without modifying the type itself.
9. What is the function of the DISTINCT clause in a LINQ query?
The DISTINCT clause returns the result set without the duplicate values.
10. What is the DataContext class and how is it related to LINQ?
After you add a LINQ to SQL Classes item to a project and open the O/R Designer, the empty design surface represents an empty DataContext class ready to be configured. The DataContext class is a LINQ to SQL class that acts as a conduit between a SQL Server database and the LINQ to SQL entity classes mapped to that database. This class contains the connection string information and the methods for connecting to a database and manipulating the data in the database. It is configured with connection information provided by the first item that is dragged onto the design surface.
11. What is the difference between the Take and Skip clauses?
The Take clause returns a specified number of elements. For example, you can use the Take clause to return two values from an array of numbers. The Skip clause skips the specified number of elements in the query and returns the rest. For example, you can use the Skip clause to skip the first four strings in an array of strings and return the remaining array of string.
12. What is Object Relational Designer (0/R Designer)?
The 0/R Designer provides a visual design surface to create LINQ to SQL entity classes and associations (relationships) that are based on objects in a database.
13. Which interface implements the standard query operators in LINQ?
The standard query operators implement the IEnumerable or the IQueryable interface in C# and theIEnumerable(Of T) or the IQueryable(Of T) interface in Visual Basic.
14. What are standard query operators in LINQ?
The standard query operators in LINQ are the extension methods that form the LINQ pattern. These operators form an API that enables querying of any .NET array or collection. It operates on sequences and allows you to perform operations, such as determining if a value exists in the sequence and performing an aggregated function, such as a summation over a sequence.
15. On what parameter does the GroupBy clause group the data?
The GroupBy clause groups the elements that share a common attribute.
16. What is a LinqDataSource control?
The LinqDataSource control enables you to use LINQ. in an ASP.NET Web page by setting the properties in the markup text. You can use the control retrieve or modify data. It is similar to the SqIDataSource andObjectDataSource controls in the sense that it can be used to declaratively bind other ASP.NET controls on a page to a data source. The difference is that instead of binding directly to a database or to a generic class, theLinqDataSource control is designed to bind a LINQ enabled data model.
17. How can you open the O/R Designer?
You can open the O/R Designer by adding a new LINQ to SQL Classes item to a project.
18. The standard query operators are themselves a set of extension methods that provide the LINQ query functionality for any type that implements the IEnumerable interface in Visual Basic. Is it True or False?
False, as it implements the IEnumerable(T) interface in Visual Basic and the IEnumerable interface is implemented in C#.
19. What are lambda expressions in LINQ?
A lambda expression is a function without a name that calculates and returns a single value. All lambda expressions use the lambda operator =>, which read as goes to. The left side of the lambda operator specifies the input parameters and the right side holds the expression or statement block.
20. Before you query a DataSet object by using LINQ to DataSet, you must first populate the dataset How can you do this?
You can load the data into the dataset by using different methods, such as:
+ Using the DataAdapter class
+ Using LINQ to SQL
21. What are the different implementations of LINQ?
The different implementations of LINQ are:
+ LINQ to SQL - Refers to a component of.NET Framework version 3.5 that provides a run-time infrastructure to manage relational data as objects.
+ LINQ to DataSet - Refers to a component that makes it easier and faster to query over data cached in a DataSet object.
+ LINQ to XML - Provides an in-memory XML programming interface.
+ LINQ to Objects - Refers to the use of LINQ queries with any IEnumerable or IEnumerable(T) collection directly, without the use of an intermediate LINQ provider or API, such as LINQ to SQL or LINQ to XML.
22. Which command-line tool generates code and mapping for the LINQ to SQL component of .NET Framework?
The SqlMetal.exe command-line tool generates code and map the LINQ to SQL component.
23. Name the control that exposes the LINQ features to Web developers through the ASP.NET data-source control architecture.
The LinqDataSource control exposes the LINQ features to Web developers through the ASP.NET data-source control architecture.
24. What is the difference between the Select clause and SelectMany() method in LINQ?
Both the Select clause and SelectMany() method are used to produce a result value from a source of values. The difference lies in the result set. The Select clause is used to produce one result value for every source value. The result value is a collection that has the same number of elements from the query. In contrast, the SelectMany() method produces a single result that contains a concatenated collection from the query.
25. Which extension method do you need to run a parallel query in PLINQ?
The AsParallel extension method is required to run a parallel query in PLINQ.
1. Define variable and constant.
A variable can be defined as a meaningful name that is given to a data storage location in the computer memory that contains a value. Every variable associated with a data type determines what type of value can be stored in the variable, for example an integer, such as 100, a decimal, such as 30.05, or a character, such as 'A'.

You can declare variables by using the following syntax:

;

A constant is similar to a variable except that the value, which you assign to a constant, cannot be changed, as in case of a variable. Constants must be initialized at the same time they are declared. You can declare constants by using the following syntax:

const int interestRate = 10;
2. What is a data type? How many types of data types are there in .NET ?
A data type is a data storage format that can contain a specific type or range of values. Whenever you declare variables, each variable must be assigned a specific data type. Some common data types include integers, floating point, characters, and strings. The following are the two types of data types available in .NET:
+ Value type - Refers to the data type that contains the data. In other words, the exact value or the data is directly stored in this data type. It means that when you assign a value type variable to another variable, then it copies the value rather than copying the reference of that variable. When you create a value type variable, a single space in memory is allocated to store the value (stack memory). Primitive data types, such as int, float, and char are examples of value type variables.
+ Reference type - Refers to a data type that can access data by reference. Reference is a value or an address that accesses a particular data by address, which is stored elsewhere in memory (heap memory). You can say that reference is the physical address of data, where the data is stored in memory or in the storage device. Some built-in reference types variables in .Net are string, array, and object.
3. Mention the two major categories that distinctly classify the variables of C# programs.
Variables that are defined in a C# program belong to two major categories: value type and reference type. The variables that are based on value type contain a value that is either allocated on a stack or allocated in-line in a structure. The variables that are based on reference types store the memory address of a variable, which in turn stores the value and are allocated on the heap. The variables that are based on value types have their own copy of data and therefore operations done on one variable do not affect other variables. The reference-type variables reflect the changes made in the referring variables.

Predict the output of the following code segment:
int x = 42;
int y = 12;
int w;
object o;
o = x;
w = y * (int)o;
Console.WriteLine(w);

/* The output of the code is 504. */
4. Which statement is used to replace multiple if-else statements in code.
In Visual Basic, the Select-Case statement is used to replace multiple If - Else statements and in C#, the switch-case statement is used to replace multiple if-else statements.
5. What is the syntax to declare a namespace in .NET?
In .NET, the namespace keyword is used to declare a namespace in the code.

The syntax for declaring a namespace in C# is:
namespace UserNameSpace;

The syntax for declaring a namespace in VB is:
Namespace UserNameSpace
6. What is the difference between constants and read-only variables that are used in programs?
Constants perform the same tasks as read-only variables with some differences. The differences between constants and read-only are

Constants:
1. Constants are dealt with at compile-time.
2. Constants supports value-type variables.
3. Constants should be used when it is very unlikely that the value will ever change.

Read-only:
1. Read-only variables are evaluated at runtime.
2. Read-only variables can hold reference type variables.
3. Read-only variables should be used when run-time calculation is required.

7. Differentiate between the while and for loop in C#.
The while and for loops are used to execute those units of code that need to be repeatedly executed, unless the result of the specified condition evaluates to false. The only difference between the two is in their syntax. The for loop is distinguished by setting an explicit loop variable.
8. What is an identifier?
Identifiers are northing but names given to various entities uniquely identified in a program. The name of identifiers must differ in spelling or casing. For example, MyProg and myProg are two different identifiers. Programming languages, such as C# and Visual Basic, strictly restrict the programmers from using any keyword as identifiers. Programmers cannot develop a class whose name is public, because, public is a keyword used to specify the accessibility of data in programs.
9. What does a break statement do in the switch statement?
The switch statement is a selection control statement that is used to handle multiple choices and transfer control to the case statements within its body. The following code snippet shows an example of the use of the switchstatement in C#:
switch(choice)
{
case 1:
console.WriteLine("First");
break;
case 2:
console.WriteLine("Second");
break;
default:
console.WriteLine("Wrong choice");
break;
}

In switch statements, the break statement is used at the end of a case statement. The break statement is mandatory in C# and it avoids the fall through of one case statement to another.
10. Explain keywords with example.
Keywords are those words that are reserved to be used for a specific task. These words cannot be used as identifiers. You cannot use a keyword to define the name of a variable or method. Keywords are used in programs to use the features of object-oriented programming.

For example, the abstract keyword is used to implement abstraction and the inherits keyword is used to implement inheritance by deriving subclasses in C# and Visual Basic, respectively.

The new keyword is universally used in C# and Visual Basic to implement encapsulation by creating objects.
11. Briefly explain the characteristics of value-type variables that are supported in the C# programming language.
The variables that are based on value types directly contain values. The characteristics of value-type variables that are supported in C# programming language are as follows:
+ All value-type variables derive implicitly from the System.ValueType class
+ You cannot derive any new type from a value type
+ Value types have an implicit default constructor that initializes the default value of that type
+ The value type consists of two main categories:
+ Structs - Summarizes small groups of related variables.
+ Enumerations - Consists of a set of named constants.

12. Give the syntax of using the while loop in a C# program.
The syntax of using the while loop in C# is:

`
while(condition) //condition
{
//statements
}
You can find an example of using the while loop in C#:
int i = 0;
while(i < 5)
{
Console.WriteLine("{0} ", i);
i++;
}

The output of the preceding code is: 0 1 2 3 4 .
`

13. What is a parameter? Explain the new types of parameters introduced in C# 4.0.
A parameter is a special kind of variable, which is used in a function to provide a piece of information or input to a caller function. These inputs are called arguments. In C#, the different types of parameters are as follows:
+ Value type - Refers that you do not need to provide any keyword with a parameter.
+ Reference type - Refers that you need to mention the ref keyword with a parameter.
+ Output type - Refers that you need to mention the out keyword with a parameter.
+ Optional parameter - Refers to the new parameter introduced in C# 4.0. It allows you to neglect the parameters that have some predefined default values. The example of optional parameter is as follows:
+ public int Sum(int a, int b, int c = 0, int d = 0); /* c and d is optional */
+ Sum(10, 20); //10 + 20 + 0 + 0
+ Sum(10, 20, 30); //10 + 20 + 30 + 0
+ Sum(10, 20, 30, 40); //10 + 20 + 30 + 40
+ Named parameter - Refers to the new parameter introduced in C# 4.0. Now you can provide arguments by name rather than position. The example of the named parameter is as follows:
+ public void CreateAccount(string name, string address = "unknown", int age = 0);
+ CreateAccount("Sara", age: 30);
+ CreateAccount(address: "India", name: "Sara");

14. Briefly explain the characteristics of reference-type variables that are supported in the C# programming language.
The variables that are based on reference types store references to the actual data. The keywords that are used to declare reference types are:
1. Class - Refers to the primary building block for the programs, which is used to encapsulate variables and methods into a single unit.
2. Interface - Contains only the signatures of methods, properties, events, or indexers.
3. Delegate - Refers to a reference type that is used to encapsulate a named or anonymous method.

15. What are the different types of literals?
A literal is a textual representation of a particular value of a type.

The different types of literals in Visual Basic are:
+ Boolean Literals - Refers to the True and False literals that map to the true and false state, respectively.
+ Integer Literals - Refers to literals that can be decimal (base 10), hexadecimal (base 16), or octal (base 8).
+ Floating-Point Literals - Refers to an integer literal followed by an optional decimal point By default, a floating-point literal is of type Double.
+ String Literals - Refers to a sequence of zero or more Unicode characters beginning and ending with an ASCII double-quote character.
+ Character Literals - Represents a single Unicode character of the Char type.
+ Date Literals - Represents time expressed as a value of the Date type.
+ Nothing - Refers to a literal that does not have a type and is convertible to all types in the type system.

The different types of literals in C# are:
+ Boolean literals - Refers to the True and False literals that map to the true and false states, respectively.
+ Integer literals - Refers to literals that are used to write values of types int, uint, long, and ulong.
+ Real literals - Refers to literals that are used to write values of types float, double, and decimal.
+ Character literals - Represents a single character that usually consists of a character in quotes, such as 'a'.
+ String literals - Refers to string literals, which can be of two types in C#:
+ A regular string literal consists of zero or more characters enclosed in double quotes, such as "hello".
+ A verbatim string literal consists of the @ character followed by a double-quote character, such as @"hello".
+ The Null literal - Represents the null-type.

16. What is the main difference between sub-procedure and function?
The sub-procedure is a block of multiple visual basic statements within Sub and End Sub statements. It is used to perform certain tasks, such as changing properties of objects, receiving or processing data, and displaying an output. You can define a sub-procedure anywhere in a program, such as in modules, structures, and classes.

We can also provide arguments in a sub-procedure; however, it does not return a new value.
The function is also a set of statements within the Function and End Function statements. It is similar to sub-procedure and performs the same task. The main difference between a function and a sub-procedure is that sub-procedures do not return a value while functions do.
17. Determine the output of the code snippet.
int a = 29;
a--;
a -= ++a;
Console.WriteLine("The value of a is: {0}", a);

/* The output of the code is -1. */
18. Differentiate between Boxing and Unboxing.
When a value type is converted to an object type, the process is known as boxing; whereas, when an object type is converted to a value type, the process is known as unboxing.

Boxing and unboxing enable value types to be treated as objects. Boxing a value type packages it inside an instance of the Object reference type. This allows the value type to be stored on the garbage collected heap. Unboxing extracts the value type from the object. In this example, the integer variable i is boxed and assigned to object obj.

Example:
int i = 123;
object obj = i; /* Thi line boxes i. */

/* The object obj can then be unboxed and assigned to integer variable i: */
i = (int)obj; // unboxing

19. Give the syntax of using the for loop in C# code?
The syntax of using the for loop in C# code is given as follows:
for(initializer; condition; loop expression)
{
//statements
}

In the preceding syntax, initializer is the initial value of the variable, condition is the expression that is checked before the execution of the for loop, and loop expression either increments or decrements the loop counter.

The example of using the for loop in C# is shown in the following code snippet:
for(int i = 0; i < 5; i++)
Console.WriteLine("Hello");

In the preceding code snippet, the word Hello will be displayed for five times in the output window.

1. What is ASP.NET AJAX?
ASP.NET AJAX, mostly called AJAX, is a set of extensions of ASP.NET. It is developed by Microsoft to implement AJAX functionalities in Web applications. ASP.NET AJAX provides a set of components that enable the developers to develop applications that can update only a specified portion of data without refreshing the entire page. The ASP.NET AJAX works with the AJAX Library that uses object-oriented programming (OOP) to develop rich Web applications that communicate with the server using asynchronous postback.
2. What is the difference between synchronous postback and asynchronous postback?
The difference between synchronous and asynchronous postback is as follows:
+ Asynchronous postback renders only the required part of the page; whereas, synchronous postback renders the entire page for any postback.
+ Asynchronous postback executes only one postback at a time, that is, if you have two buttons doing asynchronous postback, the actions will be performed one by one; whereas, synchronous postback executes all the actions at once.
+ Asynchronous postback only modifies the update panel that raises the postback; whereas, synchronous postback modifies the entire page.
3. What technologies are being used in AJAX?
AJAX uses four technologies, which are as follows:
+ JavaScript
+ XMLHttpRequest
+ Document Object Model (DOM)
+ Extensible HTML (XHTML) and Cascading Style Sheets (CSS)
4. Why do we use the XMLHttpRequest object in AJAX?
The XMLHttpRequest object is used by JavaScript to transfer XML and other text data between client and server. TheXMLHttpRequest object allows a client-side script to perform an HTTP request. AJAX applications use theXMLHttpRequest object so that the browser can communicate to the server without requiring a postback of the entire page. In earlier versions of Internet Explorer, MSXML ActiveX component is liable to provide this functionality; whereas, Internet Explorer 7 and other browsers, such as Mozilla Firefox, XMLHttpRequest is not liable to.
5. How can we get the state of the requested process?
XMLHttpRequest get the current state of the request operation by using the readyState property. This property checks the state of the object to determine if any action should be taken. The readyState property uses numeric values to represent the state.
6. What are the different controls of ASP.NET AJAX?
ASP.NET AJAX includes the following controls:
+ ScriptManager
+ ScriptManagerProxy
+ UpdatePanel
+ UpdateProgress
+ Timer
7. What are the new features included in the Microsoft AJAX library?
The Microsoft AJAX library is a client-based JavaScript library that is compatible with all modern browsers and offers a lot of functionality as compared to JavaScript. This library is released with new features and fully supports ASP.NET 4.0'. The new features included in the Microsoft AJAX library are as follows:
+ Imperative syntax - Supports simple imperative syntax that is used to create and manage controls.
+ Script loader - Retrieves all scripts that are needed by one or more client component or control automatically and executes the scripts in the order in which they are received.
+ Client data access - Supports to access client data and display by client data control and client template.
+ Client datacontext - Supports read and write permission to data from a database.
+ The AdoNetDataContext class - Enables you to easily interact with an ADO.NET Data Services service.
+ jQuery integration - Helps to access the elements in your Web pages, work with client-side events, enable visual effects, and make it easier to use AJAX in your applications.
8. Explain the Step property of the NumericUpDownExtender control.
The Step property sets the steps for numeric increment and decrement. The default value is 1.
9. What are the new features of ASP.NET AJAX 4.0?
ASP.NET 4.0 AJAX includes several new features that provide more functionality to a user. These features are as follows:
+ Support for live data binding.
+ Support for client-side template rendering.
+ Support for declarative instantiation of client components.
+ Support for using the observer pattern on JavaScript objects and arrays.
+ Support for invoking ADO.NET data services and data contexts.
+ Support for the DataView control.
10. Why do we use the UpdateProgress control in AJAX?
The UpdateProgress control is somewhat related to the UpdatePanel control. The UpdateProgress control enables you to design a user-friendly interface when a Web page consists of a number of UpdatePanel controls for partial-page rendering.

The UpdateProgress control makes you aware of the status information about the partial-page updates in theUpdatePanel control.
11. What is JSON?
JSON is an abbreviation of JavaScript Object Notation. It is a safe and reliable data interchange format in JavaScript, which is easy to understand not only for the users but also for the machines.
12. How many validation controls are available in ASP.NET AJAX 4.0?
The following validation controls are available in ASP.NET AJAX 4.0:
+ FilteredTextBoxExtender - Enables you to apply filtering to a text box.
+ MaskedEditExtender and MaskedEditValidator - Restricts a user to enter only a certain pattern of characters in the TextBox by applying a mask to the input.
+ ValidatorCalloutExtender - Attaches to the ASP.NET validators so that the error messages are not displayed as a simple text but as a balloon-style ToolTip.
+ NoBot - Prevents the spam/bot from filling the input forms automatically and uses the Completely Automated Public Turing test to tell Computers and Humans Apart (CAPTCHA), which is a type of challenge-response test to ensure that the response is not generated by the computer.
+ PasswordStrengthExtender - Measures the strength of the password text entered within the text box by validating with the different strength specified parameters
13. Explain the limitations of AJAX.
The following are the limitations of AJAX:
+ It is difficult to bookmark a particular state of the application.
+ Function provided in the code-behind file do not work because the dynamic pages cannot register themselves on browsers history engine automatically.
+ If JavaScript is disabled, then AJAX is not able to perform any work.
+ Response time may be slow because different controls of a page are loaded at different time.
14. What are the differences between AJAX and JavaScript?
The differences between AJAX and JavaScript are given as follows:
+ AJAX sends request to the server and does not wait for the response. It performs other operations on the page during that time. JavaScript make a request to the server and waits for response.
+ AJAX does not require the page to refresh for downloading the whole page while JavaScript manages and controls a Web page after being downloaded.
+ AJAX minimizes the overload on the server since the script needs to request once while JavaScript posts a request that updates the script every time.
15. Explain the UpdatePanel control.
The UpdatePanel control specifies the portions of a Web page that can be updated together. As the UpdatePanelcontrol refreshes only a selected part of the Web page instead of refreshing the entire page with a postback, you get more flexibility to create rich and client-centric Web applications.
Refreshing a selected part of the Web page is referred as partial-page update. You can add one or more UpdatePanelcontrol in the Web page, which automatically participates in partial-page update without custom client script. TheUpdatePanel control uses the UpdatePanel class to support the partial-page rendering.
16. What does the DynamicPopulateExtender control do?
The DynamicPopulateExtender control populates the contents of a control dynamically. It enables you to send an asynchronous call to the server that dynamically populates the contents of a control. TheDynamicPopulateExtender control replaces the contents of a control with the result of a Web service or page method call.
17. What does the MinimumPrefixLength property of the AutoCompleteExtender control do?
The MinimumPrefixLength property sets the minimum number of characters that must be entered before getting suggestions from the Web service.
18. What is the importance of client-side libraries?
Client-side libraries contain built-in code to make asynchronous calls over XMLHTTP. These libraries automatically handle browser compatibility issues. These libraries are based on a programming model similar to ASP.NET.
19. Can we call server-side code from JavaScript?
Yes, page methods and Web services are the two techniques to call the server-side code from JavaScript.
20. What are the components of the ASP.NET AJAX architecture?
You can divide the ASP.NET AJAX architecture into two components - AJAX client architecture and AJAX server architecture.
21. Describe AJAX Control Extender Toolkit.
AJAX Control Toolkit is a set of extenders that are used to extend the functionalities of the ASP.NET controls. The extenders use a block of JavaScript code to add new and enhanced capabilities to the ASP.NET controls. AJAX Control Toolkit is a free download available on the Microsoft site. You need to install this toolkit on your system before using extenders.
22. Explain the need of the Timer control in AJAX.
The Timer control is used with an UpdatePanel control to allow partial-page updates at a specified interval. It is mostly used when a periodically partial-page update for one or more UpdatePanel controls is required without refreshing the entire page.

The Timer control is a server control that sets a JavaScript component in the Web page. The interval property of the Timer control specifies time in milliseconds. Similar to the UpdatePanel control, the Timer control also requires an instance of the ScriptManager control in the Web page.

When the Timer control initiates a postback, the Tick event is raised on the server for which you can provide an event handler to perform the actions when the page is submitted to the server. The Tick event occurs when the time specified in the interval property has elapsed and the page is posted on the server. You can add one or more Timer controls on a Web page. Usually the entire page requires only a single Timer control; however, you can use multipleTimer controls, if the UpdatePanel controls are being updated at different intervals.
23. List the different states of XMLHttpRequest with their description.
The different states of the XMLHttpRequest object are as follows:
+ Uninitialized - Refers to the state when the object has not been initialized.
+ Open - Refers to the state when the object has been created; however, the send function has not been invoked.
+ Sent -Refers to the state when the send function is invoked; however, the status and headers are not available.
+ Receiving - Refers to the state when the process is receiving data.
+ Loaded - Refers to the state when the procedure is completed and the entire data is available.
24. Can we nest the UpdatePanel controls?
Yes, we can nest the UpdatePanel control.
25. What is the role of the ScriptManagerProxy control?
A Web page cannot contain more than one ScriptManager control. You can use the ScriptManagerProxy control to add scripts to other pages; however to perform such an operation, you need to work with a master page that contains the ScriptManager control. If you have only few pages that need to register to a script or a Web service, then you should remove these pages from the ScriptManager control and add them as individual pages by using theScriptManagerProxy control. If you include the scripts on the master page by the ScriptManager control, then the items get downloaded on each page that extends the master page, even if they are not necessary.
26. What is the work of the ConformOnFormSubmit property in the ConfirmButtonExtender control?
The ConformOnFormSubmit property determines whether or not the confirm dialog box should wait when the form is submitted for display.
27. What is the syntax to create AJAX objects?
AJAX uses the following syntax to create an object:

var myobject = new AjaxObject("page path");

The page path is the URL of the Web page containing the object that you want to call. The URL must be of the same domain as the Web page.
28. Is there any difference between HTML and XHTML?
Extensible HTML (XHTML) is a markup language that provides the mixture expressions of HTML and XML. XHTML is a flexible markup language that enables automated processing by standard XML tools, which was difficult in HTML.
29. What are the requirements to run ASP.NET AJAX applications on a server?
AJAX is a built-in functionality of .NET Framework 4.0. Therefore, you can run an AJAX application by just installing Microsoft Visual Studio 2010. However, to use extenders in your applications, you are required to install AJAX Control Toolkit and copy the AjaxControlToolkit.dll file to the Bin directory of your application.
30. Describe the situations in which AJAX should not be used.
You should not use AJAX if:
+ You want the page to show in a search engine, such as Google, because WebCrawler does not execute JavaScript code.
+ The browser does not support JavaScript.
+ You want to create a secure application.
31. What is the use of the ScriptManager control in AJAX?
The ScriptManager control is a core control that performs a key role in implementing the ASP.NET AJAX functionality. It helps to use JavaScript for the Microsoft AJAX Library. It should be noted that AJAX Library on a Web page can only be used if the Web page contains the ScriptManager control. This control makes use of theScriptManager class to maintain the AJAX script libraries and script files. It allows for partial page rendering, Web service calls, and use of ASP.NET AJAX Client Library by rendering the AJAX Library scripts to the browser.
32. How can you find out that an AJAX request has been completed?
You can find out that an AJAX request has been completed by using the readyState property. If the value of this property equals to four, it means that the request has been completed and the data is available.
33. Is it possible to use multiple ScriptManager controls on a Web page?
No, it is not possible.
34. What are the new controls introduced in ASP.NET AJAX Control Toolkit?
The following controls are introduced with the new version of AJAX Control Toolkit:
+ SeaDragonExtender control - Refers to the control that is used to deeply zoom the images. You can zoom in or out the image or the particular portion of the image by using the mouse. You can also create a menu over the Seadragon control. This control is helpful when you want to analyze the image closely.
+ AsyncFileUploadExtender control - Refers to the control that provides the facility to upload and save the files on the server asynchronously. You can check the outcome either at the server or client side.
35. Briefly describe ASP.NET AJAX Framework.
ASP.NET AJAX Framework provides a platform where developers can develop such type of applications that use the AJAX concept. The AJAX provides the collection of technologies to create dynamic pages at the client side. The JavaScript requests are responsible to retrieve data from the server or send data to the server. Even some processing at server also requires handling requests, such as searching and storing of data. These tasks are achieved more easily using the AJAX Framework.

AJAX Framework is completely devoted to process requests. The objective of the AJAX engine is to reduce the delays that the user notices while performing a postback to the server. AJAX Framework allows JavaScript functions to send requests to server at the client side. On the other side, it allows the server to process the client's request, searches data, and responds the result to the browser.
36. Is the AjaxControlToolkit.dll file installed in the Global Assembly Cache?
No, you have to copy this file to the Bin folder of your application.
37. What are the different ways to pass parameters to the server?
We can pass parameters to the server using either the GET or POST method. The following code snippets show the example of both the methods:
+ Get: XmlHttpObject.Open("GET", "file1.txt", true);
+ Post: XmlHttpObject.Open("POST", "file2.txt", true);
38. What are the extender controls?
The extender controls uses a block of JavaScript code to add new and enhanced capabilities to ASP.NET. The developers can use a set of sample extender controls through a separate download - AJAX Control Toolkit (ACT).
39. Describe the AccordionExtender control.
The AccordionExtender control is similar to the CollapsiblePanelExtender control. It allows you to group multiple collapsible panels in a single control. At the same time, it also manages the collapsed and expanded state of each panel; therefore, expanding one panel at a time. In other words, the AccordionExtender control does not support expanding two or more panels simultaneously. Instead, the header templates of all the panels are always visible so that you can click on any of them to display the hidden contents. By default, the AccordionExtendercontrol opens with one panel as expanded.
1. What are Windows services?
Windows services, previously known as NT services, are applications that are installed on the system as system services. In other words, Windows services are applications that run in the background with the Windows operating system. The primary use of Windows services is to reduce the consumption of memory required for performing backend operations. Let's take an example to understand this easily. Suppose you want to perform a variety of functions, such as monitor the performance of your computer or application, check the status of an application, and manage various devices, such as printers.

In such a case, you can use Windows services to reduce memory consumption. In addition, Windows services can run on your system even if you have not logged on to your computer. In addition, these services do not have any user interface.
2. Can you share a process between Windows services?
Yes, you can share a process between Windows services.
3. In .NET, which is the parent class to create all Windows services?
The ServiceBase class is the parent class to create all Windows services.
4. Which class in .NET is used to install a Windows service?
The ServiceInstaller class, also known as the project installer class, is used to install a Windows service.
5. While installing a Windows service, an EventLogInstaller class is automatically created to install the event log related to the particular service. Is it true?
Yes, it is true.
6. Which property of the ServiceBase class can be used to specify whether a service can be paused and resumed?
The CanPauseAndContinue property provides such type of service.
7. Describe the services that UDDI provides to Web applications.
UDDI provides the following types of services to a Web application:
+ XML Schema for business descriptions - Includes information about the service publisher (contact name, address, and so on) and specifications on the Web service
+ Web registry of Web services - Includes business, service, and binding information for the Web service
8. Write the file extension for a Web service.
A Web service file extension is .asm file. For example, service1.asmx is a Web service file.
9. Which method is used to uninstall the Windows services?
The Uninstall() method is used to uninstall the Windows services.
10. What is the use of the mustUnderstand attribute in the Header element of a SOAP message?
The mustUnderstand attribute indicates that a header entry is either required or optional for the recipient to process further.
11. Explain the WSDL.
WSDL is a short form for Web Services Description Language, which is used to describe a Web service in terms of the messages that it creates and accepts. The WSDL document is an XML file that contains the interface schema for the Web service. It identifies the methods that are used during the exchange between a Web service consumer and a Web service provider. The following are the elements contained in the WSDL document:
+ Types - Describe the variations of data types that are used to exchange messages between the user and the provider.
+ Message - Describes the actual message or method call.
+ portType - Describes the set of operations and each related message.
+ binding - Describes the protocol details.
+ service - Used to make groups a set of related ports together.
12. What advantage UDDI has over DISCO?
The UDDI directory has an advantage over a DISCO file, as it provides a single location where a client can find the Web services offered by different organizations.
13. How can you ensure that only authorized users access your Web service?
You should use the element to ensure that only authorized users access your Web service. This element allows or denies access to your Web service according to their role.
14. Describe the EventLog class.
The EventLog class is used to access the Windows event logs from Windows services. Using EventLog, you can also customize Windows event logs that record information about important software and hardware events, such as the events of the .NET controls, keyboard, or other hardware devices.
The EventLog class allows you to read or write to event logs, delete logs, and create as well as delete event sources. You can use the EventLog class to create event logs while creating an event source. An event source can be used to write to only one event log at a particular time. However, it is possible to associate one event log to multiple sources.
15. How can you prevent your Web services from unauthorized access?
The following are the ways to prevent your Web service from unauthorized access:
+ Using encryption and message-based security.
+ Using authentication and access controls for the Web service.
16. Explain the concept of Web services in brief.
A Web service may be defined as an independent and self-sustained unit of a software application that is hosted on the Web and implement specific functionalities to execute the business logic. A Web service provides so many functionalities, such as generating pay slips for employees, computing tax, broadcasting weather report, and providing updated news. The Web service allows application to share information or exchange data with other applications across different operating systems and hardware.

Therefore, the work of a Web service is to unite software by exchanging data irrespective of their operating systems, supported hardware, and programming language used in their development. The Web services transfer data in the XML format and use Simple Object Access Protocol (SOAP) to communicate. It is an XML based protocol. The Web services use Web Services Description Language (WSDL) and Universal Description, Discovery, and Integration (UDDI) to describe itself.
17. What advantages have Web services over Component Object Model (COM) and Distributed Component Object Model (DCOM)?
The advantages of Web services over COM and DCOM are as follows:
+ Web services are simple to use and can be implemented on varied platforms.
+ Web services are loosely coupled; as a result, their interfaces and methods can be extended.
+ Web services do not carry any state information with them so that multiple requests can be processed simultaneously.
18. Mention the namespace that you must import in code to build a Web service.
System.Web.Services is the elementary namespace, which must be imported to develop code of a Web service.
19. What does the portType element of a WSDL document contain?
The portType element contains the operations exposed by the Web service, and the messages involved in the communication between the Web service and its consumers.
20. What is DISCO?
DISCO is a technology developed by Microsoft to publish and discover Web services. It discovers URLs of all XML Web services located on a Web server and creates a list of these Web services in a file called as a DISCO file.
21. Which two methods are used to discover the URL of Web services?
The two methods to discover the URL of Web services are Web service discovery tool (Disco.exe) and UDDI.
22. Which step is necessary to perform before a Web service can be consumed?
It is necessary to build a proxy class by using the wsdl.exe utility before a Web service can be consumed.
23. Which property of the WebMethod attribute allows you to maintain the state of objects across sessions in a Web method?
The WebMethod attribute's EnableSession property enables you to enable session state for a Web method.
24. Write the names of public properties defined in the WebService class.
There are many properties defined in the WebServices class:
+ Application - Obtains the application object for the current HTTP request
+ Context - Obtains the HttpContext object for the current request, which encapsulates all HTTP-specific context used by the HTTP server to process Web requests
+ Server - Obtains the HttpServerUtility object for the current request
+ Session - Obtains the HttpSessionState object for the current request
+ SoapVersion - Obtains the version of the SOAP protocol used to make the SOAP request to a Web service
+ User - Obtains the Server User Object. This property can be used to authenticate whether a user is authorized to execute the request.
25. What do you understand by SOAP encoding?
The Serialization of the types, such as integers and strings, inside a SOAP message is called encoding. The SOAP objects use XML elements and attributes to serialized data, for example, encodingStyle is an attribute of theEnvelop element, which is used to specify the encoding rules for a SOAP object.
26. What is the use of a .disco file?
A client application uses a .disco file to locate or discover the documents that contain the description of a Web service. The .disco file contains links to other resources, which describe essential features, such as capabilities of a Web service. The links contained in a .disco file can refer to other discovery documents or XSD schemas. The description about the services and capabilities of a Web service is written in Web services Description Language (WSDL). A .discofile can also contain the information about other XML Web services that reside on the same or a different Web server.
27. Mention the name of the directory where it is necessary to locate the proxy file to use a Web service.
The proxy file must be stored in the /bin directory. This directory is situated under the root directory of the application.
28. Does a Web service have state?
The Web services do not have any technique to maintain state. However, it can access ASP.NET objects, such as application and session if they extend from the WebService base class.
29. Which namespace must be included in a code that enables a XML Web service to write events in an event log file?
The System.Diagnostics is the namespace, which must be included in a code to enable a Web service for writing events in an event log file.
30. Which tool installs the DLL on your local computer and installs the Windows service in a transactional manner?
The Installutil.exe tool.
1. What is an assembly?
Assembly is the smallest unit of deployment of a .net application. It can be a dll or an exe.
There are mainly two types to it:
1. Private Assembly: The dll or exe which is sole property of one application only. It is generally stored in application root folder
2. Public/Shared assembly: It is a dll which can be used by multiple applications at a time. A shared assembly is stored in GAC i.e Global Assembly Cache.
Sounds difficult? Naa....
GAC is simply C:\Windows\Assembly folder where you can find the public assemblies/dlls of all the softwares installed in your PC.
There is also a third least known type of an assembly: Satellite Assembly. A Satellite Assembly contains only static objects like images and other non-executable files required by the application.
2. Name the different components of an assembly.
An assembly is a logical unit that is made up of the following four different types of components:
+ Assembly manifest
+ MSIL source code
+ Type metadata
+ Resources
3. What are the different types of assemblies? Explain them in detail.
The following are the two types of assemblies:
+ Private Assembly - Refers to the assembly that is used by a single application. Private assemblies are kept in a local folder in which the client application has been installed.
+ Public or Shared Assembly - Refers to the assembly that is allowed to be shared by multiple applications. A shared assembly must reside in Global Assembly Cache (GAC) with a strong name assigned to it.
For example, imagine that you have created a DLL containing information about your business logic. This DLL can be used by your client application. In order to run the client application, the DLL must be included in the same folder in which the client application has been installed. This makes the assembly private to your application. Now suppose that the DLL needs to be reused in different applications. Therefore, instead of copying the DLL in every client application folder, it can be placed in the global assembly cache using the GAC tool. These assemblies are called shared assemblies.
4. Can one DLL file contain the compiled code of more than one .NET language?
No, a DLL file can contain the compiled code of only one programming language.
5. What is the maximum number of classes that can be contained in a DLL file?
There is no limit to the maximum number of classes that can be contained in a DLL file.
6. What is a satellite assembly?
Satellite assemblies are assemblies that are used to deploy language and culture specific resources for an application. In an application, a separate product ID is assigned to each language and a satellite assembly is installed in a language specific sub-directory.
7. Is versioning applicable to private assemblies?
No, versioning is not applicable to private assemblies as these assemblies reside in their individual folders. Versioning can be applied to GAC only.
8. What is metadata?
An assembly metadata describes every data type and member defined in the code. It stores the description of an assembly, such as name, version, culture, public key of an assembly along with the types exported, other assemblies dependent on this assembly, and security permissions needed to run the application. In addition, it stores the description of types, such as the name, visibility, base class, interfaces implemented, and members, such as methods, fields, properties, events, and nested types.

It also stores attributes. Metadata is stored in binary format. Therefore, metadata of an assembly is sharable among applications that execute on various platforms. It can also be exported to other applications to give information about the services and various features of an application.
9. What is Assembly Manifest?
Assemblies maintain all their information in a special unit called the manifest. Every assembly has a manifest.

The followings are the contents of an Assembly Manifest:
+ Assembly name - Represents a text string that specifies the assembly's name.
+ Version number - Represents a major and minor version number, as well as a revision and build number. The CL.R makes use of these numbers to enforce version policy.
+ Culture - Represents information of the culture or language, which the assembly supports. An assembly is a container of only resources containing culture- or language-specific information.
+ Strong name information - Represents the public key from the publisher, if a strong name is assigned to an assembly.
+ List of all files in the assembly - Represents a hash of each file contained in the assembly and a file name.
+ Type reference information - Represents the information used at the runtime to map a type reference to the file that contains its declaration and implementation.
+ Information on referenced assemblies - Represents a list of other assemblies that are statically referenced by the assembly. Each reference includes the names of dependent assemblies, assembly metadata (version, culture, operating system, and so on), and public key, if the assembly is strong named.
10. What is the value of the Copy Local property when you add an assembly in the GAC?
False.
11. What is Native Image Generator?
The Native Image Generator (Ngen.exe) is a tool that creates a native image from an assembly and stores that image to native image cache on the computer. Whenever, an assembly is run, this native image is automatically used to compile the original assembly. In this way, this tool improves the performance of the managed application by loading and executing an assembly faster.

Note that native images are files that consist of compiled processor-specific machine code. The Ngen.exe tool installs these files on to the local computer.
12. Name the MSIL Disassembler utility that parses any .NET Framework assembly and shows the information in human readable format
The Ildasm.exe utility.
13. What is the significance of the Strong Name tool?
The Strong Name utility (sn.exe) helps in creating unique public-private key pair files that are called strong name files and signing assemblies with them. It also allows key management, signature generation, and signature verification.
14. How can different versions of private assemblies be used in the same application without a re-build?
You can use different versions of private assemblies in the same application without a re-build by specifying the assembly version in the AssemblyInfo.cs or AssemblyInfo.vb file.
15. What is Global Assembly Cache (GAC)?
GAC is a central repository (cache) in a system in which assemblies are registered to share among various applications that execute on local or remote machines. .NET Framework provides the GAC tool (gacutil.exe utility), which is used to view and change the content of GAC of a system. Adding new assemblies to GAC and removing assemblies from GAC are some of the tasks that can be performed by using the gacutil.exe utility. GAC can contain multiple versions of the same .NET assembly. CLR checks GAC for a requested assembly before using information of configuration files.

The gacutil.exe /i - is the command that is used to install an assembly in GAC. Users use the Command Prompt of Visual Studio to install an assembly in GAC by using this command.

You can see all the assemblies installed in the GAC using the GAC viewer, which is located at the :\assembly directory, where is windows in Windows XP or windows in Windows Vista or WinNT in Windows 2000. Apart from the list of assemblies, the assembly viewer also shows relevant information, such as the global assembly name, version, culture, and the public key token.
16. Where is the information regarding the version of the assembly stored?
Information for the version of assembly is stored inside the assembly manifest.
17. Discuss the concept of strong names.
Whenever, an assembly is deployed in GAC to make it shared, a strong name needs to be assigned to it for its unique identification. A strong name contains an assembly's complete identity - the assembly name, version number, and culture information of an assembly. A public key and a digital signature, generated over the assembly, are also contained in a strong name. A strong name makes an assembly identical in GAC.
18. What is the difference between .EXE and .DLL files?
EXE
1. It is an executable file, which can be run independently.
2. EXE is an out-process component, which means that it runs in a separate process.
3. It cannot be reused in an application.
4. It has a main function.

DLL
1. It is Dynamic Link Library that is used as a part of EXE or other DLLs. It cannot be run independently.
2. It runs in the application process memory, so it is called as in-process component.
3. It can be reused in an application.
4. It does not have a main function.
19. Which utility allows you to reference an assembly in an application?
An assembly can be referenced by using the gacutil.exe utility with the /r option. The /r option requires a reference type, a reference ID, and a description.
20. The AssemblyInfo.cs file stores the assembly configuration information and other information, such as the assembly name, version, company name, and trademark information. (True/False).
True.
1. What is database?
A database is a logically coherent collection of data with some inherent meaning, representing some aspect of real world and which is designed, built and populated with data for a specific purpose.
2. What is DBMS?
It is a collection of programs that enables user to create and maintain a database. In other words it is general-purpose software that provides the users with the processes of defining, constructing and manipulating the database for various applications.
3. What is a Database system?
The database and DBMS software together is called as Database system.
4. What are the advantages of DBMS?
1. Redundancy is controlled.
2. Unauthorised access is restricted.
3. Providing multiple user interfaces.
4. Enforcing integrity constraints.
5. Providing backup and recovery.
5. What are the disadvantage in File Processing System?
1. Data redundancy and inconsistency.
2. Difficult in accessing data.
3. Data isolation.
4. Data integrity.
5. Concurrent access is not possible.
6. Security Problems.
6. Describe the three levels of data abstraction?
There are three levels of abstraction:
1. Physical level: The lowest level of abstraction describes how data are stored.
2. Logical level: The next higher level of abstraction, describes what data are stored in database and what relationship among those data.
3. View level: The highest level of abstraction describes only part of entire database.
7. Define the "integrity rules"?
There are two Integrity rules.
1. Entity Integrity: States that "Primary key cannot have NULL value"
2. Referential Integrity: States that "Foreign Key can be either a NULL value or should be Primary Key value of other relation.
8. What is extension and intension?
1. Extension: It is the number of tuples present in a table at any instance. This is time dependent.
2. Intension: It is a constant value that gives the name, structure of table and the constraints laid on it.
9. What is System R? What are its two major subsystems?
System R was designed and developed over a period of 1974-79 at IBM San Jose Research Center. It is a prototype and its purpose was to demonstrate that it is possible to build a Relational System that can be used in a real life environment to solve real life problems, with performance at least comparable to that of existing system.
Its two subsystems are
1. Research Storage
2. System Relational Data System.
10. How is the data structure of System R different from the relational structure?
Unlike Relational systems in System R
1. Domains are not supported
2. Enforcement of candidate key uniqueness is optional
3. Enforcement of entity integrity is optional
4. Referential integrity is not enforced
11. What is Data Independence?
Data independence means that "the application is independent of the storage structure and access strategy of data". In other words, The ability to modify the schema definition in one level should not affect the schema definition in the next higher level.
Two types of Data Independence:
1. Physical Data Independence: Modification in physical level should not affect the logical level.
2. Logical Data Independence: Modification in logical level should affect the view level.
NOTE: Logical Data Independence is more difficult to achieve
12. What is a view? How it is related to data independence?
A view may be thought of as a virtual table, that is, a table that does not really exist in its own right but is instead derived from one or more underlying base table. In other words, there is no stored file that direct represents the view instead a definition of view is stored in data dictionary.
Growth and restructuring of base tables is not reflected in views. Thus the view can insulate users from the effects of restructuring and growth in the database. Hence accounts for logical data independence.
13. What is Data Model?
A collection of conceptual tools for describing data, data relationships data semantics and constraints.
14. What is E-R model?
This data model is based on real world that consists of basic objects called entities and of relationship among these objects. Entities are described in a database by a set of attributes.
15. What is Object Oriented model?
This model is based on collection of objects. An object contains values stored in instance variables with in the object. An object also contains bodies of code that operate on the object. These bodies of code are called methods. Objects that contain same types of values and the same methods are grouped together into classes.
16. What is an Entity?
It is a 'thing' in the real world with an independent existence.
17. What is an Entity type?
It is a collection (set) of entities that have same attributes.
18. What is an Entity set?
It is a collection of all entities of particular entity type in the database.
19. What is an Extension of entity type?
The collections of entities of a particular entity type are grouped together into an entity set.
20. What is Weak Entity set?
An entity set may not have sufficient attributes to form a primary key, and its primary key compromises of its partial key and primary key of its parent entity, then it is said to be Weak Entity set.
21. What is an attribute?
It is a particular property, which describes the entity.
22. What is a Relation Schema and a Relation?
A relation Schema denoted by R(A1, A2, ..., An) is made up of the relation name R and the list of attributes Ai that it contains. A relation is defined as a set of tuples. Let r be the relation which contains set tuples (t1, t2, t3, ..., tn). Each tuple is an ordered list of n-values t=(v1,v2, ..., vn).
23. What is degree of a Relation?
It is the number of attribute of its relation schema.
24. What is Relationship?
It is an association among two or more entities.
25. What is Relationship set?
The collection (or set) of similar relationships.
26. What is Relationship type?
Relationship type defines a set of associations or a relationship set among a given set of entity types.
27. What is degree of Relationship type?
It is the number of entity type participating.
28. What is DDL (Data Definition Language)?
A data base schema is specifies by a set of definitions expressed by a special language called DDL.
29. What is VDL (View Definition Language)?
It specifies user views and their mappings to the conceptual schema.
30. What is SDL (Storage Definition Language)?
This language is to specify the internal schema. This language may specify the mapping between two schemas.
31. What is Data Storage - Definition Language?
The storage structures and access methods used by database system are specified by a set of definition in a special type of DDL called data storage-definition language.
32. What is DML (Data Manipulation Language)?
This language that enable user to access or manipulate data as organised by appropriate data model.
1. Procedural DML or Low level: DML requires a user to specify what data are needed and how to get those data.
2. Non-Procedural DML or High level: DML requires a user to specify what data are needed without specifying how to get those data.
33. What is DML Compiler?
It translates DML statements in a query language into low-level instruction that the query evaluation engine can understand.
34. What is Query evaluation engine?
It executes low-level instruction generated by compiler.
35. What is DDL Interpreter?
It interprets DDL statements and record them in tables containing metadata.
36. What is Record-at-a-time?
The Low level or Procedural DML can specify and retrieve each record from a set of records. This retrieve of a record is said to be Record-at-a-time.
37. What is Set-at-a-time or Set-oriented?
The High level or Non-procedural DML can specify and retrieve many records in a single DML statement. This retrieve of a record is said to be Set-at-a-time or Set-oriented.
38. What is Relational Algebra?
It is procedural query language. It consists of a set of operations that take one or two relations as input and produce a new relation.
39. What is Relational Calculus?
It is an applied predicate calculus specifically tailored for relational databases proposed by E.F. Codd. E.g. of languages based on it are DSL ALPHA, QUEL.
40. How does Tuple-oriented relational calculus differ from domain-oriented relational calculus?
1. The tuple-oriented calculus uses a tuple variables i.e., variable whose only permitted values are tuples of that relation. E.g. QUEL
2. The domain-oriented calculus has domain variables i.e., variables that range over the underlying domains instead of over relation. E.g. ILL, DEDUCE.
41. What is normalization?
It is a process of analyzing the given relation schemas based on their Functional Dependencies (FDs) and primary key to achieve the properties (1).Minimizing redundancy, (2). Minimizing insertion, deletion and update anomalies.
42. What is Functional Dependency?
A Functional dependency is denoted by X Y between two sets of attributes X and Y that are subsets of R specifies a constraint on the possible tuple that can form a relation state r of R. The constraint is for any two tuples t1 and t2 in r if t1[X] = t2[X] then they have t1[Y] = t2[Y]. This means the value of X component of a tuple uniquely determines the value of component Y.
43. What is Lossless join property?
It guarantees that the spurious tuple generation does not occur with respect to relation schemas after decomposition.
44. What is 1 NF (Normal Form)?
The domain of attribute must include only atomic (simple, indivisible) values.
45. What is Fully Functional dependency?
It is based on concept of full functional dependency. A functional dependency X Y is full functional dependency if removal of any attribute A from X means that the dependency does not hold any more.
46. What is 2NF?
A relation schema R is in 2NF if it is in 1NF and every non-prime attribute A in R is fully functionally dependent on primary key.
47. What is 3NF?
A relation schema R is in 3NF if it is in 2NF and for every FD X A either of the following is true
1. X is a Super-key of R.
2. A is a prime attribute of R.
In other words, if every non prime attribute is non-transitively dependent on primary key.
48. What is BCNF (Boyce-Codd Normal Form)?
A relation schema R is in BCNF if it is in 3NF and satisfies an additional constraint that for every FD X A, X must be a candidate key.
49. What is 4NF?
A relation schema R is said to be in 4NF if for every multivalued dependency X Y that holds over R, one of following is true.
1.) X is subset or equal to (or) XY = R.
2.) X is a super key.
50. What is 5NF?
A Relation schema R is said to be 5NF if for every join dependency {R1, R2,..., Rn} that holds R, one the following is true 1.) Ri = R for some i.
2.) The join dependency is implied by the set of FD, over R in which the left side is key of R.
51. What is Domain-Key Normal Form?
A relation is said to be in DKNF if all constraints and dependencies that should hold on the constraint can be enforced by simply enforcing the domain constraint and key constraint on the relation.
52. What are partial, alternate,, artificial, compound and natural key?
1. Partial Key: It is a set of attributes that can uniquely identify weak entities and that are related to same owner entity. It is sometime called as Discriminator.
2. Alternate Key: All Candidate Keys excluding the Primary Key are known as Alternate Keys.
3. Artificial Key: If no obvious key, either stand alone or compound is available, then the last resort is to simply create a key, by assigning a unique number to each record or occurrence. Then this is known as developing an artificial key.
4. Compound Key: If no single data element uniquely identifies occurrences within a construct, then combining multiple elements to create a unique identifier for the construct is known as creating a compound key.
5. Natural Key: When one of the data elements stored within a construct is utilized as the primary key, then it is called the natural key.
53. What is indexing and what are the different kinds of indexing?
Indexing is a technique for determining how quickly specific data can be found.
Types:
1. Binary search style indexing
2. B-Tree indexing
3. Inverted list indexing
4. Memory resident table
5. Table indexing
54. What is system catalog or catalog relation? How is better known as?
A RDBMS maintains a description of all the data that it contains, information about every relation and index that it contains. This information is stored in a collection of relations maintained by the system called metadata. It is also called data dictionary.
55. What is meant by query optimization?
The phase that identifies an efficient execution plan for evaluating a query that has the least estimated cost is referred to as query optimization.
56. What is durability in DBMS?
Once the DBMS informs the user that a transaction has successfully completed, its effects should persist even if the system crashes before all its changes are reflected on disk. This property is called durability.
57. What do you mean by atomicity and aggregation?
1. Atomicity: Either all actions are carried out or none are. Users should not have to worry about the effect of incomplete transactions. DBMS ensures this by undoing the actions of incomplete transactions.
2. Aggregation: A concept which is used to model a relationship between a collection of entities and relationships. It is used when we need to express a relationship among relationships.
58. What is a Phantom Deadlock?
In distributed deadlock detection, the delay in propagating local information might cause the deadlock detection algorithms to identify deadlocks that do not really exist. Such situations are called phantom deadlocks and they lead to unnecessary aborts.
59. What is a checkpoint and When does it occur?
A Checkpoint is like a snapshot of the DBMS state. By taking checkpoints, the DBMS can reduce the amount of work to be done during restart in the event of subsequent crashes.
60. What are the different phases of transaction?
Different phases are
1.) Analysis phase,
2.) Redo Phase,
3.) Undo phase.
61. What do you mean by flat file database?
It is a database in which there are no programs or user access languages. It has no cross-file capabilities but is user-friendly and provides user-interface management.
62. What is "transparent DBMS"?
It is one, which keeps its Physical Structure hidden from user.
63. What is a query?
A query with respect to DBMS relates to user commands that are used to interact with a data base. The query language can be classified into data definition language and data manipulation language.
64. What do you mean by Correlated subquery?
Subqueries, or nested queries, are used to bring back a set of rows to be used by the parent query. Depending on how the subquery is written, it can be executed once for the parent query or it can be executed once for each row returned by the parent query. If the subquery is executed for each row of the parent, this is called a correlated subquery.
A correlated subquery can be easily identified if it contains any references to the parent subquery columns in its WHERE clause. Columns from the subquery cannot be referenced anywhere else in the parent query. The following example demonstrates a non-correlated subquery.
Example: Select * From CUST Where '10/03/1990' IN (Select ODATE From ORDER Where CUST.CNUM = ORDER.CNUM)
65. What are the primitive operations common to all record management systems?
Addition, deletion and modification.
66. Name the buffer in which all the commands that are typed in are stored?
'Edit' Buffer.
67. What are the unary operations in Relational Algebra?
PROJECTION and SELECTION.
68. Are the resulting relations of PRODUCT and JOIN operation the same?
No.
PRODUCT: Concatenation of every row in one relation with every row in another.
JOIN: Concatenation of rows from one relation and related rows from another.
69. What is RDBMS KERNEL?
Two important pieces of RDBMS architecture are the kernel, which is the software, and the data dictionary, which consists of the system-level data structures used by the kernel to manage the database You might think of an RDBMS as an operating system (or set of subsystems), designed specifically for controlling data access; its primary functions are storing, retrieving, and securing data. An RDBMS maintains its own list of authorized users and their associated privileges; manages memory caches and paging; controls locking for concurrent resource usage; dispatches and schedules user requests; and manages space usage within its table-space structures.
70. Name the sub-systems of a RDBMS.
I/O, Security, Language Processing, Process Control, Storage Management, Logging and Recovery, Distribution Control, Transaction Control, Memory Management, Lock Management.
71. Which part of the RDBMS takes care of the data dictionary? How?
Data dictionary is a set of tables and database objects that is stored in a special area of the database and maintained exclusively by the kernel.
72. What is the job of the information stored in data-dictionary?
The information in the data dictionary validates the existence of the objects, provides access to them, and maps the actual physical storage location.
73. How do you communicate with an RDBMS?
You communicate with an RDBMS using Structured Query Language (SQL).
74. Define SQL and state the differences between SQL and other conventional programming Languages.
SQL is a nonprocedural language that is designed specifically for data access operations on normalized relational database structures. The primary difference between SQL and other conventional programming languages is that SQL statements specify what data operations should be performed rather than how to perform them.
75. Name the three major set of files on disk that compose a database in Oracle.
There are three major sets of files on disk that compose a database. All the files are binary. These are
1.) Database files
2.) Control files
3.) Redo logs
The most important of these are the database files where the actual data resides. The control files and the redo logs support the functioning of the architecture itself. All three sets of files must be present, open, and available to Oracle for any data on the database to be useable. Without these files, you cannot access the database, and the database administrator might have to recover some or all of the database using a backup, if there is one.
76. What is database Trigger?
A database trigger is a PL/SQL block that can defined to automatically execute for insert, update, and delete statements against a table. The trigger can e defined to execute once for the entire statement or once for every row that is inserted, updated, or deleted. For any one table, there are twelve events for which you can define database triggers. A database trigger can call database procedures that are also written in PL/SQL.
77. What are stored-procedures? And what are the advantages of using them?
Stored procedures are database objects that perform a user defined operation. A stored procedure can have a set of compound SQL statements. A stored procedure executes the SQL commands and returns the result to the client. Stored procedures are used to reduce network traffic.
78. What is Storage Manager?
It is a program module that provides the interface between the low-level data stored in database, application programs and queries submitted to the system.
79. What is Buffer Manager?
It is a program module, which is responsible for fetching data from disk storage into main memory and deciding what data to be cache in memory.
80. What is Transaction Manager?
It is a program module, which ensures that database, remains in a consistent state despite system failures and concurrent transaction execution proceeds without conflicting.
81. What is File Manager?
It is a program module, which manages the allocation of space on disk storage and data structure used to represent information stored on a disk.
82. What is Authorization and Integrity manager?
It is the program module, which tests for the satisfaction of integrity constraint and checks the authority of user to access data.
83. What are stand-alone procedures?
Procedures that are not part of a package are known as stand-alone because they independently defined. A good example of a stand-alone procedure is one written in a SQL*Forms application. These types of procedures are not available for reference from other Oracle tools. Another limitation of stand-alone procedures is that they are compiled at run time, which slows execution.
84. What are cursors give different types of cursors?
PL/SQL uses cursors for all database information accesses statements. The language supports the use two types of cursors
1.) Implicit
2.) Explicit
85. What is cold backup and hot backup (in case of Oracle)?
1. Cold Backup: It is copying the three sets of files (database files, redo logs, and control file) when the instance is shut down. This is a straight file copy, usually from the disk directly to tape. You must shut down the instance to guarantee a consistent copy. If a cold backup is performed, the only option available in the event of data file loss is restoring all the files from the latest backup. All work performed on the database since the last backup is lost.
2. Hot Backup: Some sites (such as worldwide airline reservations systems) cannot shut down the database while making a backup copy of the files. The cold backup is not an available option.
86. What is meant by Proactive, Retroactive and Simultaneous Update?
Proactive Update: The updates that are applied to database before it becomes effective in real world.
Retroactive Update: The updates that are applied to database after it becomes effective in real world.
Simultaneous Update: The updates that are applied to database at the same time when it becomes effective in real world.
1. What are data and information, and how are they related in a database?
Data is recorded facts and figures, and information is knowledge derived from data. A database stores data in such a way that information can be created.
2. What is Enterprise Resource Planning (ERP), and what kind of a database is used in an ERP application?
Enterprise Resource Planning (ERP) is an information system used in manufacturing companies and includes sales, inventory, production planning, purchasing and other business functions. An ERP system typically uses a multiuser database.
3. What is a DBMS?
DBMS stands for Database Management System. A DBMS receives requests from applications and translates those requests into actions on a specific database. A DBMS processes SQL statements or uses other functionality to create, process and administer databases.
4. Why is a database considered to be "self-describing"?
In addition to the users' data, a database contains a description of its own structure. This descriptive data is called "metadata."
5. Who is E.F. Codd, and why is he significant in the development of modern database systems?
While working at IBM, E.F. Codd created the relational database model. A paper he published in 1970 presented his ideas to the world at large. His work is the foundation for most of the DBMSs currently in use, and thus forms the basis for database systems as we know and use them today.
6. What is SQL, and why is it important?
SQL stands for Structured Query Language, and is the most important data processing language in use today. It is not a complete programming language like Java or C#, but a data sublanguage used for creating and processing database data and metadata. All DBMS products today use SQL.
7. Write an SQL SELECT statement to display all the columns of the STUDENT table but only those rows where the Grade column is greater than or equal to 90.
SELECT * FROM STUDENT WHERE Grade >= 90;
8. Name and briefly describe the five SQL built-in functions.
COUNT: computes the number of rows in a table. SUM: totals numeric columns. AVG: computes the average value. MAX: obtains the maximum value of a column in a table. MIN: obtains the minimum value of a column in a table.
9. Write an SQL SELECT statement to count the number of rows in STUDENT table and display the result with the label NumStudents.
SELECT COUNT(*) AS NumStudents FROM STUDENT;
10. What is an SQL subquery?
An SQL subquery is a means of querying two or more tables at the same time. The subquery itself is an SQL SELECT statement contained within the WHERE clause of another SQL SELECT statement, and separated by being enclosed in parenthesis. Some subqueries have equivalent SQL join structures, but correlated subqueries cannot be duplicated by a join..
11. Discuss the alternative terminology that is used in the relational model.
Relations are also called tables, and sometimes by the older data processing term files. A row is known as a tuple in the relational model, but may also be referred to as a record. Finally, relational model attributes are known as table columns and sometimes as fields.
12. Why are functional dependencies not equations?
Equations deal with numerical relationships. A functional dependency deals with the existence of a determinant relationship between attributes, regardless of whether or not there is a numerical relationship between them. Thus, if we know that there is no hot water every Wednesday, No-Hot-Water is functionally dependent on Wednesday. So, if we know it is Wednesday, then we know we will have No-Hot-Water. This is a functional dependency, but not an equation.
13. What is a foreign key, and what is it used for?
A foreign key is used to establish relationships among relations in the relational model. Technically, a foreign key is a column (or columns) appearing in one relation that is (are) the primary key of another table. Although there may be exceptions, the values in the foreign key columns usually must correspond to values existing in the set of primary key values. This correspondence requirement is created in a database using a referential integrity constraint on the foreign key.
14. What are insertion and deletion anomalies?
A deletion anomaly occurs when, by deleting the facts about one entity, we inadvertently delete facts about another entity; with one deletion, we lose facts about two entities. For example, if we delete the tuple for Student 001289 from a table, we may lose not only the fact that Student 001289 is in Pierce Hall, but also the fact that he has $200 left in his security deposit. An insertion anomaly happens when we encounter the restriction that we cannot insert a fact about one entity until we have an additional fact about another entity. For example, we want to store the fact that the security deposit for Pierce Hall is $300, but we cannot enter this data into the Student relation until a student registers for Pierce Hall.
15. What does it mean when we say that a relation is in Boyce-Codd Normal Form (BCNF)?
A relation is in BCNF when every determinant in the relation is a candidate key. This means that any possible primary key can determine all other attributes in the relation. Attributes may not be determined by non-candidate key attributes or part of a composite candidate key. Thus it is said "I swear to construct my tables so that all nonkey columns are dependent on the key, the whole key and nothing but the key, so help me Codd!"
16. You have been given a set of tables with data and asked to create a new database to store them. When you examine the data values in the tables, what are you looking for?
(1) Multivalued dependencies, (2) Functional dependencies, (3) Candidate keys, (4) Primary keys and (5) Foreign keys.
17. Why do normalized tables require more complex SQL when SQL statements are used in application programs?
Tables that are normalized contain data that has been distributed among the tables, but which may need to be recombined to answer queries from an application. To recombine the data, the programmer will have to use subqueries and/or joins. These SQL structures are more complex to write than a simple SELECT statement.
18. What is the multivalue, multicolumn problem? Include an example not used in the text.
The multivalue, multicolumn problem occurs when a table is designed to include multiple columns that hold variations of one type of attribute data. One example is where boat owners have the names of their boats stored as BOAT_01, BOAT_02 and BOAT_03.
19. Why is the multivalue, multicolumn problem another form of the multivalued dependency problem?
Both problems try to store multiple values on an attribute in a table. In the multivalue, multiplecolumn problem, the multiple values are stored in different columns. In the mutlivalued dependency problem the multiple values are stored in different rows. In both cases, the solution is the same: store the multiple values in a separate table.
20. What is the inconsistent values problem? Include an example not used in the text.
The inconsistent values problem occurs when different users or data sources use slightly different forms of the same data value. One example is where automobiles are specified as "Ford, 2-door, Red" in one cell and "Red Ford 2-door" in another.
21. Explain the relationship between entity, entity class, and entity instance.
An entity is something that can be identified in the users' work environment, something that the users want to track. Entities of a given type are grouped into entity classes. An entity instance is the representation of a particular entity.
22. Explain the difference between attributes and identifiers.
Entities have attributes. Attributes are properties that describe the entity's characteristics. Entity instances have identifiers. Identifiers are attributes that name, or identify, entity instances.
23. Name and describe three types of binary relationships.
1:1 - a single entity instance of one type is related to a single-entity instance of another type.
1:N - a single entity instance of one type is related to many-entity instances of another type.
M:N - many-entity instances of one type relate to many-entity instances of another type.
24. What is the archtetype/instance pattern?
The archetype/instance pattern occurs when one entity tracks occurrences of another entity. A common example is the relationship between CLASS and SECTION, where the actual occurrence of a class happens when students register for a SECTION of that CLASS. The archetype/instance pattern is implemented as an ID-dependent relationship.
25. What is a recursive relationship? Give an example not used in the text.
A recursive relationship is a relationship between an entity and itself. For example, given the entity PERSON, a recursive relationship could be used to show a PERSON and his or her SIBLINGs (brothers and sisters).
26. What are the steps for transforming an entity into a table?
The steps are: (1) specify the primary key, (2) specify candidate keys, (3) specify column properties including null status, data type, default value (if any), and data constraints (if any), and (4) verifying normalization.
27. Define a surrogate key, describe the ideal primary key and explain how surrogate keys meet this ideal.
The ideal primary key is short, numeric and fixed. A surrogate key is a unique, DBMS-supplied identifier intended to be used as the primary key of a table. Further, the DBMS will not allow the value of a surrogate key to be changed. The values of a surrogate key have no meaning to the users and are usually hidden on forms and reports. By design, they are short, numeric and fixed and thus meet the definition of the ideal primary key
28. Define and discuss data constraints.
Data constraints on a column are the limits put on the values the data can have. There are four types of data constraints: (1) domain constraints, which define a limited set of values for the column, (2) range constraints, which specify that the values must fall within a certain range, (3) intrarelation constraints, which define what values the column can have based on values of other columns in the same table, and (4) interrelation constraints, which define values the column can have based on values of columns in other tables.
29. In general, how are recursive relationships handled in a database design?
A recursive relationship is a relationship among entities of the same class, and is represented in the same way as other relationships are. The rows of the tables can take two different roles, however. Some are parent rows, and others are child rows. Further, the table will contain both its own primary key and the foreign key that links back to the table itself. If a row has no parent, then the value of the foreign key column in that row will be null. If the row has a parent, then there must be a foreign key value in that row that corresponds to the primary key value of another row in the table.
30. What is a cascading update?
Referential integrity constraints require that foreign key values in one table correspond to primary key values in another. If the value of the primary key is changed -- that is, updated -- the value of the foreign key must immediately be changed to match it. Cascading updates will set this change to be done automatically by the DBMS whenever necessary.
31. What is a SQL view? Briefly explain the use of views.
A SQL view is a virtual table built from other tables or views. Views are used to (1) hide columns or rows, (2) show the results of computed columns, (3) hide complicated SQL syntax, (4) layer built-in functions, (5) provide a level of indirection between application programs and tables, (6) assign different sets of processing permissions to tables, and (7) to assign different sets of triggers to the same table.
32. Explain the "paradigm mismatch" between SQL and application programming languages.
SQL statements return a set of rows, while an application program works on one row at a time. To resolve this mismatch the results of SQL statements are processed as pseudofiles, using a cursor or pointer to specify which row is being processed.
33. Name four applications for triggers.
(1) Providing default values, (2) enforcing data constraints, (3) updating views and (4) enforcing referential integrity
34. What are stored procedures, and how do they differ from triggers?
A stored procedure is a program that is stored within the database and is compiled when used. They can receive input parameters and they can return results. Unlike triggers, their scope is database-wide; they can be used by any process that has permission to use the database stored procedure.
35. What are the advantages of using stored procedures?
The advantages of stored procedures are (1) greater security, (2) decreased network traffic, (3) the fact that SQL can be optimized and (4) code sharing which leads to less work, standardized processing, and specialization among developers.
36. Why is database redesign necessary?
Database redesign is necessary for two reasons. First, redesign is necessary both to fix mistakes made during the initial database design. Second, redesign is necessary to adapt the database to changes in system requirements. Such changes are common because information systems and organizations do not just influence each other they create each other. Thus, new information systems cause changes in systems requirements.

37. What is the difference between a correlated subquery and a regular subquery?
A correlated subquery appears deceptively similar to a regular subquery. The difference is that a regular subquery can be processed from the bottom up. In a regular subquery, results from the lowest query can be determined and used to evaluate the upper-level query. In contrast, in a correlated subquery, the processing is nested; that is, a row from an upper query statement is used in comparison with rows in a lower level query. The key distinction of a correlated subquery is that the lower-level select statements use columns from upper-level statements.
38. What is a dependency graph?
A dependency graph is a diagram that is used to portray the connections between database elements. For example, a change in a table can potentially impact relationships, views, indexes, triggers, stored procedures, and application programs. These impacts need to be known and accounted for before making database changes.
39. Explain how to add a NOT NULL column to a table.
First, add the column as NULL. Then use UPDATE to add data to every row. Finally use an ALTER TABLE . . . ALTER COLUMN statement to change the column constraint to NOT NULL.
40. You have two tables, EMPLOYEE and COMPUTER that are in a one-to-one relationship. The foreign key is EmpNumber in COMPUTER which references EmpNumber as the primary key of EMPLOYEE. Explain what must be done to convert the one-to-one EMPLOYEE-COMPUTER relationship to a one-to-many relationship where one employee can have more than one computer.
In the one-to-one relationship, there will be a constraint on EmpNumber as a foreign key in COMPUTER stating that EmpNumber must be unique. To convert the relationship to a one-to-many relationship, just drop this constraint.
41. Explain the difference between an exclusive lock and a shared lock.
An exclusive lock prohibits other users from reading the locked resource; a shared lock allows other users to read the locked resource, but they cannot update it.
42. Explain the difference between optimistic locking and pessimistic locking.
Optimistic locking assumes no transaction conflict will occur and deals with the consequences if it does. Pessimistic locking assumes that conflict will occur and so prevents it ahead of time with locks. In general, optimistic locking is preferred for the Internet and for many intranet applications.

string is also reference type. By default value types are NON Nullable.
