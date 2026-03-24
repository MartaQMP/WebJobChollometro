using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebJobChollometro.Data;
using WebJobChollometro.Repositories;

string connection = @"Data Source=sqlmarta.database.windows.net;Initial Catalog=AZURETAJAMAR;Persist Security Info=True;User ID=adminsql;Password=Admin1234;Trust Server Certificate=True";
//Console.WriteLine("Bienvenido a nuestros Chollos");
// NECESITAMOS LA INYECCION DE DEPENDENCIAS
var provider = new ServiceCollection()
    .AddTransient<RepositoryChollometro>()
    .AddDbContext<ChollometroContext>(options => options.UseSqlServer(connection))
    .BuildServiceProvider();
// RECUPERAMOS EL REPOSITORY DE LA INYECCION
RepositoryChollometro repo = provider.GetService<RepositoryChollometro>();
//Console.WriteLine("Pulse ENTER para comenzar...");
//Console.ReadLine();
await repo.PopulateChollosAzureAsync();
//Console.WriteLine("Proceso completado correctamente");