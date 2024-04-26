using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;
using Cardiologia.Model;

namespace Cardiologia.Controller
{
    public class MySqlCon
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=hospital;Uid=root;");

        public void Inserir(string nome, int crm, string tipoMedico, DateTime? anoResidencia = null, string titulacao = null) 
        {
            con.Open();
            string sql = "";
            if (tipoMedico == "Residente")
            {
                sql = "INSERT INTO medico (nome, CRM) VALUES (@nome, @crm); " +
                      "INSERT INTO residente (id_medico, ano_residencia) VALUES (LAST_INSERT_ID(), @anoResidencia)";
            }
            else if (tipoMedico == "Docente")
            {
                sql = "INSERT INTO medico (nome, CRM) VALUES (@nome, @crm); " +
                      "INSERT INTO docente (id_medico, titulacao) VALUES (LAST_INSERT_ID(), @titulacao)";
            }
            else
            {
                sql = "INSERT INTO medico (nome, CRM) VALUES (@nome, @crm)";
            }

            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@crm", crm);
            if (tipoMedico == "Residente")
            {
                cmd.Parameters.AddWithValue("@anoResidencia", anoResidencia.HasValue ? anoResidencia.Value.ToString("yyyy-MM-dd") : null);
            }
            else if (tipoMedico == "Docente")
            {
                cmd.Parameters.AddWithValue("@titulacao", titulacao);
            }
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }

}
