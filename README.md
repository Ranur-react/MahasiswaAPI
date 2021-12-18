# Tutorial API .Net Core Web API C# 



#### 0. Konfigurasi Security MS SQL Management (MSSMS)

	* Security -> Login -> user
	* Servername -> Properties -> Security -> Server Auth
	* Restart MSS SQL MS, and SQL Agent on "Service.msc"

####  1. Membuat Project Baru dengan template
	* ASP .NET Core WEB API
	* target Framework .NET Core 3.1 (Long-term Support)
#### 2. Konfigurasi SQL Database Koneksi pada "appsettings.json"
 
```
  "ConnectionStrings": {
    "API": "Server=localhost;Database=Db_Mahasiswa_API;User Id=sa;Password=sapassword"
  }

```
####  3. Create Model and Declarate Attribute, Key, and Table Name
#### 4. Install NugetPlugin "Entity Framework Core & Entity Tools"
#### 5. Create Context folder -> and MyContext.cs Files yang berisi Table Declarate dan Constructor untuk turuann DbContext 
#### 6. Install NetPlugin Entity Framework SQL Server 5.0.11
#### 7. Configurasi Startup.cs Files untuk decalaret Context with appsetting.json pada ConfigureServices
	````
	/*
	*
	*/
	 services.AddDbContext<MyContext>(options => options.UseSqlServer(Configuration.GetConnectionString("API")));

	````
#### 8. typing code below to migrations Entity to database in the Nuget Console

	```
	add-migrations migrations_lable
	update-database
	```
#### 9. Check Migrasi tadi di MSSQL MS

#### 10. Membuat Repository
	a) Create Folder Repository
	b) Create Folder Interface
	c) Create Interface Class with Pascal Case Name
		* Declarate Attribute Acces method (Get,insert,update,delete)
	d) Create Repository Class
		* Set Inheritance from Interface
		* Build method Interface 
		* Set Repository Constructor for MyContext
		* Set Query Acces GetAll Method from MyContex.EntityName.TolIst();
	e) Create Controller API-Empty Class 
		* Call repository as private attribute
		* Create Constructor of Controller  to build Repository 
		* Set Get method and Repository variabel declarate
	f) Add Service Scope repository on Startup
#### 11. Access Controller on the Browser or Postman

	

