using SQLManagerApp.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLManagerApp.Models
{
    public class Procedure
    {

        private readonly Lazy<IEnumerable<ProcedureParam>> procedureParams;

        public Procedure()
        {
            procedureParams = new Lazy<IEnumerable<ProcedureParam>>(() => RepositoryFactory.GetRepository().GetProcedureParameters(this));
        }

        public IList<ProcedureParam> ProcedureParams
        {
            get => new List<ProcedureParam>(procedureParams.Value);
        }

        public string Name { get; set; }
        public string Definition { get; set; }
        public Database Database { get; set; }

        public override string ToString() => Name;
    }
}
