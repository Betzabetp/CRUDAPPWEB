using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormularioConsultas.bd;
using FormularioConsultas.Modelo;
using System.Data;
using System.Data.SqlClient;


namespace CRUDCaptura.Servicio
{
    class Consultas
    {
        private List<FormularioConsultasModelo> getTipoAyuda()
        {
            Conexion conn = new Conexion();
            SqlConnection bd = conn.GetConnection;
            bd.Open();
            List<FormularioConsultasModelo> list = new List<FormularioConsultasModelo>();
            try
            {
                SqlCommand objCommand = new SqlCommand("spGetTipoAyuda", bd);
                objCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = objCommand.ExecuteReader();
                while (reader.Read())
                {
                    var d = new FormularioConsultasModelo();
                    d.AyudaSolicitada = reader["TipoAyuda"].ToString();
                    list.Add(d);
                }
                return list;
            }
            catch
            {
                return list;
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
                }//cierraif1
            }//cierra finally
        }//cierraMetodo
        public List<FormularioConsultasModelo> getayuda()
        {

            List<FormularioConsultasModelo> listitem = getTipoAyuda();
            listitem.Insert(0, new FormularioConsultasModelo()
            {
                AyudaSolicitada = "SELECCIONAR"
            });
            return listitem;
        }//cierra modelo

         //Persona
        private List<FormularioConsultasModelo> getPesona()
        {
            Conexion conn = new Conexion();
            SqlConnection bd = conn.GetConnection;
            bd.Open();
            List<FormularioConsultasModelo> list = new List<FormularioConsultasModelo>();
            try
            {
                SqlCommand objCommand = new SqlCommand("spGetPersonalApoyo", bd);
                objCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = objCommand.ExecuteReader();
                while (reader.Read())
                {
                    var d = new FormularioConsultasModelo();
                    d.Respuesta = reader["PersonaDeAyuda"].ToString();
                    list.Add(d);
                }
                return list;
            }
            catch
            {
                return list;
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
                }//cierraif1
            }//cierra finally
        }//cierraMetodo
        public List<FormularioConsultasModelo> getpersonaldeapoyo()
        {

            List<FormularioConsultasModelo> listitem = getPesona();
            listitem.Insert(0, new FormularioConsultasModelo()
            {
                Respuesta = "SELECCIONAR"
            });
            return listitem;
        }//cierra modelo

        //Inversion
        private List<FormularioConsultasModelo> getInversion()
        {
            Conexion conn = new Conexion();
            SqlConnection bd = conn.GetConnection;
            bd.Open();
            List<FormularioConsultasModelo> list = new List<FormularioConsultasModelo>();
            try
            {
                SqlCommand objCommand = new SqlCommand("spGetMontoInversion", bd);
                objCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = objCommand.ExecuteReader();
                while (reader.Read())
                {
                    var d = new FormularioConsultasModelo();
                    d.MontoInvercion = reader["TipoInversion"].ToString();
                    list.Add(d);
                }
                return list;
            }
            catch
            {
                return list;
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
                }//cierraif1
            }//cierra finally
        }//cierraMetodo
        public List<FormularioConsultasModelo> getMontoInversion()
        {

            List<FormularioConsultasModelo> listitem= getInversion();
            listitem.Insert(0, new FormularioConsultasModelo()
            {
                MontoInvercion = "SELECCIONAR"
            });
            return listitem;
        }//cierra modelo

        //Medio Contacto
        private List<FormularioConsultasModelo> getContacto()
        {
            Conexion conn = new Conexion();
            SqlConnection bd = conn.GetConnection;
            bd.Open();
            List<FormularioConsultasModelo> list = new List<FormularioConsultasModelo>();
            try
            {
                SqlCommand objCommand = new SqlCommand("spGetRespuestaAyudada", bd);
                objCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = objCommand.ExecuteReader();
                while (reader.Read())
                {
                    var d = new FormularioConsultasModelo();
                    d.ComoLlegoMensaje = reader["RespuestaAyudada"].ToString();
                    list.Add(d);
                }
                return list;
            }
            catch
            {
                return list;
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
                }//cierraif1
            }//cierra finally
        }//cierraMetodo
        public List<FormularioConsultasModelo> getMedioContacto()
        {

            List<FormularioConsultasModelo> listitem = getContacto();
            listitem.Insert(0, new FormularioConsultasModelo()
            {
                ComoLlegoMensaje = "SELECCIONAR"
            });
            return listitem;
        }//cierra modelo

         //Estados
        private List<FormularioConsultasModelo> getEstado()
        {
            Conexion conn = new Conexion();
            SqlConnection bd = conn.GetConnection;
            bd.Open();
            List<FormularioConsultasModelo> list = new List<FormularioConsultasModelo>();
            try
            {
                SqlCommand objCommand = new SqlCommand("spGetEstados", bd);
                objCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = objCommand.ExecuteReader();
                while (reader.Read())
                {
                    var d = new FormularioConsultasModelo();
                    d.EstadoRespuestaAyuda = reader["Estado"].ToString();
                    list.Add(d);
                }
                return list;
            }
            catch
            {
                return list;
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
                }//cierraif1
            }//cierra finally
        }//cierraMetodo
        public List<FormularioConsultasModelo> getEstados()
        {

            List<FormularioConsultasModelo> listitem = getEstado();
            listitem.Insert(0, new FormularioConsultasModelo()
            {
                EstadoRespuestaAyuda = "SELECCIONAR"
            });
            return listitem;
        }//cierra modelo
        
        //Status
        private List<FormularioConsultasModelo> getSeguimientodata()
        {
            Conexion conn = new Conexion();
            SqlConnection bd = conn.GetConnection;
            bd.Open();
            List<FormularioConsultasModelo> list = new List<FormularioConsultasModelo>();
            try
            {
                SqlCommand objCommand = new SqlCommand("spGetSeguimiento", bd);
                objCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = objCommand.ExecuteReader();
                while (reader.Read())
                {
                    var d = new FormularioConsultasModelo();
                    d.Seguimiento = reader["Seguimiento"].ToString();
                    list.Add(d);
                }
                return list;
            }
            catch
            {
                return list;
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
                }//cierraif1
            }//cierra finally
        }//cierraMetodo
        public List<FormularioConsultasModelo> getSeguimiento()
        {

            List<FormularioConsultasModelo> listitem =getSeguimientodata();
            listitem.Insert(0, new FormularioConsultasModelo()
            {
                Seguimiento = "SELECCIONAR"
            });
            return listitem;
        }//cierra modelo
    }//cierraclase
}//namespace