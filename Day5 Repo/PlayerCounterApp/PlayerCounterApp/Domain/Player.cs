using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCounterApp.Domain
{
    class Player
    {
        private string _name;
        private int _age;
        private static int _counter = 0;//static fields

        static Player()
        {
            _counter = 0;//load from db,file
            Console.WriteLine("inside static constructor called only once");

        }
        public Player(string name, int age)
        {
            Console.WriteLine("player constrcutor");
           this._age = age;
            this._name = name;
            _counter += 1;
        }


        public static int GetHeadCount()
        {


            return _counter;
        }



        public int Counter
        {

            get { return _counter; }
        }
        public int Age
        {
            get
            {
                return _age;
            }

        }
        public string Name
        {
            get { return _name; }

        }




    }
}
