using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatoDeFuentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (FontFamily fuente in FontFamily.Families)
            {
                String nombre = fuente.Name;
                ListaFuentes.Items.Add(nombre);
            }
            ListaFuentes.Text = this.Texto.Font.Name.ToString();
        }

        private void BotonFormVerde_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void BotonFormAzul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void BotonFormRojo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void BotonFormControl_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void BotonTextoVerde_Click(object sender, EventArgs e)
        {
            Texto.ForeColor = Color.Green;
        }

        private void BotonTextoAzul_Click(object sender, EventArgs e)
        {
            Texto.ForeColor = Color.Blue;
        }

        private void BotonTextoRojo_Click(object sender, EventArgs e)
        {
            Texto.ForeColor = Color.Red;
        }

        private void BotonTextoNegro_Click(object sender, EventArgs e)
        {
            Texto.ForeColor = Color.Black;
        }

        private void BotonOcultar_Click(object sender, EventArgs e)
        {
            Texto.Visible = false;
        }

        private void BotonMostrar_Click(object sender, EventArgs e)
        {
            Texto.Visible = true;
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckNegrita_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckNegrita.Checked)
            {
                Texto.Font = new Font(this.Font, FontStyle.Bold);
            }
            else
            {
                Texto.Font = new Font(this.Font, FontStyle.Regular);
            }
        }

        private void CheckCursiva_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckCursiva.Checked)
            {
                Texto.Font = new Font(this.Font, FontStyle.Italic);
            }
            else
            {
                Texto.Font = new Font(this.Font, FontStyle.Regular);
            }
        }

        private void CheckSubrayado_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckSubrayado.Checked)
            {
                Texto.Font = new Font(this.Font, FontStyle.Underline);
            }
            else
            {
                Texto.Font = new Font(this.Font, FontStyle.Regular);
            }
        }

        private void BotonAumentar_Click(object sender, EventArgs e)
        {
            if (this.Width < 1200)
            {
                if (this.Height < 900)
                {
                    this.Width += 20;
                    this.Height += 20;
                }
                else
                {
                    MessageBox.Show("Ya ha alcanzado el tamaño máximo permitido");
                }
            }
            else
            {
                MessageBox.Show("Ya ha alcanzado el tamaño máximo permitido");
            }
        }

        private void BotonReducir_Click(object sender, EventArgs e)
        {
            if (this.Width > 600)
            {
                if (this.Height > 450)
                {
                    this.Width -= 20;
                    this.Height -= 20;
                }
                else
                {
                    MessageBox.Show("Ya ha alcanzado el tamaño mínimo permitido");
                }
            }
            else
            {
                MessageBox.Show("Ya ha alcanzado el tamaño mínimo permitido");
            }
        }

        private void TamañoFuenteUpDown_ValueChanged(object sender, EventArgs e)
        {
            int fuente = Convert.ToInt32(TamañoFuenteUpDown.Value);
            Texto.Font = new Font(Texto.Font.Name, fuente,
                Texto.Font.Style, Texto.Font.Unit);
        }

        private void ListaFuentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            String fuente = ListaFuentes.SelectedItem.ToString();
            int tamaño = Convert.ToInt32(Texto.Font.Size);
            Texto.Font = new Font(fuente, tamaño);
        }
    }
}
