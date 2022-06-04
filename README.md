Create an app than deals with al least one entity using EF and SQL SERVER.
The app is a Console App and it presents different options to the user.

As the app start the user can:
1.	Create an Entity.
2.	Delete an Entity.
3.	Update an Entity.
4.	Get Entity Details.
5.	Get the List of entities.
6.	Quit the app

If the user select option 6 the app is exited (breaks out the loop), else, the user is being asked what he want to do (again) after the following relevant operation are executed:
•	For option 1
o	The app ask the user for details about the data to create the entity (for example: if the entity is a Student (our Class from the lesson) the app will create a student with the name provided via user input – console.readline), and create it in the DB

•	For option 2
o	The app will ask the user for the Id of the entity the user want to delete and delete that entity from the DB using the context

•	For option 3
o	The app will ask for details about the Entity to update (id of the entity and new data for the entity fields)

•	For option 4
o	The app asks the user for the id of the entity and print the object (you can use any format of presentation as you want)

•	For option 5
o	Same as 4 but no id is needed the app just print all the data for all the entities

•	For option 6
o Quit the app


 
