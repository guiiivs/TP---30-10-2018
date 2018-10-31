using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox2.Text == "") {
                label8.Text = "Obrigatório*";
            }
            //else
            //{
            //    label8.Text = "";
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Pessoa candidato = new Pessoa();
            

                MessageBox.Show("Yay! Dado cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro, senta e chora");
            }
        }

   

    }
}
