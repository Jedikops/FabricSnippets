## Office Fabric UI Snippets for VS Code ##

**Release Date**: Dec 9, 2016

**Version**: 1.2.0*

**Provided By**: Sector 43 Software (David Mann)

**Based on**: Fabric JS release 1.2 (Nov 4, 2016)

**Status**: Stable

----------
(\* : Release numbers are now synchronized with the version of Fabric upon which they are based)

These snippets are intended to make the components from the  [Office UI Fabric](https://github.com/OfficeDev/Office-UI-Fabric-JS) project easier to use.  In general, the HTML and Javascript is taken directly from the Office UI Fabric GitHub repository, with some tweaking.

All of the core snippets have a trigger that starts with **uif** so you can see what's available by simply typing **uif** and looking at the Intellisense popup shown by VS Code.
These snippets were originally developed for my [Pluralsight course](http://s43.io/FabricCourse2).

In some cases, the snippets are a combination of shortcut and learning tool.  For example, some snippets contain both the markup and the JS code required by the component.  Consider these a starting point - you will need to tweak the code to suit your needs, but the snippet at least gets everything you need onto the page.




#Installation Instructions#

- Open the file *VSCodeFabricSnippets.txt* from the GitHub repo (direct link: [https://raw.githubusercontent.com/Sector43/FabricSnippets/master/VSCodeFabricSnippets.txt](https://raw.githubusercontent.com/Sector43/FabricSnippets/master/VSCodeFabricSnippets.txt) 
- Select all of the contents and copy it to the clipboard
- In VS Code, click **File | Preferences | User Snippets** and select **HTML** from the Language dropdown
- Paste the contents from the GitHub file into the *html.json* file that is now open in VS Code
- Save the *html.json* file and close it

The snippets are now available when you are editing an **HTML** file in VS Code.  

Installation and usage is shown in the short video here: [https://youtu.be/VsfUTwgNdgg](https://youtu.be/VsfUTwgNdgg)  Note that while this video is for the previous release of the snippets, installation and usage are essentially the same.

## Known Issues ##
- None

## Generating Visual Studio Snippets ##
Paul Schaeflein contributed a small console application that will generate a Visual Studio .snippet file for each snippet in the VSCode snippet file.  It doesn't handle replaceable parameters (which are actually removed from the 1.2.0 release of the VSCode snippets anyway) but it gets most of the drudgery work done.  The code is available in the **SnippetConverter** folder of the repo. 

## Reporting Bugs ##

Please report issues here: [https://github.com/Sector43/FabricSnippets/issues](https://github.com/Sector43/FabricSnippets/issues)


