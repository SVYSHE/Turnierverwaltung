using System.Data;
using SQLiteDatabaseGenerator.Utility;

namespace SQLiteDatabaseGenerator.Controllers
{
    public class BaseController
    {
        public BaseController()
        {
            
        }

        public void Run(string[] args)
        {
            // Evaluate Arguments
            ArgumentEvaluator argEvaluator = new ArgumentEvaluator(args);
            
            // Create Database
            
            
            // Run Create-Script
        }
    }

    
}