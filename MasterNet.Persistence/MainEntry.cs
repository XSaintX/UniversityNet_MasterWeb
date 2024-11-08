using MasterNet.Domain;
using MasterNet.Persistence;
using Microsoft.EntityFrameworkCore;

using var context = new MasterNetDbContext();
//var cursos = await context.Cursos!.ToListAsync();

var c = new Curso
{
    Id = Guid.NewGuid(),
    Titulo = "Programacion con C#",
    Descripcion = "Las bases de la programacion",
    FechaPublicacion = DateTime.Now
};

context.Add(c);
await context.SaveChangesAsync();
var cursos = await context.Cursos!.ToListAsync();

foreach (var cur in cursos)
{
    //Console.WriteLine($"Curso {cur.Titulo}");
    Console.WriteLine($"{cur.Id} {cur.Titulo}");
}
//foreach(var cur in cursos)
//{
//    //Console.WriteLine($"Curso {cur.Titulo}");
//    Console.WriteLine($"{cur.Id} {cur.Titulo}");
//}

////Console.WriteLine("Hola Mundo X");