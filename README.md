# Aplicaci�n CRUD de Empleados

Una aplicaci�n web desarrollada con ASP.NET Core Razor Pages que permite gestionar empleados.

## Caracter�sticas

- CRUD completo de empleados (Crear, Leer, Actualizar, Eliminar)
- Validaciones con DataAnnotations
- Patr�n Repository
- ViewComponent para mostrar estad�sticas
- Entity Framework Core con SQL Server LocalDB

## Requisitos

- .NET 6.0 SDK o superior
- SQL Server LocalDB o SQLite

## Instalaci�n

1. Clonar el repositorio:
git clone https://github.com/tuusuario/EmpleadosApp.git
cd EmpleadosApp


2. Restaurar paquetes NuGet:  

dotnet restore


3. Aplicar migraciones para crear la base de datos:  

dotnet ef database update


4. Ejecutar la aplicaci�n:  

dotnet run


5. Abrir en el navegador:  

https://localhost:5001


## Estructura del Proyecto  

- **Models**: Contiene la clase Empleado con validaciones  
- **Data**: Contiene el contexto de Entity Framework  
- **Repositories**: Implementa el patr�n Repository  
- **Pages**: Contiene las p�ginas Razor para el CRUD  
- **ViewComponents**: Contiene el componente de estad�sticas  

## Tecnolog�as Utilizadas  

- ASP.NET Core 6.0  
- Entity Framework Core  
- Bootstrap 5  
- SQL Server LocalDB