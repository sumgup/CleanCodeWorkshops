# Currying And Partial Application in C Sharp#

Currying is when you break down a function that takes multiple arguments into a series of functions that take part of the arguments.  

Curry is used  for dependency injection in functional programming hence we can use currying to change  signature transformation of delegate( function).

Let's  start with  a simple  example: It takes two integer as input and return int as output.

```c#
Func<int, int, int> MultiplicationSignature = (x, y) => x * y;
```

Now call this function as below :

```c#
 int  a =2;
 int  b =3;
 int ans = MultiplicationSignature(a,b);
```

Now we can also use the lambda syntax to build a multiplication function that within it returns a function that's just waiting for the other side of the multiplication expression. **Watch out syntax below!**

```c#
Func<int, Func<int, int>> curriedMultiplicationSignature = x => y => x * y;
```

 Now I can write this my code  to execute  above function

```c#
int  a =2;
int  b =3;
int ans = curriedMultiplicationSignature(a)(b);
```

The result is the same, it's just that the syntax looks unfamiliar.

Now we can curry our curriedMultiplicationSignature by just supplying one argument and then use new mul(5) function as many times we want.

```c#
var mul5 = curriedMultiplicationSignature(5);
int c = mul5(3); // 15
int d = mul5(6); // 30
```
Another example of currying.

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

Now use curry created above.

```c#
Func<int> xValueRetrivalFunc = () => new System.Random(1).Next();
var yValue = 6;
var result = curriedMultiplicationSignature(xValueRetrivalFunc())(yValue);
```

------

Now we will See  **Partial Application**

or we further  rectify  and rewrite

```c#
 int  a =2;
 int  b =3;
 var curriedMultiplicationSignatureWithA = curriedMultiplicationSignature(a);
int ans = curriedMultiplicationSignatureWithA(b);
```

Let's have more example

```c#
var  table10Func = curriedMultiplicationSignature(10);
var  table5Func =  curriedMultiplicationSignature(5);
```

Now  print the table of 10 and table of 5

```c#
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
| result of sub methods are reusable | result of sub methods are  not reusable  |



[]: https://dotnetfiddle.net/H0jvHG	"Sample Code"

Now  assume that we have function  to send notification for email and sms

```c#
Func<UserInfo,smsApiDetail, fromPhoneNumber, smstext, Outcome> SmsNotification =.........

Func<UserInfo,smtpServerDetail, fromAddress, subject,body , Outcome> EmailNotification =.........

```

Now convert that function into simple notification function which takes userinfo as input and returns outcome

so other required details will be injected implicitly while composition function in "**Partial Application way**"

```c#
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

```c#
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

