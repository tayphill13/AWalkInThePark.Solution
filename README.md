# _A Walk In the Park_

<h1 align="left">
  <img width="270" height="180" src="https://aleteia.org/wp-content/uploads/sites/2/2020/03/web3-national-park-outdoor-mountains-yosemite-national-park-shutterstock_124360591.jpg?quality=100&strip=all&w=620&h=310&crop=1">
</h1>


#### _An API that holds information about various State and National Parks, 8.21.20_

#### By _**Taylor Phillips**_

<br>

## Description

_This was a friday independent project where we built an API.  This API contains data about some National Parks and State Parks.  This API also features some implemented pagination so that API calls can return separate pages of data and the amount of objects per page can be specified._

<br>

## HTTP Request
```
For National Parks:

Get /api/nationalparks
Post /api/nationalparks
Get /api/nationalparks/{id}
Put /api/nationalparks/{id}
Delete /api/nationalparks/{id}
```
```
For State Parks:

Get /api/stateparks
Post /api/stateparks
Get /api/stateparks/{id}
Put /api/stateparks/{id}
Delete /api/stateparks/{id}
```

## Path Parameters
<br>
National Parks<br>

| Parameter | Type | Default | Required | Description |
| :------- | :-----  | :----- | :------ | :---------- |
| Name  | String  | none | false | Return matches by name |
| State |  String | none  |  false | Return matches by state  |
| Access Price | Int | none | false | Return matches by access price |
<br>
State Parks<br>

| Parameter | type | default | required | Description |
| :-------- | :------  | :----- | :------ | :--------- |
| Name | string | none  | false  | Return matches by name  |
| State | string  |  none  |  false  | Return matches by state |
| County  | string  |  none  |  false  | Return matches by county |

<br>
<br>

## Example Queries

<br>
* `http://localhost:5000/api/nationalparks?state=oregon&accessprice=0`

* `http://localhost:5000/api/nationalparks/7` <-- would query the National Park entry with an id of 7.<br>
The output would look like this:
```
    {
        "nationalParkId": 7,
        "name": "John_Day_Fossil_Beds",
        "state": "Oregon",
        "accessPrice": 0
    }
```

* `http://localhost:5000/api/stateparks/5` <-- would query the State Park entry with an id of 5.<br>
The output would look like this:
```
    {
        "stateParkId": 5,
        "name": "Emerald_Bay_State_Park",
        "state": "California",
        "county": "El_Dorado"
    }
```

* `http://localhost:5000/api/stateparks/stateparkpages?pageNumber=3&pageSize=2` <-- would query a page that displays the 3rd page of State Parks with a page size of 2 State Parks displayed per page.<br>
The output would look like this:
```
[
    {
        "stateParkId": 5,
        "name": "Emerald_Bay_State_Park",
        "state": "California",
        "county": "El_Dorado"
    },
    {
        "stateParkId": 6,
        "name": "Grizzly_Creek_Redwoods",
        "state": "California",
        "county": "Humboldt"
    }
]
```

<br>

## Software/Installation Requirements
* Install [Git v2.62.2+](https://git-scm.com/downloads/)
* Install [.NET version 3.1 SDK v2.2+](https://dotnet.microsoft.com/download/dotnet-core/2.2)
* Install [Visual Studio Code](https://code.visualstudio.com/)
* Install [MySql Workbench](https://www.mysql.com/products/workbench/)
<br>

## 💻 Setup
<br>
Copy this url to clone this project to your local system using computer's Command Line terminal: 
`http://github.com/tayphill13/AWalkInThePark.Solution.git`

If you wish to edit the code base: Open the project in your code editor; with Bash, this is done by navigating to the project directory `cd AWalkInThePark.Solution`, then `code .`

<br>

## Database Setup/Migration
<br>
* Run MySQL by entering ```mysql -uroot -pepicodus``` in the terminal (In this example, 'epicodus' is the password, so if the word `password` was your password then you'd have ```msql -uroot -ppassword```)

* If you are using mysql workbench then the database can be generated by importing `taylor_phillips.sql` located in the `AWalkInThePark.Solution` directory.
* This can be found in the MySql Workbench `Server` menu as `Data Import`, then choose `Import from Self-Contained File`.  Use the browsing tool to select the `taylor_phillips.sql` file that is included with the project and finally select `Start Import`.

[![MySql gif tutorial](https://i.gyazo.com/7344f0f1229a3da604673362176a43d4.gif)](https://gyazo.com/7344f0f1229a3da604673362176a43d4))
* Within the project file, create a new `appsettings.json` you will need to be sure that the password (pwd) matches the password that you are using for your MySql Workbench.
* Your appsettings.json file should follow this format: <br>

  ```{
  {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=databaseNameHere;uid=YourUserNameHere;pwd=YourPasswordHere;"
      }
  }
  ```

#### Alternatively,
* In your command line terminal, type `cd Desktop` then navigate to project folder using `cd AWalkInThePark.Solution`
* Then navigate to `cd WalkThePark` and type ``` dotnet ef migrations Initial ```
* Then type ``` dotnet ef database update ```
* You can confirm your the database has been created by going to the `Schemas` tab in your MySql Workbench and then right click and select `Refresh All` in the schema window.

[![Image from Gyazo](https://i.gyazo.com/5edd4bf2780449d54844cc365939558a.gif)](https://gyazo.com/5edd4bf2780449d54844cc365939558a)

### Running the program:
1. In your command line terminal, type `cd Desktop` then navigate to project folder using `cd AWalkInThePark.Solution`
2. To run the program, you'll need navigate to the project folder by entering `cd WalkThePark`, then to compile the code enter: `dotnet restore`. This will create a compiled application in the bin/ folder.  Do not touch the files in the bin/ or obj/ folders, you will not need to and the application will not run as intended.
3. You can then run the program directly with `dotnet run` while still within the 'WalkThePark' directory.

<!-- ### OpenAPI Documentation:
For further documentation on our API, see our SwaggerUI here while server is running:
<http://localhost:5000/swagger/index.html#/> -->

<br>

## Known Bugs

If user chooses to select by access price, they must enter the price in an exact whole number

<br>

## Support and contact details

_Please reach out through my GitHub account._

<br>

## Technologies Used

_**Written in:** [Visual Studio Code](https://code.visualstudio.com/)_
_**Database Mgmt:** [MySql Workbench](https://www.mysql.com/products/workbench/)_
_Using C# and .Net Core_
_This was completed using MacOS - and OS Catalina_

<br>

### License

Copyright (c) 2020 **_Taylor Phillips_**   
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

*Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:*

*The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.*

*THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.*
