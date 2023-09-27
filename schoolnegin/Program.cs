using informationschooljson;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace schoolNegin
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" Hello, Welcome to school negin");
            Console.WriteLine("\n");
            listclass listclass = new listclass();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(listclass.showlist());
            string jsonPath = Pathclass.GetPath();
            var jsonfilePath = $@"{jsonPath}\jsonfile";

            var classavalkeyjson = $"{jsonfilePath}\\classsavalkey.json";


            var classAvalContent=File.ReadAllText( classavalkeyjson ) ;
            Console.ForegroundColor = ConsoleColor.Green ;
            Console.WriteLine( classAvalContent ) ;
            

        }
    }
}