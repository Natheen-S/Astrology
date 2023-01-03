using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Astrology
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_generate_Click(object sender, RoutedEventArgs e)
        {
            char[] name = txtbox_name.Text.ToCharArray();
            string name1 = txtbox_name.Text;
            int dateofyear = Convert.ToInt32(txtbox_year.Text);
            int age = 2023 - dateofyear;
            if (name[0] == 'a' || name[0] == 's' || name[0] == 'd' || name[0] == 'f' || name[0] == 'g' || name[0] == 'h' || name[0] == 'j' || name[0] == 'k' || name[0] == 'l' && age <= 30)
            {
                lbl_result.Content = "வணக்கம் " + name1 + "\nYour age is " + age + "\n      You have a Great year ahead be focus on what you want. \n     Be honest yourselves";
            }
            if (name[0] == 'a' || name[0] == 's' || name[0] == 'd' || name[0] == 'f' || name[0] == 'g' || name[0] == 'h' || name[0] == 'j' || name[0] == 'k' || name[0] == 'l' && age >= 30)
            {
                lbl_result.Content = "வணக்கம் " + name1 + "\nYour age is " + age + "\n      You have to be careful at any cost. \n     Be Happy for the rest of your lives";
            }
            if (name[0] == 'q' || name[0] == 'w' || name[0] == 'e' || name[0] == 'r' || name[0] == 't' || name[0] == 't' || name[0] == 'y' || name[0] == 'u' || name[0] == 'i' || name[0] == 'o' || name[0] == 'p' && age <= 30)
            {
                lbl_result.Content = "வணக்கம் " + name1 + "\nYour age is " + age + "\n      You are going to be a millionaire \n     Be focused no matter what";
            }
            if (name[0] == 'q' || name[0] == 'w' || name[0] == 'e' || name[0] == 'r' || name[0] == 't' || name[0] == 't' || name[0] == 'y' || name[0] == 'u' || name[0] == 'i' || name[0] == 'o' || name[0] == 'p' && age >= 30)
            {
                lbl_result.Content = "வணக்கம் " + name1 + "\nYour age is " + age + "\n      You have a Great year ahead be focus on what you want. \n     Be honest yourselves";
            }
            if (name[0] == 'z' || name[0] == 'x' || name[0] == 'c' || name[0] == 'v' || name[0] == 'b' || name[0] == 'b' || name[0] == 'n' || name[0] == 'n' || name[0] == 'n' || name[0] == 'o' || name[0] == 'p' && age <= 30)
            {
                lbl_result.Content = "வணக்கம் " + name1 + "\nYour age is " + age + "\n      You are going to be a millionaire \n     Be focused no matter what";
            }
            if (name[0] == 'z' || name[0] == 'x' || name[0] == 'c' || name[0] == 'v' || name[0] == 'b' || name[0] == 'b' || name[0] == 'n' || name[0] == 'n' || name[0] == 'n' || name[0] == 'o'  && age >= 30)
            {
                lbl_result.Content = "வணக்கம் " + name1 + "\nYour age is " + age + "\n      You have to be careful at any cost. \n     Be Happy for the rest of your lives";
            }
        }
    }
}
