## Vivero Online Plantitas


dotnet ef migrations add InitialMigration --context plantitas.Data.ApplicationDbContext -o "C:\Users\fduarte\Documents\Temp\Proyecto\Katia\plantitas\Data\Migrations"

dotnet tool update --global dotnet-ef --version 5.0.4

dotnet ef database update

