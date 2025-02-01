using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public static class Helpers
    {
        public static int GetNumberBetween(int min, int max)
        {
            Random r = new();
            int number = r.Next(min, max + 1);
            return number;
        }
    }
}
