using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace pjPromedioNotas
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.mainForm = this;
            form2.Show();
           
        }
        //nombramos a los registros del usuario como item 
        ListViewItem Item;
        private void lvRegistro_Click(object sender, EventArgs e)
        {
            

        }
        private void lvRegistro_MouseClick(object sender, MouseEventArgs e)
        {
            Item = lvRegistro.GetItemAt(e.X, e.Y);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Item != null)
            {
                lvRegistro.Items.Remove(Item);

            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Registro");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            lvRegistro.Items.Clear();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //boton Acerca de
            Form3 Form3 = new Form3();
            //muestra el formulario 4
            Form3.Show();
        }
    }
}
