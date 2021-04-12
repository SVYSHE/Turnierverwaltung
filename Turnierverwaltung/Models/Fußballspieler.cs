using System.Data;
using System.Data.SQLite;

namespace Turnierverwaltung.Models
{
    public class Fußballspieler : Spieler
    {
        private int _rueckennummer;

        public int Rueckennummer
        {
            get => _rueckennummer;
            set => _rueckennummer = value;
        }

        public Fußballspieler() : base()
        {
            Rueckennummer = -1;
        }

        public Fußballspieler(int rueckennummer, string name, int id, SQLiteConnection connection) : base(name, id,
            connection)
        {
            Rueckennummer = rueckennummer;
        }

        public override int? InsertIntoDb()
        {
            int anzahl = 0;
            string sqlString = $"insert into fussballspieler (id, name, rueckennummer) values({Id},'{Name}',{Rueckennummer});";
            SQLiteCommand command = new SQLiteCommand(sqlString, Connection);

            try
            {
                Connection.Open();
                return command.ExecuteNonQuery();
            }
            catch (SQLiteException sqlEx)
            {
                throw sqlEx;
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