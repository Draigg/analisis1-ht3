using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace V2
{
    class Facade
    {
        private string path;
        private string lineCSV;
        private string line2;
        private List<string> lines;
        private int i, c, x, j;
        
        public void commandXML(string[] args)
        {

            for (x = 0; x < args.Length - 1; x++)
            {

                path = @"..\..\..\" + args[x];
                lines = new List<string>();
                lines = File.ReadAllLines(path).ToList();

                foreach (String line in lines)
                {
                    Console.WriteLine("<?xml version='1.0' enconding='UTF-16'?>");
                    Console.WriteLine("<project>");
                    Console.WriteLine("<Comment>");
                    Console.WriteLine("");

                    lineCSV = line.Replace(' ', ' ');
                    Console.WriteLine(lineCSV);

                    Console.WriteLine("");
                    Console.WriteLine("</Comment>");
                    Console.WriteLine("</project>");
                    Console.WriteLine("</xml");
                    Console.WriteLine("\n\n");
                }

            }

        }

        //------------------------------------------------------------------------------
        public void commandCSV(string[] args)
        {


            for (c = 0; c < args.Length - 1; c++)
            {

                path = @"..\..\..\" + args[c];
                lines = new List<string>();
                lines = File.ReadAllLines(path).ToList();

                foreach (String line in lines)
                {
                    line2 = line.Replace(' ', ',');
                    Console.WriteLine(line2);
                    Console.WriteLine("\n\n");
                }

            }

        }

        //------------------------------------------------------------------------------------------------

        public void commandHTML(string[] args)
        {

            for (i = 0; i < args.Length - 1; i++)
            {

                path = @"..\..\..\" + args[i];
                lines = new List<string>();
                lines = File.ReadAllLines(path).ToList();

                foreach (String line in lines)
                {
                    Console.WriteLine("<DOCTYPE html>");
                    Console.WriteLine("<html lang='es'>");
                    Console.WriteLine("<head>");
                    Console.WriteLine("<title> </title>");
                    Console.WriteLine("</head>");
                    Console.WriteLine("<body>");
                    Console.WriteLine("<div>");
                    line2 = line.Replace(' ', ' ');
                    Console.WriteLine("<h5>" + line2 + "</h5>");
                    Console.WriteLine("</div>");
                    Console.WriteLine("</body>");
                    Console.WriteLine("</html>");
                    Console.WriteLine("\n\n");
                }

            }

        }

        //-------------------------------------------------------------------------------------------------------


        public void commandJSON(string[] args)
        {

            for (j = 0; j < args.Length - 1; j++)
            {

                path = @"..\..\..\" + args[j];
                lines = new List<string>();
                lines = File.ReadAllLines(path).ToList();

                foreach (String line in lines)
                {
                    Console.WriteLine("\t[");
                    Console.WriteLine("\t\t{");
                    line2 = line.Replace(' ', ' ');
                    Console.WriteLine("\t\t\t'"+line2+"': 'string'");
                    Console.WriteLine("\t\t}");
                    Console.WriteLine("\t]");

                }

            }

        }




    }
}
