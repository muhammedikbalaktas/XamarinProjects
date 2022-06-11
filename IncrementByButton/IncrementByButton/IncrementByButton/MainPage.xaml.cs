using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IncrementByButton
{
    public partial class MainPage : ContentPage
    {
        static int num = 0;
        
        public MainPage()
        {
            


            InitializeComponent();

            
            
        }

        void my_click(object sender, EventArgs args)
        {
            num++;
            text_for_increment.Text = "" + num;

        }


    }
    


}

