
# Documentation for the .Net 

Este es un proyecto de backend desarrollado en **ASP.NET Core**, que expone una API REST para aprender y exponer la funcionalidades de esta misma . Sigue principios de arquitectura limpia con controladores, servicios, middlewares y dependencias inyectadas.


# Basic commands
```bash
# Clonar el repositorio
git clone https://github.com/tu-usuario/tu-proyecto-dotnet-api.git

cd tu-proyecto-dotnet-api

# Restaurar dependencias
dotnet restore

# Compilar el proyecto
dotnet build

# Ejecutar la API
dotnet run

# Ejecutar pruebas
dotnet test

# Nos permite crear los proyectos y tambien la creacion de otro tipo,si necesitas opciones usa dotnet new --List 
dotnet new

# Creacion de una API
dotnet new webapi

```
Cuando ejecutamos el comando *dotnet new webapi* el CLI de dotnet nos crea un proyecto listo para ejecutar y realizar pruebas,
veamos que contiene este proyecto.

## Controllers

Ejemplo de uso en la carpeta Controller , *API.NET/Controllers/WeatherForecastController.cs*
Este directorio contiene los controladores de la API.
Cada controlador es responsable de manejar una o varias solicitudes HTTP y devolver una respuesta.

## Middlewares

Ejemplo de uso en la carpeta Middlewares , *API.NET/Middlewares/TimeMiddlewares.cs*

## Services

Ejemplo de uso en la carpeta Middlewares , *API.NET/Service/HelloWord.cs* que a este es consumido por *API.NET/Controllers/HelloWordController.cs*

## appsettings.json

Este archivo contiene la configuración de la aplicación,
como las opciones de conexión a la base de datos y las opciones de configuración personalizadas.

## Properties
Este directorio contiene información sobre el proyecto,
como la información de versión y la información de compilación.

## Models
Este directorio contiene los modelos de datos utilizados por la API.
Los modelos representan los datos que se manejan en la API, como los recursos que se están exponiendo.

### MVC(Model View Controller )

MVC es el acrónimo de Model-View-Controller, que es un patrón de arquitectura de software utilizado en desarrollo de aplicaciones.
Se utiliza para separar la lógica de negocios, la lógica de presentación y la lógica de control en componentes independientes.

### MXC(Model  Controller ) *En nuestra API*
En el template nuestro proyecto,la arquitectura MVC se aplica para separar la lógica de la aplicación en diferentes componentes sin hacer uso de las Vistas:

1. Modelos: Los modelos representan los datos que se manejan en la API, como los recursos que se están exponiendo. Estos modelos se almacenan en el directorio Models.
2. Controladores: Los controladores son la capa de control de la aplicación y se encargan de manejar las solicitudes HTTP y devolver las respuestas correspondientes. Los controladores se almacenan en el directorio Controllers.
3. Vistas: En una API de Web, no hay vistas en el sentido tradicional, ya que no se muestra una interfaz gráfica de usuario. En su lugar, los controladores devuelven datos en formato JSON o XML para su uso por parte de las aplicaciones cliente.

## Api.net.csproj
Nos muestra la version de .Net y el SDK que como es para APIS siempre sera WEB

## Program.cs


## appsettings.Development.json
En  este archivo guardarremos conecxiones string para conectarnos a una Base de Datos ,depronto conecxiones o servicios que se encuentre en la nube
o incluso paramentros configurables dentro de la API que cuando estemos dentro de produccion se puedan modificar 


## Dependency Injection 

Nos permite utilizar diferentes tipos abstractos y configurar nuestras dependencias utilizando un inyector sin tener que 
crear un nuevo objeto o
una nueva referencia del componente cada vez que lo necesitemos,
sino que el inyector se encarga de pasarnos esa dependencia y la podemos utilizar directamente.   