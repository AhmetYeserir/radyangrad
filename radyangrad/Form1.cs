using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radyangrad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // değişken tanımlama 
            double derece, grad, radyan;
            // değer atama 
            derece = Convert.ToDouble(textBox1.Text);
            //işlem katmanı
            //radyan formül : derece * 3.14 / 180
            //radyan = derece * 3.14 / 180
            radyan = derece * 3.14 / 180;
            radyan = derece * Math.PI / 180;
            //grad formül : derece * 200 /180
            grad = derece * 200 / 180;
            // ekran görüntüsü
            textBox2.Text = radyan.ToString();
            //textBox2.Text = Convert.ToString(radyan);

            textBox3.Text = grad.ToString();  







        }
    }
}
