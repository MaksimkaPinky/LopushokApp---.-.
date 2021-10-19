
namespace LopushokApp
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LeftBtn = new System.Windows.Forms.Button();
            this.RightBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SortCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.DownCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FiltrCombo = new System.Windows.Forms.ComboBox();
            this.RangeLbl = new System.Windows.Forms.Label();
            this.CostChangeBtn = new System.Windows.Forms.Button();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(702, 438);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // LeftBtn
            // 
            this.LeftBtn.Enabled = false;
            this.LeftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftBtn.Location = new System.Drawing.Point(509, 495);
            this.LeftBtn.Name = "LeftBtn";
            this.LeftBtn.Size = new System.Drawing.Size(23, 40);
            this.LeftBtn.TabIndex = 2;
            this.LeftBtn.Text = "<";
            this.LeftBtn.UseVisualStyleBackColor = true;
            this.LeftBtn.Click += new System.EventHandler(this.LeftBtn_Click);
            // 
            // RightBtn
            // 
            this.RightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightBtn.Location = new System.Drawing.Point(681, 495);
            this.RightBtn.Name = "RightBtn";
            this.RightBtn.Size = new System.Drawing.Size(23, 40);
            this.RightBtn.TabIndex = 2;
            this.RightBtn.Text = ">";
            this.RightBtn.UseVisualStyleBackColor = true;
            this.RightBtn.Click += new System.EventHandler(this.RightBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сортировка";
            // 
            // SortCombo
            // 
            this.SortCombo.FormattingEnabled = true;
            this.SortCombo.Items.AddRange(new object[] {
            "Без сортировки",
            "Наименование",
            "Номер цеха",
            "Мин.стоимость"});
            this.SortCombo.Location = new System.Drawing.Point(16, 21);
            this.SortCombo.Name = "SortCombo";
            this.SortCombo.Size = new System.Drawing.Size(138, 21);
            this.SortCombo.TabIndex = 4;
            this.SortCombo.SelectedIndexChanged += new System.EventHandler(this.SortCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поиск";
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(262, 21);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(139, 20);
            this.SearchTxt.TabIndex = 5;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // DownCheck
            // 
            this.DownCheck.AutoSize = true;
            this.DownCheck.Location = new System.Drawing.Point(162, 24);
            this.DownCheck.Name = "DownCheck";
            this.DownCheck.Size = new System.Drawing.Size(75, 17);
            this.DownCheck.TabIndex = 6;
            this.DownCheck.Text = "убывание";
            this.DownCheck.UseVisualStyleBackColor = true;
            this.DownCheck.CheckedChanged += new System.EventHandler(this.DownCheck_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Фильтрация";
            // 
            // FiltrCombo
            // 
            this.FiltrCombo.FormattingEnabled = true;
            this.FiltrCombo.Items.AddRange(new object[] {
            "Все типы"});
            this.FiltrCombo.Location = new System.Drawing.Point(449, 21);
            this.FiltrCombo.Name = "FiltrCombo";
            this.FiltrCombo.Size = new System.Drawing.Size(157, 21);
            this.FiltrCombo.TabIndex = 4;
            this.FiltrCombo.SelectedIndexChanged += new System.EventHandler(this.FiltrCombo_SelectedIndexChanged);
            // 
            // RangeLbl
            // 
            this.RangeLbl.AutoSize = true;
            this.RangeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RangeLbl.Location = new System.Drawing.Point(190, 495);
            this.RangeLbl.Name = "RangeLbl";
            this.RangeLbl.Size = new System.Drawing.Size(229, 17);
            this.RangeLbl.TabIndex = 7;
            this.RangeLbl.Text = "Товары с ....  по .... (из всего ..... )";
            // 
            // CostChangeBtn
            // 
            this.CostChangeBtn.Location = new System.Drawing.Point(12, 495);
            this.CostChangeBtn.Name = "CostChangeBtn";
            this.CostChangeBtn.Size = new System.Drawing.Size(152, 23);
            this.CostChangeBtn.TabIndex = 8;
            this.CostChangeBtn.Text = "Изменить стоимость на ...";
            this.CostChangeBtn.UseVisualStyleBackColor = true;
            this.CostChangeBtn.Visible = false;
            this.CostChangeBtn.Click += new System.EventHandler(this.CostChangeBtn_Click);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(12, 529);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(152, 23);
            this.AddProductBtn.TabIndex = 9;
            this.AddProductBtn.Text = "Добавить товар";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(538, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(564, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(595, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 40);
            this.button3.TabIndex = 10;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(624, 495);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 40);
            this.button4.TabIndex = 10;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(653, 495);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 40);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 560);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.CostChangeBtn);
            this.Controls.Add(this.RangeLbl);
            this.Controls.Add(this.DownCheck);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.FiltrCombo);
            this.Controls.Add(this.SortCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RightBtn);
            this.Controls.Add(this.LeftBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Информационная система \"Лопушок\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button LeftBtn;
        private System.Windows.Forms.Button RightBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SortCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.CheckBox DownCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FiltrCombo;
        private System.Windows.Forms.Label RangeLbl;
        private System.Windows.Forms.Button CostChangeBtn;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

