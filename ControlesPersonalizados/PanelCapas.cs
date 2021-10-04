using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ControlesPersonalizados
{
    public partial class PanelCapas : Control
    {
        private List<Button> botones;

        public PanelCapas()
        {
            Panel relleno = new Panel();
            relleno.Dock = DockStyle.Fill;
            relleno.BackColor = Color.White;
            relleno.Parent = this;

            foreach (Button boton in Botones)
            {
                this.Controls.Add(boton);
            }

            InitializeComponent();
            
        }

        public List<Button> Botones
        {
            get => botones;
            set => botones = value;
        }
    }
}
