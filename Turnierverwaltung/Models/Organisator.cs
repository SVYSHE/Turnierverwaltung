using MySql.Data.MySqlClient;

namespace Turnierverwaltung.Models
{
    public class Organisator : Teilnehmer
    {
        #region properties

        private int _organisatorId;
        
        #endregion

        #region accessor/modifier

        public int OrganisatorId
        {
            get => _organisatorId;
            set => _organisatorId = value;
        }

        #endregion
        
        #region constructors

        public Organisator()
        {
            OrganisatorId = 0;
        }

        public Organisator(string name, int organisatorId) : base(name)
        {
            OrganisatorId = organisatorId;
        }
        #endregion
        
        #region worker
        
        #endregion
    }
}