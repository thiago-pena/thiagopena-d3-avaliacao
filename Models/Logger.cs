namespace thiagopena_d3_avaliacao.Models {
    internal class Logger : Base {
        static string path = "logs/log.txt";

        public static void Init() {
            CreateFileAndFolder(path);
        }

        public static void LogLogin(User user) {
            string line = $"{DateTime.Now.ToString()}\tUsuário {user.Name} (id: {user.Id}) logou no sistema.";
            AppendLine(path, line);
        }
        public static void LogLogoff(User user) {
            string line = $"{DateTime.Now.ToString()}\tUsuário {user.Name} (id: {user.Id}) deslogou no sistema.";
            AppendLine(path, line);
        }
    }
}
