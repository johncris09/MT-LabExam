using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MIT_05_MANABO
{
    class Calculator
    {
        public double first_num;
        public double second_num;
        public double result;

        public double Add(double fnum,double snum) 
        {
            this.first_num = fnum;
            this.second_num = snum;
            this.result = this.first_num + this.second_num;
            return this.result;
        }
        public double Minus(double fnum, double snum)
        {
            this.first_num = fnum;
            this.second_num = snum;
            this.result = this.first_num - this.second_num;
            return this.result;
        }
        public double Times(double fnum, double snum)
        {
            this.first_num = fnum;
            this.second_num = snum;
            this.result = this.first_num * this.second_num;
            return this.result;
        }
        public double Divide(double fnum, double snum)
        {
            this.first_num = fnum;
            this.second_num = snum;
            this.result = this.first_num / this.second_num;
            return this.result;
        }
        public double Modulu(double fnum, double snum)
        {
            this.first_num = fnum;
            this.second_num = snum;
            this.result = this.first_num % this.second_num;
            return this.result;
        }
    }
}
