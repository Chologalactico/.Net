
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

#Ejecutar pruebas
dotnet test
```
## Controllers

Ejemplo de uso en la carpeta Controller , *API.NET/Controllers/WeatherForecastController.cs*

## Middlewares

Ejemplo de uso en la carpeta Middlewares , *API.NET/Middlewares/TimeMiddlewares.cs*

## Services

Ejemplo de uso en la carpeta Middlewares , *API.NET/Service/HelloWord.cs* que a este es consumido por *API.NET/Controllers/HelloWordController.cs*


## Dependency Injection 

Nos permite utilizar diferentes tipos abstractos y configurar nuestras dependencias utilizando un inyector sin tener que 
crear un nuevo objeto o
una nueva referencia del componente cada vez que lo necesitemos,
sino que el inyector se encarga de pasarnos esa dependencia y la podemos utilizar directamente.   