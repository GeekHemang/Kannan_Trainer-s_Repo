using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFormsApp.Domain
{
    class DataService
    {
        private Dictionary<string, string> userNamesAndPasswod = new Dictionary<string, string>();

        public DataService() {

            userNamesAndPasswod.Add("admin", "admin123");
        }

        public bool Validate(string username, string password)
        {
            if (userNamesAndPasswod.ContainsKey(username)) {
                //check for pwassword 
                string pwd = userNamesAndPasswod[username];
                return pwd== password;
            }
            return false;
        }
        
        public int GetData() {

            return 100;
        }
    }
}
