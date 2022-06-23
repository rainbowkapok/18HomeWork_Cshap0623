using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_游曉雯_HomeWork
{
    class Ans3
    {
    }

    public class Prices
    {
        //public int No 
        //{
        //    get { return No;  }
        //    set 
        //    { 
        //        int i = 0;
        //        No += i;
        //    }
        //}

        //public int BeerSubtotal
        //{
        //    get { return BeerSubtotal; }
        //    set 
        //    {
        //        int Money = 120;
        //        int BeerSubtotal = No * Money;
        //    }
        //}
        public delegate int Payment(int Money, int No);
        public int Number(int num)
        {
            int No;
            No = num + 1;
            return No;
        }

        public int Subtotal(int Money, int No)
        {
            int pay = No * Money;
            return pay;
        }

        

       
        
        //public int Menu (int m, int No) 
        //{
        //    int ShowItem=0;
        //    int[] Order = new int[No];
        //    for (int i = 0; i < No; i++)
        //    {
        //        Order[i] = m;
        //    }

        //    foreach (int item in Order)
        //    {
        //        ShowItem += item;
               
        //    } return ShowItem;
        //}
        
    }
}
