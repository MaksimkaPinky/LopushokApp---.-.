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
    public partial class AddEditMaterialForm : Form
    {
        public ProductMaterial prd_mat { get; set; } = null;

        public int ID { get; set; }

        public AddEditMaterialForm()
        {
            InitializeComponent();
        }

        private void AddEditMaterialForm_Load(object sender, EventArgs e)
        {
            materialBindingSource.DataSource = Program.db.Material.ToList();

            if (prd_mat != null)
            {
                productMaterialBindingSource.Add(prd_mat);
                Text = "Изменение данных о материалах продукции";
            }
            else
            {               
                ProductMaterial prdmat = new ProductMaterial();
                prdmat.ProductID = ID;
                prdmat.Count = 0;
                productMaterialBindingSource.Add(prdmat);
                Text = "Добавление данных о материалах продукции";
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (prd_mat == null)
            {
                prd_mat = (ProductMaterial)productMaterialBindingSource.Current;
                if (prd_mat.MaterialID == 0 || prd_mat.Count == 0)
                {
                    MessageBox.Show("Не все данные заданы!");
                    prd_mat = null;
                    return;
                }
                Program.db.ProductMaterial.Add(prd_mat);
            }
            try
            {
                Program.db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
