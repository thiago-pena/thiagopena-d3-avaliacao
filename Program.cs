using thiagopena_d3_avaliacao.Models;
using thiagopena_d3_avaliacao.Repositories;

namespace thiagopena_d3_avaliacao {
    internal class Program {

        static string Acessar() {
            UserRepository _user = new();

            while (true) {
                string email, pw;
                Console.WriteLine("\nInforme seu email:");
                email = Console.ReadLine();
                Console.WriteLine("\nInforme sua senha:");
                pw = Console.ReadLine();

                // Chama a API verifica
                var user = _user.Login(email, pw);
                if (user != null) {
                    Logger.Login(user);
                    Console.WriteLine($"Olá {user.Name}");
                    Console.WriteLine("\nEscolha uma das opções abaixo:\n");
                    Console.WriteLine("1 - Deslogar");
                    Console.WriteLine("0 - Encerrar o sistema");

                    string option = Console.ReadLine();
                    if (option == "1")
                        Logger.Logoff(user);

                    return option;
                }
                else {
                    Console.WriteLine("\n(ERRO) Acesso inválido. Verifique os dados de acesso.");
                }
            }

        }

        static void Main(string[] args) {
            Logger.Init();

            Console.WriteLine("Bem vindo ao sistema thiagopena_d3_avaliacao.");

            string input = "-1";
            while (input != "0") {
                Console.WriteLine("\nEscolha uma das opções abaixo:\n");
                Console.WriteLine("1 - Acessar");
                Console.WriteLine("0 - Cancelar");

                input = Console.ReadLine();

                if (input == "1") {
                    string option = Acessar();
                    if (option == "1") {
                        continue;
                    }
                    else {
                        input = "0";
                    }
                }
                else if (input == "0")
                    Console.WriteLine("\nAté logo!");

            }
        }
    }
}