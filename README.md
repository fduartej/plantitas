## Vivero Online Plantitas

dotnet new mvc --auth Individual

MIGRATIONS
dotnet ef migrations add ProdutctopwdMigration --context plantitas.Data.ApplicationDbContext -o "C:\Users\fduarte\Documents\Temp\Proyecto\Katia\plantitas\Data\Migrations"

dotnet tool update --global dotnet-ef --version 5.0.4

dotnet ef database update

Crear un CRUD


dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.2
dotnet tool install --global dotnet-aspnet-codegenerator --version 5.0.2

export PATH=$HOME/.dotnet/tools:$PATH (SOLO LOS QUE LINUX)

dotnet aspnet-codegenerator controller -name ProductoController -m Producto -dc plantitas.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

dotnet aspnet-codegenerator controller -name ProformaController -m Proforma -dc plantitas.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

ACTUALIZA LA DB

dotnet ef migrations add ProdutctopwdMigration --context plantitas.Data.ApplicationDbContext -o "/home/fred/Documents/code/netcore/plantitas/Data/Migrations"

dotnet ef migrations add PrimeradMigration --context plantitas.Data.ApplicationDbContext -o "C:\Users\fduarte\Documents\Personal\USMP\FIA\Programacion I\2021-1\plantitas\Data\Migrations"

dotnet ef migrations add SegundaMigration --context plantitas.Data.ApplicationDbContext -o "C:\Users\fduarte\Documents\Personal\USMP\FIA\Programacion I\2021-1\plantitas\Data\Migrations"


dotnet ef database update