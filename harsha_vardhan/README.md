# Chapter 1 : Intro. to ASP.NET MVC

## What is ASP.NET MVC?

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

## Controllers

- Controller is a class that defines execution flow in MVC application.
- Controller receives request from browser, call the model, call the view.

### Controllers - Development

- Controller is a class.
- Optionally, it is a public class.
- Controller should be inherited from `System.Web.Mvc.Controller` class.
- Controller's name should have suffix "Controller". E.g., "HomeController"

## Action Methods

- Executes when browser sends request.
- Performs action on database and returns result to users.

## ASP.NET MVC vs ASP.NET Web Forms

|                      ASP.NET MVC                      |                                              ASP.NET Web Forms                                              |
| :---------------------------------------------------: | :---------------------------------------------------------------------------------------------------------: |
|        Supports clean separation of concerns.         |                 Presentation Logic (.aspx) and Event Logic (.aspx.cs) are tightly coupled.                  |
| Business logic layer, Controllers are unit testable.  |                       Presentation Logic and Application Logic are not unit testable.                       |
|            Supports Dependency Injection.             |                                    Doesn't support dependency injection.                                    |
|                  Faster performance                   |                                             Slower performance                                              |
| No page life cycle, controls, postback and ViewState. |                         Supports page life cycle, controls, postback and ViewState.                         |
|  Runs based on the principle of "Web is stateless".   | Hides the "stateless nature of web" and tries to mask the developers as they are in "stateful" environment. |

## Folder Structure of MVC App

|   Project Folder    |                                          Description                                           |
| :-----------------: | :--------------------------------------------------------------------------------------------: |
|    `\App_Start`     |               Contains the files that needs to be executed on the first request.               |
|     `\App_Data`     |                          Contains SQL Server LocalDb Database Files.                           |
|   `\Controllers`    |                                   Contains all controllers.                                    |
|      `\Models`      |                                      Contains all models                                       |
|      `\Views`       |                                       Contains all views                                       |
| `\Views\web.config` |                         Contains configuration settings for all views.                         |
|   `\Global.asax`    |                      Contains application level and session level events.                      |
| `\packages.config`  |            Contains the list of NuGet packages currently installed in the project.             |
|    `\Web.config`    | Contains web application configuration settings, that needs to be initialized on each request. |

## NuGet Packages of ASP.NET MVC

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

# Chapter 2: Creating First MVC App

## Action Methods

- Controller contains actions methods.
- Action methods does not provide view.
- Action method invokes the view and supply data to the view.
- Action methods are used to read, update data.
- `ActionResult` (parent class)
  - child classes: `RedirectToRoute`
- ViewName and Action name are usually the same
  - if different, `return View("OtherView")`. Specify other view name.

## Installing Packages on NuGet

- Tools --> NuGet Package Manager --> Package Manager Console
- `install-package jQuery -Version 3.6.0`
- `install-package popper.js -Version 1.16.1`
- `install-package Bootstrap -Version 4.6.0`

# Chapter 3: Action Result

## ActionResult

- ActionResult is a class, that represents "result of an action method"
- Asp.Net Mvc recommends to specify action method's return type as "ActionResult".
- ActionResult is an abstract class that has several child classes, you can return an object of any of the child classes.
  - ContentResult, ViewResult, FileResult, PartialViewResult, RedirectResult, RedirectToRouteResult, JsonResult

|      ActionResult       |                          Description                           |
| :---------------------: | :------------------------------------------------------------: |
|     `ContentResult`     |       Represents any content with specific content-type        |
|      `ViewResult`       |                  Represents result of a view.                  |
|      `FileResult`       |                 Represents content of a file.                  |
|      `JsonResult`       |              Represents json object / json array.              |
|    `RedirectResult`     |      Represents redirection to other website (HTTP 302).       |
| `RedirectToRouteResult` | Represents redirection to a specific action method (HTTP 302). |
|   `PartialViewResult`   |             Represents the result of partial view.             |

