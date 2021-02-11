using FormularioConsultas.bd;
using FormularioConsultas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioConsultas.Servicio
{
    class FormularioConsultaCrud
    {
		public string Ingresar(FormularioConsultasModelo user)
		{
			Conexion conn = new Conexion();
			SqlConnection bd = conn.GetConnection;
			bd.Open();
			string mensaje;
				SqlCommand objCommand = new SqlCommand("spInsertar", bd);
				objCommand.CommandType = CommandType.StoredProcedure;
				objCommand.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar).Value = user.Nombre;
				objCommand.Parameters.Add("@ApeidoPaterno", System.Data.SqlDbType.VarChar).Value = user.ApeidoPaterno;
				objCommand.Parameters.Add("@ApeidoMaterno", System.Data.SqlDbType.VarChar).Value = user.ApeidoMaterno;
				objCommand.Parameters.Add("@Empresa", System.Data.SqlDbType.VarChar).Value = user.Empresa;
				objCommand.Parameters.Add("@RFC", System.Data.SqlDbType.VarChar).Value = user.RFC;
				objCommand.Parameters.Add("@Direccion", System.Data.SqlDbType.VarChar).Value = user.Direccion;
				objCommand.Parameters.Add("@NumeroExt", System.Data.SqlDbType.Char).Value = user.NumeroExt;
				objCommand.Parameters.Add("@NumeroInt", System.Data.SqlDbType.Char).Value = user.NumeroInt;
				objCommand.Parameters.Add("@Colonia", System.Data.SqlDbType.VarChar).Value = user.Colonia;
				objCommand.Parameters.Add("@CiudadRespuestaAyuda", System.Data.SqlDbType.VarChar).Value = user.CiudadRespuestaAyuda;
				objCommand.Parameters.Add("@EstadoRespuestaAyuda", System.Data.SqlDbType.VarChar).Value = user.EstadoRespuestaAyuda;
				objCommand.Parameters.Add("@CodigoPostal", System.Data.SqlDbType.Decimal).Value = user.CodigoPostal;
				objCommand.Parameters.Add("@TelefonoCasa", System.Data.SqlDbType.Decimal).Value = user.TelefonoCasa;
				objCommand.Parameters.Add("@Celular", System.Data.SqlDbType.Decimal).Value = user.Celular;
				objCommand.Parameters.Add("@Correo1", System.Data.SqlDbType.VarChar).Value = user.Correo1;
				objCommand.Parameters.Add("@Correo2", System.Data.SqlDbType.VarChar).Value = user.Correo2;
				objCommand.Parameters.Add("@AyudaSolicitada", System.Data.SqlDbType.VarChar).Value = user.AyudaSolicitada;
				objCommand.Parameters.Add("@Respuesta", System.Data.SqlDbType.VarChar).Value = user.Respuesta;
				objCommand.Parameters.Add("@CiudadInteres", System.Data.SqlDbType.VarChar).Value = user.CiudadRespuestaAyuda;
				objCommand.Parameters.Add("@MontoInvercion", System.Data.SqlDbType.VarChar).Value = user.MontoInvercion;
				objCommand.Parameters.Add("@ComoLlegoMensaje", System.Data.SqlDbType.VarChar).Value = user.ComoLlegoMensaje;
				objCommand.Parameters.Add("@Seguimiento", System.Data.SqlDbType.VarChar).Value = user.Seguimiento;
				objCommand.ExecuteNonQuery();
			try {
				mensaje = "OK";
				return mensaje;
			}
			catch
			{
				mensaje = "Error";
				return mensaje;
			}
			finally
			{
				if (bd != null)
				{
					if (bd.State == ConnectionState.Open)
					{
						bd.Close();
						bd.Dispose();
					}
				}
			}
		}
	}
}