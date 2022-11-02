using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarlb_Click(object sender, EventArgs e)
        {
            Form form = new RegistroLibro();
            form.Show();
            this.Hide();
        }

        private void btnRegistraraudi_Click(object sender, EventArgs e)
        {
            Form form = new RegistroAudio();
            form.Show();
            this.Hide();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Form form = new Consultar();
            form.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
