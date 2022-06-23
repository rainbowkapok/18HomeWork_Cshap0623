using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_游曉雯_HomeWork
{
    class Ans2
    {
        public class CalNum
        {
            public static int myMoney;
            public static int myYear;
            public static int myRate;
            public static int MyMonth;//月數
            public static int myFirst;
            public static double PMT;//每月應付金額
            public static double Total;
        }

        public double Cal(int money, int year, double rate, int first)
        {
            double Mrate = (rate / 100) / 12; //月利率
            int MyMonth = year * 12;  //月數
            double t = (Mrate * Math.Pow((1 + Mrate), MyMonth)) / (Math.Pow((1 + Mrate), MyMonth) - 1);
            double PMT = (money - first) * t;  //PMT=>本金餘額*月利率

            return PMT;
        }

        public double CalTotal(double PMT, int year)
        {
            double Total;
            int MyMonth = year * 12; //月數
            Total = Math.Round(PMT) * MyMonth;
            return Total;
        }

    }
}
