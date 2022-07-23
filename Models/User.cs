namespace thiagopena_d3_avaliacao.Models {
    internal class User {
        public string Id { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public bool checkUser(string email, string password) {
            return true;
        }
    }
}
