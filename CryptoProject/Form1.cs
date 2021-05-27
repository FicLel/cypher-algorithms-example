using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace CryptoProject
{
    public partial class Form1 : Form
    {
        TDES tdes;
        static String xml = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cmbAlgoritmos.SelectedIndex == 0)
            {
                tdes = new TDES();
                txtClave.Text = tdes.generateKeysTDES().ToString();
            } 
            else if (cmbAlgoritmos.SelectedIndex == 1)
            {
                getRSAkeys();
            }
        }

        public void getRSAkeys() 
        {
            //Generate a public/private key pair.  
            RSA rsa = RSA.Create();
            //Save the public key information to an RSAParameters structure.  
            RSAParameters rsaKeyInfo = rsa.ExportParameters(true);
            xml = rsa.ToXmlString(true);
            //Console.WriteLine(xml);
            txtClave.Text = Convert.ToBase64String(rsaKeyInfo.D);
            txtClavePublica.Text = Convert.ToBase64String(rsaKeyInfo.Modulus);
        }

        public void encriptarRSA() 
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
            rsa.FromXmlString(xml);
            byte[] text = Encoding.ASCII.GetBytes(txtText.Text);
            byte[] result = rsa.Encrypt(text, false);
            txtResultado.Text = Convert.ToBase64String(result);
        }

        public void decriptRSA() 
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(xml);
            RSAParameters key = rsa.ExportParameters(true);
            byte[] text = Convert.FromBase64String(txtTextoEncriptado.Text);
            byte[] resultado = new RSAOperations().RSADecrypt(text, key, false);
            txtDesencriptado.Text = Encoding.Default.GetString(resultado);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {   if (String.IsNullOrEmpty(txtText.Text))
            {
                try
                {
                    if (cmbAlgoritmos.SelectedIndex == 0)
                    {
                        tdes = new TDES();
                        txtResultado.Text = tdes.encript(txtText.Text, txtClave.Text);
                    }
                    else if (cmbAlgoritmos.SelectedIndex == 1)
                    {
                        encriptarRSA();
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Ocurrio un error al encriptar, revise los datos");
                }
            }   
            else
            {
                MessageBox.Show("No se puede encriptar un mensaje vacio");
            }
        }

        private void btnDesecnriptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAlgoritmos.SelectedIndex == 0)
                {
                    tdes = new TDES();
                    txtDesencriptado.Text = tdes.decript(txtClave.Text, txtTextoEncriptado.Text);
                }
                else if (cmbAlgoritmos.SelectedIndex == 1)
                {
                    decriptRSA();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Algo salio mal, por favor revisar los datos que ha ingresado");
            }
        }

        private void btnExportKeys_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtClave.Text))
            {
                XMLOperations export = new XMLOperations();
                if (cmbAlgoritmos.SelectedIndex == 1)
                {
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "XML-File | *.xml";
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        export.ExportXML(export.RSAXMLKeys(xml), save.FileName);
                    }
                }
                else if (cmbAlgoritmos.SelectedIndex == 0)
                {
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "XML-File | *.xml";
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        export.ExportXML(export.TDESKey(txtClave.Text), save.FileName);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se pueden exportan llaves vacias");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtResultado.Text))
            {
                XMLOperations export = new XMLOperations();
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text-File | *.txt";
                string returnValue = txtResultado.Text;
                if (cmbAlgoritmos.SelectedIndex == 1)
                {
                    byte[] plainTextBytes = System.Text.Encoding.Default.GetBytes(txtResultado.Text);
                    returnValue = System.Convert.ToBase64String(plainTextBytes);
                }

                if (save.ShowDialog() == DialogResult.OK)
                {
                    export.ExportEncriptedText(returnValue, save.FileName);
                }
            }
            else
            {
                MessageBox.Show("No se puede exportar texto no encriptado");
            }
        }

        private void btnImportKeys_Click(object sender, EventArgs e)
        {
            XMLOperations import = new XMLOperations();
            OpenFileDialog save = new OpenFileDialog();
            save.Filter = "XML-File | *.xml";
            if (save.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(save.FileName);
                if (cmbAlgoritmos.SelectedIndex == 0)
                {
                   txtClave.Text = import.GetTDESKey(import.ImportXML(save.FileName));
                }
                else if (cmbAlgoritmos.SelectedIndex == 1)
                {
                    String[] data = import.GetRSAValues(import.ImportXML(save.FileName));
                    xml = data[2];
                    txtClave.Text = data[1];
                    txtClavePublica.Text = data[0];
                }
            }

        }

        private void btnImportText_Click(object sender, EventArgs e)
        {
            OpenFileDialog save = new OpenFileDialog();
            save.Filter = "Text-File | *.txt";
            string decodedText = "";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string text = System.IO.File.ReadAllText(save.FileName);
                if (cmbAlgoritmos.SelectedIndex == 1)
                {
                    byte[] textAsBytes = Convert.FromBase64String(text);
                    decodedText = Encoding.UTF8.GetString(textAsBytes);
                } else 
                {
                    decodedText = text;
                }
                txtTextoEncriptado.Text = decodedText;
                // Display the file contents to the console. Variable text is a string.
                System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
            }
        }

        private void cmbAlgoritmos_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background 
            e.DrawBackground();

            // Get the item text    
            string text = (e.Index >= 0) ? ((ComboBox)sender).Items[e.Index].ToString() : "";

            // Determine the forecolor based on whether or not the item is selected    
            Brush brush = Brushes.White;
            

            // Draw the text    
            e.Graphics.DrawString(text, ((Control)sender).Font, brush, e.Bounds.X, e.Bounds.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
