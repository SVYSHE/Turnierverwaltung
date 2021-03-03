namespace Turnierverwaltung.Models
{
    public class Fussballspieler : Teilnehmer
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

        public Fussballspieler()
        {
            Position = "";
        }

        public Fussballspieler(string name, string position) : base(name)
        {
            Name = name;
            Position = position;
        }
        #endregion

        #region worker

        #endregion
    }
}