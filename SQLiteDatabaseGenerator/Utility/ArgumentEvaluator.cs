using System;
using System.Data;
using System.IO;

namespace SQLiteDatabaseGenerator.Utility
{
    public class ArgumentEvaluator
    {
        private string[] _arguments;
        private string _databaseTargetPath;
        private string _databaseTargetName;
        private string _createScriptPath;
        private string _createScriptName;

        private string DatabaseTargetPath
        {
            get => _databaseTargetPath;
            set => _databaseTargetPath = value;
        }

        private string CreateScriptPath
        {
            get => _createScriptPath;
            set
            {
                if (File.Exists(value))
                    _createScriptPath = value;
                else
                {
                    throw new FileNotFoundException($"The create script file at the specified path '{value}' does not exist"); 
                }
            }
        }
        public string[] Arguments
        {
            get => _arguments;
            set
            {
                if (!value.Length.Equals(2))
                {
                    throw new ArgumentException("Please specify exactly 2 arguments.");
                }

                _arguments = value;
                _databaseTargetPath = value[0];
                _createScriptPath = value[1];
                _databaseTargetName = ExtractFileNameFromPathExpression(_databaseTargetPath);
                _createScriptName = ExtractFileNameFromPathExpression(_createScriptPath);
            }
        }
        

        public ArgumentEvaluator(string[] args)
        {
            Arguments = args;
        }

        private string ExtractFileNameFromPathExpression(string pathExpression)
        {
            string fileName = "";
            if (pathExpression.Length == 0)
            {
                throw new InvalidExpressionException(
                    "Please specify a valid path expression with the filename included at the end of the expression!");
            }

            if (!pathExpression.LastIndexOf('/').Equals(0))
            {
                fileName = pathExpression.Substring(pathExpression.LastIndexOf('/') + 1);    
            }
            else if (!pathExpression.LastIndexOf('\\').Equals(0))
            {
                fileName = pathExpression.Substring(pathExpression.LastIndexOf('\\') + 1);
            }
            else
            {
                throw new InvalidExpressionException($"The expression {pathExpression} is not a valid path expression!");
            }
            return fileName;
        }
    }
}