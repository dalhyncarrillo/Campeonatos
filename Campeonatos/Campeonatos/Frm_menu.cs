﻿//Desarrollado por Edgar Carrera -0901-09-5333-
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SQLiteConnect;
using System.Collections;

namespace Campeonatos
{
    public partial class Frm_menu_jugadores : Form
    {
        public Frm_menu_jugadores()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect(Properties.Settings.Default.ruta);


        private void Form1_Load(object sender, EventArgs e)
        {
         }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            Frm_consulta f1 = new Frm_consulta();
            f1.ShowDialog();

        }

        private void btn_Insercion_Click(object sender, EventArgs e)
        {
            frm_insertar_jugador f1 = new frm_insertar_jugador();
            f1.ShowDialog();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Frm_edicion f = new Frm_edicion();
            f.ShowDialog();
        }

        
    }   
}
