﻿# Currying And Partial Application in C Sharp#

In mathematics and computer science, currying is the technique of translating the evaluation of a function that takes multiple arguments (or a tuple of arguments) into evaluating a sequence of functions, each with a single argument.

Can be understood as : If you give a function less arguments than it expects you get back another function that only expects the missing arguments.

Let's  start with  a simple  example:

```
Func<int, int, int> MultiplicationSignature = (x, y) => x * y;
```

Now call this function as below :

```c#
 int  a = 2;
 int  b = 3;
 int ans = MultiplicationSignature(a,b);
```

Now we start making curry 

```c#
Func<int, Func<int, int>> curriedMultiplicationSignature = x =>(x, y) => MultiplicationSignature(x,y);
```

 Now I can write this my code  to execute  above function

```c#
int  a =2;
int  b =3;
int ans = curriedMultiplicationSignature(a)(b);
```

Or  we do  currying for second scenario

```c#
Func<int, int, double> dividedSignature = (x, y) => y != 0 ? (x / (Convert.ToDouble(y))) : 0d;

Func<Func<int>, Func<int, double>> curriedMultiplicationSignature = f1 =>
                        {
                            var x = f1();
                            return y =>
                            {
                               return dividedSignature(x, y);
                            };
                        }; 
```

Now  use this curry

```
Func<int> xValueRetrivalFunc = () => new System.Random(1).Next();
var yValue = 6;
var result = curriedMultiplicationSignature(xValueRetrivalFunc)(yValue);
```

This is called  Currying  Pattern 

------

Now we will See  **Partial Application**

Calling (or applying) a curried function with one argument, is called [partial application](http://en.wikipedia.org/wiki/Partial_application).

or we further  rectify  and rewrite

```c#
 int  a =2;
 int  b =3;
 Func<int, Func<int, int>> curriedMultiplicationSignature = x => y => x * y;
 var curriedMultiplicationSignatureWithA = curriedMultiplicationSignature(a);
int ans = curriedMultiplicationSignatureWithA(b);
```

Let's have more example

```c#
var  table10Func = curriedMultiplicationSignature(10);
var  table5Func =  curriedMultiplicationSignature(5);
```

Now  print the table of 10 and table of 5

```
/// print table of 10
 for(int i=1;i<=10;i++)
 {
    Console.WriteLine("{0} * {1} ={2}",10,i,table10Func(i) );
 }
 /// print table of 5
 for(int i=1;i<=10;i++)
 {
    Console.WriteLine("{0} * {1} ={2}",10,i,table5Func(i) );
 }
```

 This is  called the Partial  Application



|            **Currying**            |         **Partial Application**          |
| :--------------------------------: | :--------------------------------------: |
|       Parameter pass at last       | parameter passed while doing composition |
| result of sub methods are reusable |  result of sub methods are not reusable  |



[]: https://dotnetfiddle.net/H0jvHG	"Sample Code"



Now  we  assume that we have function  to send notification for email and sms

```
Func<UserInfo,smsApiDetail, fromPhoneNumber, smstext, Outcome> SmsNotification =.........

Func<UserInfo,smtpServerDetail, fromAddress, subject,body , Outcome> EmailNotification =.........

```

Now convert that function into  simple notification function which gives user info and return outcome

so other required details will be injected implicitly while composition function in "**Partial Application way**"

```
/// for SMS
var smsApiDetail = somthing;
var fromPhoneNumber = "+919999999999";
var smstext = "Hello text for sms";

Func<UserInfo, Outcome> SmsNotificationCurry = (u) => SmsNotification(u,smsApiDetail,fromPhoneNumber,smstext);

//// For Email
var smtpServerDetail =somthing;
var fromAddress = "something@somthing.com";
var subject ="This is notificaiton subject line";
var body ="<html><body>Hello there,<br/> this is email notification.</body></html>";

Func<UserInfo, Outcome> emailNotificationCurry =(u) => EmailNotification(u,smtpServerDetail,fromAddress,subject,body);

```

Now  use this function to send notification

```
public static void  SendNotification(UserInfo user, Func<UserInfo, Outcome> notification  )
{
     var result = notification(user);
     Console.WriteLine(result);
}

public static void  Run(string serviceName)
{
    var userInfo = .....;
    Func<UserInfo, Outcome> notificationCurry =serviceName =="SMS"?SmsNotificationCurry:emailNotificationCurry;
    
    SendNotification(userInfo,notificationCurry);
}
```

 **Curry vs Partial Application Code**

[https://dotnetfiddle.net/s39pY5]: 

