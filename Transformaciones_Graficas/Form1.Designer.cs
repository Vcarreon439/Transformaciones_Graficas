
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
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pnlMenuDer = new System.Windows.Forms.Panel();
            this.tabInfo = new System.Windows.Forms.TabControl();
            this.tabInfo2 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnMover = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.btnCirculo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRectangulo = new System.Windows.Forms.ToolStripMenuItem();
            this.poligonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.icnPctShHi2 = new FontAwesome.Sharp.IconPictureBox();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.pnlFondo.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlMenuDer.SuspendLayout();
            this.tabInfo.SuspendLayout();
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
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(33, 610);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.tabInfo.Controls.Add(this.tabInfo2);
            this.tabInfo.Controls.Add(this.tabPage2);
            this.tabInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInfo.Location = new System.Drawing.Point(0, 33);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.SelectedIndex = 0;
            this.tabInfo.Size = new System.Drawing.Size(192, 577);
            this.tabInfo.TabIndex = 0;
            // 
            // tabInfo2
            // 
            this.tabInfo2.Location = new System.Drawing.Point(4, 22);
            this.tabInfo2.Name = "tabInfo2";
            this.tabInfo2.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo2.Size = new System.Drawing.Size(184, 551);
            this.tabInfo2.TabIndex = 0;
            this.tabInfo2.Text = "Capas";
            this.tabInfo2.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(184, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnMover
            // 
            this.btnMover.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMover.Image = global::Transformaciones_Graficas.Properties.Resources.send_message;
            this.btnMover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(30, 20);
            this.btnMover.Text = "toolStripButton1";
            this.btnMover.ToolTipText = "Para seleccionar figuras";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Transformaciones_Graficas.Properties.Resources.rotate_right;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(30, 20);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Rotar figura";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCirculo,
            this.btnRectangulo,
            this.poligonoToolStripMenuItem});
            this.toolStripButton2.Image = global::Transformaciones_Graficas.Properties.Resources.geometry1;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(30, 20);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // btnCirculo
            // 
            this.btnCirculo.Image = global::Transformaciones_Graficas.Properties.Resources.circle;
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(180, 22);
            this.btnCirculo.Text = "Elipse";
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Image = global::Transformaciones_Graficas.Properties.Resources.crop_square;
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(180, 22);
            this.btnRectangulo.Text = "Rectangulo";
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // poligonoToolStripMenuItem
            // 
            this.poligonoToolStripMenuItem.Image = global::Transformaciones_Graficas.Properties.Resources.play_arrow;
            this.poligonoToolStripMenuItem.Name = "poligonoToolStripMenuItem";
            this.poligonoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poligonoToolStripMenuItem.Text = "Poligono";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 610);
            this.Controls.Add(this.pnlFondo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlMenuDer.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icnPctShHi2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Panel pnlMenuDer;
        private System.Windows.Forms.TabControl tabInfo;
        private System.Windows.Forms.TabPage tabInfo2;
        private System.Windows.Forms.TabPage tabPage2;
        private FontAwesome.Sharp.IconPictureBox icnPctShHi2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMover;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem btnCirculo;
        private System.Windows.Forms.ToolStripMenuItem btnRectangulo;
        private System.Windows.Forms.ToolStripMenuItem poligonoToolStripMenuItem;
        private System.Windows.Forms.Timer tmrUpdate;
    }
}

