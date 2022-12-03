# View Engines

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




