﻿using System.Text;
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
    }

    

        

        }
    