```cs
return Content(string Content, string ContentType);
return  View(string ViewName);
return File(string FilePath, string ContentType);
return Json(object data, JsonRequestBehavior behavior);
return Redirect(string url);
return RedirectToAction(string ActionName, string ControllerName);
return PartialView(string ViewName);
```

## `RedirectResult`

- The class's object represents redirection from an action method to other website.
- It sends HTTP 302 response to the browser; so the browser sends another request to the specific url.
- The Redirect() method creates and returns an object of "RedirectResult" class.
- Syntax: `return Redirect("url");`

## `RedirectToAction`

- This class's object represents redirection from one action method to another action method.
- It sends HTTP 302 response to the browser; so the browser sends another request to the specific action method.
- The `RedirectToAction()` method creates and returns an object of "RedirectToRouteResult" class.
- Syntax: `return RedirectToAction("action name", "controller name");`

# Chapter 4: Razor View Engine

## View Engines

- Swap between HTML code and C# code.
- Include `@{ C# Code }`
- View Engine provides a set of syntaxes to write C#.NET code (server side code) in the view.
- View Engine is also responsible to render the view as html.
- ASP.NET MVC supports 2 types of view engines:
  - ASPX View Engine
  ```
      <%
          C#.NET Code
      %>
  ```
  - Razor View Engine
  ```
      @{
          C#.NET Code
      }
  ```

## ASPX vs Razor

|                  ASPX View Engine                   |                        Razor View Engine                         |
| :-------------------------------------------------: | :--------------------------------------------------------------: |
| ASPX is older view engine, supported in MVC 1,2,3,4 | Razor is latest and advanced view engine, supported in MVC 3,4,5 |
|              File extension is `.aspx`              |            File extension is `.cshtml` (or `.vbhtml`)            |
| Syntax is cumbersome, when used in real-world views |            Syntax is very clear, clean and expression            |
|      Can't write html tags in the code blocks       |              Can write html tags in the code blocks              |

## Using `ViewBag`

- In Controller

```cs
public ActionResult StudentDetails()
{
    ViewBag.StudentId = 101;
    return View();
}
```

- In View

```html
<tr>
  <td>Student Id</td>
  <td>@ViewBag.StudentId</td>
</tr>
```

## Razor Code

- In View

```html
@{ string StudentResult; if (ViewBag.Marks >= 35) { StudentResult = "Pass"; } else { StudentResult = "Fail"; } }

<tr>
  <td>Result</td>
  <td>@StudentResult</td>
</tr>
```

## Razor If

```html
<td colspan="2">
  @if (StudentResult == "Pass") {
  <span class="text-success">Congratulations!</span>
  } else {
  <span class="text-danger">Better luck next time!</span>
  }
</td>
```

## Razor For Loop

```html
<ul>
  @for (int i = 1; i <= ViewBag.NoOfSemesters; i++) {
  <li>@i</li>
  }
</ul>
```

## Razor Foreach

- In Controller:

```cs
ViewBag.Subjects = new List<string>() { "Maths", "Physics", "Chemistry" };
```

- Use `@foreach` when reading data from an array of collection
- In View:

```html
<ul>
  @foreach (var subject in ViewBag.Subjects) {
  <li>@subject</li>
  }
</ul>
```

# Chapter 5: HTTP

## What is HTTP?

- HTTP is an application-protocol that defines set of rules to send request from browser to server and send response from server to browser.

## HTTP Concepts

- HTTP Request Message Format
- HTTP Methods
- HTTP Request Headers
- HTTP Response Message Format
- HTTP Response Headers
- HTTP MIME Types
- HTTP Status Codes

### HTTP Request Message Format

- Request Start Line
  - `<Method> <Url> HTTP/1.1`
  - E.g., `GET /customer/dashboard.html HTTP/1.1`
- Request Headers
  - Key:Value pairs to send to server
