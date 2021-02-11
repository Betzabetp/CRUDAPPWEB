using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioConsultas.bd
{
    class Conexion
    {
		private SqlConnection dbConnect;

		public SqlConnection GetConnection
		{
			get { return dbConnect; }
			set { dbConnect = value; }
		}

		public Conexion()
		{
			string ConnectionString = ConfigurationManager.ConnectionStrings["dbConnect"].ConnectionString;
			dbConnect = new SqlConnection(ConnectionString);
		}
	}
}
