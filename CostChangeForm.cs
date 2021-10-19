using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LopushokApp.ModelEF;

namespace LopushokApp
{
    public partial class CostChangeForm : Form
    {
        public CostChangeForm()
        {
            InitializeComponent();
        }

        private void CostChangeForm_Load(object sender, EventArgs e)
        {
            decimal sred = 0;
            foreach(int id in Form1.lstSelectedProduct)
            {
                Product prd = Program.db.Product.Find(id);
                sred += prd.MinCostForAgent;
            }
            sred = sred/Form1.lstSelectedProduct.Count;
            AddCostTxt.Text = sred.ToString();
        }

        private void EditCostBtn_Click(object sender, EventArgs e)
        {
            if ((AddCostTxt.Text == ""))
            {
                MessageBox.Show("Не задана величина изменения цены.");
                return;
            }

            decimal delta = Convert.ToDecimal(AddCostTxt.Text);
            foreach (int id in Form1.lstSelectedProduct)
            {
                Product prd = Program.db.Product.Find(id);
                prd.MinCostForAgent += delta;
            }

            try {
                Program.db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddCostTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != ',')) // если символ не цифра  
                e.Handled = true;   // нажатый символ не вводится

        }
    }
}
