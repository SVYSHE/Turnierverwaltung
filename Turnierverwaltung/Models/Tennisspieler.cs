using System.Data;
using System.Data.SQLite;

namespace Turnierverwaltung.Models
{
    public class Tennisspieler : Spieler
    {
        private string _schlagHand;

        public string SchlagHand
        {
            get => _schlagHand;
            set => _schlagHand = value;
        }

        public Tennisspieler() : base()
        {
            SchlagHand = "";
        }

        public Tennisspieler(string schlagHand, string name, int id, SQLiteConnection connection) : base(name, id,
            connection)
        {
            SchlagHand = schlagHand;
        }
        public override int? InsertIntoDb()
        {
            int anzahl = 0;
            string sqlString = $"insert into tennisspieler (id, name, schlaghand) values({Id},{Name},{SchlagHand});";
            SQLiteCommand command = new SQLiteCommand(sqlString, Connection);

            try
            {
                Connection.Open();
                return command.ExecuteNonQuery();
            }
            catch (SQLiteException sqlEx)
            {
                return null;
            }
            finally
            {
                if (Connection.State.Equals(ConnectionState.Open))
                {
                    Connection.Close();
                }
            }
        }
    }
}