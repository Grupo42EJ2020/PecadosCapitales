using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MVCLaboratorio.Utilerias;
using System.Data.SqlClient;

namespace MVCLaboratorio.Models
{
    public class RepositorioCurso_Tema_Video
    {
        public List<Curso_Tema_Video> obtenerCTVs()
        {
            //funcionalidad
            DataTable dtCTV;
            dtCTV = BaseHelper.ejecutarConsulta("sp_Curso_Tema_Video_ConsultarTodo", CommandType.StoredProcedure);
            List<Curso_Tema_Video> lstCTV = new List<Curso_Tema_Video>();

            foreach (DataRow item in dtCTV.Rows)
            {
                Curso_Tema_Video CTVAux = new Curso_Tema_Video();
                CTVAux.IdCTV = int.Parse(item["IdCTV"].ToString());
                CTVAux.IdCT = int.Parse(item["IdCT"].ToString());
                CTVAux.IdVideo = int.Parse(item["IdVideo"].ToString());
                lstCTV.Add(CTVAux);
            }
            return lstCTV;
        }
        public Curso_Tema_Video obtenerCTV(int IdCTV)
        {
            DataTable dtCTV;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCTV", IdCTV));

            dtCTV = BaseHelper.ejecutarConsulta("sp_Curso_Tema_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Curso_Tema_Video datosCTV = new Curso_Tema_Video();

            if (dtCTV.Rows.Count > 0)
            {
                datosCTV.IdCTV = int.Parse(dtCTV.Rows[0]["IdCTV"].ToString());
                datosCTV.IdCT = int.Parse(dtCTV.Rows[0]["IdCT"].ToString());
                datosCTV.IdVideo = int.Parse(dtCTV.Rows[0]["IdVideo"].ToString());
                return datosCTV;
            }
            else
            {
                return null;
            }
        }
        public void insertarCTV(Curso_Tema_Video datosCTV)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCT", datosCTV.IdCT));
            parametros.Add(new SqlParameter("@IdVideo", datosCTV.IdVideo));
            BaseHelper.ejecutarConsulta("sp_Curso_Tema_Video_Insertar", CommandType.StoredProcedure, parametros);
        }

        public void eliminarCTV(int IdCTV)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCTV", IdCTV));

            BaseHelper.ejecutarSentencia("sp_Curso_Tema_Video_Eliminar", CommandType.StoredProcedure, parametros);

        }

        public void actualizarCTV(Curso_Tema_Video datosCTV)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCTV", datosCTV.IdCTV));
            parametros.Add(new SqlParameter("@IdCT", datosCTV.IdCT));
            parametros.Add(new SqlParameter("@IdVideo", datosCTV.IdVideo));
            BaseHelper.ejecutarConsulta("sp_Curso_Tema_Video_Actualizar", CommandType.StoredProcedure, parametros);
        }

    }
}