using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    //Count Property
    public class CustomList<T>
    {
        public static void Count()
        {
            List<string> NFLTeams = new List<string>();
            NFLTeams.Add("Packers");
            NFLTeams.Add("Bears");
            NFLTeams.Add("Vikings");

            Console.WriteLine("{0} NFLTeams:", NFLTeams.Count);
            Display(NFLTeams);

        }
        //Add Method
        public static double AddMethod(double firstNumber, double secondNumber)
        {
            double a = firstNumber = 5;
            double b = secondNumber = 5;
            return a + b;
        }
    }

}
