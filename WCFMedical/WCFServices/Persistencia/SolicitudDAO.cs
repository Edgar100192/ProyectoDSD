﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFServices.Dominio;


namespace WCFServices.Persistencia
{
    public class SolicitudDAO
    {
        private string CadenaConexion = "Data Source=DESKTOP-ANB7MGC\\MSSQLSERVER1; Initial Catalog=DB_Medical;Integrated Security=SSPI;";

        public Solicitud Crear(Solicitud SolicitudACrear)
        {
            Solicitud SolicitudCreado = null;
            string sql = "INSERT INTO T_Solicitud VALUES(@num_soli,@cod_cli,@direccion,@distrito,@fecha,@dniM,@observacion,@estado)";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {

                    comando.Parameters.Add(new SqlParameter("@num_soli", SolicitudACrear.Nu_Solicitud));
                    comando.Parameters.Add(new SqlParameter("@cod_cli", SolicitudACrear.co_Cliente));
                    comando.Parameters.Add(new SqlParameter("@direccion", SolicitudACrear.Direccion));
                    comando.Parameters.Add(new SqlParameter("@distrito", SolicitudACrear.Distrito));
                    comando.Parameters.Add(new SqlParameter("@fecha", SolicitudACrear.fe_registro));
                    comando.Parameters.Add(new SqlParameter("@dniM", SolicitudACrear.dni_medio));
                    comando.Parameters.Add(new SqlParameter("@observacion", SolicitudACrear.observa));
                    comando.Parameters.Add(new SqlParameter("@estado", SolicitudACrear.estado));
                    comando.ExecuteNonQuery();

                }
            }
            SolicitudCreado = Obtener(SolicitudACrear.Nu_Solicitud);
            return SolicitudCreado;
        }

        public Solicitud Obtener(int Nu_Solicitud)
        {
            Solicitud SolicitudEncontrado = null;
            string sql = "SELECT * FROM T_Solicitud WHERE Nu_Solicitud=@num_soli";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@num_soli", Nu_Solicitud));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                            SolicitudEncontrado = new Solicitud()
                            {
                                Nu_Solicitud = (int)resultado["num_solicitud"],
                                co_Cliente = (int)resultado["cod_cliente"],
                                Direccion = (string)resultado["des_direccion"],
                                Distrito = (string)resultado["des_distrito"],
                                fe_registro = (string)resultado["fec_registro"],
                                dni_medio = (int)resultado["nu_dni_medico"],
                                observa = (string)resultado["des_observacion"]

                            };
                    }
                }
            }
            return SolicitudEncontrado;
        }
        public Solicitud Modificar(Solicitud SolicitudaModificar)
        {
            Solicitud SolicitudModificado = null;
            string sql = "UPDATE T_Solicitud SET num_solicitud=@num_soli,cod_cliente=@cod_cli,des_direccion=@direccion,des_distrito=@distrito,fec_registro=@fecha,nu_dni_medico=@dniM,des_observacion=@observacion,ind_estado=@estado";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {

                    comando.Parameters.Add(new SqlParameter("@num_soli", SolicitudaModificar.Nu_Solicitud));
                    comando.Parameters.Add(new SqlParameter("@cod_cli", SolicitudaModificar.co_Cliente));
                    comando.Parameters.Add(new SqlParameter("@direccion", SolicitudaModificar.Direccion));
                    comando.Parameters.Add(new SqlParameter("@distrito", SolicitudaModificar.Distrito));
                    comando.Parameters.Add(new SqlParameter("@fecha", SolicitudaModificar.fe_registro));
                    comando.Parameters.Add(new SqlParameter("@dniM", SolicitudaModificar.dni_medio));
                    comando.Parameters.Add(new SqlParameter("@observacion", SolicitudaModificar.observa));
                    comando.Parameters.Add(new SqlParameter("@estado", SolicitudaModificar.estado));
                    comando.ExecuteNonQuery();

                }
            }
            SolicitudModificado = Obtener(SolicitudaModificar.Nu_Solicitud);
            return SolicitudModificado;

        }
        public void Eliminar(int Nu_Solicitud)
        {
            string sql = "DELETE FROM T_Solicitud WHERE Nu_Solicitud=@num_soli";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@num_soli", Nu_Solicitud));
                    comando.ExecuteNonQuery();
                }
            }
        }
        public List<Solicitud> Listar()
        {
            List<Solicitud> SolicitudesEncontrados = new List<Solicitud>();
            Solicitud SolicitudEncontrado = null;
            string sql = "SELECT * FROM t_solicitud";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            SolicitudEncontrado = new Solicitud()
                            {
                                Nu_Solicitud = (int)resultado["num_solicitud"],
                                co_Cliente = (int)resultado["cod_cliente"],
                                Direccion = (string)resultado["des_direccion"],
                                Distrito = (string)resultado["des_distrito"],
                                fe_registro = (string)resultado["fec_registro"],
                                dni_medio = (int)resultado["nu_dni_medico"],
                                observa = (string)resultado["des_observacion"]

                            };
                            SolicitudesEncontrados.Add(SolicitudEncontrado);
                        }
                    }
                }
            }
            return SolicitudesEncontrados;
        }

    }
}