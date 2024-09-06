using CadastrodeAnimais.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CadastrodeAnimais.Controller
{
    internal class ControllerAnimais
    {
        //crud
        // c- create/inserir na tabela do banco
        //r-read/ ler os registros da tabela do banco
        //u-update/Alterar registros da tabela do banco
        //d-delete/Apagar registros da tabela do banco

        //Método de inserir registros na tabela
        public void EnviarBanco()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("Procedure");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try {

                cmd.Parameters.AddWithValue("@nome",Animais.Nome);
                cmd.Parameters.AddWithValue("@raca", Animais.Raca);
                cmd.Parameters.AddWithValue("@porte", Animais.Porte);
                 
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados inseridos com sucesso");


            }




            catch (Exception)
            { 

                throw;
            }
        }
    }
}
