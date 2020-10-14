using ProjetoDS.dao;
using ProjetoDS.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDS.view
{
    public partial class Frmclientes : Form
    {
        public Frmclientes()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            try{
                Cliente obj = new Cliente();
                obj.nome = txtnome.Text;
                obj.email = txtemail.Text;
                obj.senha = txtsenha.Text;
                obj.sexo = cbsexo.Text;
                ClienteDAO dao = new ClienteDAO();
                dao.Cadastrar(obj);
                MessageBox.Show("Sucesso");

        }catch(Exception erro)

        {
                MessageBox.Show("Aconteceu um erro" + erro);
        }
            
        }

        private void Frmclientes_Activated(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            dgCliente.DataSource = dao.ListarTodosClientes();
        }
    }
}
