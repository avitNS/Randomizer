using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer
{
    class Params
    {
        public int From { get; set; }
        public int To { get; set; }
        public Params() { }
        public void GetValues(MainWindow mainWindow)
        {
            if (mainWindow.tbFrom.Text == "" || mainWindow.tbFrom.Text==" ")
            {
                mainWindow.tbFrom.Text = "0";
                From = 0;
            }  
            else
                From = int.Parse(mainWindow.tbFrom.Text);
            if (mainWindow.tbTo.Text == "" || mainWindow.tbTo.Text == " ")
            {
                mainWindow.tbTo.Text = "1";
                To = int.Parse(mainWindow.tbTo.Text);
            }
            else
                To = int.Parse(mainWindow.tbTo.Text);


        }
    }
}
