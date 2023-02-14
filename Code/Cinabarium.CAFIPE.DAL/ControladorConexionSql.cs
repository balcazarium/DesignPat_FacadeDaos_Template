using Cinabarium.Dataservare.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinabarium.CAFIPE.DAL.SqlServer
{
    public class ControladorConexionSql : SqlNexumModeratoris
    {
        public ControladorConexionSql(string connectionString) : base(connectionString) { }
    }
}
