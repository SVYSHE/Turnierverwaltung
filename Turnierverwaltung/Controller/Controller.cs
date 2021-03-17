﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using Turnierverwaltung.Models;
using Turnierverwaltung.Views;

namespace Turnierverwaltung.Controller
{
    public class Controller
    {
        #region properties

        private ConsoleUi _ui;
        private SQLiteConnection _connection;
        private string _connectionString;
        private string _databasePath;

        #endregion

        #region accessor/modifier

        public ConsoleUi Ui
        {
            get => _ui;
            set => _ui = value;
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

        public Controller()
        {
            Ui = new ConsoleUi();
            ConnectionString = "Data Source=/Database/turnierverwaltung.db;Version=3";
            Connection = new SQLiteConnection(Connection);
        }

        public Controller(ConsoleUi ui, SQLiteConnection connection)
        {
            Ui = ui;
            Connection = connection;
        }

        #endregion
        
        #region worker
        
        public void Run()
        {
                
        }

        public List<Spieler> RetrieveAllTeilnehmerFromDb()
        {
            List<Spieler> teilnehmerList = new List<Spieler>();
            string sqlString = "select * from spieler";

            SQLiteCommand command = new SQLiteCommand(sqlString, Connection);
            try
            {
                Connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        
                    }
                }

                return teilnehmerList;
            }
            catch (SQLiteException sqlEx)
            {
                return teilnehmerList;
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