using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elite_Add_On_Helper
{
    public class Apps
    {
        private string name;
        private string location;
        private bool enabled;
        private string apptype;

        public string Name { get { return name; } set {name = value;} }
        public string Location { get { return location; } set {location = value;} } 
        public string Apptype { get { return apptype; } set { apptype= value;} }    
        public bool Enabled { get { return enabled; } set { enabled= value;} }


        
        public void Launch()
        {
            
        }
    }
}
