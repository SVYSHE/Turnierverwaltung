using MySql.Data.MySqlClient;

namespace Turnierverwaltung.Models
{
    public class Schiedsrichter : Teilnehmer
    {
        #region properties

        private int _anzahlSpieleErfahrung;
        
        #endregion

        #region accessor/modifier

        public int AnzahlSpieleErfahrung
        {
            get => _anzahlSpieleErfahrung;
            set => _anzahlSpieleErfahrung = value;
        }

        #endregion
        
        #region constructors

        public Schiedsrichter()
        {
            AnzahlSpieleErfahrung = 0;
        }

        public Schiedsrichter(string name, int anzahlSpieleErfahrung) : base(name)
        {
            AnzahlSpieleErfahrung = anzahlSpieleErfahrung;
        }
        #endregion
        
        #region worker
        
        #endregion
    }
}