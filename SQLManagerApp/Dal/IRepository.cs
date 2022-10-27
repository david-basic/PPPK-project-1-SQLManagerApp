using SQLManagerApp.Models;
using System.Collections.Generic;
using System.Data;

namespace SQLManagerApp.Dal
{
    public interface IRepository
    {
        IEnumerable<Column> GetColumns(DBEntity dBEntity);
        IEnumerable<Database> GetDatabases();
        IEnumerable<DBEntity> GetDBEntities(Database database, DBEntityType dBEntity);
        IEnumerable<ProcedureParam> GetProcedureParameters(Procedure procedure);
        IEnumerable<Procedure> GetProcedures(Database database);
        DataSet CreateDataSet(DBEntity dBEntity);
        void Login(string server, string username, string password);
        DataSet CreateQueryDataSet(string query, Database database);
    }
}