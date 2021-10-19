
namespace LopushokApp
{
    partial class ProductUserCntrl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.TypeNameProductLbl = new System.Windows.Forms.Label();
            this.CostLbl = new System.Windows.Forms.Label();
            this.ArticulLbl = new System.Windows.Forms.Label();
            this.MaterialLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Material2Lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WorkshopLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MinCostLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Image = global::LopushokApp.Properties.Resources.picture;
            this.PictureBox.Location = new System.Drawing.Point(3, 4);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(77, 67);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // TypeNameProductLbl
            // 
            this.TypeNameProductLbl.AutoSize = true;
            this.TypeNameProductLbl.Location = new System.Drawing.Point(86, 7);
            this.TypeNameProductLbl.Name = "TypeNameProductLbl";
            this.TypeNameProductLbl.Size = new System.Drawing.Size(110, 13);
            this.TypeNameProductLbl.TabIndex = 1;
            this.TypeNameProductLbl.Text = "Тип | Наименование";
            // 
            // CostLbl
            // 
            this.CostLbl.AutoSize = true;
            this.CostLbl.Location = new System.Drawing.Point(599, 7);
            this.CostLbl.Name = "CostLbl";
            this.CostLbl.Size = new System.Drawing.Size(61, 13);
            this.CostLbl.TabIndex = 2;
            this.CostLbl.Text = "стоимость";
            // 
            // ArticulLbl
            // 
            this.ArticulLbl.AutoSize = true;
            this.ArticulLbl.Location = new System.Drawing.Point(86, 23);
            this.ArticulLbl.Name = "ArticulLbl";
            this.ArticulLbl.Size = new System.Drawing.Size(48, 13);
            this.ArticulLbl.TabIndex = 3;
            this.ArticulLbl.Text = "Артикул";
            // 
            // MaterialLbl
            // 
            this.MaterialLbl.AutoSize = true;
            this.MaterialLbl.Location = new System.Drawing.Point(86, 43);
            this.MaterialLbl.Name = "MaterialLbl";
            this.MaterialLbl.Size = new System.Drawing.Size(65, 13);
            this.MaterialLbl.TabIndex = 4;
            this.MaterialLbl.Text = "Материалы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Стоимость:";
            // 
            // Material2Lbl
            // 
            this.Material2Lbl.AutoSize = true;
            this.Material2Lbl.Location = new System.Drawing.Point(86, 56);
            this.Material2Lbl.Name = "Material2Lbl";
            this.Material2Lbl.Size = new System.Drawing.Size(16, 13);
            this.Material2Lbl.TabIndex = 4;
            this.Material2Lbl.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Цех:";
            // 
            // WorkshopLbl
            // 
            this.WorkshopLbl.AutoSize = true;
            this.WorkshopLbl.Location = new System.Drawing.Point(413, 7);
            this.WorkshopLbl.Name = "WorkshopLbl";
            this.WorkshopLbl.Size = new System.Drawing.Size(65, 13);
            this.WorkshopLbl.TabIndex = 2;
            this.WorkshopLbl.Text = "номер цеха";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Мин.стоимость:";
            // 
            // MinCostLbl
            // 
            this.MinCostLbl.AutoSize = true;
            this.MinCostLbl.Location = new System.Drawing.Point(413, 22);
            this.MinCostLbl.Name = "MinCostLbl";
            this.MinCostLbl.Size = new System.Drawing.Size(84, 13);
            this.MinCostLbl.TabIndex = 2;
            this.MinCostLbl.Text = "мин.стоимость";
            // 
            // ProductUserCntrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Material2Lbl);
            this.Controls.Add(this.MaterialLbl);
            this.Controls.Add(this.ArticulLbl);
            this.Controls.Add(this.MinCostLbl);
            this.Controls.Add(this.WorkshopLbl);
            this.Controls.Add(this.CostLbl);
            this.Controls.Add(this.TypeNameProductLbl);
            this.Controls.Add(this.PictureBox);
            this.Name = "ProductUserCntrl";
            this.Size = new System.Drawing.Size(674, 75);
            this.Load += new System.EventHandler(this.ProductUserCntrl_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductUserCntrl_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label TypeNameProductLbl;
        private System.Windows.Forms.Label CostLbl;
        private System.Windows.Forms.Label ArticulLbl;
        private System.Windows.Forms.Label MaterialLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Material2Lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label WorkshopLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MinCostLbl;
    }
}
