﻿using System;
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

namespace WDictionary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
       public MainWindow()
        {
            InitializeComponent();
            mainLabel.Content = DateTime.Now.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EnglishToEnglish nextPage = new EnglishToEnglish();
            nextPage.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EnglishToHindi nextPage = new EnglishToHindi();
            nextPage.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EnglishToBengali nextPage = new EnglishToBengali();
            nextPage.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is a windows based Dictionary application provide word meaning to the user without any online connection\nDeveloped By:-\nAbhishek Sharma\nAkshat Mani\nNalini Srivastav\nKritika Sinha");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("1.Main interface of the Dictionary application provide you a path for word meaning.\n2.ClickMe gives you word of the day.\n3.Choose your language to which you want meaning,it is given below in button form,when you click on the following buttons you will get a new interface for the translation of word.\n4.EnglishToEnglish button convert to english language\n5.EnglishToHindi convert to hindi language");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
