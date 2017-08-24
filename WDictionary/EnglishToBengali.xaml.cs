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
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace WDictionary
{
    /// <summary>
    /// Interaction logic for EnglishToBengali.xaml
    /// </summary>
    public partial class EnglishToBengali : Window
    {
        String label;
        public EnglishToBengali()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AKSHAT-PC;Initial Catalog=dictionary;Integrated Security=True");
            SqlCommand sd = new SqlCommand(@"SELECT Meaning FROM Words_2 WHERE Word= '" + textBox1.Text + "'", con);
            con.Open();
            SqlDataReader dr = sd.ExecuteReader();
            if (dr.Read())
            {
                label = dr.IsDBNull(dr.GetOrdinal("Meaning"))
                  ? String.Empty
                  : dr.GetString(dr.GetOrdinal("Meaning"));
            }
            dr.Close();
            label1.Content = label;

        }

       
    }
}
