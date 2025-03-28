# Proyecto: Formulario de Registro en ASP.NET Core MVC

Este proyecto implementa un formulario web en **ASP.NET Core MVC** con **Entity Framework Core**, permitiendo a los usuarios ingresar y consultar datos personales en una base de datos SQL Server.

## Características
- **Formulario con Bootstrap 5**
- **Validaciones en el lado del cliente y servidor**
- **Persistencia de datos en SQL Server mediante Entity Framework Core**
- **Arquitectura limpia con separación en capas**
- **Controlador REST para consultas**

## Tecnologías Utilizadas
- **.NET 8**
- **ASP.NET Core MVC**
- **Entity Framework Core**
- **SQL Server**
- **Bootstrap 5**


### 1. Configurar la Base de Datos
Edita el archivo `appsettings.json` y reemplaza `TU_SERVIDOR` con la dirección de tu servidor SQL Server:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=TU_SERVIDOR;Database=RegistroPersonasDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### 2. Crear la Base de Datos y Migraciones
Ejecuta los siguientes comandos en la **Consola del Administrador de Paquetes (PMC)** o en la **Terminal**:
```powershell
# Aplicar migraciones y crear la base de datos
Add-Migration InitialCreate
Update-Database
```

### 3. Ejecutar el Proyecto
Ejecuta el siguiente comando:
```bash
dotnet run
```
O usa Visual Studio:
- Abre el proyecto en **Visual Studio**.
- Selecciona **IIS Express** o **Kestrel**.
- Presiona `Ctrl + F5` para ejecutar.

## Estructura del Proyecto
```
📂 Registros
│── 📂 Controllers
│   ├── PersonaMvcController.cs
│── 📂 Models
│   ├── Persona.cs
│── 📂 Data
│   ├── AppDbContext.cs
│── 📂 Views
│   ├── 📂 PersonaMvc
│   │   ├── Create.cshtml
│── appsettings.json
│── Program.cs
```

## API REST - Consulta de Personas
El proyecto expone un **endpoint REST** para consultar personas por ID o nombre.

**Ejemplo de consulta:**
```http
GET /api/persona/1
```
🚀

