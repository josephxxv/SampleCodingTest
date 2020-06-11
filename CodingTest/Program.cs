using System;

namespace CodingTest
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new App();
            app.Run(new MainWindow());
        }
    }
}
