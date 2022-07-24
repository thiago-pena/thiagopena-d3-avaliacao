using thiagopena_d3_avaliacao.Models;

namespace thiagopena_d3_avaliacao.Interfaces {
    internal interface IUser {
        public List<User> GetAll();
        public User? Login(string email, string password);
    }
}
