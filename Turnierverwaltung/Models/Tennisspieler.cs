namespace Turnierverwaltung.Models
{
    public class Tennisspieler : Teilnehmer
    {
        #region properties

        private int _platzAufWeltrangliste;
        
        #endregion

        #region accessor/modifier

        public int PlatzAufWeltrangliste
        {
            get => _platzAufWeltrangliste;
            set => _platzAufWeltrangliste = value;
        }

        #endregion
        
        #region constructors

        public Tennisspieler()
        {
            PlatzAufWeltrangliste = 0;
        }

        public Tennisspieler(string name, int platzAufWeltrangliste) : base(name)
        {
            PlatzAufWeltrangliste = platzAufWeltrangliste;
        }
        #endregion
        
        #region worker
        
        #endregion
    }
}