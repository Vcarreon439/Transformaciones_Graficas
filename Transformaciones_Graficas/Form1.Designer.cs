
namespace Transformaciones_Graficas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMover = new System.Windows.Forms.ToolStripButton();
            this.btnRotar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.btnCirculo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRectangulo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPoligono = new System.Windows.Forms.ToolStripMenuItem();
            this.btnContorno = new System.Windows.Forms.ToolStripButton();
            this.btnRelleno = new System.Windows.Forms.ToolStripButton();
            this.pnlMenuDer = new System.Windows.Forms.Panel();
            this.tabInfo = new System.Windows.Forms.TabControl();
            this.tabCapas = new System.Windows.Forms.TabPage();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.tabPropiedades = new System.Windows.Forms.TabPage();
            this.icnPctShHi2 = new FontAwesome.Sharp.IconPictureBox();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pnlFondo.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlMenuDer.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icnPctShHi2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.Controls.Add(this.toolStrip1);
            this.pnlFondo.Controls.Add(this.pnlMenuDer);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(1044, 610);
            this.pnlFondo.TabIndex = 1;
            this.pnlFondo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFondo_MouseDown);
            this.pnlFondo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlFondo_MouseMove);
            this.pnlFondo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlFondo_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMover,
            this.btnRotar,
            this.toolStripButton2,
            this.btnContorno,
            this.btnRelleno,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(33, 610);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMover
            // 
            this.btnMover.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMover.Image = ((System.Drawing.Image)(resources.GetObject("btnMover.Image")));
            this.btnMover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(30, 20);
            this.btnMover.Text = "toolStripButton1";
            this.btnMover.ToolTipText = "Para seleccionar figuras";
            // 
            // btnRotar
            // 
            this.btnRotar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRotar.Image = ((System.Drawing.Image)(resources.GetObject("btnRotar.Image")));
            this.btnRotar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRotar.Name = "btnRotar";
            this.btnRotar.Size = new System.Drawing.Size(30, 20);
            this.btnRotar.Text = "toolStripButton1";
            this.btnRotar.ToolTipText = "Rotar figura";
            this.btnRotar.Click += new System.EventHandler(this.btnRotar_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCirculo,
            this.btnRectangulo,
            this.btnPoligono});
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(30, 20);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // btnCirculo
            // 
            this.btnCirculo.Image = ((System.Drawing.Image)(resources.GetObject("btnCirculo.Image")));
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(180, 22);
            this.btnCirculo.Text = "Elipse";
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Image = ((System.Drawing.Image)(resources.GetObject("btnRectangulo.Image")));
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(180, 22);
            this.btnRectangulo.Text = "Rectangulo";
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // btnPoligono
            // 
            this.btnPoligono.Image = ((System.Drawing.Image)(resources.GetObject("btnPoligono.Image")));
            this.btnPoligono.Name = "btnPoligono";
            this.btnPoligono.Size = new System.Drawing.Size(180, 22);
            this.btnPoligono.Text = "Poligono";
            this.btnPoligono.Click += new System.EventHandler(this.btnPoligono_Click);
            // 
            // btnContorno
            // 
            this.btnContorno.AutoSize = false;
            this.btnContorno.BackColor = System.Drawing.Color.Black;
            this.btnContorno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnContorno.ForeColor = System.Drawing.Color.Transparent;
            this.btnContorno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnContorno.Name = "btnContorno";
            this.btnContorno.Size = new System.Drawing.Size(30, 20);
            this.btnContorno.Text = "toolStripButton3";
            this.btnContorno.ToolTipText = "Contorno de la figura";
            this.btnContorno.Click += new System.EventHandler(this.btnContorno_Click);
            // 
            // btnRelleno
            // 
            this.btnRelleno.AutoSize = false;
            this.btnRelleno.BackColor = System.Drawing.Color.Transparent;
            this.btnRelleno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRelleno.ForeColor = System.Drawing.Color.Transparent;
            this.btnRelleno.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRelleno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRelleno.Name = "btnRelleno";
            this.btnRelleno.Size = new System.Drawing.Size(30, 20);
            this.btnRelleno.Text = "toolStripButton4";
            this.btnRelleno.ToolTipText = "Relleno de la figura";
            this.btnRelleno.Click += new System.EventHandler(this.btnRelleno_Click);
            // 
            // pnlMenuDer
            // 
            this.pnlMenuDer.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuDer.Controls.Add(this.tabInfo);
            this.pnlMenuDer.Controls.Add(this.icnPctShHi2);
            this.pnlMenuDer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMenuDer.Location = new System.Drawing.Point(852, 0);
            this.pnlMenuDer.Name = "pnlMenuDer";
            this.pnlMenuDer.Size = new System.Drawing.Size(192, 610);
            this.pnlMenuDer.TabIndex = 1;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.tabCapas);
            this.tabInfo.Controls.Add(this.tabPropiedades);
            this.tabInfo.Controls.Add(this.tabRegistro);
            this.tabInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInfo.Location = new System.Drawing.Point(0, 33);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.SelectedIndex = 0;
            this.tabInfo.Size = new System.Drawing.Size(192, 577);
            this.tabInfo.TabIndex = 0;
            // 
            // tabCapas
            // 
            this.tabCapas.Location = new System.Drawing.Point(4, 22);
            this.tabCapas.Name = "tabCapas";
            this.tabCapas.Padding = new System.Windows.Forms.Padding(3);
            this.tabCapas.Size = new System.Drawing.Size(184, 551);
            this.tabCapas.TabIndex = 0;
            this.tabCapas.Text = "Capas";
            this.tabCapas.UseVisualStyleBackColor = true;
            // 
            // tabRegistro
            // 
            this.tabRegistro.Controls.Add(this.txtLog);
            this.tabRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistro.Size = new System.Drawing.Size(184, 551);
            this.tabRegistro.TabIndex = 1;
            this.tabRegistro.Text = "Registro";
            this.tabRegistro.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 3);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(178, 545);
            this.txtLog.TabIndex = 0;
            // 
            // tabPropiedades
            // 
            this.tabPropiedades.Location = new System.Drawing.Point(4, 22);
            this.tabPropiedades.Name = "tabPropiedades";
            this.tabPropiedades.Size = new System.Drawing.Size(184, 551);
            this.tabPropiedades.TabIndex = 2;
            this.tabPropiedades.Text = "Propiedades";
            this.tabPropiedades.UseVisualStyleBackColor = true;
            // 
            // icnPctShHi2
            // 
            this.icnPctShHi2.BackColor = System.Drawing.Color.Transparent;
            this.icnPctShHi2.Dock = System.Windows.Forms.DockStyle.Top;
            this.icnPctShHi2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.icnPctShHi2.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.icnPctShHi2.IconColor = System.Drawing.SystemColors.ControlText;
            this.icnPctShHi2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnPctShHi2.IconSize = 33;
            this.icnPctShHi2.Location = new System.Drawing.Point(0, 0);
            this.icnPctShHi2.Name = "icnPctShHi2";
            this.icnPctShHi2.Size = new System.Drawing.Size(192, 33);
            this.icnPctShHi2.TabIndex = 1;
            this.icnPctShHi2.TabStop = false;
            this.icnPctShHi2.Click += new System.EventHandler(this.icnPctShHi2_Click);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 1;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(30, 20);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 610);
            this.Controls.Add(this.pnlFondo);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlMenuDer.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabRegistro.ResumeLayout(false);
            this.tabRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icnPctShHi2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Panel pnlMenuDer;
        private System.Windows.Forms.TabControl tabInfo;
        private System.Windows.Forms.TabPage tabCapas;
        private System.Windows.Forms.TabPage tabRegistro;
        private FontAwesome.Sharp.IconPictureBox icnPctShHi2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMover;
        private System.Windows.Forms.ToolStripButton btnRotar;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem btnCirculo;
        private System.Windows.Forms.ToolStripMenuItem btnRectangulo;
        private System.Windows.Forms.ToolStripMenuItem btnPoligono;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.TabPage tabPropiedades;
        private System.Windows.Forms.ToolStripButton btnContorno;
        private System.Windows.Forms.ToolStripButton btnRelleno;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

