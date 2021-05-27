
namespace CryptoProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.RichTextBox();
            this.lblClave1 = new System.Windows.Forms.Label();
            this.txtClavePublica = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImportKeys = new System.Windows.Forms.Button();
            this.btnExportKeys = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnDesecnriptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTextoEncriptado = new System.Windows.Forms.TextBox();
            this.txtDesencriptado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAlgoritmos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImportText = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Location = new System.Drawing.Point(8, 167);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(686, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar Llaves";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.txtClave.Location = new System.Drawing.Point(8, 65);
            this.txtClave.Name = "txtClave";
            this.txtClave.ReadOnly = true;
            this.txtClave.Size = new System.Drawing.Size(329, 96);
            this.txtClave.TabIndex = 1;
            this.txtClave.Text = "";
            // 
            // lblClave1
            // 
            this.lblClave1.AutoSize = true;
            this.lblClave1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.lblClave1.Location = new System.Drawing.Point(4, 46);
            this.lblClave1.Name = "lblClave1";
            this.lblClave1.Size = new System.Drawing.Size(37, 13);
            this.lblClave1.TabIndex = 2;
            this.lblClave1.Text = "Clave";
            // 
            // txtClavePublica
            // 
            this.txtClavePublica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.txtClavePublica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClavePublica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.txtClavePublica.Location = new System.Drawing.Point(365, 65);
            this.txtClavePublica.Name = "txtClavePublica";
            this.txtClavePublica.ReadOnly = true;
            this.txtClavePublica.Size = new System.Drawing.Size(329, 96);
            this.txtClavePublica.TabIndex = 3;
            this.txtClavePublica.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(365, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clave Publica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.label2.Location = new System.Drawing.Point(5, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Texto";
            // 
            // btnImportKeys
            // 
            this.btnImportKeys.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.btnImportKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportKeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.btnImportKeys.Location = new System.Drawing.Point(594, 5);
            this.btnImportKeys.Name = "btnImportKeys";
            this.btnImportKeys.Size = new System.Drawing.Size(100, 22);
            this.btnImportKeys.TabIndex = 6;
            this.btnImportKeys.Text = "Importar Llaves";
            this.btnImportKeys.UseVisualStyleBackColor = true;
            this.btnImportKeys.Click += new System.EventHandler(this.btnImportKeys_Click);
            // 
            // btnExportKeys
            // 
            this.btnExportKeys.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.btnExportKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportKeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.btnExportKeys.Location = new System.Drawing.Point(498, 5);
            this.btnExportKeys.Name = "btnExportKeys";
            this.btnExportKeys.Size = new System.Drawing.Size(90, 22);
            this.btnExportKeys.TabIndex = 7;
            this.btnExportKeys.Text = "Exportar Llaves";
            this.btnExportKeys.UseVisualStyleBackColor = true;
            this.btnExportKeys.Click += new System.EventHandler(this.btnExportKeys_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtClave);
            this.panel1.Controls.Add(this.btnExportKeys);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Controls.Add(this.btnImportKeys);
            this.panel1.Controls.Add(this.lblClave1);
            this.panel1.Controls.Add(this.txtClavePublica);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(35, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 211);
            this.panel1.TabIndex = 8;
            // 
            // txtText
            // 
            this.txtText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(8, 44);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(329, 19);
            this.txtText.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnImportText);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDesencriptado);
            this.panel2.Controls.Add(this.txtTextoEncriptado);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnDesecnriptar);
            this.panel2.Controls.Add(this.btnEncriptar);
            this.panel2.Controls.Add(this.txtResultado);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtText);
            this.panel2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(35, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 220);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.label3.Location = new System.Drawing.Point(5, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(8, 107);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(329, 19);
            this.txtResultado.TabIndex = 11;
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(129)))), ((int)(((byte)(172)))));
            this.btnEncriptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(129)))), ((int)(((byte)(172)))));
            this.btnEncriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncriptar.ForeColor = System.Drawing.Color.Black;
            this.btnEncriptar.Location = new System.Drawing.Point(8, 152);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(329, 23);
            this.btnEncriptar.TabIndex = 12;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = false;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // btnDesecnriptar
            // 
            this.btnDesecnriptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.btnDesecnriptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.btnDesecnriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesecnriptar.Location = new System.Drawing.Point(365, 152);
            this.btnDesecnriptar.Name = "btnDesecnriptar";
            this.btnDesecnriptar.Size = new System.Drawing.Size(329, 23);
            this.btnDesecnriptar.TabIndex = 13;
            this.btnDesecnriptar.Text = "Desencriptar";
            this.btnDesecnriptar.UseVisualStyleBackColor = false;
            this.btnDesecnriptar.Click += new System.EventHandler(this.btnDesecnriptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.label4.Location = new System.Drawing.Point(362, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Texto";
            // 
            // txtTextoEncriptado
            // 
            this.txtTextoEncriptado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.txtTextoEncriptado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTextoEncriptado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoEncriptado.Location = new System.Drawing.Point(365, 43);
            this.txtTextoEncriptado.Name = "txtTextoEncriptado";
            this.txtTextoEncriptado.Size = new System.Drawing.Size(329, 19);
            this.txtTextoEncriptado.TabIndex = 15;
            // 
            // txtDesencriptado
            // 
            this.txtDesencriptado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.txtDesencriptado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesencriptado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesencriptado.Location = new System.Drawing.Point(365, 106);
            this.txtDesencriptado.Name = "txtDesencriptado";
            this.txtDesencriptado.Size = new System.Drawing.Size(329, 19);
            this.txtDesencriptado.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.label5.Location = new System.Drawing.Point(362, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Resultado";
            // 
            // cmbAlgoritmos
            // 
            this.cmbAlgoritmos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.cmbAlgoritmos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbAlgoritmos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlgoritmos.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlgoritmos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.cmbAlgoritmos.FormattingEnabled = true;
            this.cmbAlgoritmos.IntegralHeight = false;
            this.cmbAlgoritmos.ItemHeight = 20;
            this.cmbAlgoritmos.Items.AddRange(new object[] {
            "TDES",
            "RSA"});
            this.cmbAlgoritmos.Location = new System.Drawing.Point(536, 44);
            this.cmbAlgoritmos.Name = "cmbAlgoritmos";
            this.cmbAlgoritmos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbAlgoritmos.Size = new System.Drawing.Size(203, 26);
            this.cmbAlgoritmos.TabIndex = 11;
            this.cmbAlgoritmos.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbAlgoritmos_DrawItem);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.label6.Location = new System.Drawing.Point(379, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Seleccione el algoritmo:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.btnExport.Location = new System.Drawing.Point(8, 182);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(329, 23);
            this.btnExport.TabIndex = 18;
            this.btnExport.Text = "Exportar Texto";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImportText
            // 
            this.btnImportText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.btnImportText.Location = new System.Drawing.Point(365, 181);
            this.btnImportText.Name = "btnImportText";
            this.btnImportText.Size = new System.Drawing.Size(329, 23);
            this.btnImportText.TabIndex = 19;
            this.btnImportText.Text = "Importar Texto";
            this.btnImportText.UseVisualStyleBackColor = true;
            this.btnImportText.Click += new System.EventHandler(this.btnImportText_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(-2, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 28);
            this.panel3.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(97)))), ((int)(((byte)(106)))));
            this.button1.Location = new System.Drawing.Point(751, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.label7.Location = new System.Drawing.Point(15, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sistema de encriptacion y desencriptacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(781, 554);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAlgoritmos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.RichTextBox txtClave;
        private System.Windows.Forms.Label lblClave1;
        private System.Windows.Forms.RichTextBox txtClavePublica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImportKeys;
        private System.Windows.Forms.Button btnExportKeys;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDesecnriptar;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDesencriptado;
        private System.Windows.Forms.TextBox txtTextoEncriptado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAlgoritmos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImportText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}

