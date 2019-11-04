using Calc.Currency;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calc.Cantor
{
   public  class RecalculateCurrencies

    {
        private const decimal euroEx = 3.14M;
        private const decimal dollarEx = 3.14M;


        //public  decimal Exchange(Euro euro, Pln pln)
        //{
        //    if (pln. > 0)
        //    {
        //        return euro. * pln.;
        //    }
        //    else
        //        Console.WriteLine("Cant multitude");
        //    return 0;
        //}
        //public  decimal Substract(Euro euro, Pln pln)
        //{
        //    if (euro. >= pln.)
        //    {
        //        return euro. - pln.;
        //    }
        //    else
        //    Console.WriteLine("You dont have enught money");
        //    return 0;
        //}
        //public decimal Add(Euro euro, Pln pln)
        //{
        //    return euro. + pln.;
        //}

        public decimal Exchange(decimal euro, decimal pln)
        {
            if (pln > 0)
            {
                return euro * pln * euroEx;
            }
            else
                throw new Exception("Cant sub by 0");
            
        }
        public decimal Substract(decimal euro, decimal pln)
        {

           
            if (euro >= pln)
            {
                return (euro * euroEx) - pln;
            }
            else
           
            throw new Exception ("You dont have enught money");
        }
        public decimal Add(decimal euro, decimal pln)
        {
            return (euro * euroEx) + pln ;
        }

    }
}
