using System.Collections.Generic;

namespace Turnierverwaltung.Models
{
    public class Turnier
    {
        #region properties

        private List<Teilnehmer> _teilnehmer;
        private List<Spiel> _spiele;

        #endregion

        #region accessor/modifier

        public List<Teilnehmer> Teilnehmer
        {
            get => _teilnehmer;
            set => _teilnehmer = value;
        }

        public List<Spiel> Spiele
        {
            get => _spiele;
            set => _spiele = value;
        }

        #endregion

        #region constructors

        #endregion

        #region worker

        #endregion
    }
}