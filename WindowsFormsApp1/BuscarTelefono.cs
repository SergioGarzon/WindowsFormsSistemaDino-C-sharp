﻿using System;
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
    public partial class BuscarTelefono : Form
    {
        public BuscarTelefono()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conectionDataBase conection = new conectionDataBase();
            
            MessageBox.Show(""+ conection.getDataBaseCliente(int.Parse(txtDNI.Text)));
        }
    }
}

