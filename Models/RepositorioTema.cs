using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MVCLaboratorio.Utilerias;
using System.Data.SqlClient;

namespace MVCLaboratorio.Models
{
    public class RepositorioTema
    {
        public List<Tema> obtenerTema()
        {
            //funcionalidad
            DataTable dtTema;
            dtTema = BaseHelper.ejecutarConsulta("sp_Tema_ConsultarTodo", CommandType.StoredProcedure);
            List<Tema> lstTema = new List<Tema>();

            foreach (DataRow item in dtTema.Rows)
            {
                Tema TemaAux = new Tema();
                TemaAux.IdTema = int.Parse(item["IdTema"].ToString());
                TemaAux.Nombre = item["Nombre"].ToString();
                lstTema.Add(TemaAux);
            }

            return lstTema;
        }
        public Tema obtenerTema(int IdTema)
        {
            DataTable dtTema;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdTema", IdTema));

            dtTema = BaseHelper.ejecutarConsulta("sp_Tema_ConsultarporId", CommandType.StoredProcedure, parametros);
            Tema datosTema = new Tema();

            if (dtTema.Rows.Count > 0)
            {
                datosTema.IdTema = int.Parse(dtTema.Rows[0]["IdTema"].ToString());
                datosTema.Nombre = dtTema.Rows[0]["Nombre"].ToString();
                return datosTema;
            }
            else
            {
                return null;
            }
        }
        public void insertarTema(Tema datosTema)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Nombre", datosTema.Nombre));

            BaseHelper.ejecutarSentencia("sp_Tema_Insertar", CommandType.StoredProcedure, parametros);

        }
        public void eliminarTema(int IdTema)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdTema", IdTema));

            BaseHelper.ejecutarSentencia("sp_Tema_Eliminar", CommandType.StoredProcedure, parametros);

        }
        public void actualizarTema(Tema datosTema)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdTema", datosTema.IdTema));
            parametros.Add(new SqlParameter("@Nombre", datosTema.Nombre));
           
            BaseHelper.ejecutarSentencia("sp_Tema_Actualizar", CommandType.StoredProcedure, parametros);
        }
        public int obtenerDependenciaTema(int id)
        {
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdTema", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Tema_Dependiente", CommandType.StoredProcedure, parametros);

            if (dtVideo.Rows.Count > 0) //si lo encontro
            {
                return 1;
            }
            else
            { //no lo encontro 
                return 0;
            }
        }
    }
}