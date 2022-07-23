//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Data.SqlClient;
using thiagopena_d3_avaliacao.Models;

namespace thiagopena_d3_avaliacao.Repositories {
    internal class UserRepository {
        private readonly string stringConexao = "Data source=DESKTOP-50E45J9; initial catalog=thiagopena-d3-avaliacao; user id=sa; pwd=pena123;";

        public List<User> GetAll() {
            List<User> users = new();

            // Declara a SqlConnection con passando a string de conexão como parâmetro
            using (SqlConnection con = new SqlConnection(stringConexao)) {
                // Declara a instrução a ser executada
                string query = "SELECT id, name, email, password FROM Users";


                // Abre a conexão com o banco de dados
                con.Open();
                // Declara o SqlDataReader rdr para percorrer a tabela do banco de dados
                SqlDataReader rdr;
                // Declara o SqlCommand cmd passando a query que será executada e a conexão como parâmetros
                using (SqlCommand cmd = new(query, con)) {
                    // Executa a query e armazena os dados no rdr
                    rdr = cmd.ExecuteReader();

                    // Enquanto houver registros para serem lidos no rdr, o laço se repete
                    while (rdr.Read()) {
                        // Instancia um objeto genero do tipo Product
                        User user = new() {
                            Id = rdr["id"].ToString(),
                            Name = rdr["name"].ToString(),
                            Email = rdr["email"].ToString(),
                            Password = rdr["password"].ToString()
                        };

                        users.Add(user);
                    };
                }
            }
            return users;
        }

        public User Login(string email, string password) {
            List<User> users = GetAll();
            return users.Find(user => user.Email == email && user.Password == password);
        }
    }

}
