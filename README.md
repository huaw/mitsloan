# MIT Sloan

#1. Setting up your development environment
(Episerver can be conveniently installed through Visual Studio and the Episerver Visual Extensions, providing everything you need to get a sample website up and running and get started developing.)
 * Install Visual Studio 2015 above (Pro version is recommended)
 * Install Resharper (https://www.jetbrains.com/resharper/) for on-the-fly code quality analysis
 * Install Microsoft SQL Server 2016 and SQL Server Management Studio (If you install the free express version, recommend to install the version with Advanced Services Features)
 * Install the Episerver Visual Studio extensions. Using the extension package for Episerver CMS you can set up a project with a database, required NuGet references. (Select Tools > Extensions and Updates.In the extensions window, select Online, and type "episerver" in the search box.Select Episerver CMS Visual Studio Extension and click Install (or Update if already installed).
 * Within the Visual Studio, in your nuget package Manager Settings Tools->Nuget package Manager->Package Manager Settings->Nuget Package Manager->Package Sources, add Episerver NuGet source: Episerver nuget feed: http://nuget.episerver.com/feed/packages.svc
 * Use the Visual Studio to open the project solution file MITSloan.sln
 * Set your local solution to use "Develop" solution configuration
 * Set the Visual Studio solution's start project to MITSloan.Website 
 * The initial database backup file dbEPiServerMITSloan.bak is place in the repository folder MITSloan.Data
 * Set up a database using dbEPiServerMITSloan.bak in SQL Server
 * Once the solution is build successfully, run the website locally (you can use the IIS express with Visual Studio, or run the site as local IIS website)
 * To run the site with FE style and Javascript, cd into `Website/Client` then do a "npm i" and "gulp build" (Assume node.js, gulp installed) (Please refer to front end setup for detailed instruction)
 * If you need to access the content editor area, go to /admui/. (the initial webadmin username and password is : initialadministrator / 3p!Pass )
 
#2. Environments
 * Local development environment settings (no transformation applied) (Note: Dev Ops is needed)
      ** in EPiServerLog.config, look for "errorFileLogAppender", update the log file path accordingly
	  ** in EPiServerLog.config, look for "<root>", update the level accordingly
	  ** in Config/connectionStrings.config, look for "EPiServerDB", update the connectionStrings accordingly
	  ** in EPiServer.Framework.config, look for "appData", update the basePath accordingly
	  ** in System.Net.MailSettings.Smtp.config, look for "specifiedPickupDirectory", update the pickupDirectoryLocation (note this is for local development)
	  ** in System.ServiceModel.Services.config, the endpoint is disabled for local development
	  ** in System.Web.Compilation.config, debug is set to true for local development      
 * CI DEV (Dev Ops is managed by MIT; Continuous Build and deployment is via Bamboo Build Server): http://oc-episerver-dev.azurewebsites.net/
 * QA (Dev Ops is managed by MIT; Continuous Build and deployment is via Bamboo Build Server): http://oc-episerver-prod-staging.azurewebsites.net/
 * Stage (TBD)
 * Prod (TBD)
 
#3. Software for the local development
 * Microsoft Visual studio 2015 or above
 * .net framework 4.6 if this is not installed in the machine
 * Microsoft SQL Server 2016 and SQL Server Management Studio
 * Node.js
 * Gulp
 * Resharper
 
#4. Possible software needed for the build server
 * Powershell
 * MSBuild
 * .net framework 4.6 if this is not installed in the server
 * Command Lind
 * Node.js
 * Gulp
 
#5. Code Analysis
All Starter Kit project Code Analysis is using "Microsoft Managed Recommended Rules".
 * "Microsoft Managed Recommended Rules" Description:
These rules focus on the most critical problems in your code, including potential security holes, application crashes, and other important logic and design errors. You should include this rule set in any custom rule set you create for your projects.
 
#6. NuGet used packages used for the starter kit solution
  Antlr.3.4.1.9004
  Castle.Core.3.3.3
  Castle.Windsor.3.3.0
  EntityFramework.6.1.3
  EPiServer.CMS.10.7.0
  EPiServer.CMS.Core.10.7.0
  EPiServer.CMS.UI.10.8.0
  EPiServer.CMS.UI.AspNetIdentity.10.8.0
  EPiServer.CMS.UI.Core.10.8.0
  EPiServer.Framework.10.7.0
  EPiServer.Logging.Log4Net.2.1.0
  EPiServer.Packaging.3.3.0
  EPiServer.Packaging.UI.3.3.0
  log4net.2.0.3
  Lucene.Net.3.0.3
  Microsoft.AspNet.Identity.Core.2.2.1
  Microsoft.AspNet.Identity.EntityFramework.2.2.1
  Microsoft.AspNet.Identity.Owin.2.2.1
  Microsoft.AspNet.Mvc.5.2.3
  Microsoft.AspNet.Providers.Core.2.0.0
  Microsoft.AspNet.Razor.3.2.3
  Microsoft.AspNet.Web.Optimization.1.1.3
  Microsoft.AspNet.WebApi.Client.5.2.3
  Microsoft.AspNet.WebApi.Core.5.2.3
  Microsoft.AspNet.WebApi.WebHost.5.2.3
  Microsoft.AspNet.WebPages.3.2.3
  Microsoft.Owin.3.0.1
  Microsoft.Owin.Host.SystemWeb.3.0.1
  Microsoft.Owin.Security.3.0.1
  Microsoft.Owin.Security.Cookies.3.0.1
  Microsoft.Owin.Security.OAuth.3.0.1
  Microsoft.ReportViewer.Common.10.0.40219.1
  Microsoft.ReportViewer.WebForms.10.0.40219.1
  Microsoft.Tpl.Dataflow.4.5.24
  Microsoft.Web.Infrastructure.1.0.0.0
  Newtonsoft.Json.9.0.1
  nJupiter.Configuration.4.0.4.516
  NuGet.Core.2.5.0
  Owin.1.0
  SharpZipLib.0.86.0
  structuremap.web-signed.3.1.6.191
  structuremap-signed.3.1.9.463
  WebGrease.1.5.2
  