# ActionResult

- ActionResult is a class, that represents "result of an action method"
- Asp.Net Mvc recommends to specify action method's return type as "ActionResult".
- ActionResult is an abstract class that has several child classes, you can return an object of any of the child classes.
    - ContentResult, ViewResult, FileResult, PartialViewResult, RedirectResult, RedirectToRouteResult, JsonResult

|ActionResult|Description|
|:-:|:-:|
|`ContentResult`|Represents any content with specific content-type|
|`ViewResult`|Represents result of a view.|
|`FileResult`|Represents content of a file.|
|`JsonResult`|Represents json object / json array.|
|`RedirectResult`|Represents redirection to other website (HTTP 302).|
|`RedirectToRouteResult`|Represents redirection to a specific action method (HTTP 302).|
|`PartialViewResult`|Represents the result of partial view.|

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








