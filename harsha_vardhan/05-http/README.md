# What is HTTP?

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
