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
    public partial class Form3 : MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/007JoelDavid");
            }
            catch { }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
            try
            {
                System.Diagnostics.Process.Start("https://twitter.com/JD_Quisbert");
            }
            catch { }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            

            try
            {
                System.Diagnostics.Process.Start("https://github.com/aquila6555");
            }
            catch { }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

            try
            {
                System.Diagnostics.Process.Start("aquila6555@gmail.com");
            }
            catch { }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            try
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC1aoLoUxAtJxihDU6nhXQKA");
            }
            catch { }
        }
    }
}
