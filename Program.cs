using System;
using System.Collections.Generic;
using System.Linq;

var fruits = new List<string>();
fruits.Add("🍊");
fruits.Add("🍌");
fruits.Add("🍍");
fruits.Add("🍓");
fruits.Add("🍇");

// 1- primeiro item
Console.WriteLine(fruits.First());
Console.WriteLine(fruits.FirstOrDefault("Não encontrou itens"));

// 2-Verificar se um elemento existe
Console.WriteLine(fruits.Any(x => x == "🍇"));

// 3 - verificar se todos os elementos são de um tipo
Console.WriteLine(fruits.All(x => x == "🍓"));
// Console.WriteLine(fruits.All(x => x == x.Idade > 18));

// 4 - contar
Console.WriteLine(fruits.Count);
//  Console.WriteLine(fruits.Count(x => x == "🍓"));

// 5 - ElementAt - índice
Console.WriteLine(fruits.ElementAt(4));

// 6 - Take
foreach (var fruit in fruits.Take(3))
{
    Console.WriteLine(fruit);
}

// 7 - Where
// foreach (var fruit in fruits
//            .Where(x => x == "🍓" || x == "🍌"))
//        Console.WriteLine(fruit);

// 8 - Single
Console.WriteLine(fruits.Single(x => x == "🍌"));

// 9 - último elemento
Console.WriteLine(fruits.Last());

// 10 - Skip
foreach (var fruit in fruits
            .Skip(1)
            .Take(2))
{
    Console.WriteLine(fruit);
}
