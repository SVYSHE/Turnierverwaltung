namespace Turnierverwaltung.Models
{
    public class Spieler : Teilnehmer
    {
        #region properties

        private int _rueckennummer;
        
        #endregion

        #region accessor/modifier

        public int Rueckennummer
        {
            get => _rueckennummer;
            set => _rueckennummer = value;
        }

        #endregion
        
        #region constructors

        public Spieler()
        {
            Rueckennummer = 0;
        }

        public Spieler(string name, int rueckennummer) : base(name)
        {
            Rueckennummer = rueckennummer;
        }

        #endregion

        #region worker

        #endregion
    }
}