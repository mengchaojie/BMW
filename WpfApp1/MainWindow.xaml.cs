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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataContext dt = new DataContext();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = dt;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if(dt.UserLogin.UserName =="bmw" && dt.UserLogin.Password=="2022")
            {
                MessageBox.Show("登录成功");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
