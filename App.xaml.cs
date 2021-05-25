using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Prism.Ioc;
using Prism.Unity;
using TIAOpenness.ViewModels;

namespace TIAOpenness
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
public partial class App : PrismApplication
{
    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
        //创建服务
        // containerRegistry.Register<Services.ICustomerStore, Services.DbCustomerStore>();
        containerRegistry.RegisterForNavigation<MainWindow, MainWindow1ViewModel>();

        }

    protected override Window CreateShell()
    {
        var w = Container.Resolve<MainWindow>();
        return w;
    }
}
}
