using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibraryOrg.DataAccess;

namespace TrackerLibraryOrg
{
    //nije nacrt za kucu(objekat), nego je sama kuca, ne prave se njene istance, svi je koriste
    public static class GlobalConfig
    {
        //mora se i inicijalizuje
        public static IDataConnection Connection { get; private set; } //ne mogu spolja da je promene

        public static void InitializeConnection(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string ConnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }

    public enum DatabaseType
    {
        Sql,
        TextFile
    }
}
