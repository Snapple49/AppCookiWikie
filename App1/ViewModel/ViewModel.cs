using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
//using System.IO.IsolatedStorage;



namespace App1.Common
{
    class ViewModel
    {
        public ObservableCollection<Cooki> CookieList { get; set; }

        public void GetCookies()
        {
            GetDefaultCookies();
        }

        public void GetDefaultCookies(){
            ObservableCollection<Cooki> a = new ObservableCollection<Cooki>();

            a.Add(new Cooki() { Name = "Chocolate chip cookie", ImgLoc = "Assets/ChocolateChip.png" });
            a.Add(new Cooki() { Name = "Chocolate chip cookie 2", ImgLoc = "Assets/ChocolateChip.png" });
            a.Add(new Cooki() { Name = "Chocolate chip cookie 3", ImgLoc = "Assets/ChocolateChip.png" });

            CookieList = a;
        }
    }
}
