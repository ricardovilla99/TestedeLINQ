using System.Collections.Concurrent;

namespace TestedeLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criar uma lista de diversos numeros inteiros
            var lista = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
            };

            Console.WriteLine("Lista de todos os números da lista: ");

            foreach (var todos in lista)
            {
                Console.WriteLine(todos);
            }

            int somaTotal = lista.Sum();
            Console.WriteLine($"\nA soma de todos os números da lista é: {somaTotal}.");

            int numeroElementos = lista.Count();
            Console.WriteLine($"\nO número de elementos individuais da lista é: {numeroElementos}.");

            int min = lista.Min();
            int max = lista.Max();
            Console.WriteLine("\nO menor número da lista é {0} e o maior é {1}.", min, max);

            int agregados = lista.Aggregate((a, b) => a + b);
            Console.WriteLine($"\nA soma de todos os números, usando outro método é: {agregados}.");




            //metodo para selecionar somente os impares, modulo diferente de zero
            var listaImpares = lista.Where(n => n % 2 != 0).ToList();

            //usar foreach para mostrar os numeros impares
            Console.WriteLine("\nLista dos números ímpares usando o foreach");
            foreach (var item in listaImpares)
            {
                Console.WriteLine(item);
            }

            //mostra de novo usando o metodo de juntar uma string com o resultado de impares
            Console.WriteLine("\nRepetindo\n");
            Console.WriteLine("Método de juntar uma string \", \" com o resultado da variavel impares\n");
            Console.WriteLine(string.Join(", ", listaImpares));

            //agora selecionar somente os pares, modulo igual a zero
            var listaPares = lista.Where(n => n % 2 == 0).ToList();

            //usar foreach para mostrar os numeros pares
            Console.WriteLine("\nLista dos números pares usando o foreach");
            foreach (var item in listaPares)
            {
                Console.WriteLine(item);
            }



            //lista de numeros por extenso (strings)
            var listaString = new List<string>
            {
                "um", "dois", "tres", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze", "treze", "quatorze", "quinze"
            };

            Console.WriteLine("\nNúmeros por extenso em forma de lista de strings:");

            foreach (var nome in listaString)
            {
                Console.WriteLine(nome);
            }

            //aqui usa LINQ para selecionar aquilo que começa com S
            var selecaoUm = from letraS in listaString
                            where letraS.StartsWith("s")
                            select letraS;

            Console.WriteLine("\nNumeros que começam com a letra S: ");

            //aqui mostra o conteudo da consulta LINQ 1
            foreach (var letraS in selecaoUm)
            {
                Console.WriteLine(letraS);
            }

            //aqui usa LINQ para selecionar aquilo que começa com O
            var selecaoDois = from letraO in listaString
                              where letraO.StartsWith("o")
                              select letraO;

            Console.WriteLine("\nNumeros que começam com a letra O: ");

            //aqui mostra o conteudo da consulta LINQ 2
            foreach (var letraO in selecaoDois)
            {
                Console.WriteLine(letraO);
            }

            //dicionario unindo numero em forma int com ele em forma string
            Dictionary<int, string> numerosPorExtenso = new Dictionary<int, string>

            {
                    { 1, "um" },
                    { 2, "dois" },
                    { 3, "três" },
                    { 4, "quatro" },
                    { 5, "cinco" },
                    { 6, "seis" },
                    { 7, "sete" },
                    { 8, "oito" },
                    { 9, "nove" },
                    { 10, "dez" },
                    { 11, "onze" },
                    {12, "doze" },
                    {13, "treze" },
                    {14, "quatorze" },
                    {15, "quinze" }
            };

            Console.WriteLine("\nConteúdo do Dicionário: ");
            foreach (var item in numerosPorExtenso)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nAbaixo podemos usar o metodo ToList para mostrar chave e valor");

            numerosPorExtenso.ToList()
                .ForEach(elemento => Console.WriteLine($"Chave: {elemento.Key}, Valor: {elemento.Value}"));


        }
    }
}