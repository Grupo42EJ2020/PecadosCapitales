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
            //implementar funcionalidad
            //obtener la info de los videos de la BD
            DataTable dtCurso;
            dtCurso = BaseHelper.ejecutarConsulta("sp_Curso_ConsultarTodo", CommandType.StoredProcedure);

            List<Curso> lstCurso = new List<Curso>();

            //convertir el DataTable a una lista de Curso List<Curso>
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


        public Curso obtenerCurso(int idCurso)
        {
            DataTable dtCurso;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCurso", idCurso));

            dtCurso = BaseHelper.ejecutarConsulta("sp_Curso_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //convertir el dtCurso a un objeto Curso
            Curso datosCurso = new Curso();

            if (dtCurso.Rows.Count > 0) //si lo encontro
            {
                datosCurso.IdCurso = int.Parse(dtCurso.Rows[0]["IdCurso"].ToString());
                datosCurso.Descripcion = dtCurso.Rows[0]["Descripcion"].ToString();
                datosCurso.IdEmpleado = int.Parse(dtCurso.Rows[0]["IdEmpleado"].ToString());

                return datosCurso;
            }
            else
            { //no lo encontro 
                return null;
            }
        }

        public void insertarCurso(Curso datosCurso)
        {
            //realizar el update
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Descripcion", datosCurso.Descripcion));
            parametros.Add(new SqlParameter("@IdEmpleado", datosCurso.IdEmpleado));


            BaseHelper.ejecutarConsulta("sp_Curso_Insertar", CommandType.StoredProcedure, parametros);

        }

        public void eliminarCurso(int idCurso)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCurso", idCurso));

            BaseHelper.ejecutarSentencia("sp_Curso_Eliminar", CommandType.StoredProcedure, parametros);

        }

        public void actualizarCurso(Curso datosCurso)
        {
            //realizar el update
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCurso", datosCurso.IdCurso));
            parametros.Add(new SqlParameter("@Nombre", datosCurso.Descripcion));
            parametros.Add(new SqlParameter("@IdEmpleado", datosCurso.IdEmpleado));


            BaseHelper.ejecutarConsulta("sp_Curso_Actualizar", CommandType.StoredProcedure, parametros);

        }
    }
}