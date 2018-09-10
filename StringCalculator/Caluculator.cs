using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Caluculator
    {
        public Caluculator()
        {

        }

        public static Int64 Add(string numbers)
        {

            List<string> delemiters = new List<string> { ",", "\n" };
            Int64 result = 0;
            char newDelem;

            string newDelecmStr = string.Empty;
            if (string.IsNullOrEmpty(numbers))
                return 0;

            if (numbers.StartsWith("//") && numbers.Contains("\n"))
            {

                numbers = numbers.TrimStart('/');
                string newDelems = numbers.Substring(0, numbers.IndexOf('\n'));
                numbers = numbers.Substring(numbers.IndexOf('\n') + 1);

                Regex regex = new Regex(@"\[(?<delem>.*?)\]");
                MatchCollection matches = regex.Matches(newDelems.TrimEnd('\n'));

                if (!string.IsNullOrEmpty(newDelems) &&  newDelems.Length == 1)
                    delemiters.Add(newDelems);

                else if(!string.IsNullOrEmpty(newDelems) && newDelems.Length > 1)
                {
                    foreach (Match _match in matches)
                    {
                        delemiters.Add(_match.Groups["delem"].Value);
                    }
                }
                //string[] DelemAndNumbers = numbers.Split('\n');
                //
                //newDelem = numbers[0];
                //
                //newDelecmStr = Convert.ToString(newDelem);
                
            }

            string[] numberstoAdd = numbers.Split(delemiters.ToArray<string>(), StringSplitOptions.RemoveEmptyEntries);

            if (numberstoAdd != null && numberstoAdd.Count() == 0)
                return 0;

            var negatives = numberstoAdd.ToList<string>().Where(num => Convert.ToInt64(num) < 0).ToList();
            if(negatives != null && negatives.Count > 0)
                throw new Exception(string.Format("negatives not allowed: ({0})", string.Join(", ", negatives)));

            foreach (string _str in numberstoAdd)
            {
                Int64 _num = Convert.ToInt64(_str);

                if (_num < 0)
                    throw new Exception(string.Format("negatives not allowed - {0}", _num));

                if (_num > 1000)
                    continue;

                result += _num;               
            }

            return Convert.ToInt64(result);
        }
    }
}
