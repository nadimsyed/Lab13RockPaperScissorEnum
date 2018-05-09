using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab13
{
    class Validator
    {
        //TODO: Add Space and Enter validators, as well as other validations I did in TaskList(as well as other
        //      past projects I did. Can use it as a revolving validator class inshaAllah
        public static bool DoubleChecker(string x)
        {
            return double.TryParse(x, out double work);
        }

        public static bool IntChecker(string x)
        {
            return int.TryParse(x, out int work);
        }
        
        public static bool SpaceEnterChecker(string input)
        {
            return (input == "" || Regex.IsMatch(input, @"\s"));
        }



        public static bool DateTimeChecker(string input)
        {
            bool dateTimeWorked = DateTime.TryParse(input, out DateTime dateTime);
            return dateTimeWorked;
        }
    }
}
