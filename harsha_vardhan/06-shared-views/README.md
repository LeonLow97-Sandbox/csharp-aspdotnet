# Shared Views

- Shared views are present in the `Views\Shared` folder.
- Shared views are the views that can be called from any controller of the entire project.
- The views that belongs to all controllers are created as shared views.
- When we call a view, it checks for the view in the `Views\ControllerName` folder first; if it is not found, it will search in the `Views\Shared` folder.
- In VS Code, Add View --> Layout page
- passing common data through viewbag to the shared view.