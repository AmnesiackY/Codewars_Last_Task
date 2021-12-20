using System;

namespace Training_Proiect
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number for check");
            int nFloors = check_value(Console.ReadLine());
            Console.WriteLine(TowerBuilder(nFloors));
        }
        public static string[] TowerBuilder(int nFloors)
        {
            string[] tower = new string[nFloors];
            int spaces = nFloors - 1;
            for (int floor = 0; floor < nFloors; floor++, spaces--)
            {
                int asterisk = floor * 2 + 1;
                tower[floor] = new String(' ', spaces) + new String('*', asterisk) + new String(' ', spaces);
            }
            return tower;
        }
        public static int check_value(string str_check)
        {
            int str_int32;
            while (!Int32.TryParse(str_check, out str_int32))
            {
                Console.WriteLine("Symbols uncorrect! Try again ");
                str_check = Console.ReadLine();
            }
            return str_int32;
        }
    }
}

