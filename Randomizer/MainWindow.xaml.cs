using System;
using System.Windows;

namespace Randomizer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        static string Generate(Params myparams)
        {
            string result;
            int temp;
            Random random = new Random();
            temp = random.Next(myparams.From, myparams.To);
            result = Convert.ToString(temp);
            return result;
        }

        private void btGenerate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Params myparams = new Params();
                myparams.GetValues(this);
                string res = Generate(myparams);
                tbNumber.Text = res;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(@"Change values! From can not be more than To!");
            }
            



        }
    }
}
