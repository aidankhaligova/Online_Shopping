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

namespace OnlineShopping.Views.SmallWindows
{
    /// <summary>
    /// Interaction logic for EmployeeAddWindow.xaml
    /// </summary>
    public partial class EmployeeAddWindow : Window
    {
        public EmployeeAddWindow()
        {
            InitializeComponent();
        }

       

        private void CloseClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}