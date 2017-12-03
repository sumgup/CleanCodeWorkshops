













## AWS Lambda

**AWS Lambda** is an [event-driven](https://www.wikiwand.com/en/Event-driven_programming), [serverless computing](https://www.wikiwand.com/en/Serverless_computing) platform provided by [Amazon](https://www.wikiwand.com/en/Amazon.com) as a part of the [Amazon Web Services](https://www.wikiwand.com/en/Amazon_Web_Services). It is a compute service that runs code in response to [events](https://www.wikiwand.com/en/Event_(computing)) and automatically manages the compute resources required by that code. It was introduced in 2014.

AWS Lambda is a compute service that lets you run code without provisioning or managing servers. AWS Lambda executes your code only when needed and scales automatically, from a few requests per day to thousands per second. You pay only for the compute time you consume - there is no charge when your code is not running.

### How Does AWS Lambda Run My Code? The Container Model

When AWS Lambda executes your Lambda function on your behalf, it takes care of provisioning and managing resources needed to run your Lambda function. When you create a Lambda function, you specify configuration information, such as the amount of memory and maximum execution time that you want to allow for your Lambda function. When a Lambda function is invoked, AWS Lambda launches a **container** (that is, an execution environment) **based on the configuration settings you provided.**

The content of this section is for information only. AWS Lambda manages container creations and deletion, there is no AWS Lambda API for you to manage containers. It takes time to set up a container and do the necessary bootstrapping, which adds some latency each time the Lambda function is invoked. You typically see this latency when a Lambda function is invoked for the first time or after it has been updated because AWS Lambda tries to reuse the container for subsequent invocations of the Lambda function.

Coding Style

Stateless Style - Functional Approach -> Requiring functions to be stateless enables AWS Lambda to launch as many copies of a function as needed to scale to the incoming rate of events and requests.

No affinity with the underlying compute infrastructure

Your code should expect local file system access, child processes, and similar artifacts to be limited to the lifetime of the request.

Persistent state should be stored in Amazon S3, Amazon DynamoDB, or another cloud storage service. 

Programming Model

You write code for your Lambda function in one of the languages AWS Lambda supports. Regardless of the language you choose, there is a common pattern to writing code for a Lambda function that includes the following core concepts:

1. **Handler** – Handler is the function AWS Lambda calls to start execution of your Lambda function. You identify the handler when you create your Lambda function. When a Lambda function is invoked, AWS Lambda starts executing your code by calling the handler function. AWS Lambda passes any event data to this handler as the first parameter. Your handler should process the incoming event data and may invoke any other functions/methods in your code.
2. **The context object** and how it interacts with Lambda at runtime – AWS Lambda also passes a  context  object to the handler function, as the second parameter. Via this context object your code can interact with AWS Lambda. For example, your code can find the execution time remaining before AWS Lambda terminates your Lambda function.
3. Logging - Your Lambda function can contain logging statements. AWS Lambda writes these logs to CloudWatch Logs.
4. Exceptions -  Your Lambda function needs to communicate the result of the function execution to AWS Lambda. Depending on the language you author your Lambda function code, there are different ways to end a request successfully or to notify AWS Lambda an error occurred during execution. If you invoke the function synchronously, then AWS Lambda forwards the result back to the client.



#### Videos 

AWS re:invent 2017: Getting Started with Serverless Architectures (CMP211)

https://www.youtube.com/watch?v=0ytBy4-fvo4

AWS re:invent 2017: Building .NET-based Serverless Architectures and Running .NET Co (ARC318)

https://www.youtube.com/watch?v=0dLSC3o8UqI

AWS re:invent 2017: Authoring and Deploying Serverless Applications with AWS SAM (SRV311)

https://www.youtube.com/watch?v=pMyniSCOJdA

**<u>Blog Task</u>**

Why .net core > Performance, Less Memory, Open Source

How to find it same container is used

What gets persisted in Container?

Keeping DRY

Cold Start   vs Warm Start

