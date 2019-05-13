using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Project
{
    class Program
    {
        public const int INPUT_DATA_OPTION = 1;
        public const int CROSS_JOIN_OPTION = 2;
        public const int PRINT_CALC_OPTION = 3;
        public const int PRINT_RESULTS_OPTION = 4;
        public const int CLEAR_DATA_BASE_OPTION = 5;
        public const int EXIT_OPTION = 6;
        static void Main(string[] args)
        {
            int action = 0;
            while (action != EXIT_OPTION)
            {
                action = Menu.StartMenu();
                switch (action)
                {
                    case 1:
                        Calculator.InputData();
                        break;
                    case 2:
                        Calculator.CrossJoinData();
                        break;
                    case 3:
                        Calculator.PrintCalc();
                        break;
                    case 4:
                        Calculator.PrintResults();
                        break;
                    case 5:
                        Calculator.ClearDB();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
