using System;

namespace Turnierverwaltung.Views
{
    public class ConsoleUi
    {
        #region properties
        
        private string _text;
        
        #endregion
        
        #region accessor/modifier

        public string Text
        {
            get => _text;
            set => _text = value;
        }

        #endregion

        #region constructor

        public ConsoleUi()
        {
            Text = "";
        }

        public ConsoleUi(string text)
        {
            Text = text;
        }

        #endregion

        #region worker

        public string OutputText(string text)
        {
            Text = text;
            Console.WriteLine(Text);
            return Text;
        }

        public string InputText()
        {
            Text = Console.ReadLine();
            return Text;
        }
        
        #endregion
    }
}