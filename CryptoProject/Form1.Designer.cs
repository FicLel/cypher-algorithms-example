
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(3, 167);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(691, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar Llaves";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(3, 65);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(329, 96);
            this.txtClave.TabIndex = 1;
            this.txtClave.Text = "";
            // 
            // lblClave1
            // 
            this.lblClave1.AutoSize = true;
            this.lblClave1.Location = new System.Drawing.Point(4, 46);
            this.lblClave1.Name = "lblClave1";
            this.lblClave1.Size = new System.Drawing.Size(34, 13);
            this.lblClave1.TabIndex = 2;
            this.lblClave1.Text = "Clave";
            // 
            // txtClavePublica
            // 
            this.txtClavePublica.Location = new System.Drawing.Point(365, 65);
            this.txtClavePublica.Name = "txtClavePublica";
            this.txtClavePublica.Size = new System.Drawing.Size(329, 96);
            this.txtClavePublica.TabIndex = 3;
            this.txtClavePublica.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clave Publica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Texto";
            // 
            // btnImportKeys
            // 
            this.btnImportKeys.Location = new System.Drawing.Point(594, 15);
            this.btnImportKeys.Name = "btnImportKeys";
            this.btnImportKeys.Size = new System.Drawing.Size(100, 23);
            this.btnImportKeys.TabIndex = 6;
            this.btnImportKeys.Text = "Importar Llaves";
            this.btnImportKeys.UseVisualStyleBackColor = true;
            this.btnImportKeys.Click += new System.EventHandler(this.btnImportKeys_Click);
            // 
            // btnExportKeys
            // 
            this.btnExportKeys.Location = new System.Drawing.Point(498, 15);
            this.btnExportKeys.Name = "btnExportKeys";
            this.btnExportKeys.Size = new System.Drawing.Size(90, 23);
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
            this.panel1.Location = new System.Drawing.Point(11, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 211);
            this.panel1.TabIndex = 8;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(6, 44);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(323, 20);
            this.txtText.TabIndex = 9;
            // 
            // panel2
            // 
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
            this.panel2.Location = new System.Drawing.Point(19, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 220);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(6, 107);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(323, 20);
            this.txtResultado.TabIndex = 11;
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(6, 152);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(323, 23);
            this.btnEncriptar.TabIndex = 12;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // btnDesecnriptar
            // 
            this.btnDesecnriptar.Location = new System.Drawing.Point(365, 152);
            this.btnDesecnriptar.Name = "btnDesecnriptar";
            this.btnDesecnriptar.Size = new System.Drawing.Size(323, 23);
            this.btnDesecnriptar.TabIndex = 13;
            this.btnDesecnriptar.Text = "Desencriptar";
            this.btnDesecnriptar.UseVisualStyleBackColor = true;
            this.btnDesecnriptar.Click += new System.EventHandler(this.btnDesecnriptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Texto";
            // 
            // txtTextoEncriptado
            // 
            this.txtTextoEncriptado.Location = new System.Drawing.Point(365, 43);
            this.txtTextoEncriptado.Name = "txtTextoEncriptado";
            this.txtTextoEncriptado.Size = new System.Drawing.Size(323, 20);
            this.txtTextoEncriptado.TabIndex = 15;
            // 
            // txtDesencriptado
            // 
            this.txtDesencriptado.Location = new System.Drawing.Point(365, 107);
            this.txtDesencriptado.Name = "txtDesencriptado";
            this.txtDesencriptado.Size = new System.Drawing.Size(323, 20);
            this.txtDesencriptado.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Resultado";
            // 
            // cmbAlgoritmos
            // 
            this.cmbAlgoritmos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlgoritmos.FormattingEnabled = true;
            this.cmbAlgoritmos.Items.AddRange(new object[] {
            "TDES",
            "RSA"});
            this.cmbAlgoritmos.Location = new System.Drawing.Point(512, 10);
            this.cmbAlgoritmos.Name = "cmbAlgoritmos";
            this.cmbAlgoritmos.Size = new System.Drawing.Size(203, 21);
            this.cmbAlgoritmos.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Seleccione el algoritmo:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(6, 182);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(323, 23);
            this.btnExport.TabIndex = 18;
            this.btnExport.Text = "Exportar Texto";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 492);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAlgoritmos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}

