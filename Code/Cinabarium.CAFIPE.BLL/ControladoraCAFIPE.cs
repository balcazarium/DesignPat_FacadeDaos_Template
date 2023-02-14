using Cinabarium.CAFIPE.DAL.SqlServer;
using Cinabarium.CAFIPE.DTO;
using Cinabarium.Dataservare.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinabarium.CAFIPE.BLL
{
    public class ControladoraCAFIPE
    {
        private ControladorConexionSql controladorConexion;
       
        public ControladoraCAFIPE(ControladorConexionSql controlador)
        {
            controladorConexion = controlador;
        }
        public ControladoraCAFIPE(string cadenaConexion)
        {
            controladorConexion = new ControladorConexionSql(cadenaConexion);
        }
        public IEnumerable<LibroDiarioDTO> ObtenerLibroDiario(Parametri parametri = null)
        {
            DAOObtenerLibroDiario daoObtener = new DAOObtenerLibroDiario(controladorConexion);
            ContextoDaoSqlServer<LibroDiarioDTO> contexto = new ContextoDaoSqlServer<LibroDiarioDTO>(daoObtener);
            return contexto.EjecutarEstrategiaConsulta(parametri);
        }
    }
}
