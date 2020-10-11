using _2lb.Factorial;
using _2lb.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2lb
{
    using Factorial.SpecialClass2lb;
    using System.Threading;

    public partial class Form1 : Form
    {
        private BindingSource _bs;
        
        public Form1()
        {
            
            InitializeComponent();
            _bs = new BindingSource();
            dataGridView1.Visible = false;
            _bs.DataSource = Storage.factors;
            dataGridView1.DataSource = _bs;
            dataGridView1.AutoResizeColumns(); 
            numericAddDelPerson.Visible = false;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AddFabrica_Click(object sender, EventArgs e)
        {
           
            label1.Visible = false;
            dataGridView1.Visible = true;
            buttonDell.Visible = true;
            AddFabricaMenu.Visible = false;
            AddFabricaMenu.Enabled = false;
            AddPerson.Visible = true;
            numericAddDelPerson.Visible = true;
            label2.Visible = true;
           
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
          
           
        }

        private void AddFactor_Click(object sender, EventArgs e)
        {
            
        }
      
        private void AddPerson_Click(object sender, EventArgs e)
        {
            
            foreach(DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Factor factorcell = row.DataBoundItem as Factor;
                if (factorcell != null)
                {
                       
                        factorcell.AdditionW((int)numericAddDelPerson.Value);
                        _bs.ResetBindings(true);
                }

            }
           
        }//добавление

        private void buttonDell_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Factor factorcell = row.DataBoundItem as Factor;
                if (factorcell != null)
                {
                    factorcell.DismissalW((int)numericAddDelPerson.Value);
                    _bs.ResetBindings(true);
                }

            }
        }//удаление
        private void buttonSl_Click(object sender, EventArgs e)
        {
            Factor factorcell = new Factor();
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                factorcell = row.DataBoundItem as Factor;
                if (factorcell != null)
                {

                }

            }
            Factor factorcell1 = new Factor();
            foreach (DataGridViewRow row1 in this.dataGridView1.SelectedRows)
            {
                factorcell1 = row1.DataBoundItem as Factor;
                if (factorcell1 != null)
                {
                    Factor resultfact = factorcell + factorcell1;
                    Storage.AddObject(resultfact);
                    _bs.DataSource = Storage.factors;
                    _bs.ResetBindings(true);
                }

            }
        }//слияние

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripMenuItemSort_Click(object sender, EventArgs e)
        {
            Array.Sort(Storage.factors);
            _bs.ResetBindings(true);
            Thread.Sleep(1000);
        }

        private void ToolStripMenuItemMerge_Click(object sender, EventArgs e)
        {
            Factor factorcell = new Factor();
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                factorcell = row.DataBoundItem as Factor;
                if (factorcell != null)
                {

                }

            }
            Factor factorcell1 = new Factor();
            foreach (DataGridViewRow row1 in this.dataGridView1.SelectedRows)
            {
                factorcell1 = row1.DataBoundItem as Factor;
                if (factorcell1 != null)
                {
                    Factor resultfact = factorcell + factorcell1;
                    Storage.AddObject(resultfact);
                    _bs.DataSource = Storage.factors;
                    _bs.ResetBindings(true);
                }

            }
        }

        private void toolStripMenuAdd_Click(object sender, EventArgs e)
        {
            var dialog = new AddFabricaView();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Storage.AddObject(dialog.factor);
                _bs.DataSource = Storage.factors;
                _bs.ResetBindings(true);

            }
        }

        private void ToolStripMenuItemInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вторая лабораторная работа по СПЗ", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
