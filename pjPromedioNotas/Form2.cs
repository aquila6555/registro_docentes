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
    public partial class Form2 : MetroForm
    {
        public Form1 mainForm;//Esta variable hace referencia al Form1



        public Form2()
        {
            InitializeComponent();
        }

        public void btnRegis_Click(object sender, EventArgs e)
        {

          

            //objeto de la clase 
            Docente objD = new Docente();

            //enviando los valores a la clase 
            objD.nombre = txtNombre.Text;

             objD.sueldoBasico = int.Parse(txtSueldo.Text);
             objD.añosTrabajados = int.Parse(txtAños.Text);
          

            //Declaramos las variables necesarias:
            int menor, mayor, aleatorio;
            //Declaramos la variable randomica:
            Random randObj = new Random();
            //Ahora capturamos la cantidad, menor, mayor:
           
            menor = 100;
            mayor = 200;
                      
                //Capturamos el número aleatorio que esta entre menor y mayor
                aleatorio = randObj.Next(menor, mayor);
       


            string edad;
            edad = (DateTime.Today.AddTicks(-cboNacimiento.Value.Ticks).Year - 1).ToString();

          
           


                    ListViewItem fila = new ListViewItem(aleatorio.ToString());
                fila.SubItems.Add(objD.nombre);
            if (rbdMas.Checked == true)
                {
                    fila.SubItems.Add("Masculino".ToString());
                }
                else
                {
                    fila.SubItems.Add("Femenino".ToString());
                }
                fila.SubItems.Add(edad.ToString());
                fila.SubItems.Add(txtSueldo.Text);

            fila.SubItems.Add(txtAños.Text);
               
               // fila.SubItems.Add(objD.nuevoSueldo().ToString());
                 fila.SubItems.Add(objD.nuevoSueldo().ToString());
                mainForm.lvRegistro.Items.Add(fila);

            this.Close();
            }

        
    }
    }

