using System;
using System.IO;

namespace Curso_c
{
    public class arquivo
    {
        public void criandoArquivos()
        {
            using (var escrever = new StreamWriter("Cadastro.txt", true)){
                Console.WriteLine("Informe quantas pessoas você deseja cadastrar?:");

                string quantidadePessoasInput = Console.ReadLine();
                int quantidadePessoas = int.Parse(quantidadePessoasInput);
                string[] nomes = new string[quantidadePessoas];

                for (int cont = 0; cont < quantidadePessoas; cont++){
                    Console.WriteLine($"Digite o nome da pessoa {cont + 1}:");
                    nomes[cont] = Console.ReadLine().Trim();
                    escrever.WriteLine(nomes[cont]);
                }
            }

            Console.WriteLine("\nCadastro concluído e salvo no arquivo txt.");
        }
    }
}
