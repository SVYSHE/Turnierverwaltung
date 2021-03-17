using System.Buffers.Text;
using System.Data;
using System.Data.SQLite;

namespace Turnierverwaltung.Models
{
    public class Handballspieler : Spieler
    {
        private string _wurfHand;

        public string WurfHand
        {
            get => _wurfHand;
            set => _wurfHand = value;
        }

        public Handballspieler() : base()
        {
            WurfHand = "";
        }

        public Handballspieler(string wurfHand, string name, int id, SQLiteConnection connection) : base(name, id,
            connection)
        {
            WurfHand = wurfHand;
        }

        public override int? InsertIntoDb()
        {
            int anzahl = 0;
            string sqlString = $"insert into handballspieler (id, name, wurfhand) values({Id},{Name},{WurfHand});";
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