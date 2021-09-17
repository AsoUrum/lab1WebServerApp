using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace Lab1_ASP.NetConnectedMode.VALIDATION
{
    public class Validator
    {
        // version 1
        public static bool Isvalid(string input)
        {
            if (!(Regex.IsMatch(input, @"^\d{4}$")))
            {
                return false;
            }
            return true;
        }
        // version 2 more flexible for any lenght of numbers for an employee id
        public static bool Isvalid(string input, int size)
        {
            if (!(Regex.IsMatch(input, @"^\d{"+ size +"}$")))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidName(string input) { 
            if (input.Length ==  0)
            {
                return false;
            }
            for(int i = 0; i< input.Length; i++)
            {
                if( ((char.IsNumber(input[i])) && (!(char.IsLetter(input[i])))) )
                {

                return false;

                }
            }
            return true;
        }



    }
}