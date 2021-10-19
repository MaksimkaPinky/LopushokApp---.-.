
namespace LopushokApp
{
    partial class AddEditMaterialForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label materialIDLabel;
            System.Windows.Forms.Label productIDLabel;
            this.productMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.materialIDComboBox = new System.Windows.Forms.ComboBox();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.materialTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            countLabel = new System.Windows.Forms.Label();
            materialIDLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(50, 78);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(38, 13);
            countLabel.TabIndex = 7;
            countLabel.Text = "Count:";
            // 
            // materialIDLabel
            // 
            materialIDLabel.AutoSize = true;
            materialIDLabel.Location = new System.Drawing.Point(27, 49);
            materialIDLabel.Name = "materialIDLabel";
            materialIDLabel.Size = new System.Drawing.Size(61, 13);
            materialIDLabel.TabIndex = 9;
            materialIDLabel.Text = "Material ID:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(27, 15);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(61, 13);
            productIDLabel.TabIndex = 11;
            productIDLabel.Text = "Product ID:";
            // 
            // productMaterialBindingSource
            // 
            this.productMaterialBindingSource.DataSource = typeof(LopushokApp.ModelEF.ProductMaterial);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(17, 111);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(158, 111);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // countTextBox
            // 
            this.countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productMaterialBindingSource, "Count", true));
            this.countTextBox.Location = new System.Drawing.Point(94, 75);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(121, 20);
            this.countTextBox.TabIndex = 8;
            // 
            // materialIDComboBox
            // 
            this.materialIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productMaterialBindingSource, "MaterialID", true));
            this.materialIDComboBox.DataSource = this.materialBindingSource;
            this.materialIDComboBox.DisplayMember = "Title";
            this.materialIDComboBox.FormattingEnabled = true;
            this.materialIDComboBox.Location = new System.Drawing.Point(94, 41);
            this.materialIDComboBox.Name = "materialIDComboBox";
            this.materialIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.materialIDComboBox.TabIndex = 10;
            this.materialIDComboBox.ValueMember = "ID";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(LopushokApp.ModelEF.Material);
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productMaterialBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(94, 8);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.productIDTextBox.TabIndex = 12;
            // 
            // materialTypeBindingSource
            // 
            this.materialTypeBindingSource.DataSource = typeof(LopushokApp.ModelEF.MaterialType);
            // 
            // AddEditMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 157);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(materialIDLabel);
            this.Controls.Add(this.materialIDComboBox);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SaveBtn);
            this.Name = "AddEditMaterialForm";
            this.Text = "Добавление/ Изменение материалов";
            this.Load += new System.EventHandler(this.AddEditMaterialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productMaterialBindingSource;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.ComboBox materialIDComboBox;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.BindingSource materialTypeBindingSource;
    }
}