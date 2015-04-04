using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace App1.Common
{
    public class Cooki : INotifyPropertyChanged
    {
        //The name of the cookie
        public String Name { get; set; }

        //An image depicting the cookie
        public String ImgLoc { get; set; }





        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public Cooki GetCopy()
        {
            Cooki copy = (Cooki)this.MemberwiseClone();
            return copy;
        }
    }
}
