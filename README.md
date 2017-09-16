# A Small Application - VehicleManagment

This is but a small console application that creates three objects: Two cars, one plane and a boat, with all the necessary information.
It then checks to see whether the two cars are the same by matching the licenseplate numbers. It is expected that plate nunmbers are unique. 

The app then tells the plane to fly and car number 1 to drive. 

Every information about the transportationvehicles is converted to JSON format using the package Newtonsoft.Json and written to a local .json file.

Software used for editing: Visual Studio Community 

Additional packages: Newtonsoft.Json

-- For testing --

Step 1 - Install Visual Studio

Step 2 - Clone or download the repository

Step 3 - find the project file, path: SmallConsoleJSONApp/SmallConsoleJSONApp.sln and start it. 

Step 4 - Update package reference for Newtonsoft.Json in Visual Studio

- Go to search at the top right and search for "Package Manager Console" and click on it.
  
- At the new window that came up, find the dropdown button for default project and make sure the current project is chosen.
  
- Now type the following: Install-Package Newtonsoft.Json
  
- Newtonsoft.Json is now ready for use in your project!
  
------------------------------------------------------------------------------------------------------------------------------
