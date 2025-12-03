using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpViolationApp.Domain
{
    class FixedDeposit
    {
        private int _accno;
        private string _name;
        private double _principleAmount;
        private int _duration;
        private FestivalOptions _festivalType;

        public FixedDeposit(int accno, string name, double principleAmount, int duration, FestivalOptions festivalType)
        {
            _accno = accno;
            _name = name;
            _principleAmount = principleAmount;
            _duration = duration;
            _festivalType = festivalType;
        }


        private double CalcuateRate()
        {

            if (_festivalType == FestivalOptions.Christmas)
                return .07;//complex 10 lines


            if (_festivalType == FestivalOptions.NewYear)
                return .08;///complex 10 lines


            if (_festivalType == FestivalOptions.Diwali)
                return .09;

            return .06;///complex 10 lines
        }

        public double SimpleInterest {
            get
            {

                return _principleAmount * _duration * CalcuateRate();
            }
        }

    }
}
