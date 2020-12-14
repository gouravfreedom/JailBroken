using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CryptoCheck
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();

            var detector = new JailbreakDetector(new Ex.Env()).IsJailbroken;
            //var data = detector.IsJailbroken();
            Console.WriteLine(detector.ToString());
        }
    }
}
