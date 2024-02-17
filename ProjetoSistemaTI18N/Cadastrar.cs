using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistemaTI18N
{
    public partial class Cadastrar : Form
    {
        DAO bd;
        public Cadastrar()
        {
            InitializeComponent();
            bd = new DAO(); //Conectar a tela com a classe DAO
        }//fim do construtor

        private void codigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do código

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }//fim do nome

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do telefone

        private void cidade_TextChanged(object sender, EventArgs e)
        {

        }//fim da cidade

        private void estado_TextChanged(object sender, EventArgs e)
        {

        }//fim do estado

        private void cadastrarBotao_Click(object sender, EventArgs e)
        {
            int cod     = Convert.ToInt32(codigo.Text);
            string name = nome.Text;
            string tel  = telefone.Text;
            string cid  = cidade.Text;
            string est  = estado.Text;

            bd.Inserir(cod, name, tel, cid, est);//Inserindo no BD

            //Limpando os campos
            codigo.Text = "";
            nome.Text = "";
            telefone.Text = "";
            cidade.Text = "";
            estado.Text = "";
        }//fim do botão cadastrar

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do voltar

    }//fim da classe
}//fim do projeto
