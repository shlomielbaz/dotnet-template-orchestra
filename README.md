# Orchestrate .NET core apps with docker-compose
This is a multi services app rely on dotnet core temlates apps, the following example demonstrate a separation between the presentation tier to the application logics. 

Docker-compose is used to orchestrate (run) multiple containers in a single command, it is also used to coordinate between the services (containers);

![Docker-compose](/docker-compose.png)

### Application Folder Structure
* **Web** - represent the presentation tier, contains the landing page and web apps navigations: "Home", "Privacy" and "Weather Forecast".
  * **Pages** - contains the UI pages.
* **Api** - responsible for incoming HTTP messages.
  * **Controllers** - contains classes that handle the RESTFul API's.
* **Services** - represent the transformation tier where incoming messages represented by ViewModels transform to Entities and vice versa.
* **Data** - contains the DB context and repository.
* **Utils** - holds extention methods, helpers, providers and so.
* **Domain** - contains the "domain" app, which is the abstraction of the app.
  * **Entities** - contains classes that reflect the DB schemas.
  * **Enums** - contains the application types.
  * **General** - contains classes for general use.
  * **Interfaces** - contains interfaces that represent the application abstraction.
  * **Models** - contains classes that represent data transfer object and views reflection.

### Application Diagram
![Application Diagram](/app-diagram.png)

### Running The Project
From the solution root run: **docker-compose up**
