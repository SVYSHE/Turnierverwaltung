using System.Collections.Generic;

namespace Turnierverwaltung.Models
{
    public class Spiel
    {
        #region properties

        private List<Teilnehmer> _teilnehmer;

        #endregion

        #region accessor/modifier

        public List<Teilnehmer> Teilnehmer
        {
            get => _teilnehmer;
            set => _teilnehmer = value;
        }

        #endregion

        #region constructors

        public Spiel()
        {
            Teilnehmer = new List<Teilnehmer>();
        }

        public Spiel(List<Teilnehmer> teilnehmer)
        {
            Teilnehmer = teilnehmer;
        }
        #endregion

        #region worker

        #endregion
    }
}