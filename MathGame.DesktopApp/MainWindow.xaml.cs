﻿using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace MathGame.DesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();

#if DEBUG
            serviceCollection.AddBlazorWebViewDeveloperTools();
#endif
            Resources.Add("services", serviceCollection.BuildServiceProvider());
        }
    }
}
