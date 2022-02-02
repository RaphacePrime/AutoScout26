

# AutoScout26
> Demo app for buy and sell veichles

C# Demo Application for understand how 
databases can be used in Visual Studio

## Installing / Getting started

A quick introduction of the minimal setup you need to get running.

```shell
git clone https://github.com/RaphacePrime/AutoScout26
```

open the solution,
press F12 for running the code

If you don't know the fundamentals of Databases in C#, 
please check https://www.geeksforgeeks.org/basic-database-operations-using-c-sharp/
before continuing

### Databases

Database: MazzoLuzzi.accdb (Access Database)
Table Utenti: It's the users table
	-->username;nomecognome;codicefiscale;password;saldo

Table Prodotti: It's the cars table
	-->codiceprodotto	marca	cilindrata	modello	tipologia	n_chilometro	url	immatricolazione	prezzo	username
	
## Forms

### Form Form1(Menu)

The first Form that appears on execution of the code is the Menu,
where you can login as a user to the catalog or to the form for selling a car.
With username "alunno" and password "alunno" you can jump into forms for the Admins
where you can directly modify the tables of the database

### Form Catalogo2(Catalog)

Here you can buy the cars inserted in the DB, but first the program will check 
if the user has enough money, then it will update the user's "saldo" with the money 
remaining and then it will eliminate the car from the table.

### Form Vendi

Here you can insert from the user side a car.
F7 to watch the code and the command I used to
insert the record in the table


### Form Admin & AdminU

You can add and delete a record from the admin side,
and you can visualize the database 


## Contributing

Contributors of this work are:
-https://github.com/RaphacePrime
-https://github.com/armati03
-https://github.com/Luzzi03

## Links

- Project homepage: https://github.com/RaphacePrime
- Repository: https://github.com/RaphacePrime/AutoScout25
- Related projects:
  - Your other project: https://github.com/RaphacePrime
 
## Licensing

"The code in this project is licensed under MIT license."
