

using System;
using System.Data.Common;

namespace CustomerInheritanceApp.Domain
{
    class Customer : Object // ISA
    {

        private string _id;
        private string _name;
        private string _location;


        public Customer(string myid, string myname)
            :this(myid,myname,"Noida")
        {
           
           


        }

        public Customer(string id, string name, string _location)
        {

            _id = id;
            _name = name;
           this. _location = _location;

            Console.WriteLine("customer created");
        }
      

        public string Id
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Location
        {

            get { return _location; }
        }

        public override string ToString()
        {
            return $"id is {_id} , name is {_name} ,location {_location},parent {base.ToString()}";
        }

        public override bool Equals(object second)
        {
           
           Customer c=   second as Customer;//casting 
           return (this._id == c._id);
            //return (this.Id == c.Id && this.Name == c.Name);
        }

    }
}
