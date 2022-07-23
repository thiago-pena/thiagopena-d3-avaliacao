using thiagopena_d3_avaliacao.Models;
using thiagopena_d3_avaliacao.Repositories;

namespace thiagopena_d3_avaliacao {
    internal class Program {
        static void Acessar() {
            UserRepository _user = new();

            bool valid = false;
            while (!valid) {
                string email, pw;
                Console.WriteLine("Informe seu email:");
                email = Console.ReadLine();
                Console.WriteLine("Informe sua senha:");
                pw = Console.ReadLine();

                // Chama a API verifica
                var user = _user.Login(email, pw);
                if (user != null) {
                    Logger.LogLogin(user);
                    Console.WriteLine($"Olá {user.Name}");
                }
                else {
                    Console.WriteLine("Acesso inválido. Verifique os dados de acesso.");
                }
            }

        }

        static void Main(string[] args) {
            Logger.Init();
            string input = "-1";
            while (input != "0") {
                Console.WriteLine("1 - Acessar");
                Console.WriteLine("0 - Cancelar");

                input = Console.ReadLine();

                if (input == "1") {
                    Acessar();
                }

            }
        }
    }
}