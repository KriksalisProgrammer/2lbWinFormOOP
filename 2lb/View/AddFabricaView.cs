using _2lb.Factorial;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace _2lb.View
{
    public partial class AddFabricaView : Form
    {
        public Factor factor { get; set; }
        public AddFabricaView()
        {
            InitializeComponent();
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "," };
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            bool filled = Controls.OfType<TextBox>().Any(textBox => textBox.TextLength == 0);
            if (!filled)
            {
                factor = new Factor().SetName(textBoxName.Text)
                    .SetWorking(Convert.ToUInt32(textBoxQWorking.Text))
                    .SetWorkShop(Convert.ToUInt32(textBoxQWorkShop.Text))
                    .SetSalaryWorking(Convert.ToDecimal(textBoxSWorking.Text))
                    .SetSalaryMaster(Convert.ToDecimal(textBoxSMaster.Text));
                factor.QMaster();
                factor.ProfitOfMounthWorking();
                factor.ProfitOfMounthMaster();
                factor.SalarySum();
                factor.SetSumProfit(4000);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
           
            Close();
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBoxQWorking_KeyPress(object sender, KeyPressEventArgs e)
        {

            ValidateText(sender, e);
        }

        private void textBoxQWorkShop_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateText(sender, e);
        }

        private void textBoxSWorking_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextSymbol(sender, e);
        }

        private void textBoxSMaster_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextSymbol(sender, e);
        }
        private void ValidateText(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }//запрет ввода букв
        private void ValidateTextSymbol(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        
    }
}
