﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transformaciones_Graficas
{
    public class CButton : Button
    {
        public CButton(Control aControl) 
        {
            this.Font = new Font( "Montserrat", 8, FontStyle.Bold);
            this.ForeColor = Color.White;
            this.Dock = DockStyle.Top;
            this.BackColor = Color.FromArgb(38, 39, 60);
            this.Parent = aControl;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(63, 71, 103);
            this.Idetificador = "aaa";
            this.Text = this.Idetificador;
            this.Size = new Size( this.Size.Width ,35);
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.Padding = new Padding(15, 0, 0, 0);
        }

        private string _idetificador;

        public string Idetificador
        {
            get => _idetificador;
            set => _idetificador = value;
        }
    }
}
