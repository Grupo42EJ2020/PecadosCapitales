using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using MVCLaboratorio.Utilerias;
using System.Data.SqlClient;

namespace MVCLaboratorio.Models
{
    public class RepositorioCurso : ICurso
    {
        public List<Curso> obtenerCurso()
        {
            //funcionalidad
            DataTable dtCurso;
            dtCurso = BaseHelper.ejecutarConsulta("sp_Curso_ConsultarTodo", CommandType.StoredProcedure);
            List<Curso> lstCurso = new List<Curso>();

            foreach (DataRow item in dtCurso.Rows)
            {
                Curso CursoAux = new Curso();
                CursoAux.IdCurso = int.Parse(item["IdCurso"].ToString());
                CursoAux.Descripcion = item["Descripcion"].ToString();
                CursoAux.IdEmpleado = int.Parse(item["IdEmpleado"].ToString());
                lstCurso.Add(CursoAux);
            }

            return lstCurso;
        }

        public Curso obtenerCurso(int IdCurso)
        {
            DataTable dtCurso;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCurso", IdCurso));

            dtCurso = BaseHelper.ejecutarConsulta("sp_Curso_ConsultarporId", CommandType.StoredProcedure, parametros);

            Curso datosCurso = new Curso();

            if (dtCurso.Rows.Count > 0)
            {
                datosCurso.IdCurso = int.Parse(dtCurso.Rows[0]["IdCurso"].ToString());
                datosCurso.Descripcion = dtCurso.Rows[0]["Descripcion"].ToString();
                datosCurso.IdEmpleado = int.Parse(dtCurso.Rows[0]["IdEmpleado"].ToString());
                return datosCurso;
            }
            else
            {
                return null;
            }
        }

        public void insertarCurso(Curso datosCurso)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Descripcion", datosCurso.Descripcion));
            parametros.Add(new SqlParameter("@IdEmpleado", datosCurso.IdEmpleado));

            BaseHelper.ejecutarSentencia("sp_Curso_Insertar", CommandType.StoredProcedure, parametros);

        }
        public void eliminarCurso(int IdCurso)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCurso", IdCurso));

            BaseHelper.ejecutarSentencia("sp_Curso_Eliminar", CommandType.StoredProcedure, parametros);

        }
        public void actualizarCurso(Curso datosCurso)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCurso", datosCurso.IdCurso));
            parametros.Add(new SqlParameter("@Descripcion", datosCurso.Descripcion));
            parametros.Add(new SqlParameter("@IdEmpleado", datosCurso.IdEmpleado));

            BaseHelper.ejecutarSentencia("sp_Curso_Actualizar", CommandType.StoredProcedure, parametros);
        }
        public int obtenerDependenciaCurso(int id)
        {
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCurso", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Curso_Dependiente", CommandType.StoredProcedure, parametros);

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