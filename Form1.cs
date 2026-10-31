using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace entorno1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value <= 90)
                progressBar1.Value += 10;
            else
                MessageBox.Show("no insista ya esta en el limite");

        }

        private void btndisminuir_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value >= 10)
                progressBar1.Value -= 10;
            else
                MessageBox.Show("error llego a 0","ventana de error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            if (mskclave.Text == "*")
                            {
                groupBox1.Visible = true;
            }
            else
            {
                MessageBox.Show("Clave incorrecta");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.masculino;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.femenino;
        

        }
    }
}
