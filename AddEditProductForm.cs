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
using System.Data.Entity;

namespace LopushokApp
{
    public partial class AddEditProductForm : Form
    {
        public Product prd { get; set; } = null;
        public AddEditProductForm()
        {
            InitializeComponent();
        }

        private void AddEditProductForm_Load(object sender, EventArgs e)
        {
            productTypeBindingSource.DataSource = Program.db.ProductType.ToList();            
            
            materialBindingSource.DataSource = Program.db.Material.ToList();

            if(prd == null)
            {                
                // добавляем в промежуточный объект пустой объект - продукции
                productBindingSource.AddNew();
                // настраиваем картинку и надпись
                // запрещаем удаление еще не введенной продукции
                DeleteBtn.Enabled = false;
                productImage = @"products\picture.png";
                ProdictPictureBox.Image = Image.FromFile(productImage);
                Text = "Добавление нового товара";
                // добавление материалов не показываем
                // еще нет ID продукции
                Size = new Size (500, 400); 
            }
            else
            {
                // передаем DataGridView коллекцию productMaterial
                // productMaterialBindingSource.DataSource = prd.ProductMaterial.ToList();
                productMaterialBindingSource.DataSource = Program.db.ProductMaterial.Local
                .ToBindingList().Where(pm => (pm.ProductID == prd.ID));
                // добавляем в промежуточный объект - объект-продукции
                productBindingSource.Add(prd);
                // показываем в PictureBox изображение продукции
                if (prd.Image != "")
                    ProdictPictureBox.Image = Image.FromFile(prd.Image);
                else
                {
                    productImage = @"products\picture.png";
                    ProdictPictureBox.Image = Image.FromFile(productImage);
                }

                Text = "Изменение данных товара";
            }
        }
        string productImage = "";
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Файлы картинок|*.jpg;*.jpeg;*.png;";
            
            // задаем подкаталог "products"
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.InitialDirectory += @"\products\";

            DialogResult dr = ofd.ShowDialog();
            if(dr == DialogResult.OK)
            {
                // выделяем относительный путь
                string file = ofd.FileName;
                int n = file.IndexOf("products");
                file = file.Substring(n);
                ///////////////////////////////
                imageTextBox.Text = file;
                productImage = file;
                ProdictPictureBox.Image = Image.FromFile(file);
                ((Product)productBindingSource.Current).Image = file;                
            }
        }
        //  сохраняем данные о продукции
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(prd == null)
            {
                prd = (Product)productBindingSource.Current;
                Program.db.Product.Add(prd);
            }
            prd.Image = productImage;
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
        // выполняем закрытие формы
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить продукт - " + prd.Title,
                "Удаление продукции", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                // Проверяем - можно ли удалять эту продукцию
                // проверяем - есть ли данные о продажах товара?
                if (prd.ProductSale.Count > 0)
                {
                    MessageBox.Show("Данную продукцию удалить нельзя, т.к. есть данные о продажах!");
                    return;
                }
                // проверяем - есть данные о материалах?
                if (prd.ProductMaterial.Count > 0)
                {//  удаляем данные о материалах
                    //foreach (ProductMaterial prd_mtr in prd.ProductMaterial)
                    //{
                    //    Program.db.ProductMaterial.Remove(prd_mtr);
                    //}
                    Program.db.ProductMaterial.RemoveRange(prd.ProductMaterial);
                }
                // проверяем - есть данные о истории стоимости?
                if (prd.ProductCostHistory.Count > 0)
                {//  удаляем данные о истории стоимости
                    //foreach (ProductCostHistory prd_hist in prd.ProductCostHistory)
                    //{
                    //    Program.db.ProductCostHistory.Remove(prd_hist);
                    //}
                    Program.db.ProductCostHistory.RemoveRange(prd.ProductCostHistory);
                }                

                // удаляем выбранный объект из коллекции
                Program.db.Product.Remove(prd);
                
                // сохраняем сделанные изменения в БД
                try  // обрабатываем исключения
                {
                    // сохраняем сделанные изменения в БД
                    Program.db.SaveChanges();
                    // завершаем работу формы
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)  // если ошибка, то попадаем сюда
                {
                    // выводим сообщение SQL Server об ошибке
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
        }
        //////////////////////////////////////////////////////
        //////////////////////////////////////////////////////
        //  Работа с данными о материалах
        //
        private void productMaterialDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        //  добавляем новый материал
        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddEditMaterialForm form = new AddEditMaterialForm();
            form.prd_mat = null;
            // передаем ID для задания в списке материалов
            form.ID = prd.ID;

            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                productMaterialBindingSource.DataSource =
                    Program.db.ProductMaterial.Where(p => p.ProductID == prd.ID).ToList();
            }
        }
        //  изменяем данные о материале
        private void EditBtn_Click(object sender, EventArgs e)
        {
            ProductMaterial prdMater = (ProductMaterial)productMaterialBindingSource.Current;
            AddEditMaterialForm form = new AddEditMaterialForm();
            form.prd_mat = prdMater;
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                productMaterialBindingSource.DataSource =
                    Program.db.ProductMaterial.Where(p => p.ProductID == prd.ID).ToList();
            }
        }
        //  удаляем материал
        private void DeleteMaterBtn_Click(object sender, EventArgs e)
        {
            ProductMaterial prdMater = (ProductMaterial)productMaterialBindingSource.Current;
            DialogResult dr = MessageBox.Show("Удалить материал - " + prdMater.Material.Title, 
                "Удаление данных о материалах продукции", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Program.db.ProductMaterial.Remove(prdMater);
                Program.db.SaveChanges();
            }
        }        
    }
}
