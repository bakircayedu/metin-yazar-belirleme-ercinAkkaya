using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace veri_yapıları_proje
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public string metin;


        private void btnDosya_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(.txt)|.txt";
            ofd.ShowDialog();

            Stream file = ofd.OpenFile();
            StreamReader reader = new StreamReader(file);
            metin = reader.ReadToEnd();
            lblMetin.Text = ofd.FileName;
        }

    }
}