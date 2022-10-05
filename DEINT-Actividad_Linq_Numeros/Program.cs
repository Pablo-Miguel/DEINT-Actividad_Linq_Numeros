// See https://aka.ms/new-console-template for more information

var numeros = Enumerable.Range(1, 100).ToList();

var numDivEntre7 = numeros.Where(x => x % 7 == 0).ToList();

foreach (int i in numDivEntre7)
{
    Console.WriteLine(i);
}
