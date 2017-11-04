### Prerequisites :

##### **Func**

Encapsulates a method that has one parameter and returns a value of the type specified by the *TResult* parameter.

Encapsulation (Dictionary Meaning) : The action of enclosing something in or as if in a capsule.

C# Syntax

```csharp
public delegate TResult Func<in T, out TResult>(
	T arg
)
```

##### **Delegate** 

A [delegate](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/delegate) is a type that represents references to methods with a particular parameter list and return type. 

Delegate declaration example:

```c#
delegate double MathAction(double num);
```

C# examples for delegates

Delegates can be invoked using :

1. Named method
2. Anonymous Method
3. Lambda expression

```c#
// Declare delegate -- defines required signature:
delegate double MathAction(double num);

class DelegateTest
{

// Regular method that matches signature:
static double Double(double input)
{
    return input * 2;
}

static void Main()
{
    // Instantiate delegate with named method:
    MathAction ma = Double;

    // Invoke delegate ma:
    double multByTwo = ma(4.5);
    Console.WriteLine("multByTwo: {0}", multByTwo);

    // Instantiate delegate with anonymous method:
    MathAction ma2 = delegate(double input)
    {
        return input * input;
    };

    double square = ma2(5);
    Console.WriteLine("square: {0}", square);

    // Instantiate delegate with lambda expression
    MathAction ma3 = s => s * s * s;
    double cube = ma3(4.375);

    Console.WriteLine("cube: {0}", cube);
}
// Output:
// multByTwo: 9
// square: 25
// cube: 83.740234375
}
```
In versions of C# before 2.0, the only way to declare a [delegate](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/delegate) was to use [named methods](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/delegates-with-named-vs-anonymous-methods). C# 2.0 introduced anonymous methods and in C# 3.0 and later, lambda expressions supersede anonymous methods as the preferred way to write inline code. 

##### Lambda Expression

