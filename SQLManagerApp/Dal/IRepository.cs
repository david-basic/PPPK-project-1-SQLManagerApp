using SQLManagerApp.Models;
using System.Collections.Generic;

namespace SQLManagerApp.Dal
{
    public interface IRepository
    {
        IEnumerable<Column> GetColumns(DBEntity dBEntity);
        IEnumerable<Database> GetDatabases();
        IEnumerable<DBEntity> GetDBEntities(Database database, DBEntityType dBEntity);
        IEnumerable<ProcedureParam> GetProcedureParameters(Procedure procedure);
        IEnumerable<Procedure> GetProcedures(Database database);
        void Login(string server, string username, string password);
    }
}