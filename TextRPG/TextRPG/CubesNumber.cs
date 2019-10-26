using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public static class CubesNumber
    {
        private static Random random = new Random();

        public static int D4
        {
            get { return random.Next(1, 4); }
        }

        public static int D6
        {
            get { return random.Next(1, 6); }
        }

        public static int D8
        {
            get { return random.Next(1, 8); }
        }

        public static int D20
        {
            get { return random.Next(1, 20); }
        }
    }
}
