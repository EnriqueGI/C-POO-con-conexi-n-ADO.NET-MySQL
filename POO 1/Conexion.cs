using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POO_1
{
    class Conexion
    {
        private MySqlConnection _oConexion;

        public MySqlConnection OConexion { get => _oConexion; set => _oConexion = value; }

        public void Conectar()
        {
            try
            {
                OConexion.ConnectionString = "server=localhost;database=covicipol;user id=root;password=enq2290;";
                OConexion.Open();
            }

            
           

        catch ( MySqlException oExcep){
                //  si se produce algún error,
                //  lo capturamos mediante el objeto
                //  de excepciones particular para
                //  el proveedor de Mysql
                MessageBox.Show("Error al conectar con datos"+ oExcep.Message);
            }
            
  
        }

       

    }
}
