# FlatPlanet
FlatPlanet assessment

Follow the following steps to run the Solution
- Download the solution.
- Open the solution
- Right click on the Solution "FlatPlanet" and select "Restore NuGet Package"
- Go to the Project "FlatPlanet.DAL" and set the right connection string for your machine.
- Right click on the Project "FlatPlanet.DAL" and select "Set as Start up Project"
- Go to Tools > NuGet Package Manager > Package Manager Console
- Inside Package Manager Console, set the Default project to "FlatPlanet.DAL"
- Inside Package Manager Console, run this command "Update-Database -verbose"
- If an error is encountered while running the command above, try to close Visual Studio and open the project again. It is a known issue for Entityframework Code-first Migration.
- Go to the Project "FlatPlanet.Web" and set the right connection string for your machine.
- Right click on the Project "FlatPlanet.Web" and select "Set as Start up Project"
- Run the project
