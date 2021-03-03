using Turnierverwaltung.Views;

namespace Turnierverwaltung.Controller
{
    public class Controller
    {
        #region properties

        private ConsoleUi _ui;
        

        #endregion

        #region accessor/modifier

        public ConsoleUi Ui
        {
            get => _ui;
            set => _ui = value;
        }

        #endregion

        #region constructors

        public Controller()
        {
            Ui = new ConsoleUi();
        }

        public Controller(ConsoleUi ui)
        {
            Ui = ui;
        }

        #endregion
        
        #region worker
        
        public void Run()
        {
                
        }
        
        #endregion
        
    }
}