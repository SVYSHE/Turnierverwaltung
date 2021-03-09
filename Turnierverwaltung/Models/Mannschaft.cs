using MySql.Data.MySqlClient;

using System.Collections.Generic;

namespace Turnierverwaltung.Models
{
    public class Mannschaft : Teilnehmer
    {
        #region properties

        private List<Teilnehmer> _mitglieder;

        #endregion

        #region accessor/modifier

        public List<Teilnehmer> Mitglieder
        {
            get => _mitglieder;
            set => _mitglieder = value;
        }

        #endregion

        #region constructors

        public Mannschaft()
        {
            Mitglieder = new List<Teilnehmer>();
        }

        public Mannschaft(string name, List<Teilnehmer> mitglieder) : base(name)
        {
            Mitglieder = mitglieder;
        }
        #endregion

        #region worker

        #endregion
    }
}