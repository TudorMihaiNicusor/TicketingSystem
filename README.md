!DISCLAIMER - the names for most objects and labels are in Romanian!

1. Requirements
    - a database in SQL Server
    - you can run the script attached to have all the required tables and some start input
    - change the connection credentials to it in all * DAL.cs files

2. Using
    - when you run the program, the login page will open: 
                        - login succesfully as admin - username:admin1 password:12345
                        - login succesfully as operator - username:operator1 password:54321
    - the admin page: 
                        - "Vizualizare Spectacole" -> to display in the first DataGrid all the Shows from database
                        - "Adaugare" -> to add a new show to database
                        - "Update" -> to update an existing show, the "Titlu" field is mandatory
                        - "Delete" -> to delte an existing show, the "Titlu" field is mandatory
                        - "Add" -> to add a new operator to database
                        - "Titlu" - the title of the show, "Regizor" - the director of the show, "Data Premiera" - premiere date (yyyy.mm.dd hh:mm:ss PM/AM)
                            "Actori" - the names of the cast, "Numar bilete" - the number of tickets available
                        - "LogOut" - to log out and go back to the login page
    - the operator page:

                        - "Rand bilet" - the row of the seat for the chosen show
                        - "Numar bilet" - the number of the seat for the chosen show
                        - "Vizualizare Bilete" - to display in the second DataGrid all the tickets from database
                        - "Vizualizare Bilete Spectacol" - to display in the second DataGrid all the tickets from database for the show specify in the title TextBox
                        - "AdaugaBilet" - to add a ticket for the mention show for the row and number specified
                        - "Vinde Bilet" - to sell a ticket for the mention show for the row and number specified
