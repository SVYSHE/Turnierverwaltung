using System;
using static Turnierverwaltung.Controller.BaseController;

namespace Turnierverwaltung
{
    class Program
    {
        static void Main()
        {
            Controller.BaseController baseController = new Controller.BaseController();
            baseController.Run();
        }
    }
}