- Empty Line: separates request headers and request body
- Request Body
  - Content to sent to server

### HTTP Methods

|                               GET                               |                                  POST                                  |
| :-------------------------------------------------------------: | :--------------------------------------------------------------------: |
|                Used to retrieve data from server                |            Used to perform insert/update/delete operations             |
|    Parameters will be appended to the Url as "query string".    | Parameters are not sent in the url, but will be sent in "request body" |
| Parameters will be displayed in the address bar of the browser. |  Parameters will not be displayed in the address bar of the browser.   |
|            Can pass limited no. of characters only.             |                        Can send unlimited data.                        |
|         Can be cached by the browser / search engines.          |            Can't be cached by the browser / search engines.            |
|  Can pass only ASCII characters; can't pass Unicode characters  |               Supports Unicode characters / binary data.               |

- Note: "binary data" like files and images.

### HTTP Request Headers

- Accept: Informs the server what type of content the client is expecting. E.g., text/html
- Accept-language: Informs the server which language content the client is expecting. E.g., en-US
- Content-Type: MIME type of request body (useful for POST and PUT)
  - E.g., text/x-www-form-urlencoded OR multipart/form-data
- Content-Length: Length of the request body (useful for POST and PUT). E.g., 100
- Data: Date and time of request. E.g., Tue, 15 Nov 1994 08:12:31 GMT
- Host: Server domain name. E.g., www.website.com
- User-Agent: Browser details: E.g., Mozilla/5.0 Firefox/12.0
- Cookie: Contains cookies to send to server. E.g., x=100

```
GET /docs/index.html HTTP/1.1
Host: www.nowhere123.com
Accept: image/gif, image/jpeg, */*
Accept-Language: en-us
Accept-Encoding: gzip, deflate
User-Agent: Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)
(blank line)
```

### HTTP Response Headers

- Cache-Control: Indicates Browser cache should be enabled or not. E.g., max-age = 60
- Set-Cookie: Contains cookies to send to browser. E.g., x=100
- Content-Type: MIME type of response body. E.g., text/plain
- Content-Length: Length of response body. E.g., 100

```
HTTP/1.1 200 OK
Date: Sun, 18 Oct 2009 08:56:53 GMT
Server: Apache/2.2.14 (Win32)
Last-Modified: Sat, 20 Nov 2004 07:16:26 GMT
Content-Length: 44
Connection: close
Content-Type: text/html
X-Pad: avoid browser bug

<html><body><h1>It works!</h1></body></html>
```

### HTTP MIME Types

- text/plain, text/html, text/css, text/javascript, application/json, text/xml, image/png, image/jpeg, audio/mp3, video/mp4

### HTTP Status Codes

- 100: Continue
- 200: OK
- 302: Redirection
- 304: Modified
- 400: Bad Request
- 401: Unauthorized
- 404: Not Found

## Request

- The `Request` object contains request details sent from browser to server.
  - Member of `System.Web.Mvc.Controller` class.
  - Type `System.Web.RequestBase`

|        Request Properties         |                   Description                    |
| :-------------------------------: | :----------------------------------------------: |
|           `Request.Url`           |             Represents current url.              |
| `Request.PhysicalApplicationPath` |         Represents current folder path.          |
|          `Request.Path`           |         Represents current virtual path.         |
|      `Request.Browser.Type`       |         Represents current browser name.         |
|       `Request.QueryString`       |         Represents current query string.         |
|         `Request.Headers`         |   Represents request headers (key/value pairs)   |
|       `Request.HttpMethod`        | Represents http method of the request (GET/POST) |

```cs
public ActionResult RequestExample()
{
    ViewBag.Url = Request.Url;
    ViewBag.PhysicalApplicationPath = Request.PhysicalApplicationPath;
    ViewBag.Path = Request.Path;
    ViewBag.BrowserType = Request.Browser.Type;
    ViewBag.QueryString = Request.QueryString["username"];
    ViewBag.Headers = Request.Headers["Accept"];
    ViewBag.HttpMethod = Request.HttpMethod;
    return View();
}
```

