using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Cardiologia.Controller
{
    public class MySqlConPaciente
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=hospital;Uid=root;");

        public void Inserir(int registro, string nome, string sexo, string cor, DateTime dataNasc)
        {
            con.Open();
            string sql = "INSERT INTO paciente(registro, nome, sexo, cor, data_nascimento) VALUES(@registro, @nome, @sexo, @cor, @datanasc)";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@registro", registro);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@sexo", sexo);
            cmd.Parameters.AddWithValue("@cor", cor);
            cmd.Parameters.AddWithValue("@datanasc", dataNasc/*.ToString("yyyy-MM-dd")*/);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
