using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_Final
{
    class MyConnection
    {
        public MySqlConnection conexion;
        public void crearConexion()
        {
            string conec = "Server=localhost;database=misfinanzas;uid=root;pwd=;";
            conexion = new MySqlConnection(conec);
            conexion.Open();
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public MySqlConnection getConexion()
        {
            Console.WriteLine("Conexion establecida");
            Console.ReadLine();
            return conexion;
        }
    }

}
