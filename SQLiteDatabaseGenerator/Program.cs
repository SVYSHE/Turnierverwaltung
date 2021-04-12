using System;
using SQLiteDatabaseGenerator.Controllers;

namespace SQLiteDatabaseGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseController controller = new BaseController();
            controller.Run(args);
            
        }
    }
}