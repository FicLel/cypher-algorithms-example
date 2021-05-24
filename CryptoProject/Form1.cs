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
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(xml);
            byte[] text = Encoding.UTF8.GetBytes(txtText.Text);
            byte[] result = rsa.Encrypt(text, true);
            txtResultado.Text = Convert.ToBase64String(result);
        }

        public void decriptRSA() 
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(xml);
            byte[] text = Convert.FromBase64String(txtTextoEncriptado.Text);
            byte[] resultado =  rsa.Decrypt(text, true);
            txtDesencriptado.Text = Encoding.UTF8.GetString(resultado);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEncriptar_Click(object sender, EventArgs e)
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

        private void btnDesecnriptar_Click(object sender, EventArgs e)
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

        private void btnExportKeys_Click(object sender, EventArgs e)
        {
            XMLOperations export = new XMLOperations();
            if (cmbAlgoritmos.SelectedIndex == 1)
            {
                export.RSAXMLKeys(xml);
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
    }
}
