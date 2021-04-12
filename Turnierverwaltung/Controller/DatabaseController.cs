using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Text;
using Turnierverwaltung.Models;

namespace Turnierverwaltung.Controller
{
    public class DatabaseController
    {
        public const string DATABASE_PATH = @"Resources\turnierverwaltung.db";
        public const string CREATE_SCRIPT_PATH = @"Resources\create_script.sql";

        private string databaseFileName = "turnierverwaltung.db";
        private string createScriptFileName = "create_script.sql";


        private SQLiteConnection _connection;
        private SQLiteDataReader _dataReader;
        private SQLiteCommand _command;

        public string DatabaseFileName => databaseFileName;
        public string CreateScriptFileName => createScriptFileName;

        public SQLiteConnection Connection
        {
            get => _connection;
            set => _connection = value;
        }

        public SQLiteDataReader DataReader
        {
            get => _dataReader;
            set => _dataReader = value;
        }

        public SQLiteCommand Command
        {
            get => _command;
            set => _command = value;
        }

        public DatabaseController()
        {
        }

        public DatabaseController(SQLiteConnection connection, SQLiteDataReader dataReader, SQLiteCommand command)
        {
            Connection = connection;
            DataReader = dataReader;
            Command = command;
        }

        public bool CreateDatabaseAndTables()
        {
            bool creationIsSuccess = false;
            try
            {
                if (!File.Exists(@"..\..\..\Resources\turnierverwaltung.db"))
                {
                    if (File.Exists(@"..\..\..\Resources\create_script.sql"))
                    {
                        SQLiteConnection.CreateFile(@"..\..\..\Resources\turnierverwaltung.db");
                        string createScriptContent =
                            File.ReadAllText(@"..\..\..\Resources\create_script.sql", Encoding.UTF8);
                        Connection = new SQLiteConnection($"DataSource={@"..\..\..\Resources\turnierverwaltung.db"};Version=3");
                        Connection.Open();
                        Command = new SQLiteCommand(createScriptContent, Connection);
                        Command.ExecuteNonQuery();
                        creationIsSuccess = true;
                    }
                    else
                    {
                        throw new FileNotFoundException("Cannot find the create script in the 'Resources' folder.",
                            createScriptFileName);
                    }
                }
                else
                {
                    Connection =
                        new SQLiteConnection($"DataSource={@"..\..\..\Resources\turnierverwaltung.db"};Version=3");
                }
            }
            catch (Exception e)
            {
                creationIsSuccess = false;
            }
            finally
            {
                if (Connection != null)
                {
                    if (Connection.State != ConnectionState.Closed)
                    {
                        Connection.Close();
                    }
                }
            }

            return creationIsSuccess;
        }
    }
}