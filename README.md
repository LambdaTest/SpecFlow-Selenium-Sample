# Run Selenium Tests With SpecFlow — TestMu AI (Formerly LambdaTest)

![image](https://user-images.githubusercontent.com/70570645/171986341-572a87c2-3855-4e19-a710-36909cb51e2d.png)

<p align="center">
  <a href="https://www.testmuai.com/blog/?utm_source=github&utm_medium=repo&utm_campaign=specflow-selenium-sample" target="_bank">Blog</a>
  &nbsp; &#8901; &nbsp;
  <a href="https://www.testmuai.com/support/docs/?utm_source=github&utm_medium=repo&utm_campaign=specflow-selenium-sample" target="_bank">Docs</a>
  &nbsp; &#8901; &nbsp;
  <a href="https://www.testmuai.com/learning-hub/?utm_source=github&utm_medium=repo&utm_campaign=specflow-selenium-sample" target="_bank">Learning Hub</a>
  &nbsp; &#8901; &nbsp;
  <a href="https://www.testmuai.com/newsletter/?utm_source=github&utm_medium=repo&utm_campaign=specflow-selenium-sample" target="_bank">Newsletter</a>
  &nbsp; &#8901; &nbsp;
  <a href="https://www.testmuai.com/certifications/?utm_source=github&utm_medium=repo&utm_campaign=specflow-selenium-sample" target="_bank">Certifications</a>
  &nbsp; &#8901; &nbsp;
  <a href="https://www.youtube.com/@TestMuAI" target="_bank">YouTube</a>
</p>
&emsp;
&emsp;
&emsp;

*Learn how to use SpecFlow framework to configure and run your C# automation testing scripts on the TestMu AI platform*

[<img height="58" width="200" src="https://user-images.githubusercontent.com/70570645/171866795-52c11b49-0728-4229-b073-4b704209ddde.png">](https://accounts.lambdatest.com/register?utm_source=github&utm_medium=repo&utm_campaign=specflow-selenium-sample)

## Table Of Contents

* [Pre-requisites](#pre-requisites)
* [Run Your First Test](#run-your-first-test)
* [Parallel Testing With SpecFlow](#running-your-parallel-tests-using-specflow)
* [Local Testing With SpecFlow](#testing-locally-hosted-or-privately-hosted-projects)


## Prerequisites

**Note:** This tutorial is specifically for Windows users using **Microsoft Visual Studio**.

Before you can start performing **SpecFlow** automation testing with **Selenium**, you would need to:

* Download and Install **Selenium WebDriver** from the [official website](https://www.selenium.dev/downloads/).
* Make sure you work with latest version of **SpecFlow**.
* **.Net** framework to deliver guidelines while developing a range of application using C#.
* Download [Selenium WebDriver Language Binding](https://www.selenium.dev/downloads/) for C# and extract them to appropriate folder. A [.NET Core SDK](https://dotnet.microsoft.com/en-us/download) of 2.1 or greater version.

### Installing Selenium Dependencies And Tutorial Repo

**Step 1:** Clone the TestMu AI’s SpecFlow-Selenium-Sample repository and navigate to the code directory as shown below:

```csharp
git clone https://github.com/LambdaTest/SpecFlow-Selenium-Sample
cd SpecFlow-Selenium-Sample
```
### Setting Up Your Authentication

Make sure you have your TestMu AI credentials with you to run test automation scripts with C#. You can get these credentials from the [TestMu AI Automation Dashboard](https://automation.lambdatest.com/login?utm_source=github&utm_medium=repo&utm_campaign=specflow-selenium-sample) or by your TestMu AI Profile.

**Step 2:** Set TestMu AI **Username** and **Access Key** in environment variables.

* For **Linux/macOS**:
  
  ```bash
  export LT_USERNAME="YOUR_USERNAME" 
  export LT_ACCESS_KEY="YOUR ACCESS KEY"
  ```
  * For **Windows**:
  ```bash
  set LT_USERNAME="YOUR_USERNAME" 
  set LT_ACCESS_KEY="YOUR ACCESS KEY"
  ```
## Run Your First Test

>**Test Scenario**: The below sample script TodoAppSteps.cs tests a sample to-do list app by marking couple items as done, adding a new item to the list and finally displaying the count of pending items as output.

**Step 3:** In the test script [TodoAppSteps.cs](https://github.com/LambdaTest/SpecFlow-Selenium-Sample/blob/master/Step%20Defination/TodoAppSteps.cs), you need to update your test capabilities. In this code, we are passing browser, browser version, and operating system information, along with TestMu AI Selenium grid capabilities via capabilities object. The capabilities object in the above code are defined as:

```csharp 
DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, "Chrome");
            capabilities.SetCapability(CapabilityType.Version, "96");
            capabilities.SetCapability(CapabilityType.Platform, "Windows 10");
```
You can generate capabilities for your test requirements with the help of our inbuilt [Desired Capability Generator](https://www.testmuai.com/capabilities-generator/?utm_source=github&utm_medium=repo&utm_campaign=specflow-selenium-sample).

### Executing Your First Test 

**Step 4:** Build the solution by clicking in **Build > Build Solution.** 

**Step 5:** As shown below click on **Test Explorer** on your MS Visual Studio:

<img height="300" src= "https://user-images.githubusercontent.com/70570645/171986691-f41b3082-9cf8-4863-91f4-bb77538d15c8.png"/>

**Step 6:** Click on **Run** from the Test Explorer to run the sample test as shown below:

<img height="300" src= "https://user-images.githubusercontent.com/70570645/171986838-fd229e7e-29ff-41b7-8476-28eb17efee6a.png"/>

Your results would be displayed on the test console and on the TestMu AI dashboard. [TestMu AI Dashboard](https://automation.lambdatest.com/?utm_source=github&utm_medium=repo&utm_campaign=specflow-selenium-sample) will help you view all your text logs, screenshots and video recording for your entire Selenium tests.

## Running Your Parallel Tests Using SpecFlow

To run parallel tests, you may go to **Test Explorer** on Visual Studio as mentioned above and click on **Run All** tests to execute the tests. 

## Testing Locally Hosted Or Privately Hosted Projects

You can test your locally hosted or privately hosted projects with TestMu AI Selenium grid using TestMu AI Tunnel. All you would have to do is set up an SSH tunnel using tunnel and pass toggle `tunnel = True` via desired capabilities. TestMu AI Tunnel establishes a secure SSH protocol based tunnel that allows you in testing your locally hosted or privately hosted pages, even before they are live.

Refer our [TestMu AI Tunnel documentation](https://www.testmuai.com/support/docs/testing-locally-hosted-pages/?utm_source=github&utm_medium=repo&utm_campaign=specflow-selenium-sample) for more information.

Here’s how you can establish TestMu AI Tunnel.

Download the binary file of:
* [TestMu AI Tunnel for Windows](https://downloads.lambdatest.com/tunnel/v3/windows/64bit/LT_Windows.zip)
* [TestMu AI Tunnel for macOS](https://downloads.lambdatest.com/tunnel/v3/mac/64bit/LT_Mac.zip)
* [TestMu AI Tunnel for Linux](https://downloads.lambdatest.com/tunnel/v3/linux/64bit/LT_Linux.zip)

Open command prompt and navigate to the binary folder.

Run the following command:

```bash
LT -user {user’s login email} -key {user’s access key}
```
So if your user name is lambdatest@example.com and key is 123456, the command would be:

```bash
LT -user lambdatest@example.com -key 123456
```
Once you are able to connect **TestMu AI Tunnel** successfully, you would just have to pass on tunnel capabilities in the code shown below :

**Tunnel Capability**

```java
DesiredCapabilities capabilities = new DesiredCapabilities();        
        capabilities.setCapability("tunnel", true);
```

## Tutorials 📙

Check out our latest tutorials on SpecFlow automation testing 👇

* [SpecFlow Tutorial For Automation Testing With Selenium C#](https://www.testmuai.com/blog/specflow-tutorial-for-automation-testing/?utm_source=github&utm_medium=repo&utm_campaign=specflow-selenium-sample)
* [Understanding SpecFlow Framework and Running Tests on Cloud Selenium Grid](https://www.testmuai.com/blog/specflow-tutorial-for-automation-testing/?utm_source=github&utm_medium=repo&utm_campaign=specflow-selenium-sample)
* [How To Perform Parallel Execution With Specflow, NUnit, And Selenium](https://www.testmuai.com/blog/parallel-execution-with-specflow-nunit-and-selenium/?utm_source=github&utm_medium=repo&utm_campaign=specflow-selenium-sample)


For video tutorials on Selenium SpecFlow, please refer to our [SpecFlow Tutorial Playlist](https://www.youtube.com/playlist?list=PLZMWkkQEwOPmE8w1NjEmTrbRSmPokMG9L). ▶️

Subscribe To Our [TestMu AI YouTube Channel 🔔](https://www.youtube.com/@TestMuAI) and keep up-to-date on the latest video tutorial around software testing world.

## Documentation & Resources :books:

      
Visit the following links to learn more about TestMu AI's features, setup and tutorials around test automation, mobile app testing, responsive testing, and manual testing.

* [TestMu AI Documentation](https://www.testmuai.com/support/docs/?utm_source=github&utm_medium=repo&utm_campaign=specflow-selenium-sample)
* [TestMu AI Blog](https://www.testmuai.com/blog/?utm_source=github&utm_medium=repo&utm_campaign=specflow-selenium-sample)
* [TestMu AI Learning Hub](https://www.testmuai.com/learning-hub/?utm_source=github&utm_medium=repo&utm_campaign=specflow-selenium-sample)    

## TestMu AI Community :busts_in_silhouette:

The [TestMu AI Community](https://community.testmuai.com/?utm_source=github&utm_medium=repo&utm_campaign=specflow-selenium-sample) allows people to interact with tech enthusiasts. Connect, ask questions, and learn from tech-savvy people. Discuss best practises in web development, testing, and DevOps with professionals from across the globe 🌎

## What's New At TestMu AI ❓

To stay updated with the latest features and product add-ons, visit [Changelog](https://changelog.lambdatest.com/)

## 🚀 LambdaTest is Now TestMu AI

👋 Welcome to TestMu AI, the next evolution of LambdaTest. As of January 2026, [LambdaTest is Now TestMu AI](https://www.testmuai.com/lambdatest-is-now-testmuai/) - we have evolved from a cross-browser testing cloud into a unified, AI-native quality engineering platform designed for the modern DevOps era.

Whether you have been part of the LambdaTest community for years or are just discovering TestMu AI, our mission remains the same: to help you ship faster with high-scale test execution, autonomous testing, and deep quality analytics.

### 🔄 Our Rebrand Journey

In 2017, we introduced LambdaTest with a clear mission: to become the world's most trusted cloud testing platform. We built a scalable, high-performance test cloud that eliminated flakiness, improved developer feedback cycles, and accelerated release velocity for teams worldwide.

As LambdaTest grew, we expanded the platform into Test Intelligence, Visual Regression Testing, Accessibility Testing, API Testing, and Performance Testing, covering the entire testing lifecycle. These capabilities enabled teams to test any stack, on any technology, at enterprise scale.

Over time, we rebuilt the architecture to be AI-native from the ground up. What began as LambdaTest's high-performance testing cloud has now evolved into TestMu AI, an AI-native, multi-agent platform redefining modern quality engineering.

We chose the name TestMu AI to reflect our shift towards intelligent, autonomous testing. While our identity has changed, our core technology and commitment to the testing community stay the same.

👉 Find [LambdaTest's New Home](https://www.testmuai.com/).

### 🔭 Explore TestMu AI

The same infrastructure LambdaTest customers relied on, now delivered through autonomous AI agents.

- [KaneAI](https://www.testmuai.com/kane-ai/)
- [Agent-to-Agent Testing](https://www.testmuai.com/agent-to-agent-testing/)
- [HyperExecute](https://www.testmuai.com/hyperexecute/)
- [Real Device Cloud](https://www.testmuai.com/real-device-cloud/)
- [Pricing](https://www.testmuai.com/pricing/)
- [Documentation](https://www.testmuai.com/support/docs/)