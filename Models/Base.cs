namespace thiagopena_d3_avaliacao.Models {
    internal class Base {

        public static void CreateFileAndFolder(string path) {
            string folder = path.Split('/')[0];
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
            if (!File.Exists(path))
                File.Create(path).Close();
        }

        public static List<string> ReadAllLines(string path) {
            List<string> lines = new();
            if (!File.Exists(path))
                return lines;

            StreamReader file = new(path);
            string line;
            while ((line = file.ReadLine()) != null)
                lines.Add(line);

            file.Close();

            return lines;
        }

        public static void AppendLine(string path, string line) {
            List<string> lines = ReadAllLines(path);
            lines.Add(line);
            StreamWriter file = new(path);

            file.WriteLine(string.Join('\n', lines));
            file.Close();
        }
    }
}
