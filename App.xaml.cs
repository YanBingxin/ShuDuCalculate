using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace 饼饼爱稳稳数独求解
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            IView view = new MainWindow();
            IViewModel viewModel = new MainViewModel(view);
            view.Show();
        
        }
    }
}
