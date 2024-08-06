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
        public Form1()
        {
            InitializeComponent();

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string produto = tbProd.Text;
            int quantidade = int.Parse(tbQuant.Text);
            double Valor = double.Parse(tbVal.Text);

           lbItens.Items.Add(produto+"/"+quantidade+"/"+Valor.ToString("C"));

        }

       
    }
}
