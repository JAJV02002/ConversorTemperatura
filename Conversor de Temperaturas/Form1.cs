using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_Temperaturas
{
    public partial class Weather : Form
    {
        double Temperatura;
        double C, F;
        public Weather()
        {
            InitializeComponent();
        }

        Classes.ClsFarenheit obj = new Classes.ClsFarenheit();
        private void BttnConvertir_Click(object sender, EventArgs e)
        {
            F = double.Parse(TxtFarenheit.Text);
            double farenheit;

        }
    }
}
