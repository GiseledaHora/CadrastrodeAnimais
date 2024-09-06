using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrodeAnimais.Model
{
    internal class Conexao
    {
        public static string Conectar() { 
         
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gisele.hsilva1\source\repos\CadrastrodeAnimais\CadrastrodeAnimais\Dados\bdAnimais.mdf;Integrated Security=True";
        
        }
    }
}
