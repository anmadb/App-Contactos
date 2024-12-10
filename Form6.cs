using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contactos2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            maskedTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form7 form7 = new Form7();

            String nombre = textBox2.Text;

            if (textBox2.Text.Length == 0 && maskedTextBox1.Text.Length == 0)
            {

                form7.MostrarTexto("Falta usuario y contraseña");
                form7.Show();
            }
            else if (maskedTextBox1.Text.Length == 0)
            {
                form7.MostrarTexto("Falta contraseña ");
                form7.Show();
            }
            else if (textBox2.Text.Length == 0)
            {
                form7.MostrarTexto("Falta nombre");
                form7.Show();
            }
            else
            {
                form1.Show();

            }

            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.UseSystemPasswordChar = !maskedTextBox1.UseSystemPasswordChar;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
