# Vendimia
## App Demo de una App de Ventas con Winforms &amp; Entity Framework

No hay archivo de configuración... por el momento, así que la cadena de conexión está con código duro en el archivo **ApplicationDbContext.cs**, línea 14:

```optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=VendimiaDB;Integrated Security=True")```, 
modificarla de acuerdo a la instancia de SQL Server instalada o apunta a una instancia de Azure.
Las tablas se generan desde el Visual Studio 2019 con la **Consola de Paquetes Nuget (Menú Herramientas -> Administrador de Paquetes Nuget -> Consola del Administrador de Paquetes)**
con el comando **Update-Database**

Con eso se generan las tablas y la configuración inicial. Si prefieres correr o generar el script directo en la base de datos, intenta mejor con **Script-Migration**

Después de eso simplemente correr la aplicación.

