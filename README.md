# Proyecto 1 - Calculadora

## Preview

![v0.1_calculadora-cs](./assets/img/v0.1.png)

## Resumen
Crear una **aplicación de calculadora en Windows Forms con C#** que permita a un usuario anónimo realizar cálculos básicos y algunos avanzados, registrando cada operación en una base 
de datos SQL Server.

## Requisitos Funcionales

1. **Usuario y acceso**
    - Usuario anónimo (sin login ni autenticación).
2. **Operaciones básicas**
    - Sumar, restar, multiplicar, dividir.
3. **Gestión de entradas**
    - Botones **C** (clear) y **CE** (clear entry) para borrar.
4. **Operaciones avanzadas**
    - Potencia al cuadrado (`x²`) y raíz cuadrada (`√x`).
    - Números negativos (botón `-`).
    - Números decimales (botón `.`).
5. **Persistencia de datos**
    - Guardar cada cálculo en una **tabla de MS SQL Server**.
    - Nombre de base de datos, tabla y campos definidos por el equipo.
6. **Opcionales**
    - Incorporar 2 operaciones adicionales (científicas o de desarrollador).
    - Botón **“Mostrar cálculos”** para listar operaciones guardadas en la base de datos.

## Base de datos
```mermaid
erDiagram
    Calculations {
        int ID PK
        string Operacion
        float Resultado
        datetime FechaHora
    }

```

## Timeline

```mermaid
---
config:
  kanban:
    ticketBaseUrl: 'https://github.com/Ju3juan/calculadora-cs/issues/#TICKET#'
---
kanban
  todo[Todo]
    id10["Implementación Operaciones Básicas"]@{ ticket: 10, priority: 'P0', size: 'M', iteration: 'Iteración 1' }
    id6["Diagrama de Base de Datos"]@{ ticket: 6, priority: 'P1', size: 'M', iteration: 'Iteración 1', assigned: 'Ju3juan' }
    id7["Diseño Interfaz Calculadora"]@{ ticket: 7, priority: 'P1', size: 'M', iteration: 'Iteración 1', assigned: 'Ju3juan' }

  inProgress[In Progress]
    id5["Wireframe y Planeación Inicial"]@{ ticket: 5, priority: 'P0', size: 'L', iteration: 'Iteración 1', assigned: 'Ju3juan' }
    id4["Crear proyecto Windows Forms en C#"]@{ ticket: 4, priority: 'P1', size: 'S', iteration: 'Iteración 1', assigned: 'Ju3juan' }

  done[Done]
    id2["Configurar repositorio GitHub para Proyecto Calculadora"]@{ ticket: 2, priority: 'P1', size: 'XS', iteration: 'Iteración 1', assigned: 'Ju3juan' }

  backlog[Backlog]
    id8["Integración Eventos Botones"]@{ ticket: 8, priority: 'P1', size: 'M', iteration: 'Iteración 1' }
    id11["Guardar Cálculos en DB"]@{ ticket: 11, priority: 'P1', size: 'L', iteration: 'Iteración 1' }
    id9["Visualización Historial"]@{ ticket: 9, priority: 'P2', size: 'M', iteration: 'Iteración 2' }
    id11b["Operaciones Avanzadas"]@{ ticket: 11, priority: 'P2', size: 'M', iteration: 'Iteración 2' }
    id12["Preparar Presentación Final - PPT"]@{ ticket: 12, priority: 'P2', size: 'S', iteration: 'Iteración 2', assigned: 'Ju3juan' }
    id13["Entrega Final en MS Teams y GitHub"]@{ ticket: 13, priority: 'P2', size: 'XS', iteration: 'Entrega', assigned: 'Ju3juan' }

```

```mermaid
gantt
    title Proyecto Calculadora - Desarrollo de Software IV
    dateFormat  YYYY-MM-DD
    axisFormat  %d-%b

  
    section Iteración 1
    Wireframe y Planeación Inicial       :a1, 2025-10-14, 2d
    Configurar repositorio GitHub        :a2, 2025-10-14, 1d
    Crear proyecto Windows Forms en C#   :a3, 2025-10-15, 1d
    Diagrama de Base de Datos            :a4, 2025-10-15, 2d
    Diseño Interfaz Calculadora          :a5, 2025-10-16, 3d
    Implementación Operaciones Básicas   :a6, 2025-10-17, 4d
    Guardar Cálculos en DB               :a7, 2025-10-18, 3d

  

    section Iteración 2
    Operaciones Avanzadas                :b1, 2025-10-23, 3d
    Visualización Historial              :b2, 2025-10-23, 2d
    Preparar Presentación Final (PPT)    :b3, 2025-10-25, 2d
    Entrega Final en MS Teams y GitHub   :b4, 2025-10-28, 2d
```
## Git Ignore

