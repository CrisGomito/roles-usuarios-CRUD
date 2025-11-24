# CRUD\_Semana5



# Sistema CRUD de Usuarios y Roles  

\*\*Proyecto:\*\* Usuarios y Roles (Windows Forms · EF Core)  

\*\*Repositorio:\*\* \[roles-usuarios-CRUD](https://github.com/CrisGomito/roles-usuarios-CRUD)  



---



## 1. Descripción del proyecto  

Esta aplicación WinForms en C# permite la gestión completa (CRUD: Crear, Leer, Actualizar, Eliminar) de **Usuarios** y **Roles**, mediante una arquitectura en capas (Modelo → Controlador → Vista) y el uso de EntityFrameworkCore para acceso a base de datos SQL Server.  

El objetivo es demostrar buenas prácticas de desarrollo: acceso parametrizado, separación de responsabilidades, validaciones en el formulario, uso de vistas consistentes y script de base de datos.



---



## 2. Funcionalidades  

\- Autenticación de usuario (login) con verificación de correo y contraseña.  

\- Vista principal (dashboard) con menú para acceder a Usuarios y Roles.  

\- CRUD completo para Usuarios:

&nbsp; - Ver lista de usuarios.

&nbsp; - Insertar nuevos usuarios.

&nbsp; - Editar datos de usuario existentes.

&nbsp; - Eliminar usuarios.

\- CRUD completo para Roles:

&nbsp; - Ver lista de roles.

&nbsp; - Insertar nuevos roles.

&nbsp; - Editar roles existentes.

&nbsp; - Eliminar roles.

\- Validaciones de campos obligatorios, formato de correo, cédula (en el caso de usuarios), estado activo/inactivo.  

\- Uso de EF Core con DbContext para Roles y Usuarios, y script SQL para crear la base de datos y las tablas.



---



## 3. Arquitectura y capas  

La aplicación sigue una estructura por carpetas:  

\- `Modelos/` → clases de datos (`Usuario\_Model`, `Rol\_Model`)  

\- `Controladores/` → lógica de negocio/acceso a datos (`Usuarios\_Controller`, `Roles\_Controller`, `Auth\_Controller`)  

\- `Vistas/` → formularios WinForms (`frm\_login`, `frm\_dashboard`, vistas para Usuarios y Roles)  

\- `Config/` → configuración de conexión y `DbContext` para EF Core (`sqlServer\_dbcontext`)  

\- `Migrations/` → migraciones de EF Core (opcional)  

\- `App.config` → cadena de conexión a SQL Server  



Esta separación permite claridad, mantenibilidad y escalabilidad del código.



---



## 4. Requisitos de ambiente  

\- Visual Studio 2022 o superior (Windows Forms).  

\- .NET 6.0 (o la versión que uses en tu proyecto).  

\- SQL Server (por ejemplo, SQL Server Express) instalado y accesible.  

\- Cadena de conexión configurada en `App.config` bajo la clave `"cn"`.  

\- Paquetes NuGet instalados: `Microsoft.EntityFrameworkCore`, `Microsoft.EntityFrameworkCore.SqlServer`, `Microsoft.EntityFrameworkCore.Tools`.



---



## 5. Instalación y configuración  

1\. Clona el repositorio:  

&nbsp;  ```bash

&nbsp;  git clone https://github.com/CrisGomito/roles-usuarios-CRUD.git



---



## Video Código Explicación Rápida:



https://

