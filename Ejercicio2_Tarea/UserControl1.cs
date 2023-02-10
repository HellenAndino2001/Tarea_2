using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_Tarea
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        //BOTON CALCULAR
        private async void button1_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal (TB1.Text);
            decimal nota2 = Convert.ToDecimal(TB2.Text);
            decimal nota3= Convert.ToDecimal(TB3.Text);
            decimal nota4 = Convert.ToDecimal(TB4.Text);

            decimal resultado = await PromedioAsync(nota1, nota2, nota3, nota4);

            MessageBox.Show($" Su promedio es:{resultado} ");


        }
        //FUNCION ASINCRONA
        private async Task <decimal> PromedioAsync(decimal n1,decimal n2,decimal n3,decimal n4)
        {
            decimal promedio = await Task.Run(() =>
            {
                return (n1+n2+n3+ n4)/4;    
  
            });
            return promedio;
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
