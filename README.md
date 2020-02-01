# UmbracoMvcHelpers
Umbraco website demonstrating how MVC helpers can be used.
This sample website is very simple - a list of events and event details.  

The true benefit of HTML helpers comes with more complicated sites when it can be hard to maintain consistent, reusable code across many views.
But hopefully even this simple site can help you see the potential power of MVC Html helpers - look at EventsPage.cshtml especially to see how much simpler using the HTML helpers can be in comparison with the standard techiques.

### Getting started
Download this repo, build with nuget package restore, then view in browser

The default installation was used, so the database is in the repo: App_Data/umbraco.sdf

### Backoffice Login
Username: admin; Password: password

### Strongly typed models with Ditto
A controller has been added for each document type (inheriting from RenderMvcController) which is where Ditto creates the strongly typed models

### Coming soon ...
- EditorFor, LabelFor, ValidationMessageFor examples
- Custom scaffolding templates to speed up coding

If those would be of interest to you please tweet me @lottepitcher to encourage me to get those added...!
