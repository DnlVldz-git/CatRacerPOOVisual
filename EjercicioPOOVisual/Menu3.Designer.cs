
namespace EjercicioPOOVisual
{
    partial class Menu3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu3));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDinero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPsw = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.InfoText;
            button2.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            button2.ForeColor = System.Drawing.Color.LimeGreen;
            button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            button2.Location = new System.Drawing.Point(465, 501);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(187, 66);
            button2.TabIndex = 14;
            button2.Text = "Registrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.InfoText;
            button1.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            button1.ForeColor = System.Drawing.Color.LimeGreen;
            button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            button1.Location = new System.Drawing.Point(58, 110);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(187, 66);
            button1.TabIndex = 17;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(408, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 204);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(239, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Introduzca la cantidad de dinero que invertirá:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxDinero
            // 
            this.textBoxDinero.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxDinero.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBoxDinero.Location = new System.Drawing.Point(242, 364);
            this.textBoxDinero.Name = "textBoxDinero";
            this.textBoxDinero.Size = new System.Drawing.Size(120, 24);
            this.textBoxDinero.TabIndex = 7;
            this.textBoxDinero.TextChanged += new System.EventHandler(this.textBoxDinero_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(239, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Introduzca su nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxNombre.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBoxNombre.Location = new System.Drawing.Point(242, 448);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(183, 24);
            this.textBoxNombre.TabIndex = 9;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(670, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Introduzca su sexo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSexo.BackColor = System.Drawing.SystemColors.InfoText;
            this.comboBoxSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSexo.ForeColor = System.Drawing.Color.LimeGreen;
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Prefiero no decir"});
            this.comboBoxSexo.Location = new System.Drawing.Point(673, 364);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSexo.TabIndex = 11;
            this.comboBoxSexo.SelectedIndexChanged += new System.EventHandler(this.comboBoxSexo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(670, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Introduzca su edad:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxEdad.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBoxEdad.Location = new System.Drawing.Point(673, 448);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(82, 24);
            this.textBoxEdad.TabIndex = 13;
            this.textBoxEdad.TextChanged += new System.EventHandler(this.textBoxEdad_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(248, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Introduzca un ID de tres dígitos:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxID.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBoxID.Location = new System.Drawing.Point(251, 280);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(120, 24);
            this.textBoxID.TabIndex = 16;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxPsw);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(button1);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(button2);
            this.panel1.Controls.Add(this.textBoxEdad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxSexo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxDinero);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 615);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ForeColor = System.Drawing.Color.LimeGreen;
            this.label6.Location = new System.Drawing.Point(647, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Introduzca una contraseña:";
            // 
            // textBoxPsw
            // 
            this.textBoxPsw.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxPsw.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBoxPsw.Location = new System.Drawing.Point(650, 280);
            this.textBoxPsw.Name = "textBoxPsw";
            this.textBoxPsw.Size = new System.Drawing.Size(194, 24);
            this.textBoxPsw.TabIndex = 19;
            // 
            // Menu3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1079, 615);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu3";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDinero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxPsw;
        private System.Windows.Forms.Label label6;
    }
}