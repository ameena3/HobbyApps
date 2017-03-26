using System;

namespace ObserverPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface IregularPolygon
    {
         int NumberOfsides { get; set; }
        double getperimeter();
        

    }
}