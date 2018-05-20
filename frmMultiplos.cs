using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DAI_PRA1__Quispe_
{
    public partial class frmMultiplos : Form
    {
        ArrayList lista = new ArrayList();
        Random objRandom = new Random();
        int[] intNumeros = new int[100];

        public frmMultiplos()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
            for (int valor = 0; valor < 100; valor++){
                intNumeros[valor] = ( objRandom.Next(0, 1000));
                if (intNumeros[valor]%5==0)
                {
                    int numero = intNumeros[valor];
                    lista.Add(numero);
                }

                
              
            }
            
            lstMultiplos.DataSource = lista;
            
           

        }
    }
}
