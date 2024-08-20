using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windosMercado
{
    public partial class Form1 : Form
    {
        double total;
        public Form1()
        {
            InitializeComponent();

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string produto = tbProd.Text;
            int quantidade = int.Parse(tbQuant.Text);
            double valor = double.Parse(tbVal.Text);

           lbItens.Items.Add(produto+"/"+quantidade+"/"+valor.ToString("C"));

            total += quantidade * valor;

            tbProd.Text = "";
            tbQuant.Text = "";
            tbVal.Text = "";
            lblTotal.Text = total.ToString("C");
        }

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            total = 0;
            lbItens.Items.Clear();
        }
    }
}
