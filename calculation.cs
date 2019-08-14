using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callllculator_finall
{
    class calculation
    {    // declaration of required varaiables

        private double fnum;
        private double snum;
        private string opr;
        private double result;

        public double Fnum { get => fnum; set => fnum = value; }
        public double Snum { get => snum; set => snum = value; }
        public string Opr { get => opr; set => opr = value; }
        public double Result { get => result; set => result = value; }

        //calculation of numbers
        public double calculate()
        {
            switch (opr)
            {

                case "+":

                    result = fnum + snum;
                    break;

                case "-":

                    result = fnum - snum;
                    break;


                case "*":

                    result = fnum * snum;
                    break;


                case "/":

                    result = fnum / snum;
                    break;


            }
            return result;
        }
    }

}