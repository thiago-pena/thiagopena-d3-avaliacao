using System.Data.SqlClient;
using thiagopena_d3_avaliacao.Interfaces;
using thiagopena_d3_avaliacao.Models;

namespace thiagopena_d3_avaliacao.Repositories {
    internal class UserRepository : IUser {
        private readonly string stringConexao = "Data source=DESKTOP-50E45J9; initial catalog=thiagopena-d3-avaliacao; user id=sa; pwd=pena123;";

        public List<User> GetAll() {
            List<User> users = new();

            using (SqlConnection con = new SqlConnection(stringConexao)) {
                string query = "SELECT id, name, email, password FROM Users";
                con.Open();
                SqlDataReader rdr;
                using (SqlCommand cmd = new(query, con)) {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read()) {
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

        public User? Login(string email, string password) {
            List<User> users = GetAll();
            return users.Find(user => user.Email == email && user.Password == password);
        }
    }

}
