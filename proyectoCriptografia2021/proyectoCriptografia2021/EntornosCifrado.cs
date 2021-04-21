using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCriptografia2021
{
    public class EntornosCifrado
    {
        SqlConnection miConnexion;

        public EntornosCifrado()
        {
            miConnexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CRIPTOGRAFIA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            miConnexion.Open();

        }

        public SqlDataReader consultarBD (String consulta)
        {
            SqlDataReader resultados;
            SqlCommand comando;

            comando = new SqlCommand(consulta, miConnexion);

            resultados = comando.ExecuteReader();


            return resultados;
        }

        public string cifrarMensaje (string mensajeOriginal, int idMetodoCifrado)
        {
            int position = 0;
            int positionLetraAcrual = 0;
            int positionLetraNueva = 0;
            int longitudAlfabeto = 27;

            string mensajeCifrado;

            SqlDataReader resultadoBD;

            resultadoBD = consultarBD("select position from Metodo_Cifrado where idCifrado=" + idMetodoCifrado);

            while (resultadoBD.Read())
            {
                position = (int)resultadoBD[0];
            }

            for(int i =0; i < mensajeOriginal.Length; i++)
        }

    }
}
