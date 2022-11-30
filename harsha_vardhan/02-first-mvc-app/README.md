# Action Methods

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