A lambda expression is an [anonymous function](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/anonymous-methods) that you can use to create [delegates](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates) or [expression tree](http://msdn.microsoft.com/library/fb1d3ed8-d5b0-4211-a71f-dd271529294b) types. By using lambda expressions, you can write local functions that can be passed as arguments or returned as the value of function calls. Lambda expressions are particularly helpful for writing LINQ query expressions.

To create a lambda expression, you specify input parameters (if any) on the left side of the lambda operator [=>](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-operator), and you put the expression or statement block on the other side. For example, the lambda expression `x => x * x` specifies a parameter that’s named `x` and returns the value of `x` squared. You can assign this expression to a delegate type, as the following example shows:

Example:

```C#
delegate int del(int i);  
static void Main(string[] args)  
{  
  del myDelegate = x => x * x;  
  int j = myDelegate(5); //j = 25  
}  
```
Type: T : The parameter of the method that this delegate encapsulates.

**Return Value**

Type: TResult : The return value of the method that this delegate encapsulates.

**Type Parameters**

- **in **T

  The type of the parameter of the method that this delegate encapsulates.


- **out **TResult

  The type of the return value of the method that this delegate encapsulates.

**Example**:

A function that take integer as input and returns string representation of it.

 public string ConvertIntToString(int i)

```C#
    public string ConvertIntToString(int i)
	{
      return string.Format("string = {0}", i); 
    }
```
```c#
 		//
        // Create a Func that has 1 parameter and 1 return value.
        // ... Parameter is an integer, result value is a string.
        //
        Func<int, string> func1 = (x) =>
            string.Format("string = {0}", x);
```

##### **Action**

Definition : Encapsulates a method that has a single parameter and does not return a value.

C# Syntax

```c#
public delegate void Action<in T>(
	T obj
)
```

Parameters

- obj

  Type: T

  The parameter of the method that this delegate encapsulates.

Type Parameters

- **in **T

  The type of the parameter of the method that this delegate encapsulates.

Example:

When you use the Action<T> delegate, you do not have to explicitly define a delegate that encapsulates a method with a single parameter. For example, the following code explicitly declares a delegate named DisplayMessage and assigns a reference to either the [WriteLine](https://msdn.microsoft.com/en-us/library/zdf6yhx5(v=vs.110).aspx) method or the ShowWindowsMessage method to its delegate instance.

```c#
using System;
using System.Windows.Forms;

delegate void DisplayMessage(string message);

public class TestCustomDelegate
{
   public static void Main()
   {
      DisplayMessage messageTarget; 

      if (Environment.GetCommandLineArgs().Length > 1)
         messageTarget = ShowWindowsMessage;
      else
         messageTarget = Console.WriteLine;

      messageTarget("Hello, World!");   
   }      

   private static void ShowWindowsMessage(string message)
   {
      MessageBox.Show(message);      
   }
}
```

The following example simplifies this code by instantiating the Action<T> delegate instead of explicitly defining a new delegate and assigning a named method to it.

```c#
using System;
using System.Windows.Forms;

public class TestAction1
{
   public static void Main()
   {
      Action<string> messageTarget; 

      if (Environment.GetCommandLineArgs().Length > 1)
         messageTarget = ShowWindowsMessage;
      else
         messageTarget = Console.WriteLine;

      messageTarget("Hello, World!");   
   }      

   private static void ShowWindowsMessage(string message)
   {
      MessageBox.Show(message);      
   }
}
```

##### Func Example:

When you use the Func<T, TResult> delegate, you do not have to explicitly define a delegate that encapsulates a method with a single parameter. For example, the following code explicitly declares a delegate named ConvertMethod and assigns a reference to the UppercaseString method to its delegate instance.

```c#
using System;

delegate string ConvertMethod(string inString);

public class DelegateExample
{
   public static void Main()
   {
      // Instantiate delegate to reference UppercaseString method
      ConvertMethod convertMeth = UppercaseString;
      string name = "Dakota";
      // Use delegate instance to call UppercaseString method
      Console.WriteLine(convertMeth(name));
   }

   private static string UppercaseString(string inputString)
   {
      return inputString.ToUpper();
   }
}
```

The following example simplifies this code by instantiating the Func<T, TResult> delegate instead of explicitly defining a new delegate and assigning a named method to it.

```c#
using System;

public class GenericFunc
{
   public static void Main()
   {
      // Instantiate delegate to reference UppercaseString method
      Func<string, string> convertMethod = UppercaseString;
      string name = "Dakota";
      // Use delegate instance to call UppercaseString method
      Console.WriteLine(convertMethod(name));
   }

   private static string UppercaseString(string inputString)
   {
      return inputString.ToUpper();
   }
}
```

### ﻿Steps 

Functional thinking : In functional paradigm, each operation can be simply represented by a functions, and functions can be composed:

What are the operations in this program?

1. Download - DownloadHtml
2. Convert - ConvertToWord
3. Upload - UploadToOneDrive

```c#
	 public FileInfo DownloadHtml(Uri uri)
        {
            return default;
        }

        public FileInfo ConvertToWord(FileInfo htmlDocument)
        {
            return default;
        }

        public void UploadToOneDrive(FileInfo file)
        {

        }
```
Convert these three into func.

```c#
private void Foo()
{
  Func<Uri, FileInfo> downloadHtml = DownloadHtml;
  Func<FileInfo, FileInfo> convert = ConvertToWord;
  Action<FileInfo> upload = UploadToOneDrive; // Note :  We are using Action not func. Why?
}
```
How do we build document using function above : 

Refactor Foo to BuildDocument

```c#
  private void CreateDocumentBuilder(Func<Uri, FileInfo> downloadHtml, Func<FileInfo, FileInfo> convert, Action<FileInfo> upload)
    {
        var uri = new Uri("www.microsoft.com");
        var htmlFile = downloadHtml(uri);
        var convertedFile = convert(htmlFile);
        upload(convertedFile);
    }
```
Code above can be refactored to Action - which will take URI as input

```c#
private Action<Uri> CreateDocumentBuilder(Func<Uri, FileInfo> downloadHtml,
      Func<FileInfo, FileInfo> convert, Action<FileInfo> upload)
    {
        return (uri) =>
        {
            var htmlFile = downloadHtml(uri);
            var convertedFile = convert(htmlFile);
            upload(convertedFile);
        };
    }
```
Lets call BuildDocument:

```c#
    private void CreateDocument()
    {
        Action<Uri> buildDocument = CreateDocumentBuilder(DownloadHtml, ConvertToWord, UploadToOneDrive);
        buildDocument(new Uri("www.microsoft.com"));
    }
```


### Key Learning:

 **This demonstrates in C# functions are first class citizens just like objects.** Internally, CreateDocumentBuilder function composes the input functions and return a new function.

### Additional Facts

- Lambda expression and functional programming came from lambda calculus, which was invented in 1930s.

- The first functional programming language, Lisp, was designed in 1950s. Lisp is also the second oldest high level programming language still widely used today. It is only 1 year younger than Fortran, an imperative programming language.

  ​

### Next Steps

1. In the sample above provider can be interface - Upload to Google drive - Modify above sample to use interface.  
2. Can we try implement method chaining for download, convert and upload?
3. Create another sample to use LINQ based approach opposed to imperative.
4. Drill down Lambda expression to use expression trees
