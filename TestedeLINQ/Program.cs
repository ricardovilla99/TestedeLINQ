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
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
            };

            Console.WriteLine("Lista de todos os números da lista: ");

            foreach (var todos in lista)
            {
                Console.WriteLine(todos);
            }

            //metodo para selecionar somente os impares, modulo diferente de zero
            var listaImpares = lista.Where(n => n % 2 != 0);

            var impares = listaImpares.ToList();

            //usar foreach para mostrar os numeros impares
            Console.WriteLine("\nLista dos números ímpares usando o foreach");
            foreach (var item in impares)
            {
                Console.WriteLine(item);
            }

            //mostra de novo usando o metodo de juntar uma string com o resultado de impares
            Console.WriteLine("\nRepetindo\n");
            Console.WriteLine("Método de juntar uma string \", \" com o resultado da variavel impares\n");
            Console.WriteLine(string.Join(", ", impares));

            //agora selecionar somente os pares, modulo igual a zero
            var listaPares = lista.Where(n => n % 2 == 0);

            var pares = listaPares.ToList();

            //usar foreach para mostrar os numeros pares
            Console.WriteLine("\nLista dos números pares usando o foreach");
            foreach (var item in pares)
            {
                Console.WriteLine(item);
            }



            //lista de numeros por extenso (strings)
            var listaString = new List<string>
            {
                "um", "dois", "tres", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze"
            };

            Console.WriteLine("\nNúmeros por extenso em forma de lista de strings: \n");

            foreach (var nome in listaString)
            {
                Console.WriteLine(nome);
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
                    { 11, "onze" }
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