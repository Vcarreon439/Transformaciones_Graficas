
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
            this.btnBezier = new System.Windows.Forms.ToolStripButton();
            this.btnRezise = new System.Windows.Forms.ToolStripButton();
            this.btnRotar = new System.Windows.Forms.ToolStripDropDownButton();
            this.anguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAnguloFig = new System.Windows.Forms.ToolStripTextBox();
            this.btnDibujar = new System.Windows.Forms.ToolStripSplitButton();
            this.btnCirculo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRectangulo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPoligono = new System.Windows.Forms.ToolStripMenuItem();
            this.ladosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLadosPoligono = new System.Windows.Forms.ToolStripTextBox();
            this.btnContorno = new System.Windows.Forms.ToolStripButton();
            this.btnRelleno = new System.Windows.Forms.ToolStripButton();
            this.btnSesgado = new System.Windows.Forms.ToolStripButton();
            this.pnlMenuDer = new System.Windows.Forms.Panel();
            this.tabInfo = new System.Windows.Forms.TabControl();
            this.tabCapas = new System.Windows.Forms.TabPage();
            this.tabPropiedades = new System.Windows.Forms.TabPage();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPosY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPosX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.btnExportLog = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.icnPctShHi2 = new FontAwesome.Sharp.IconPictureBox();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pnlFondo.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlMenuDer.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabPropiedades.SuspendLayout();
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
            this.pnlFondo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFondo_Paint);
            this.pnlFondo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFondo_MouseDown);
            this.pnlFondo.MouseEnter += new System.EventHandler(this.pnlFondo_MouseEnter);
            this.pnlFondo.MouseLeave += new System.EventHandler(this.pnlFondo_MouseLeave);
            this.pnlFondo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlFondo_MouseMove);
            this.pnlFondo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlFondo_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMover,
            this.btnBezier,
            this.btnSesgado,
            this.btnRezise,
            this.btnRotar,
            this.btnDibujar,
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
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnBezier
            // 
            this.btnBezier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBezier.Image = global::Transformaciones_Graficas.Properties.Resources.journey;
            this.btnBezier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBezier.Name = "btnBezier";
            this.btnBezier.Size = new System.Drawing.Size(30, 20);
            this.btnBezier.Text = "toolStripButton3";
            this.btnBezier.Click += new System.EventHandler(this.btnBezier_Click);
            // 
            // btnRezise
            // 
            this.btnRezise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRezise.ForeColor = System.Drawing.Color.Transparent;
            this.btnRezise.Image = global::Transformaciones_Graficas.Properties.Resources.photo_size_select_small;
            this.btnRezise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRezise.Name = "btnRezise";
            this.btnRezise.Size = new System.Drawing.Size(30, 20);
            this.btnRezise.Text = "toolStripButton1";
            this.btnRezise.ToolTipText = "Redimensionar objeto";
            this.btnRezise.Click += new System.EventHandler(this.btnRezise_Click);
            // 
            // btnRotar
            // 
            this.btnRotar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRotar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anguloToolStripMenuItem,
            this.txtAnguloFig});
            this.btnRotar.Image = ((System.Drawing.Image)(resources.GetObject("btnRotar.Image")));
            this.btnRotar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRotar.Name = "btnRotar";
            this.btnRotar.Size = new System.Drawing.Size(30, 20);
            this.btnRotar.Text = "toolStripButton1";
            this.btnRotar.ToolTipText = "Rotar figura";
            this.btnRotar.Click += new System.EventHandler(this.btnRotar_Click);
            // 
            // anguloToolStripMenuItem
            // 
            this.anguloToolStripMenuItem.Name = "anguloToolStripMenuItem";
            this.anguloToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.anguloToolStripMenuItem.Text = "Angulo";
            // 
            // txtAnguloFig
            // 
            this.txtAnguloFig.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAnguloFig.Name = "txtAnguloFig";
            this.txtAnguloFig.Size = new System.Drawing.Size(100, 23);
            this.txtAnguloFig.TextChanged += new System.EventHandler(this.txtAnguloFig_TextChanged);
            // 
            // btnDibujar
            // 
            this.btnDibujar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDibujar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCirculo,
            this.btnRectangulo,
            this.btnPoligono});
            this.btnDibujar.Image = ((System.Drawing.Image)(resources.GetObject("btnDibujar.Image")));
            this.btnDibujar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(30, 20);
            this.btnDibujar.Text = "toolStripButton2";
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
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
            this.btnPoligono.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ladosToolStripMenuItem,
            this.txtLadosPoligono});
            this.btnPoligono.Image = ((System.Drawing.Image)(resources.GetObject("btnPoligono.Image")));
            this.btnPoligono.Name = "btnPoligono";
            this.btnPoligono.Size = new System.Drawing.Size(180, 22);
            this.btnPoligono.Text = "Poligono";
            this.btnPoligono.Click += new System.EventHandler(this.btnPoligono_Click);
            // 
            // ladosToolStripMenuItem
            // 
            this.ladosToolStripMenuItem.Name = "ladosToolStripMenuItem";
            this.ladosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ladosToolStripMenuItem.Text = "Lados";
            // 
            // txtLadosPoligono
            // 
            this.txtLadosPoligono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLadosPoligono.Name = "txtLadosPoligono";
            this.txtLadosPoligono.Size = new System.Drawing.Size(100, 23);
            this.txtLadosPoligono.TextChanged += new System.EventHandler(this.txtLadosPoligono_TextChanged);
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
            // btnSesgado
            // 
            this.btnSesgado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSesgado.Image = global::Transformaciones_Graficas.Properties.Resources.format_shapes;
            this.btnSesgado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSesgado.Name = "btnSesgado";
            this.btnSesgado.Size = new System.Drawing.Size(30, 20);
            this.btnSesgado.Text = "toolStripButton1";
            this.btnSesgado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSesgado.ToolTipText = "Modificar los puntos de las figuras";
            this.btnSesgado.Click += new System.EventHandler(this.btnSesgado_Click);
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
            // tabPropiedades
            // 
            this.tabPropiedades.Controls.Add(this.txtAngulo);
            this.tabPropiedades.Controls.Add(this.label6);
            this.tabPropiedades.Controls.Add(this.txtLargo);
            this.tabPropiedades.Controls.Add(this.label4);
            this.tabPropiedades.Controls.Add(this.txtAncho);
            this.tabPropiedades.Controls.Add(this.label5);
            this.tabPropiedades.Controls.Add(this.txtPosY);
            this.tabPropiedades.Controls.Add(this.label3);
            this.tabPropiedades.Controls.Add(this.txtPosX);
            this.tabPropiedades.Controls.Add(this.label2);
            this.tabPropiedades.Controls.Add(this.txtIdentificador);
            this.tabPropiedades.Controls.Add(this.label1);
            this.tabPropiedades.Location = new System.Drawing.Point(4, 22);
            this.tabPropiedades.Name = "tabPropiedades";
            this.tabPropiedades.Size = new System.Drawing.Size(184, 551);
            this.tabPropiedades.TabIndex = 2;
            this.tabPropiedades.Text = "Propiedades";
            this.tabPropiedades.UseVisualStyleBackColor = true;
            // 
            // txtAngulo
            // 
            this.txtAngulo.Location = new System.Drawing.Point(68, 161);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(81, 20);
            this.txtAngulo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Angulo";
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(95, 106);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(81, 20);
            this.txtLargo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Largo";
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(10, 106);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(79, 20);
            this.txtAncho.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ancho";
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(95, 63);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(81, 20);
            this.txtPosY.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y";
            // 
            // txtPosX
            // 
            this.txtPosX.Location = new System.Drawing.Point(10, 63);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(79, 20);
            this.txtPosX.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(10, 24);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(166, 20);
            this.txtIdentificador.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador";
            // 
            // tabRegistro
            // 
            this.tabRegistro.Controls.Add(this.btnExportLog);
            this.tabRegistro.Controls.Add(this.txtLog);
            this.tabRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistro.Size = new System.Drawing.Size(184, 551);
            this.tabRegistro.TabIndex = 1;
            this.tabRegistro.Text = "Registro";
            this.tabRegistro.UseVisualStyleBackColor = true;
            // 
            // btnExportLog
            // 
            this.btnExportLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportLog.Location = new System.Drawing.Point(99, 516);
            this.btnExportLog.Name = "btnExportLog";
            this.btnExportLog.Size = new System.Drawing.Size(75, 23);
            this.btnExportLog.TabIndex = 1;
            this.btnExportLog.Text = "Exportar Log";
            this.btnExportLog.UseVisualStyleBackColor = true;
            this.btnExportLog.Click += new System.EventHandler(this.btnExportLog_Click);
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
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(30, 20);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Informacion de los desarrolladores";
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
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlMenuDer.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabPropiedades.ResumeLayout(false);
            this.tabPropiedades.PerformLayout();
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
        private System.Windows.Forms.ToolStripSplitButton btnDibujar;
        private System.Windows.Forms.ToolStripMenuItem btnCirculo;
        private System.Windows.Forms.ToolStripMenuItem btnRectangulo;
        private System.Windows.Forms.ToolStripMenuItem btnPoligono;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.TabPage tabPropiedades;
        private System.Windows.Forms.ToolStripButton btnContorno;
        private System.Windows.Forms.ToolStripButton btnRelleno;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtAngulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPosY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPosX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportLog;
        private System.Windows.Forms.ToolStripButton btnRezise;
        private System.Windows.Forms.ToolStripMenuItem ladosToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtLadosPoligono;
        private System.Windows.Forms.ToolStripDropDownButton btnRotar;
        private System.Windows.Forms.ToolStripMenuItem anguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtAnguloFig;
        private System.Windows.Forms.ToolStripButton btnBezier;
        private System.Windows.Forms.ToolStripButton btnSesgado;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

