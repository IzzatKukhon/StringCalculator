using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("{0} = {1}", "Caluculator.Add(\"\")", Caluculator.Add("")));
            Console.WriteLine(string.Format("{0} = {1}", "Caluculator.Add(\"1,2,1001\")", Caluculator.Add("1,2,1001")));
            Console.WriteLine(string.Format("{0} = {1}", "Caluculator.Add(\"1,2,3,1005\")", Caluculator.Add("1,2,3,1005")));
            Console.WriteLine(string.Format("{0} = {1}", "Caluculator.Add(\"1,2\\n3\")", Caluculator.Add("1,2\n3")));
            Console.WriteLine(string.Format("{0} = {1}", "Caluculator.Add(\"1\\n2,3\")", Caluculator.Add("1\n2,3")));
            Console.WriteLine(string.Format("{0} = {1}", "Caluculator.Add(\"//;\\n1\\n2,3;4\")", Caluculator.Add("//;\n1\n2,3;4")));

            Console.WriteLine(string.Format("{0} = {1}", "Caluculator.Add(\"//y\\n1\\n2y3\\n4,9y0\")", Caluculator.Add("//y\n1\n2y3\n4,9y0")));
            Console.WriteLine(string.Format("{0} = {1}", "Caluculator.Add(\"//;\\n1;2;7;7\")", Caluculator.Add("//;\n1;2;7;7")));
            Console.WriteLine(string.Format("{0} = {1}", "Caluculator.Add(\"//[*][%]\\n1*2%3*1200\")", Caluculator.Add("//[*][%]\n1*2%3*1200")));
            Console.WriteLine(string.Format("{0} = {1}", "Caluculator.Add(\"//[*][%]\\n1**2%3\")", Caluculator.Add("//[*][%]\n1**2%3")));
            Console.WriteLine(string.Format("{0} = {1}", "Caluculator.Add(\"//[*][%][_]\\n1*2%%3___5%%1002\")", Caluculator.Add("//[*][%][_]\n1*2%%3___5%%1002")));
            Console.WriteLine(string.Format("{0} = {1}", "Caluculator.Add(\"//[**][%%][__][&]\\n1**2%%3__5&9\")", Caluculator.Add("//[**][%%][__][&]\n1**2%%3__5&9")));
           
            //Console.WriteLine(Caluculator.Add("//y\n1\n2y3\n4,-9y-6"));

            //Console.WriteLine(Caluculator.Add("//[y][x]\n1\n2y3\n4,-9x-6"));
 



            Console.ReadLine();
        }
    }
}
