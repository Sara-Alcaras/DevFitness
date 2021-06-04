﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DevFitness.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite seu nome.");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite sua altura.");
            var altura = Console.ReadLine();

            Console.WriteLine("Digite seu peso.");
            var peso = Console.ReadLine();

            var listaRefeicoes = new List<Refeicao>();

            var opcao = "-1";
            
            while (opcao != "0")
            {
                ExibirOpcoes();
                opcao = Console.ReadLine(); // Vai ler a linha de comando, digitar o valor e retornar a variavel

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine($"Nome: {nome}, Altura: {altura}, Peso: {peso}");
                        break;
                    case "2":
                       Cadastrar(listaRefeicoes);

                        break;
                    case "3":
                        ListarRefeicoes(listaRefeicoes);
                        break;
                    default:
                        Console.WriteLine("Por favor, digite outra opção.");
                        break;
                }

            }

            //var bebida = new Bebida("Leite Integral", 500, true);
            //var comida = new Comida("Sanduba", 100, 0.5M);

            //var listaComidas = new List<Refeicao> { bebida, comida };

            //ListarRefeicoes(listaComidas);

            Console.WriteLine("Fechando o app");
            Console.Read();
        }

        public static void ExibirOpcoes()
        {
            Console.WriteLine("--- Seja bem-vindo(a) ao DevFitness ---");
            Console.WriteLine("1- Exibir detalhes de usuário.");
            Console.WriteLine("2- Cadastrar nova refeição.");
            Console.WriteLine("3- Listar todas refeições.");
            Console.WriteLine("0- Finalizar aplicação.");
        }
        public static void Cadastrar(List<Refeicao> refeicoes)
        {
            Console.WriteLine("Digite a descrição da refeição.");
            var descricao = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de calorias.");
            var calorias = Console.ReadLine();

            if (int.TryParse(calorias, out int caloriasInt))
            {
                var refeicao = new Refeicao(descricao, caloriasInt);

                refeicoes.Add(refeicao);

                Console.WriteLine("Refeição adicionada com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor de calorias inválido.");
            }

        }

         public static void ListarRefeicoes(List<Refeicao> refeicoes)
         {
            foreach (var refeicao in refeicoes)
            {
               refeicao.ImprimirMensagem();
            }

         }
    }
}

   // if (opcao == "1")
            //  {
            // Console.WriteLine($"Nome: {nome}, Altura: {altura}, Peso: {peso}");

            //  }
            // else if (opcao == "2")
            // {
            // Cadastrar();
            //  }
            // else if (opcao == "3")
            // {
            // ListarRefeicoes();
            // }
            //else
            // {
            //    Console.WriteLine("Por favor, digite outra opção.");
            // }

//var numeroString = "0 1 2 3 4 5 6 7 8 9";
//var numeros = numeroString.Split(' '); // Vai quebrar os numeros com um espaço, vai criar uma matriz de caracteres string

//for (var i = 0; i < numero.Length; i++) // Inicializador, Condição, Iterador
//{
//    // Vai passar os elementos
//    Console.WriteLine(numeros[i]);
//}

//var contador = 0;

//while (contador < numeros.Length)
//{
//    Console.WriteLine(numeros[contador]);

//    contador++;
//}

//foreach (string numero in numeros)
//{
//    Console.WriteLine(numero);
//}

//  var notas = new List<int> { 10, 1, 4, 8, 9, 2, 6, 2, 10 };
//notas.Add(5);
//notas.Add(10);
//var anyNumeroMaiorQue3 = notas.Any(n => n > 3);
//var firstNota = notas.First(n => n == 2);
//var singleNota9 = notas.Single(n => n == 9);
//var ordered = notas.OrderBy(n => n);
//var pow2 = notas.Select(n => Math.Pow(n, 2));
//var max = notas.Max();
//var min = notas.Min();
//var sum = notas.Sum();
//var average = notas.Average();