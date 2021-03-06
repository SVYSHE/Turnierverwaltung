﻿namespace Turnierverwaltung.Models
{
    public class Physio : Teilnehmer
    {
        #region properties

        private int _id;
        
        #endregion

        #region accessor/modifier

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        #endregion
        
        #region constructors

        public Physio()
        {
            Id = 0;
        }

        public Physio(string name, int id) : base(name)
        {
            Id = id;
        }
        #endregion
        
        #region worker
        
        #endregion
    }
}