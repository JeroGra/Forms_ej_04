using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEjercicio04
{
    public partial class Form1 : Form
    {
        private static bool rdBtnAs = false;
        private static bool rdBtnDe = false;
        private static int tam = 0;

        private void OrdenarYAgregar()
        {
            Ordenar.Ordenamiento(tam);
            this.listBox1.Items.Clear();
            for (int i = 0; i < tam; i++)
            {
                this.listBox1.Items.Add(Ordenar.arrayNums[i]);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Ordenamineto";
            this.textBox1.Enabled = false;
            this.btnAgregar.Enabled = false;
            this.listBox1.Enabled = false;
            this.groupBox1.Enabled = false;
            this.groupBox1.Visible = false;
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero;

            if (this.listBox1.Items.Count < 1)
            {
                numero = Convert.ToInt32(this.textBox1.Text);
                Ordenar.arrayNums[0] = numero;
                this.listBox1.Items.Add(Ordenar.arrayNums[0]);
                
            }
            else
            {
                tam = this.listBox1.Items.Count;
                numero = Convert.ToInt32(this.textBox1.Text);
                Ordenar.arrayNums[tam] = numero;
                this.listBox1.Items.Add(Ordenar.arrayNums[tam]);

                tam++;
                OrdenarYAgregar();
            }      
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            this.lblMns.Visible = false;
            Form1.rdBtnAs = this.rdBtnAscendente.Checked;
            Form1.rdBtnDe = this.rdBtnDescendente.Checked;
            

            if (Form1.rdBtnAs == true)
            {
                Ordenar.OrdenarAscendente = true;
            }
            else
            {
                if (Form1.rdBtnDe == true)
                {
                    Ordenar.OrdenarAscendente = false;
                }
            }

            if(tam > 1)
            {
                OrdenarYAgregar();
            }


            if(this.btnAgregar.Enabled == false)
            {
                this.textBox1.Enabled = true;
                this.btnAgregar.Enabled = true;
                this.listBox1.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que quieres borrar los datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

              //  this.listBox1.Items.Clear();
                Form1.tam = 0;
               /* for (int i = 0; i < 100; i++)
                {
                    Array.Clear(Ordenar.arrayNums, 0, 100);
                }*/

         
                foreach (Control controles in this.groupBox1.Controls)
                {
                    if(controles is TextBox)
                    {
                        ((TextBox)controles).Clear();
                    }
                }
                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.groupBox1.Visible = true;
            if (MessageBox.Show("Seguro que quiere salir de la app?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            this.groupBox1.Visible = false;
        }
    }
}
