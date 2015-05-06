using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormCurp.SRCurp;

namespace FormCurp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        SRCurp.DatosCurpSoapClient cu = new DatosCurpSoapClient();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAp.Text != string.Empty && txtAm.Text != string.Empty && txtnom.Text != string.Empty && txtAno.Text != string.Empty && txtDia.Text != string.Empty && txtMes.Text != string.Empty && txtSexo.Text != string.Empty)
            {
                try
                {
                    MessageBox.Show(cu.CurpImp(txtAp.Text, txtAm.Text, txtnom.Text, txtAno.Text, (txtMes.SelectedIndex +1).ToString(), txtDia.Text, txtSexo.SelectedItem.ToString()), "Tu Curp es la siguiente:", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (FormatException ex)
                {

                    MessageBox.Show(string.Format("Debes introducir datos validos en las cajas de texto. \n {o}", ex.Message));

                }
                
            }
            else
            {
                MessageBox.Show(string.Format("Debes introducir valores verdaderos en las cajas de textos"));

            }
        }
    }
}
