﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace HyperPC
{
    /// <summary>
    /// Логика взаимодействия для Robo.xaml
    /// </summary>
    public partial class Robo : Page
    {
        public Robo()
        {
            InitializeComponent();
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("https://kulikov205.github.io/Glas/");
            Process.Start("https://github.com/Kulikov205/Glas");
        }
    }
}
