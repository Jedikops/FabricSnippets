## Office Fabric UI Snippets for VS Code ##

**Release Date**: March 25, 2016

**Status**: 1.0

**Provided By**: Sector 43 Software (David Mann)

**Details**: [s43.io/FabricSnippets](http://s43.io/FabricSnippets)

**Based on**: Fabric release 2.01 (Feb 5, 2016)

----------


These snippets are intended to make the [Office UI Fabric](https://github.com/OfficeDev/Office-UI-Fabric) easier to use.  In general, the HTML is taken directly from the Office UI Fabric GitHub repository, with some tweaking.

Snippets generally fall into one of two flavors:


- **Simple Components**: these have no JavaScript elements and so the snippet just expands into the correct HTML to render the component

- **Complex Components**: these aren't really "complex" they simply have some JavaScript associated with them.  In these cases, there is a snippet for the component and one for an example of the JavaScript required to make the component work.

All of the core snippets have a trigger that starts with **uif-** so you can see what's available by simply typing **uif-** and looking at the Intellisense popup shown by VS Code.
These snippets were originally developed for my [Pluralsight course](http://s43.io/FabricCourse2) so there are a handful of snippets that I built for the demos in that course.  I've left them in just in case they provide value, or if you're following along with the course.  Here's the info on them:

- **htmlShell** - Creates the shell of an HTML page with the proper doctype for Fabric
- **jsAddPeoplePickerResult** - sample code for adding a result into the Peoplepicker
- **gridRefRow** - adds a single grid row with each cell set to 1 column wide.  Useful for building a grid below and having a reference to see how many columns each cell takes up
- **gridDemoStyle** - some style overrides used to differentiate the sample grid in the course
- **gridDemoRows** - inserts the sample markup for a three column grid used as a demo in the course
- **callOutPositioning** - sample styles for positioning a callOut
- **callOutPositioningJS** - sample code for showing the callout in the demo
- **spinnerDemo** - sample markup for working with the Spinner component
- **commandBarDemo** - sample code for adding a ContextualMenu to a CommandBar
- **progressDemo** - sample code and markup for the Progress Indicator demo




#Installation Instructions#

For the time being, installation is manual.  Once I've ironed out any bugs, I'll make a true VS Code extension and deploy it to the Extension Gallery.  At that point, I'll also create a Visual Studio Extension and deploy that to the Visual Studio Gallery as well.  If there is interest, I'll convert the snippets to other editors - Sublime is one I'm considering, but am open to other suggestions as well.

To Install:

- Open the file *VSCodeFabricSnippets.txt* from the GitHub repo (direct link: [https://raw.githubusercontent.com/Sector43/FabricSnippets/master/VSCodeFabricSnippets.txt](https://raw.githubusercontent.com/Sector43/FabricSnippets/master/VSCodeFabricSnippets.txt) 
- Select all of the contents and copy it to the clipboard
- In VS Code, click **File | Preferences | User Snippets** and select **HTML** from the Language dropdown
- Paste the contents from the GitHub file into the *html.json* file that is now open in VS Code
- Save the *html.json* file and close it

The snippets are now available when you are editing an HTML file in VS Code.  (**NOTE**: Snippets in VS Code only seem to work if the HTML file is open as part of a folder, not if you just open a standalone file.  I'm looking into whether this is really true, and if so whether it is by design or a bug)

Installation and usage is shown in the short video here: [https://youtu.be/VsfUTwgNdgg](https://youtu.be/VsfUTwgNdgg)

## Known Issues ##
- None

Please report other issues here: [https://github.com/Sector43/FabricSnippets/issues](https://github.com/Sector43/FabricSnippets/issues)


