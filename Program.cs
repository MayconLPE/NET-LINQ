using ESTUDOS_CSHARP_LINQ;

internal class Program
{
    private static void Main(string[] args)
    {
        // FONTE DE DADOS
        var listaProdutos = new List<Produto>()
            {
                new Produto {Id = 2, CategoriaId = 3, Nome = "Short", Status = true, Valor = 1},
                new Produto {Id = 7, CategoriaId = 2, Nome = "Feijão", Status = true, Valor = 12},
                new Produto {Id = 4, CategoriaId = 1, Nome = "Maquina de lavar", Status = false, Valor = 32},
                new Produto {Id = 3, CategoriaId = 1, Nome = "Video Game", Status = true, Valor = 99},
                new Produto {Id = 9, CategoriaId = 2, Nome = "Geladeira", Status = true, Valor = 10},
                new Produto {Id = 6, CategoriaId = 2, Nome = "Arroz", Status = true, Valor = 55},
                new Produto {Id = 8, CategoriaId = 1, Nome = "TV", Status = true, Valor = 45},
                new Produto {Id = 1, CategoriaId = 3, Nome = "Camiseta", Status = true, Valor = 100},
                new Produto {Id = 5, CategoriaId = 1, Nome = "Microondas", Status = true, Valor = 90},

            };

        var listaCategorias = new List<Categoria>
            {
                new Categoria {Id = 1, Status = true, Nome = "Eletronicos"},
                new Categoria {Id = 2, Status = true, Nome = "Alimentos"},
                new Categoria {Id = 3, Status = true, Nome = "Vestuario"},
            };

        // CRIAR CONSULTA LINQ

        // var resultado = from produto in listaProdutos
        //                 where produto.Valor > 50
        //                 select produto;

        // 01- FILTRAR PRODUTOS POR NOME
        // var resultado = from produto in listaProdutos
        //                 where produto.Nome.ToLower() == "arroz"
        //                 select produto;

        // 02- FILTRAR PRODUTOS PELA PRIMEIRA LETRA DO NOME
        // var resultado = from produto in listaProdutos
        //                 where produto.Nome.ToLower().Substring(0,1) == "m"
        //                 select produto;

        // 03- FILTRAR PRODUTOS PELA PRIMEIRA LETRA DO NOME E STATUS ATIVO
        // var resultado = from produto in listaProdutos
        //                 where produto.Nome.ToLower().Substring(0, 1) == "m" &&
        //                 produto.Status == true
        //                 select produto;

        // 04- ORDENAR OS PRODUTOS POR ID
        // var resultado = from produto in listaProdutos
        //                 where produto.Id > 1 && produto.Id < 5
        //                 orderby produto.Id // para decrescente: descending
        //                 select produto;

        // // EXECUTAR A CONSULTA
        // foreach (var result in resultado)
        // {
        //     Console.WriteLine($"{result.Id} | {result.Nome} | {result.Valor} | {result.CategoriaId}");
        // }

        // AGRUPAR POR CATEGORIA:
            // var resultado = from produtos in listaProdutos
            //              group produtos by produtos.CategoriaId into produtosAgrupados
            //              select produtosAgrupados;
            // foreach (var item in resultado)
            // {
            //     Console.WriteLine(item.Key);
            //     foreach (var prod in item)
            //     {
            //         Console.WriteLine($"Produto: {prod.Nome} | Categoria: {prod.CategoriaId}");
            //     }
            // }
        
        // C# - LINQ - First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault

        // var resultado = listaProdutos.First();
        var resultado = listaProdutos.FirstOrDefault(x => x.Id == 2);

        Console.WriteLine($"Nome: {resultado.Nome} | ID: {resultado.Id}");

    }
}