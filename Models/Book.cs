using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models;

internal class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Authors { get; set; }
    public string Year { get; set; }
    public string Publisher { get; set; }
    public string Isbn { get; set; }
    public string Summary { get; set; }
}
