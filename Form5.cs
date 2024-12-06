﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static contactos2.ListaContactos;

namespace contactos2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NombreEliminar = textBox1.Text.Trim(); 
            string TelefonoEliminar = textBox2.Text.Trim(); 

            if (string.IsNullOrEmpty(NombreEliminar) && string.IsNullOrEmpty(TelefonoEliminar))
            {
                MessageBox.Show("Por favor, ingresa el nombre o el número de teléfono del contacto que deseas eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(NombreEliminar))
            {
                Contact contactByName = ListaContactos.listaContactos.FirstOrDefault(c => c.Nombre.Equals(NombreEliminar, StringComparison.OrdinalIgnoreCase));
                if (contactByName != null)
                {
                    ListaContactos.listaContactos.Remove(contactByName);
                    MessageBox.Show("Contacto eliminado correctamente por nombre.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear(); 
                }
                else
                {
                    MessageBox.Show("No se encontró ningún contacto con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!string.IsNullOrEmpty(TelefonoEliminar))
            {
                Contact contactByPhone = ListaContactos.listaContactos.FirstOrDefault(c => c.Nombre == TelefonoEliminar);
                if (contactByPhone != null)
                {
                    ListaContactos.listaContactos.Remove(contactByPhone);
                    MessageBox.Show("Contacto eliminado correctamente por teléfono.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Clear(); 
                }
                else
                {
                    MessageBox.Show("No se encontró ningún contacto con ese número de teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
