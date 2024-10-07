using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Git_taak_1
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

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Mainwindow.Background = new SolidColorBrush(Colors.Black);
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Mainwindow.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Image_MouseEnter_1(object sender, MouseEventArgs e)
        {
            Mainwindow.Background = new SolidColorBrush(Colors.Green);
        }
        private void Image_MouseLeave_1(object sender, MouseEventArgs e)
        {
            Mainwindow.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Image_MouseEnter_2(object sender, MouseEventArgs e)
        {
            Mainwindow.Background = new SolidColorBrush(Colors.Blue);
        }

        private void Image_MouseLeave_2(object sender, MouseEventArgs e)
        {
            Mainwindow.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Image_MouseEnter_3(object sender, MouseEventArgs e)
        {
            Mainwindow.Background= new SolidColorBrush(Colors.Yellow);
        }

        private void Image_MouseLeave_3(object sender, MouseEventArgs e)
        {
            Mainwindow.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Image_MouseEnter_4(object sender, MouseEventArgs e)
        {
            Mainwindow.Background = new SolidColorBrush(Colors.Red);
        }

        private void Image_MouseLeave_4(object sender, MouseEventArgs e)
        {
            Mainwindow.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Colour_Code.Text = "#008000";
            Colour_information.Text = "Groen is de kleur van genezing";
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Colour_Code.Text = "#0000FF";
            Colour_information.Text = "Blauw is de kleur van intelligentie";
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            Colour_Code.Text = "#FFFF00";
            Colour_information.Text = "Geel is de kleur van levenslust";
        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            Colour_Code.Text = "#FF0000";
            Colour_information.Text = "Rood is de kleur van warmte";
        }
    }

    

        

        }
    
