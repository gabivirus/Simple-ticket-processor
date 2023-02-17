using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            double valor, multa, juros, desc, acresc, vjuros, vmulta, vdesc, total;

            DateTime venc, pag;

            int dias;

            valor = double.Parse(ValueBox.Text); venc = Convert.ToDateTime(EndDate.Text); pag = Convert.ToDateTime(PayDate.Text); multa = double.Parse(TicketBox.Text); juros = double.Parse(FeesBox.Text); desc = double.Parse(DiscountBox.Text);

            if (pag > venc) 
            {
                dias = (pag - venc).Days;
                vmulta = (multa / 100) * valor;
                vjuros = (juros / 100) * valor * dias;
            }
            else { dias = 0; vmulta = 0; vjuros = 0; }

            DelayBox.Text = dias.ToString();
            TicketValueBox.Text = vmulta.ToString("C");
            FeesBox.Text = vjuros.ToString("C");

            acresc = vmulta + vjuros;
            AddBox.Text = acresc.ToString("C");

            if (pag < venc) { vdesc = (desc / 100) * valor; }
            else { vdesc = 0; }

            DiscountValueBox.Text = vdesc.ToString();
            total = valor + acresc - vdesc;

            TotalBox.Text = total.ToString("C");
        }
    }
}
