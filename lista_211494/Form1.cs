using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista_211494
{
    public partial class Form1 : Form
    {


        double adicionar;
        double total_despesa;
        double total_compra;
        double total_saldo;

        public Form1()
        {
            InitializeComponent();
        }


        private void txtProduto1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            string produto = txtProduto1.Text;
            int quantidade = int.Parse(txtQuant.Text);
            double valor_uni = double.Parse(txtValor.Text);
            adicionar = quantidade * valor_uni;

            listProdutos.Items.Add(produto + "/" + quantidade + "/" + "R$ " + adicionar);
            total_compra = total_compra + adicionar;
            txtProduto1.Clear();
            txtQuant.Clear();
            txtValor.Clear();

            lblTotal.Text = "R$" + total_compra.ToString("F");
            total_saldo = total_saldo + total_compra;

            lblSaldo.Text = total_saldo.ToString("F");

            if (total_saldo > 0)
            {
                lblSaldo.ForeColor = Color.Black;
            }
            else
            {
                lblSaldo.ForeColor = Color.Red;
            }
        }

        private void btnDespesa_Click(object sender, EventArgs e)
        {
            string despesa = txtDespesa.Text;
            double valor = double.Parse(txtValortotal.Text);

            total_despesa = total_despesa + valor;

            listDespesa.Items.Add(despesa + "/" + "R$ " + valor);
            total_despesa = total_despesa + adicionar;
            txtDespesa.Clear();
            txtValortotal.Clear();


            lblDespesa.Text = "R$" + total_despesa.ToString("F");
            total_saldo = total_saldo - total_despesa;
            lblSaldo.Text = total_saldo.ToString("F");

            if (total_saldo > 0)
            {
                lblSaldo.ForeColor = Color.Black;
            }
            else
            {
                lblSaldo.ForeColor = Color.Red;
            }
        }

        private void listProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listProdutos.Items.Clear();
            listDespesa.Items.Clear();
            txtProduto1.Clear();
            txtQuant.Clear();
            txtValor.Clear();
            txtDespesa.Clear();
            txtValortotal.Clear();

            lblSaldo.Text = "";
            lblDespesa.Text = "";
            lblTotal.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblS_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
