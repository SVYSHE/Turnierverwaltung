namespace Turnierverwaltung.Models
{
    public class Teilnehmer
    {
        #region properties
        
        private string _name;

        #endregion

        #region accessor/modifier

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        #endregion

        #region constructors

        public Teilnehmer()
        {
            Name = "";
        }
        
        public Teilnehmer(string name)
        {
            Name = name;
        }
        #endregion

        #region worker

        #endregion
    }
}