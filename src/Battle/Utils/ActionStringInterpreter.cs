using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ShipCore.Battle.Utils
{
    public static class ActionStringInterpreter
    {
        private const bool DEBUG_MODE = false;

        public static bool IsStringValid(String str)
        {
            String[] parts = str.Split(':');

            // Check if at least EntityID, ActionType and Target are available in str
            if (parts.Length < 3) return false;

            // Check if first information is EntityID
            try {
                Guid tmp = Guid.Parse(parts[0]);
            }
            catch (FormatException) {
                Console.WriteLine("SHIPCORE ERR: (ActionStringInterpreter - IsStringValid) | Bad format : " + parts[0]);
                return false;
            }

            // Check if second information is Action (only alphabetical characters)
            if (!Regex.IsMatch(parts[1], @"^[a-zA-Z]+$")) return false;

            // Check if third parameter is Target (tuple)
            if (!Regex.IsMatch(parts[2], @"^\([0-9]+,[0-9]+\)$")) return false;

            if (DEBUG_MODE)
            {
                Console.WriteLine("Entity " + parts[0] + " performs " + parts[1] + " on " + parts[2]);
                for (int i = 3; i < parts.Length; i++)
                {
                    Console.WriteLine("\tParam #" + (i - 2) + " : " + parts[i]);
                }
            }

            return true;
        }
    }
}
