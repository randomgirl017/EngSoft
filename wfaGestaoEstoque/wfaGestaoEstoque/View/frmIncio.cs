﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaGestaoEstoque
{
    public partial class frmIncio : Form
    {
        public frmIncio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCad_Click(object sender, EventArgs e)
        {
            View.frmCadConsum form = new View.frmCadConsum();
            form.Show();
     
        }

        private void frmIncio_Load(object sender, EventArgs e)
        {
            lblData.Text = "Olá, seja bem vindo! Hoje é " + DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
