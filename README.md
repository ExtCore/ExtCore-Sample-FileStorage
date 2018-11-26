# ExtCore Framework 4.0.0-alpha2 Sample Web Application That Uses File Storage

[![Join the chat at https://gitter.im/ExtCore/ExtCore](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/ExtCore/ExtCore?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

## Introduction

[ExtCore](https://github.com/ExtCore/ExtCore) is free, open source and cross-platform framework for creating
modular and extendable web applications based on ASP.NET Core. It is built using the best and the most modern
tools and languages (Visual Studio 2017, C# etc). Join our team!

This is the ExtCore framework sample web application that uses the file storage extension. It allows to work with a file storage
through the abstraction layer and easily replace, let's say, file system storage with the Dropbox or Azure Blob Storage ones without changing any code.

## Getting Started

* open the Startup class and specify correct path to the solution;
* ensure that the /FileStorage/Uploads folder exists inside the WebApplication project's one;
* rebuild the solution;
* run the main web application and try to upload some files;
* open WebApplication.csproj file as text and replace the ExtCore.FileStorage.FileSystem package reference to the ExtCore.FileStorage.Dropbox one
(note that you can just copy the extension's DLL files and their dependencies inside the extensions folder instead to specify which implementation should be used);
* create an application inside your Dropbox account, create an access token inside that app and specify it inside the Startup class;
* set the root path to the / and specify the Dropbox access token inside the Startup class;
* create Uploads folder inside your Dropbox account;
* run the main web application and try to upload some files.

## More Information

### Other Samples

* [Full-featured ExtCore 3.3.0 framework sample web application](https://github.com/ExtCore/ExtCore-Sample);
* [ExtCore framework 3.3.0 sample simplest web application](https://github.com/ExtCore/ExtCore-Sample-Simplest);
* [ExtCore framework 3.3.0 sample MVC web application](https://github.com/ExtCore/ExtCore-Sample-Mvc);
* [ExtCore framework 3.3.0 sample web application that uses a database](https://github.com/ExtCore/ExtCore-Sample-Data);
* [ExtCore framework 3.3.0 sample web application that uses Identity](https://github.com/ExtCore/ExtCore-Sample-Identity);
* [ExtCore framework 3.3.0 sample web application with modular UI](https://github.com/ExtCore/ExtCore-Sample-Modular-Ui);
* [ExtCore framework 3.3.0 advanced sample web application with modular UI](https://github.com/ExtCore/ExtCore-Sample-Modular-Ui-Adv);
* [ExtCore framework 3.3.0 advanced sample accounting web application](https://github.com/ExtCore/ExtCore-Sample-Accounting);
* [ExtCore framework 3.3.0 sample web application that registers a service inside the extension](https://github.com/ExtCore/ExtCore-Sample-Service);
* [ExtCore framework 3.3.0 sample web application that uses the events](https://github.com/ExtCore/ExtCore-Sample-Events);
* [ExtCore framework 3.3.0 sample API web application](https://github.com/ExtCore/ExtCore-Sample-Api).

You can also download our [ready to use full-featured sample](http://extcore.net/files/ExtCore-Sample-3.3.0.zip).
It contains everything you need to run ExtCore-based web application from Visual Studio 2017, including SQLite
database with the test data.

### Tutorials

We have written [several tutorials](http://docs.extcore.net/en/latest/getting_started/index.html)
to help you start developing your ExtCore-based web applications.

### Real Projects

Please take a look at [Platformus](https://github.com/Platformus/Platformus) on GitHub. It is CMS
built on ExtCore framework with more than 10 extensions and 80 projects.

## Links

Sources on GitHub: https://github.com/ExtCore/ExtCore

Website: http://extcore.net/

Docs: http://docs.extcore.net/

Author: http://sikorsky.pro/