using GarverOps.Class;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace GarverOps.Services
{
    public class SQLiteData
    {

        public SQLiteConnection conn;
        public SQLiteData()
        {
            conn = GetConnection();
            conn.CreateTable<OpEquation>();
         
        }

        public SQLiteConnection GetConnection()
        {
            var dbase = "OpsCalculations.db";
            var dbpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
             //var dbpath = "/storage/emulated/0/Android/data/com.GarverUSA.GarverOps/files/";
         //  var dbpath = Android.OS.Environment.ExternalStorageDirectory.Path;

            var backingFile = Path.Combine(dbpath, "count.txt");
            using (var writer = File.CreateText(backingFile))
            {
                 writer.WriteLineAsync("10");
            }

            var path = Path.Combine(dbpath, dbase);
            var connection = new SQLiteConnection(path);
            return connection;

        }

     
    }
}
