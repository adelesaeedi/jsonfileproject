namespace schoolNegin
{
    public static class Pathclass
    {
        public static string GetPath()
        {

            var secondPath = Directory.GetCurrentDirectory();
            Console.WriteLine(secondPath);
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string pathclass = new Uri(actualPath).LocalPath;
            return secondPath;
        }

    }
}
