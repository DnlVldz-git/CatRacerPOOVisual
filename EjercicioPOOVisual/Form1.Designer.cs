
namespace EjercicioPOOVisual
{
    partial class form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnCerrar;
            System.Windows.Forms.Button btnMin;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMainFoto = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            btnCerrar = new System.Windows.Forms.Button();
            btnMin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = System.Drawing.SystemColors.InfoText;
            btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCerrar.ForeColor = System.Drawing.Color.LimeGreen;
            btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnCerrar.Location = new System.Drawing.Point(1653, 0);
            btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(51, 50);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMin
            // 
            btnMin.BackColor = System.Drawing.SystemColors.InfoText;
            btnMin.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMin.ForeColor = System.Drawing.Color.LimeGreen;
            btnMin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnMin.Location = new System.Drawing.Point(1604, 0);
            btnMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnMin.Name = "btnMin";
            btnMin.Size = new System.Drawing.Size(51, 50);
            btnMin.TabIndex = 4;
            btnMin.Text = "-";
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panelMainFoto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1707, 886);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.LimeGreen;
            this.button2.Location = new System.Drawing.Point(288, 672);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 57);
            this.button2.TabIndex = 4;
            this.button2.Text = "CERRAR SESIÓN";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(1098, 672);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "PRESIONA AQUÍ PARA CONTINUAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelMainFoto
            // 
            this.panelMainFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMainFoto.BackgroundImage")));
            this.panelMainFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMainFoto.Location = new System.Drawing.Point(499, 138);
            this.panelMainFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMainFoto.Name = "panelMainFoto";
            this.panelMainFoto.Size = new System.Drawing.Size(611, 351);
            this.panelMainFoto.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(btnMin);
            this.panel2.Controls.Add(btnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1707, 53);
            this.panel2.TabIndex = 2;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1707, 886);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMainFoto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

