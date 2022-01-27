# Fixing Style Issues in "Hello, world!" app

This is a beginner level task for practicing AutoCode tasks management. Translations: [Russian](README-RU.md).


## Get the Project

* [Open a project from your remote repository](https://docs.microsoft.com/en-us/visualstudio/get-started/tutorial-open-project-from-repo) or [get your local copy](https://docs.microsoft.com/en-us/azure/devops/repos/git/clone#clone-from-another-git-provider) with Visual Studio.


## Complete the Task

1. [Build the solution](https://docs.microsoft.com/en-us/visualstudio/ide/building-and-cleaning-projects-and-solutions-in-visual-studio).
    * Click on menu item - _Build\Build Solution_.
    * Or use default keyboard shortcut - _Ctrl+Shift+B_.
1. Open [Error List](https://docs.microsoft.com/en-us/visualstudio/ide/find-and-fix-code-errors#review-the-error-list) view.
    * Click on menu item - _View\Error List_.
    * Or use default shortcut - _Ctrl+W, E_.
1. Double-click on a warning in the Error List view. You will get to the [HelloWorld.cs](HelloWorldStyle/HelloWorld.cs) file.
1. Open Error List view again, and click on a warning "Code" link. You will get to a documentation web-page for a warning.
1. Go to the [HelloWorld.cs](HelloWorldStyle/HelloWorld.cs) file, and format the current document.
    * Use default shortcut - _Ctrl+K, Ctrl+D_.
1. Build the solution again, open Error List view, and compare the number of compiler warnings with the previous number.
1. Fix all compiler warnings in the [HelloWorld.cs](HelloWorldStyle/HelloWorld.cs) file.


## Fix Compiler Issues

Additional style and code checks are enabled for the projects in this solution to help you maintaining consistency of the project source code and avoiding silly mistakes. [Review the Error List](https://docs.microsoft.com/en-us/visualstudio/ide/find-and-fix-code-errors#review-the-error-list) in Visual Studio to see all compiler warnings and errors.

If a compiler error or warning message is not clear, [review errors details](https://docs.microsoft.com/en-us/visualstudio/ide/find-and-fix-code-errors#review-errors-in-detail) or google the error or warning code to get more information about the issue.

Also, you can use [Sonar rule knowledge database](https://rules.sonarsource.com/csharp) for searching more detailed information regarding detected Sonars' issues.


## Save Your Work

* [Rebuild your solution](https://docs.microsoft.com/en-us/visualstudio/ide/building-and-cleaning-projects-and-solutions-in-visual-studio) in Visual Studio.
* Check out the [Error List window](https://docs.microsoft.com/en-us/visualstudio/ide/reference/error-list-window) for compiler errors and warnings. If you have any of those issues, **fix issues** and rebuild the solution again.
* [Run all unit tests with Test Explorer](https://docs.microsoft.com/en-us/visualstudio/test/run-unit-tests-with-test-explorer) and make sure there are **no failed unit tests**. Fix your code to [make all your unit tests GREEN](https://stackoverflow.com/questions/276813/what-is-red-green-testing).
* Review all your changes **before** saving your work.
    * Open "Changes" view in [Team Explorer](https://docs.microsoft.com/en-us/visualstudio/ide/reference/team-explorer-reference).
    * Click with your right mouse button on a modified file.
    * Click on "Compare with Unmodified" menu item to open a comparison window.
* [Stage your changes](https://docs.microsoft.com/en-us/azure/devops/repos/git/commits#stage-your-changes) and [create a commit](https://docs.microsoft.com/en-us/azure/devops/repos/git/commits#create-a-commit).
* Share your changes by [pushing them to remote repository](https://docs.microsoft.com/en-us/azure/devops/repos/git/pushing).


## See also

* Visual Studio
  * [Getting Started with Visual Studio 2019](https://www.youtube.com/watch?v=1CgsMtUmVgs)
  * [Git Fundamentals](https://www.youtube.com/watch?v=c3482qAzZLQ)
  * [Default keyboard shortcuts in Visual Studio](https://docs.microsoft.com/en-us/visualstudio/ide/default-keyboard-shortcuts-in-visual-studio)
