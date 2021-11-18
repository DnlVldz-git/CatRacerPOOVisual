
namespace EjercicioPOOVisual
{
    partial class FormRegistrar
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
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPsw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
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
            button2.Location = new System.Drawing.Point(424, 482);
            button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(169, 52);
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
            button1.Location = new System.Drawing.Point(60, 78);
            button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(169, 52);
            button1.TabIndex = 17;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.textBoxPsw);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(button1);
            this.panel1.Controls.Add(this.comboBoxSexo);
            this.panel1.Controls.Add(button2);
            this.panel1.Controls.Add(this.textBoxEdad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 588);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxPsw
            // 
            this.textBoxPsw.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPsw.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBoxPsw.Location = new System.Drawing.Point(616, 274);
            this.textBoxPsw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPsw.Name = "textBoxPsw";
            this.textBoxPsw.Size = new System.Drawing.Size(215, 30);
            this.textBoxPsw.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.LimeGreen;
            this.label6.Location = new System.Drawing.Point(611, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Introduzca una contraseña:";
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSexo.BackColor = System.Drawing.SystemColors.InfoText;
            this.comboBoxSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxSexo.ForeColor = System.Drawing.Color.LimeGreen;
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Prefiero no decir"});
            this.comboBoxSexo.Location = new System.Drawing.Point(616, 379);
            this.comboBoxSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(215, 33);
            this.comboBoxSexo.TabIndex = 11;
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEdad.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBoxEdad.Location = new System.Drawing.Point(138, 382);
            this.textBoxEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(215, 30);
            this.textBoxEdad.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(134, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Introduzca su edad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(612, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Introduzca su sexo:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNombre.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBoxNombre.Location = new System.Drawing.Point(138, 274);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(202, 30);
            this.textBoxNombre.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(134, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Introduzca su nombre:";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(384, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 159);
            this.panel2.TabIndex = 5;
            // 
            // FormRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1004, 588);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRegistrar";
            this.Text = "FormRegistrar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxPsw;
        private System.Windows.Forms.Label label6;
    }
}