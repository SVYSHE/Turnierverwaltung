namespace Turnierverwaltung.Models
{
    public class Handballspieler : Teilnehmer
    {
        #region properties

        private string _position;
        
        #endregion

        #region accessor/modifier

        public string Position
        {
            get => _position;
            set => _position = value;
        }

        #endregion
        
        #region constructors

        public Handballspieler()
        {
            Position = "";
        }

        public Handballspieler(string name, string position) : base(name)
        {
            Position = position;
        }
        #endregion
        
        #region worker
        
        #endregion
    }
}