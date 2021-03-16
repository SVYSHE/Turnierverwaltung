﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Turnierverwaltung.Models
{
    public class Spieler : Teilnehmer
    {
        #region properties

        private int _id;
        private SQLiteConnection _connection;
        private string _connectionString;
        private string _databasePath;
        #endregion

        #region accessor/modifier

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public SQLiteConnection Connection
        {
            get => _connection;
            set => _connection = value;
        }

        public string ConnectionString
        {
            get => _connectionString;
            set => _connectionString = value;
        }

        public string DatabasePath
        {
            get => _databasePath;
            set => _databasePath = value;
        }

        #endregion
        
        #region constructors

        public Spieler()
        {
            Id = 0;
            ConnectionString = "Data Source=" + "/Database/turnierverwaltung.db" + ";Version=3";
            Connection = new SQLiteConnection(ConnectionString);
        }

        public Spieler(string name, int id, SQLiteConnection connection) : base(name)
        {
            Id = id;
            Connection = connection;
        }

        #endregion

        #region worker

        public int? InsertSpielerIntoDb()
        {
            int anzahl = 0;
            string sqlString = $"insert into spieler (rueckennummer) values('{Id}');";
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
        #endregion
    }
}