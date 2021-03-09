using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Turnierverwaltung.Database
{
    public class DatabaseController
    {
        private MySqlConnection _dbConnection;
        private MySqlCommand _command;
        private MySqlDataReader _dataReader;

        public MySqlConnection DbConnection
        {
            get => _dbConnection;
            set => _dbConnection = value;
        }

        public MySqlCommand Command
        {
            get => _command;
            set => _command = value;
        }

        public MySqlDataReader DataReader
        {
            get => _dataReader;
            set => _dataReader = value;
        }

        public DatabaseController()
        {
            DbConnection = new MySqlConnection();
            Command = new MySqlCommand();
            DataReader = null;
        }

        public DatabaseController(MySqlConnection dbConnection, MySqlCommand command, MySqlDataReader dataReader)
        {
            DbConnection = dbConnection;
            Command = command;
            DataReader = dataReader;
        }

        public MySqlConnection OpenConnectionWithConnectionString(string connectionString)
        {
            try
            {
                DbConnection.ConnectionString = connectionString;
                DbConnection.Open();
                return DbConnection;
            }
            catch (MySqlException mySqlEx)
            {
                Console.WriteLine(mySqlEx.Message);
                return null;
            }
        }

        public int? ExecuteNonQuery(string nonQueryCommand)
        {
            try
            {
                Command.CommandText = nonQueryCommand;
                Command.Connection = DbConnection;
                Command.CommandType = CommandType.Text;
                return Command.ExecuteNonQuery();
            }
            catch (MySqlException mySqlEx)
            {
                Console.WriteLine(mySqlEx.Message);
                return null;
            }
        }

        public MySqlDataReader ExecuteReader(string queryCommand)
        {
            try
            {
                Command.CommandText = queryCommand;
                Command.Connection = DbConnection;
                Command.CommandType = CommandType.Text;
                MySqlDataReader reader = Command.ExecuteReader();
                DataReader = reader;
                return reader;
            }
            catch (MySqlException mySqlEx)
            {
                Console.WriteLine(mySqlEx.Message);
                return null;
            }
        }

        public bool CloseDbConnection()
        {
            try
            {
                if (!(DbConnection.State.Equals(ConnectionState.Closed)))
                {
                    DbConnection.Close();    
                }
                return true;
            }
            catch (MySqlException mySqlEx)
            {
                Console.WriteLine(mySqlEx);
                return false;
            }
        }
    }
}