using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFServices.Dominio;

namespace WCFServices.Persistencia
{
    public class AtencionDAO
    {
        private string CadenaConexion = "Data Source=LAPTOP-M4MA8DSL\\SQLEXPRESS; Initial Catalog=BD_Medical;Integrated Security=SSPI;";

        public Atencion Crear(Atencion atencionACrear)
        {
            Atencion atencionCreado = null;
            string sql = "INSERT INTO t_atencion_medica VALUES (@nunatencion, @nunsolicitud, @numdni, @observacion, @fecregistro, @horainicio,@horafin)";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@nunatencion", atencionACrear.NunAtencion));
                    comando.Parameters.Add(new SqlParameter("@nunsolicitud", atencionACrear.NumSolicitud));
                    comando.Parameters.Add(new SqlParameter("@numdni", atencionACrear.NumDni));
                    comando.Parameters.Add(new SqlParameter("@observacion", atencionACrear.Observacion));
                    comando.Parameters.Add(new SqlParameter("@fecregistro", atencionACrear.FecRegistro));
                    comando.Parameters.Add(new SqlParameter("@horainicio", atencionACrear.HoraInicio));
                    comando.Parameters.Add(new SqlParameter("@horafin", atencionACrear.HoraFin));
                    comando.ExecuteNonQuery();
                }
            }
            atencionCreado = Obtener(atencionACrear.NunAtencion);
            return atencionCreado;
        }
        public Atencion Obtener(int NunAtencion)/**/
        {
            Atencion atencionEncontrado = null;
            string sql = "SELECT * FROM t_atencion_medica WHERE cod_aten_medica=@nunatencion";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@nunatencion", NunAtencion));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            atencionEncontrado = new Atencion()
                            {
                                NunAtencion = (int)resultado["cod_aten_medica"],
                                NumSolicitud = (int)resultado["num_solicitud"],
                                NumDni = (int)resultado["num_dni_medico"],
                                Observacion = (string)resultado["des_observacion"],
                                FecRegistro = (string)resultado["fec_registro"],
                                HoraInicio = (string)resultado["des_hora_inicio"],
                                HoraFin = (string)resultado["des_hora_fin"]
                            };
                        }
                    }
                }
            }
            return atencionEncontrado;
        }

        public Atencion Modificar(Atencion atencionAModificar)
        {
            Atencion atencionModificado = null;

            string sql = "UPDATE t_atencion_medica SET des_observacion=@observacion, des_hora_inicio=@horainicio, des_hora_fin=@horafin WHERE cod_aten_medica=@nunatencion";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {

                    comando.Parameters.Add(new SqlParameter("@observacion", atencionAModificar.Observacion));
                    comando.Parameters.Add(new SqlParameter("@horainicio", atencionAModificar.HoraInicio));
                    comando.Parameters.Add(new SqlParameter("@horafin", atencionAModificar.HoraFin));
                    comando.Parameters.Add(new SqlParameter("@nunatencion", atencionAModificar.NunAtencion));
                }
            }
            atencionModificado = Obtener(atencionAModificar.NunAtencion);
            return atencionModificado;
        }

        public void Eliminar(int NunAtencion)
        {
            string sql = "DELETE FROM t_atencion_medica WHERE cod_aten_medica = @nunatencion ";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@nunatencion", NunAtencion));
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Atencion> Listar()
        {
            List<Atencion> atencionesEncontrados = new List<Atencion>();
            Atencion atencionEncontrado = null;
            string sql = "SELECT * from t_atencion_medica";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            atencionEncontrado = new Atencion()
                            {
                                NunAtencion = (int)resultado["cod_aten_medica"],
                                NumSolicitud = (int)resultado["num_solicitud"],
                                NumDni = (int)resultado["num_dni_medico"],
                                Observacion = (string)resultado["des_observacion"],
                                FecRegistro = (string)resultado["fec_registro"],
                                HoraInicio = (string)resultado["des_hora_inicio"],
                                HoraFin = (string)resultado["des_hora_fin"]
                            };
                            atencionesEncontrados.Add(atencionEncontrado);
                        }

                    }
                }
            }
            return atencionesEncontrados;

        }

    }
}