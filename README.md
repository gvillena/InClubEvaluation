
# InClubEvaluation - Giancarlo Villena


Este repositorio contiene el codigo fuente para la prueba tecnica del proceso de seleccion de la empresa InClub, elaborado sobre .NET Core 3.1 y utilizando una simplificada arquitectura de Microservicios.


## IdentityAPI
Este proyecto ejecuta una aplicacion orientada a microservicios y una aplicacion .NET Core MVC que consume este servicio. 

Este servicio sigue el patron de diseño **Identity Provider** o **STS (Sercurity Token Service)**, implementado sobre ASP.NET Core Identiy.

### Instalación

 Crear la bases de datos **InClub.Evaluation.IdentityDatabase** en una instancia de **SQL Server**

   ```bash
     CREATE DATABASE InClub.Evaluation.IdentityDatabase     
   ```

 Modificar el archivo **"app-settings.json"** en el proyecto **IdentityAPI** que se encuentra dentro de la solución con la cadena de conexion de la base de datos creada en el paso anterior. 
   ```json
    "ConnectionStrings": {
       "DefaultConnection": "Tu cadena de conexion"
    },
   ```

Aplicar la migracion de la base de datos con el comando **Update-Database** utilizando la herramienta **Package Manager Console** de Visual Studio.
   ```
     Update-Database -Project Identity.API -StartupProject Identity.API
   ```

Listo!

### Ejecucion
Ejecutar el proyecto **IdentityAPI** utilizando el perfil de **ISSExpress** de la solucion dentro de Visual Studio.

Esto abrira un navegador mostrando la pagina de inicio del proyecto donde encontrara dos botones en la parte superior para **Registrarse** e **Iniciar sesión** respectivamente.

## CatalogAPI
Este proyecto ejecuta una aplicacion orientada a microservicios que expone un servicio RESTful para operaciones CRUD. 

Este servicio utiliza **gRPC** como framework para la comunicacion con servicios siguiendo el concepto de **RPC (Remote Procedure Call)**, **Swagger** para la documentacion del serivicio REST Api aplicando la especificacion **OpenApi**, implementado sobre ASP.NET Core.

### Instalación

 Crear la bases de datos **InClub.Evaluation.CatalogDatabase** en una instancia de **SQL Server**

   ```bash
     CREATE DATABASE InClub.Evaluation.CatalogDatabase     
   ```

 Modificar el archivo **"app-settings.json"** en el proyecto **CatalogAPI** que se encuentra dentro de la solución con la cadena de conexion de la base de datos creada en el paso anterior. 
   ```json
    "ConnectionStrings": {
       "DefaultConnection": "Tu cadena de conexion"
    },
   ```

Aplicar la migracion de la base de datos con el comando **Update-Database** utilizando la herramienta **Package Manager Console** de Visual Studio.
   ```
     Update-Database -Project Catalog.API -StartupProject Catalog.API
   ```

Listo!

### Ejecucion
Ejecutar el proyecto **CatalogAPI** utilizando el perfil de **ISSExpress** de la solucion dentro de Visual Studio.

Esto abrira un navegador mostrando la interfaz de usuario de **Swagger** implementado dentro del proyecto, tal como se muestra a continuacion.
