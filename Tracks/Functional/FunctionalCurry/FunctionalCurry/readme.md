

﻿# Curry Pattern in C##

Curry is used  for dependency injection in functional programming

hence we can use curry to change  signature transformation of delegate( function).

Let's  start with  a simple  example:

```
Func<int, int, int> MultiplicationSignature = (x, y) => x * y;
```

Now call this function as below :

```c#
 int  a =2;
 int  b =3;
 int ans  =MultiplicationSignature(a,b);
```

Now  we start making curry 

```
Func<int, Func<int, int>> curriedMultiplicationSignature = x => y => x * y;
```

 Now I can write this my code  to execute  above function

```
int  a =2;
int  b =3;
int ans = curriedMultiplicationSignature(a)(b);
```

or we further  rectify  and rewrite

```
 int  a =2;
 int  b =3;
 var curriedMultiplicationSignatureWithA = curriedMultiplicationSignature(a);
int ans = curriedMultiplicationSignatureWithA(b);
```

Let's have more example

```
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

[]: https://dotnetfiddle.net/H0jvHG	"Sample Code"

Now  we  assume that we have function  to send notification for email and sms

```
Func<UserInfo,smsApiDetail, fromPhoneNumber, smstext, Outcome> SmsNotification =.........

Func<UserInfo,smtpServerDetail, fromAddress, subject,body , Outcome> EmailNotification =.........

```

Now convert that function into  simple notification

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

