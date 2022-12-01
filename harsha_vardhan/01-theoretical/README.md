# What is ASP.NET MVC?

- ASP.NET MVC is a Web Application Framework, that gives you a powerful, MVC architecture-based way to build dynamic web applications that enables a clean separation of concerns that gives you full control over markup.
- Main Advantages:
    - Clean separation of concerns (develop model, view and controller independently)
    - Faster performance (no server controls required)

## What is MVC?

- MVC is an architectural pattern that dictates you to write the application code as composition of 3 major parts.
- Model
    - Data Structure
    - Business Logic
        - File or Database
- View
    - Presentation Logic
    - Reads data from Model
- Controller
    - Defines execution flow
    - Execution starts from controller
    - Fills data into model object
    - Pass model objects to view

## Why ASP.NET MVC?

- Advantages:
    - Supports Clean Separation of Concerns
    - Supports Unit Testing
    - Supports Dependency Injection
    - Supports Faster Performance than ASP.NET Web Forms.
    - No Page Life Cycle, Controls, Postback and ViewState.

# Controllers

- Controller is a class that defines execution flow in MVC application.
- Controller receives request from browser, call the model, call the view.

## Controllers - Development

- Controller is a class.
- Optionally, it is a public class.
- Controller should be inherited from `System.Web.Mvc.Controller` class.
- Controller's name should have suffix "Controller". E.g., "HomeController"

# Action Methods

- Executes when browser sends request.
- Performs action on database and returns result to users.

# ASP.NET MVC vs ASP.NET Web Forms

|ASP.NET MVC|ASP.NET Web Forms|
|:-:|:-:|
|Supports clean separation of concerns.|Presentation Logic (.aspx) and Event Logic (.aspx.cs) are tightly coupled.|
|Business logic layer, Controllers are unit testable.|Presentation Logic and Application Logic are not unit testable.|
|Supports Dependency Injection.|Doesn't support dependency injection.|
|Faster performance|Slower performance|
|No page life cycle, controls, postback and ViewState.|Supports page life cycle, controls, postback and ViewState.|
|Runs based on the principle of "Web is stateless".|Hides the "stateless nature of web" and tries to mask the developers as they are in "stateful" environment.|

# Folder Structure of MVC App

|Project Folder|Description|
|:-:|:-:|
|`\App_Start`|Contains the files that needs to be executed on the first request.|
|`\App_Data`|Contains SQL Server LocalDb Database Files.|
|`\Controllers`|Contains all controllers.|
|`\Models`|Contains all models|
|`\Views`|Contains all views|
|`\Views\web.config`|Contains configuration settings for all views.|
|`\Global.asax`|Contains application level and session level events.|
|`\packages.config`|Contains the list of NuGet packages currently installed in the project.|
|`\Web.config`|Contains web application configuration settings, that needs to be initialized on each request.|

# NuGet Packages of ASP.NET MVC

- `Microsoft.AspNet.Mvc`
    - Contains the necessary DLL files that are needed to execute ASP.NET MVC applications.
        - namespace `System.Web.Mvc`
- `Microsoft.AspNet.Razor`
    - Contains the necessary DLL files that are needed to execute Razor views in MVC.
- `Microsoft.AspNet.WebPages`
    - Contains the necessary DLL files that are needed to execute HTML Helpers in Razor Views.
- `Microsoft.CodeDom.Providers.DotNetCompilerPlatform`
    - Contains a new generation .net compiler called Roslyn compiler.
- `Microsoft.Web.Infrastructure`
    - Necessary to dynamically register HTTP modules at runtime.























