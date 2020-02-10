using System;
using System.Text;

namespace RhombusDrower
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var rhombusDrawer = new RhombusDrawer();
            rhombusDrawer.Draw(n);
        }
    }
}
