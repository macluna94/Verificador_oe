using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SmartDeviceProject4
{
    class DB
    {
        private SqlDataReader m_dr;
        private string m_stringConexion;
        private SqlConnection m_cnn;
        private SqlCommand cmd;

        public DB(string cadenaConexion)
        {
            m_stringConexion = cadenaConexion;
            m_cnn = new SqlConnection(m_stringConexion);
        }

        public void Consulta(string query)
        {
            if (Cnn.State == System.Data.ConnectionState.Open)
            {
                cmd = new SqlCommand(query, m_cnn);
                Dr.Close();
                Dr = cmd.ExecuteReader();
            }
            else
            {
                m_cnn.Open();
                cmd = new SqlCommand(query, m_cnn);
                Dr = cmd.ExecuteReader();
            }
        }

        public SqlDataReader consultar(String sql)
        {
            if (Cnn.State == System.Data.ConnectionState.Open)
            {
                cmd = new SqlCommand(sql, m_cnn);
                Dr.Close();
                Dr = cmd.ExecuteReader();
            }
            else
            {
                m_cnn.Open();
                cmd = new SqlCommand(sql, m_cnn);
                Dr = cmd.ExecuteReader();
            }
            return Dr;
        }

        public SqlDataReader Dr
        {
            get { return m_dr; }
            set { m_dr = value; }
        }

        public void Cerrar()
        {
            Dr.Close();
            m_cnn.Close();
        }

        public SqlConnection Cnn
        {
            get { return m_cnn; }
            set { m_cnn = value; }
        }
    }
}