```gitignore
# Editors
**/.nvim/
**/.vs/
**/.vscode/

## Binary folders
**/Debug/
**/bin/
**/build/
**/packages/

# Compress files
*.zip
*.7z

# tmp
**/bin/
**/obj/
*.tmp

# unk
*.pdb
*.cache
*.log
.idea/
thumbs.db
.ds_store
*.user
*.suo
*.userosscache
*.sln.docstates
```


## Build

### Requerimientos (Windows) (Obligatorios)
- Visual Studio
- Sql Server

### Requerimientos (Windows) (Opcionales)
- SSMS Studio


## Git

### Config
```
git config --global core.autocrlf input
git config --global core.eol lf
```


### Git Pull
Always try 
```zsh
git pull --rebase
```

if you get a merge conflict, you can undo everything with 
```zsh
git rebase --abort
```

## Estructura del Proyecto - Github
### En Remote
```
Calculadora-cs/
│
├─ Properties/             # Archivos de configuración del proyecto
│   ├─ Resources.resx
│   └─ AssemblyInfo.cs
├─ App.config              # Configuración de la aplicación
├─ Form1.cs                # Lógica principal del formulario
├─ Form1.Designer.cs       # Diseño de la interfaz
├─ Form1.resx              # Recursos del formulario
├─ Program.cs              # Punto de entrada de la aplicación
├─ Calculadora123.csproj   # Archivo del proyecto C#
├─ .gitignore              # Ignorar bin, obj y archivos temporales
└─ Calculadora12.sln       # Solución de Visual Studio
```
## Botones

| Tipo    | Nombre                | Descripción                                             |
| ------- | --------------------- | ------------------------------------------------------- |
| TextBox | `txtDisplay`          | Pantalla principal donde se muestra el número/resultado |
| Button  | `btn0`                | Botón número 0                                          |
| Button  | `btn1`                | Botón número 1                                          |
| Button  | `btn2`                | Botón número 2                                          |
| Button  | `btn3`                | Botón número 3                                          |
| Button  | `btn4`                | Botón número 4                                          |
| Button  | `btn5`                | Botón número 5                                          |
| Button  | `btn6`                | Botón número 6                                          |
| Button  | `btn7`                | Botón número 7                                          |
| Button  | `btn8`                | Botón número 8                                          |
| Button  | `btn9`                | Botón número 9                                          |
| Button  | `btnSuma`             | Botón `+`                                               |
| Button  | `btnResta`            | Botón `-`                                               |
| Button  | `btnMultiplicar`      | Botón `*`                                               |
| Button  | `btnDividir`          | Botón `/`                                               |
| Button  | `btnC`                | Limpiar todo                                            |
| Button  | `btnCE`               | Limpiar entrada                                         |
| Button  | `btnPunto`            | Decimal `.`                                             |
| Button  | `btnNegativo`         | Cambiar signo `±`                                       |
| Button  | `btnCuadrado`         | Elevar al cuadrado                                      |
| Button  | `btnRaiz`             | Raíz cuadrada                                           |
| Button  | `btnMostrarHistorial` | Mostrar todos los cálculos guardados                    |

## Logic

```mermaid
flowchart TD
    Start((Inicio))
    Input[Ingresar número]
    SelectOp{{Seleccionar operación}}
    Compute[Calcular resultado]
    Continue{{Otra operación?}}
    Display[Mostrar resultado]
    SaveDB[(Guardar en DB)]
    ShowHistory[Mostrar historial opcional]
    End(((Fin)))

    Start --> Input --> SelectOp --> Compute --> Continue
    Continue -->|Sí| Input
    Continue -->|No| Display --> SaveDB --> End
    Display --> ShowHistory

```

# References

[Rivera, R. (2025). _DS4-Proyecto1-WinFormsApp_ [Documento PDF]. Universidad Tecnológica de Panamá.](https://utpac.sharepoint.com/sites/DSIV-1GS221-II2025/_layouts/15/embed.aspx)