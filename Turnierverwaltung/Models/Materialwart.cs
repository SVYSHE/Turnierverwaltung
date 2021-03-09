using MySql.Data.MySqlClient;

namespace Turnierverwaltung.Models
{
    public class Materialwart : Teilnehmer
    {
        #region properties

        private int _id;
        
        #endregion

        #region accessor/modifier

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        #endregion
        
        #region constructors

        public Materialwart()
        {
            Id = 0;
        }

        public Materialwart(string name, int id) : base(name)
        {
            Id = id;
        }
        #endregion
        
        #region worker
        
        #endregion
    }
}