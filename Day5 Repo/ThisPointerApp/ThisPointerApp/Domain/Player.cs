using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisPointerApp.Domain
{
    class Player
    {
        private string _name;
        private int _age;

      
        public Player(string _name, int _age)
        {
            Console.WriteLine("player created");
            this._age = _age;
            this._name = _name;
           
        }

        public Player WhoIsElder(Player secondPlayer) {
            if (secondPlayer.Age > this.Age)
                return secondPlayer;

            return this;
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