## Response

- The "Response" object contains the content that is to be sent from server to browser.
  - Member of `System.Web.Mvc.Controller` class.
  - Type `System.Web.RequestBase`

|  Response Properties   |                             Description                              |
| :--------------------: | :------------------------------------------------------------------: |
|   `Response.Write()`   |                 Sends given content to the browser.                  |
| `Response.ContentType` |         Represents type of response content. E.g., text/html         |
|   `Response.Headers`   | Represents response headers that can be sent from server to browser. |
| `Response.StatusCode`  |          Represents status of request. E.g., 200, 302, etc.          |

# Chapter 6: Shared Views

## Shared Views

- Shared views are present in the `Views\Shared` folder.
- Shared views are the views that can be called from any controller of the entire project.
- The views that belongs to all controllers are created as shared views.
- When we call a view, it checks for the view in the `Views\ControllerName` folder first; if it is not found, it will search in the `Views\Shared` folder.
- In VS Code, Add View --> Layout page
- passing common data through `ViewBag` to the shared view.

# Chapter 7: Layout Views

## Layout Views

- Layout views contain "page template", which contains common parts of the UI, such as logo, header, menubar, etc.
- `@RenderBody()` method represents the reserved area for the actual content of view.
- _Execution Flow_: Controller --> View --> Layout View --> Rendered View Result --> Send response to browser.
- One View can only have 1 Layout View.

## Create a Layout View

1. Created Shared Folder in Views
2. Create new item in shared folder

- Web --> MVC --> MVC 5 Layout Page (Razor)

- The `@RenderBody()` method must be present in the LayoutView.cshtml file.

```html
<div class="container-fluid">@RenderBody()</div>
```

- In other controllers, add view and select '_use a layout page_'

```cs
@{
  // if "Home" is specified here, ViewBag.Title value can be accessed in LayoutView.cshtml
  // because the execution flow is View --> Layout View
    ViewBag.Title = "Home";
    Layout = "~/Views/Shared/_LayoutPage1.cshtml";
}
```

## Sections in Layout Views

- Sections are used to display view-specific content in the layout view.
- Sections are defined in the view and rendered in the layout view.

```cs
// Layout View
@RenderSection("section name")

// Optional to provide a section
@RenderSection("section name", required: false)
```

```cs
// View
@section sectionname
{
  Content Here
}
```

## `_ViewStart.cshtml`

- It defines the **default layout view of all the views of a folder**.
- If it is present in the "Views" folder, it defines the default layout view of all the views of entire project.
- If it is present in `View\ControllerName` folder, it defines the default layout view of all the views of same controller only.
- _Execution Flow_: Controller --> \_ViewStart.cshtml of "Views" folder --> \_ViewStart.cshtml of "Controller1" folder --> View --> Layout View --> Generate View Result --> Response

```cs
// In _ViewStart.cshtml
@{
  Layout = "Path of Layout View"
}
```

## Partial Views

- Partial View is a small view that contains content that can be shared among multiple views.
- Can be present in "Views\ControllerName" folder or in "Views\Shared" folder.

#### Example:

- Created a file called `PartialView.cshtml` with some content.
- In View1.cshtml

```cs
@{Html.RenderPartial();}
```

- In View2.cshtml

```cs
@{Html.RenderPartial();}
```

## View vs Partial View

|                                 View                                  |                                       Partial View                                       |
| :-------------------------------------------------------------------: | :--------------------------------------------------------------------------------------: |
|                    View can contain a layout page.                    |                       Partial view doesn't contain a layout page.                        |
| `_ViewStart.cshtml` file will be called before the execution of view. |        `_ViewStart.cshtml` file will not be called before the execution of view.         |
| View can have html structured elements such as html, head, body, etc. | Partial view doesn't contain any html structured elements such as html, head, body, etc. |
