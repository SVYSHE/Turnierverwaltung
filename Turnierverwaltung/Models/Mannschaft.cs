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

        public Mannschaft() : base()
        {
            
        }

        public Mannschaft(string name) : base()
        {
            
        }
        #endregion

        #region worker

        #endregion
    }
}