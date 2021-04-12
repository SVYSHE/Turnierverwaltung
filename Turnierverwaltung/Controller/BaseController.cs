using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using Turnierverwaltung.Models;
using Turnierverwaltung.Views;

namespace Turnierverwaltung.Controller
{
    public class BaseController
    {
        #region properties

        private ConsoleUi _ui;
        private DatabaseController _databaseController;

        #endregion

        #region accessor/modifier

        public ConsoleUi Ui
        {
            get => _ui;
            set => _ui = value;
        }

        public DatabaseController DatabaseController
        {
            get => _databaseController;
            set => _databaseController = value;
        }

        #endregion

        #region constructors

        public BaseController()
        {
            Ui = new ConsoleUi();
            DatabaseController = new DatabaseController();
        }

        public BaseController(ConsoleUi ui, DatabaseController databaseController)
        {
            Ui = ui;
            DatabaseController = databaseController;
        }

        #endregion
        
        #region worker
        
        public void Run()
        {
            try
            {
                DatabaseController.CreateDatabaseAndTables();
                Fußballspieler fb1 = new Fußballspieler(1,"Peter",1,DatabaseController.Connection);
                fb1.InsertIntoDb();
                Console.WriteLine("Erfolgreich eingefügt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
        
        public List<Spieler> RetrieveAllTeilnehmerFromDb()
        {
            List<Spieler> teilnehmerList = new List<Spieler>();
            string sqlString = "select * from spieler";

            DatabaseController.Command = new SQLiteCommand(sqlString, DatabaseController.Connection);
            try
            {
                DatabaseController.Connection.Open();
                SQLiteDataReader reader = DatabaseController.Command.ExecuteReader();

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
                if (DatabaseController.Connection.State.Equals(ConnectionState.Open))
                {
                    DatabaseController.Connection.Close();
                }
            }
            
        }
        
        #endregion
        
    }
}