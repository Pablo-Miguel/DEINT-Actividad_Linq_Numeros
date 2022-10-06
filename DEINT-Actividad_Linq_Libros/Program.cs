// See https://aka.ms/new-console-template for more information


using DEINT_Actividad_Linq_Libros;
using System.Xml.Serialization;

var libros = new List<Libro>() {
    new Libro{Titulo= "Don Quijote de la Mancha", IDAutor= 1, FechaPublicacion= 1605, Ventas= 500},
    new Libro{Titulo="Historia de dos ciudades", IDAutor=2, FechaPublicacion=1859, Ventas=200},
    new Libro{Titulo="El Señor de los Anillos", IDAutor=3, FechaPublicacion=1978, Ventas= 150},
    new Libro{Titulo="El principito", IDAutor=4, FechaPublicacion=1951, Ventas=140},
    new Libro{Titulo="El hobbit", IDAutor=3, FechaPublicacion=1982, Ventas=100},
    new Libro{Titulo="Sueño en el pabellón rojo", IDAutor=5, FechaPublicacion=1792, Ventas=100},
    new Libro{Titulo="Las aventuras de Alicia en el país de las maravillas", IDAutor=6, FechaPublicacion=1865, Ventas=100},
    new Libro{Titulo="Diez negritos", IDAutor=7, FechaPublicacion=1939, Ventas=100},
    new Libro{Titulo="El león, la bruja y el armario", IDAutor=8, FechaPublicacion=1950, Ventas=85},
    new Libro{Titulo="El código Da Vinci", IDAutor=9, FechaPublicacion=2003, Ventas=80},
    new Libro{Titulo="El guardián entre el centeno", IDAutor=10, FechaPublicacion=1951, Ventas=65},
    new Libro{Titulo="El alquimista", IDAutor=11, FechaPublicacion=1988, Ventas=65}
};

var autores = new List<Autor>() {
    new Autor{IDAutor= 1, Nombre= "Miguel de Cervantes"},
    new Autor{IDAutor=2, Nombre= "Charles Dickens"},
    new Autor{IDAutor=3, Nombre= "J. R. R. Tolkien"},
    new Autor{IDAutor=4, Nombre= "Antoine de Saint-Exupéry"},
    new Autor{IDAutor=5, Nombre= "Cao Xueqin"},
    new Autor{IDAutor=6, Nombre= "Lewis Car"},
    new Autor{IDAutor=7, Nombre= "Agatha Christie"},
    new Autor{IDAutor=8, Nombre= "C. S. Lewis"},
    new Autor{IDAutor=9, Nombre= "Dan Brown"},
    new Autor{IDAutor=10, Nombre= "J. D. Salinger"}
};

//Mostrar en consola los 3 libros con más ventas.
Console.WriteLine("Mostrar en consola los 3 libros con más ventas.");

var tresLibrMasVentas = libros.OrderBy(x => x.Ventas).TakeLast(3);

foreach (var i in tresLibrMasVentas) { 
    Console.WriteLine("\t" + i.Titulo);
}

Console.WriteLine();
//Mostrar en consola los 3 libros con menos ventas.
Console.WriteLine("Mostrar en consola los 3 libros con menos ventas.");

var tresLibrMenosVentas = libros.OrderBy(x => x.Ventas).Take(3);

foreach (var i in tresLibrMenosVentas)
{
    Console.WriteLine("\t" + i.Titulo);
}

Console.WriteLine();
//Mostrar en consola el código y el nombre de los autores cuyo nombre tenga menos
//de 10 caracteres(eliminando espacios en blanco).
Console.WriteLine("Mostrar en consola el código y el nombre de los autores cuyo nombre tenga menos de 10 caracteres(eliminando espacios en blanco).");

var nombAutorMas10Caract = autores.Where(x => x.Nombre.Replace(" ", String.Empty).Length <= 10).ToList();

foreach (var i in nombAutorMas10Caract)
{
    Console.WriteLine($"\tID: {i.IDAutor} -> {i.Nombre}");
}

Console.WriteLine();
//Mostrar en consola los libros agrupados por el autor.
Console.WriteLine("Mostrar en consola los libros agrupados por el autor.");

var librosAgrupAutor = libros.GroupBy(x => x.IDAutor);

foreach (var i in librosAgrupAutor) {
    foreach (var j in i) {
        Console.WriteLine($"\tIDAutor: {i.Key} --> Libro: {j.Titulo}");
    }
}

Console.WriteLine();
//Mostrar en consola los libros publicados hace menos de 50 años.
Console.WriteLine("Mostrar en consola los libros publicados hace menos de 50 años.");

var libroHaceMas50A = libros.Where(x => (new DateOnly().Year - x.FechaPublicacion) <= 50).ToList();

foreach (var i in libroHaceMas50A) {
    Console.WriteLine("\t" + i.Titulo);
}

Console.WriteLine();
//Mostrar en consola el libro más viejo
Console.WriteLine("Mostrar en consola el libro más viejo");

var libroMasViejo = libros.MinBy(x => x.FechaPublicacion);

Console.WriteLine("\t" + libroMasViejo.Titulo);

Console.WriteLine();
//Mostrar en consola los libros que comiencen con "El".
Console.WriteLine("Mostrar en consola los libros que comiencen con 'El'.");

var libresComEl = libros.Where(x => x.Titulo.StartsWith("El")).ToList();

foreach (var i in libresComEl) {
    Console.WriteLine("\t" + i.Titulo);
}

Console.WriteLine();