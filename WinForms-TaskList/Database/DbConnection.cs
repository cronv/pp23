using System.IO;

namespace WinForms_TaskList.Database
{
    class DbConnection
    {
        public static string  dbPath = Path.GetFullPath("Database/TaskList.db");
        public static string dbConnection = "Data Source=" + DbConnection.dbPath + ";Version=3";
    }
}
