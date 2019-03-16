using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SQLite;

public class DBConnector : MonoBehaviour
{
    void Start()
    {
        SQLiteConnection connection = new SQLiteConnection(@"Data Source=f:\mydb.db;Version=3;");
        connection.Open();

        SQLiteCommand command = connection.CreateCommand();
        command.CommandType = System.Data.CommandType.Text;
        command.CommandText = "CREATE TABLE IF NOT EXISTS 'highscores' ( " +
                          "  'id' INTEGER PRIMARY KEY, " +
                          "  'name' TEXT NOT NULL, " +
                          "  'score' INTEGER NOT NULL" +
                          ");";

        command.ExecuteNonQuery();
        connection.Close();
    }
}
