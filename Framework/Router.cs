using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Controllers;

namespace ConsoleApp2.Framework;

internal static class Router
{
    static BookControllers bookController = new();
    static MainController mainController = new();
    public static void Forward(string route)
    {
        switch (route.ToLower())
        {
            case "help":
                mainController.Help(); break;
            case "clear":
                mainController.Clear(); break;
            case "list":
                bookController.List();
                break;
            case "single":
                bookController.Single(5);
                break;
            default:
                break;

        }
    }
}