using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using MVCLaboratorio.Utilerias;
using System.Data.SqlClient;

namespace MVCLaboratorio.Models
{
    public class RepositorioCurso_Tema : ICurso_Tema
    {

        public List<Curso_Tema> obtenerCurso_Tema()
        {
            //Obtener la informacion de Curso_Tema de la Base
            DataTable dtCurso_Tema;
            dtCurso_Tema = BaseHelper.ejecutarConsulta("sp_Curso_Tema_ConsultarTodo", CommandType.StoredProcedure);

            List<Curso_Tema> lstCurso_Tema = new List<Curso_Tema>();

            //convertir el DataTable a una lista de Curso List<Curso>
            foreach (DataRow item in dtCurso_Tema.Rows)
            {
                Curso_Tema Curso_TemaAux = new Curso_Tema();
                Curso_TemaAux.IdCT = int.Parse(item["IdCT"].ToString());
                Curso_TemaAux.IdCurso = int.Parse(item["IdCurso"].ToString());
                Curso_TemaAux.IdTema = int.Parse(item["IdTema"].ToString());


                lstCurso_Tema.Add(Curso_TemaAux);
            }

            return lstCurso_Tema;
        }


        public Curso_Tema obtenerCurso_Tema(int idCT)
        {
            DataTable dtCurso_Tema;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCT", idCT));

            dtCurso_Tema = BaseHelper.ejecutarConsulta("sp_Curso_Tema_ConsultarPorID", CommandType.StoredProcedure, parametros);

            
            Curso_Tema datosCurso_Tema = new Curso_Tema();

            if (dtCurso_Tema.Rows.Count > 0) //Se Encontro
            {
                datosCurso_Tema.IdCT = int.Parse(dtCurso_Tema.Rows[0]["IdCT"].ToString());
                datosCurso_Tema.IdCurso = int.Parse(dtCurso_Tema.Rows[0]["IdCurso"].ToString());
                datosCurso_Tema.IdTema = int.Parse(dtCurso_Tema.Rows[0]["IdTema"].ToString());

                return datosCurso_Tema;
            }
            else
            { 
                return null;
            }
        }

        public void insertarCurso_Tema(Curso_Tema datosCurso_Tema)
        {
            //Update
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCurso", datosCurso_Tema.IdCurso));
            parametros.Add(new SqlParameter("@IdTema", datosCurso_Tema.IdTema));


            BaseHelper.ejecutarConsulta("sp_Curso_Tema_Insertar", CommandType.StoredProcedure, parametros);

        }

        public void eliminarCurso_Tema(int idCT)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCT", idCT));

            BaseHelper.ejecutarSentencia("sp_Curso_Tema_Eliminar", CommandType.StoredProcedure, parametros);

        }

        public void actualizarCurso_Tema(Curso_Tema datosCurso_Tema)
        {
            //Update
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCT", datosCurso_Tema.IdCT));
            parametros.Add(new SqlParameter("@IdCurso", datosCurso_Tema.IdCurso));
            parametros.Add(new SqlParameter("@IdTema", datosCurso_Tema.IdTema));


            BaseHelper.ejecutarConsulta("sp_Curso_Tema_Actualizar", CommandType.StoredProcedure, parametros);

        }
        public int obtenerCursoTemaDependiente(int id)
        {
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCT", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_CursoTemaDependiente", CommandType.StoredProcedure, parametros);

            if (dtVideo.Rows.Count > 0) 
            {
                return 1;
            }
            else
            { 
                return 0;
            }
        }
    }
}