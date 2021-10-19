
namespace LopushokApp
{
    partial class CostChangeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddCostTxt = new System.Windows.Forms.TextBox();
            this.EditCostBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "На сколько надо изменить стоимость :";
            // 
            // AddCostTxt
            // 
            this.AddCostTxt.Location = new System.Drawing.Point(237, 40);
            this.AddCostTxt.Name = "AddCostTxt";
            this.AddCostTxt.Size = new System.Drawing.Size(120, 20);
            this.AddCostTxt.TabIndex = 1;
            this.AddCostTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddCostTxt_KeyPress);
            // 
            // EditCostBtn
            // 
            this.EditCostBtn.Location = new System.Drawing.Point(116, 100);
            this.EditCostBtn.Name = "EditCostBtn";
            this.EditCostBtn.Size = new System.Drawing.Size(75, 23);
            this.EditCostBtn.TabIndex = 2;
            this.EditCostBtn.Text = "Изменить";
            this.EditCostBtn.UseVisualStyleBackColor = true;
            this.EditCostBtn.Click += new System.EventHandler(this.EditCostBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(248, 100);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CostChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 152);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.EditCostBtn);
            this.Controls.Add(this.AddCostTxt);
            this.Controls.Add(this.label1);
            this.Name = "CostChangeForm";
            this.Text = "Изменение минимальной стоимости выбранных товаров";
            this.Load += new System.EventHandler(this.CostChangeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddCostTxt;
        private System.Windows.Forms.Button EditCostBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}