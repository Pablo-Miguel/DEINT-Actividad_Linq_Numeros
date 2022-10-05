// See https://aka.ms/new-console-template for more information

var numeros = Enumerable.Range(1, 100).ToList();

var numDivEntre7 = numeros.Where(x => x % 7 == 0).ToList();

foreach (int i in numDivEntre7)
{
    Console.WriteLine(i);
}

Console.WriteLine();

var numerosParesImpares = numDivEntre7.GroupBy(x => x % 2 == 0).ToList();

foreach (var grp in numerosParesImpares) {
    if (grp.Key == true) Console.WriteLine("PARES: ");
    else Console.WriteLine("IMPARES: ");
    foreach (int i in grp) {
        Console.WriteLine($" - {i}");
    }
}