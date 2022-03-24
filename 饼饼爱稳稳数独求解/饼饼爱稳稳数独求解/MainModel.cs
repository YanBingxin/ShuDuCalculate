using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 饼饼爱稳稳数独求解
{
    public class MainModel
    {
        public static string[,] ShuDu = new string[9, 9];
        public static string[,] PerfectShuDu = new string[9, 9];
        public static List<string>[,] AvailableList = new List<string>[9, 9];
        public static Stack<string[,]> PreShuDu =new Stack<string[,]>();
    }
}
