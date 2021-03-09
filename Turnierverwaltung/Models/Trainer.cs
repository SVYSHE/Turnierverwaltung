using MySql.Data.MySqlClient;

namespace Turnierverwaltung.Models
{
    public class Trainer : Teilnehmer
    {
        #region properties

        private int _jahresgehaltInEuro;
        
        #endregion

        #region accessor/modifier

        public int JahresgehaltInEuro
        {
            get => _jahresgehaltInEuro;
            set => _jahresgehaltInEuro = value;
        }

        #endregion
        
        #region constructors

        public Trainer()
        {
            JahresgehaltInEuro = 0;
        }

        public Trainer(string name, int jahresgehaltInEuro) : base(name)
        {
            JahresgehaltInEuro = jahresgehaltInEuro;
        }
        #endregion
        
        #region worker
        
        #endregion
    }
}