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

namespace MedFed_Nutrition
{
    /// <summary>
    /// Interaction logic for GoalsControl.xaml
    /// </summary>
    public partial class GoalsControl : UserControl
    {
        public GoalsControl()
        {
            InitializeComponent();
            this.Save.Click += Save_Click;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string printMsg = "Saved Info";
            MessageBox.Show(printMsg);
        }
    }
}
