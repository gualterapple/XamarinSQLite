using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinSQLiteG
{
    public interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DbConnection();
    }
}
