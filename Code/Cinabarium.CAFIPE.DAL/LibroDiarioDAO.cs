using Cinabarium.CAFIPE.DTO;
using Cinabarium.Dataservare.SqlServer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinabarium.CAFIPE.DAL.SqlServer
{
    public class DAOAgregarLibroDiario : DAOSServareqlServer<LibroDiarioDTO>
    {
        public DAOAgregarLibroDiario(SqlNexumModeratoris moderator) : base(moderator) { }

        protected override void AdConfigurareSqlCommand(SqlCommand command, LibroDiarioDTO entitas)
        {
            //TODO:

        }
    }
    public class DAOActualizarLibroDiario : DAOSServareqlServer<LibroDiarioDTO>
    {
        public DAOActualizarLibroDiario(SqlNexumModeratoris moderator) : base(moderator) { }

        protected override void AdConfigurareSqlCommand(SqlCommand command, LibroDiarioDTO entitas)
        {
            //TODO:
        }
    }
    public class DAOEliminarLibroDiario : DAOSServareqlServer<LibroDiarioDTO>
    {
        public DAOEliminarLibroDiario(SqlNexumModeratoris moderator) : base(moderator) { }

        protected override void AdConfigurareSqlCommand(SqlCommand command, LibroDiarioDTO entitas)
        {
            //TODO:

        }
    }

    public class DAOObtenerLibroDiario : DAOQuerySqlServer<LibroDiarioDTO>
    {
        public DAOObtenerLibroDiario(ControladorConexionSql moderator) : base(moderator) { }

        protected override void AdConfigurareSqlCommand(SqlCommand command)
        {
            //TODO:  
            command.CommandText = "select id, nombre, etc from Librodiario";
            
        }
        protected override LibroDiarioDTO AdTabularumFaciendarum(SqlDataReader lectorem)
        {
            //TODO:
            LibroDiarioDTO libro = new LibroDiarioDTO();
            libro.Identificador = (Guid)lectorem["id"];
            return libro;
            //return base.AdTabularumFaciendarum(lectorem);
        }
    }
}
