using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace V1
{
    class MainApp
    {
        static void Main(string[] args)
        {

        string path;
        string line2;
        List<string> lines;

            for (int i = 0; i < args.Length; i++)
            {
                path = @"..\..\..\" + args[i];
                lines = new List<string>();
                lines = File.ReadAllLines(path).ToList();
                foreach (String line in lines)
                {
                    line2 = line.Replace(' ', ',');
                    Console.WriteLine(line2);
                }
            }

        }
    }
}
