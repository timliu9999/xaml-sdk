﻿using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using CreateCustomDateTimePickerColumn;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
			this.radGridView.ItemsSource = Club.GetClubs();
        }
    }
}
