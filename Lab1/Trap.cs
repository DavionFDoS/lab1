﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Trap : Abs
    {
        private double left;
        private double right;
        public Trap(double left, double right):base(left,right)
        {
            this.left = 1;
            this.right = 100000;
        }
        public double Tr(int n)
        {
            double h = (right - left) / n;
            double res = 0;

            for (int i = 1; i < n - 1; i++)
            {
                res += h * (Func(left + (h * i)));
            }

            res += (h * ((Func(left) + Func(right)) / 2));

            return res;
        }
    }
}
