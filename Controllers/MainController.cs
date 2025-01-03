using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.View;

namespace ConsoleApp2.Controllers;

internal class MainController
{
    MainView view = new();
    public void Help()
    {
        view.HelpView();
    }
    public void Clear()
    {
        view.ClearView();
    }
}
