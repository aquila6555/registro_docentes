using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPromedioNotas
{
    class Docente
    {
        //atributos
        public string nombre { get; set; }
      
        public int sueldoBasico { get; set; }
        public int añosTrabajados { get; set; }
        public int bono { get; set; }

      

        
        public double nuevoSueldo()
        {
            if (añosTrabajados >= 4) 
            {
                if (añosTrabajados >= 8)
                {
                    if (añosTrabajados >= 12)
                    {
                        if (añosTrabajados >= 16)
                        {
                            if (añosTrabajados >= 20)
                            {
                                if (añosTrabajados >= 24)
                                {
                                    return sueldoBasico + (sueldoBasico * 0.90);
                                }
                                else
                                {
                                    return sueldoBasico + (sueldoBasico * 0.75);
                                }
                            }
                            else
                            {
                                return sueldoBasico + (sueldoBasico * 0.60);
                            }
                        }
                        else
                        {
                            return sueldoBasico + (sueldoBasico * 0.45);
                        }
                    }
                    else
                    {
                        return sueldoBasico + (sueldoBasico * 0.30);
                    }
                }
                else
                {
                    return sueldoBasico+(sueldoBasico*0.15);
                }
            }
            else
            {
                return sueldoBasico;
            }
        }

    }
}


         
                 
   