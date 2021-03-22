
namespace Lab_3_Exercise_2_TestLіst
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.memberLіst = new System.Windows.Forms.CheckedListBox();
            this.peopleLіst = new System.Windows.Forms.ComboBox();
            this.button1_NamebuttonAdd = new System.Windows.Forms.Button();
            this.button2_NamebuttonDelete = new System.Windows.Forms.Button();
            this.button3_NamebuttonSort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.memberLіst);
            this.groupBox1.Location = new System.Drawing.Point(113, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список учасників";
            // 
            // memberLіst
            // 
            this.memberLіst.FormattingEnabled = true;
            this.memberLіst.Location = new System.Drawing.Point(0, 19);
            this.memberLіst.Name = "memberLіst";
            this.memberLіst.Size = new System.Drawing.Size(124, 94);
            this.memberLіst.TabIndex = 0;
            // 
            // peopleLіst
            // 
            this.peopleLіst.FormattingEnabled = true;
            this.peopleLіst.Items.AddRange(new object[] {
            "Пупкін В. С.",
            "Бобкін Б. Б.",
            "Бібкін В. В."});
            this.peopleLіst.Location = new System.Drawing.Point(113, 150);
            this.peopleLіst.Name = "peopleLіst";
            this.peopleLіst.Size = new System.Drawing.Size(121, 21);
            this.peopleLіst.TabIndex = 1;
            // 
            // button1_NamebuttonAdd
            // 
            this.button1_NamebuttonAdd.Location = new System.Drawing.Point(61, 196);
            this.button1_NamebuttonAdd.Name = "button1_NamebuttonAdd";
            this.button1_NamebuttonAdd.Size = new System.Drawing.Size(75, 23);
            this.button1_NamebuttonAdd.TabIndex = 2;
            this.button1_NamebuttonAdd.Text = "Додати";
            this.button1_NamebuttonAdd.UseVisualStyleBackColor = true;
            this.button1_NamebuttonAdd.Click += new System.EventHandler(this.button1_NamebuttonAdd_Click);
            // 
            // button2_NamebuttonDelete
            // 
            this.button2_NamebuttonDelete.Location = new System.Drawing.Point(142, 196);
            this.button2_NamebuttonDelete.Name = "button2_NamebuttonDelete";
            this.button2_NamebuttonDelete.Size = new System.Drawing.Size(75, 23);
            this.button2_NamebuttonDelete.TabIndex = 3;
            this.button2_NamebuttonDelete.Text = "Видалити";
            this.button2_NamebuttonDelete.UseVisualStyleBackColor = true;
            this.button2_NamebuttonDelete.Click += new System.EventHandler(this.button2_NamebuttonDelete_Click);
            // 
            // button3_NamebuttonSort
            // 
            this.button3_NamebuttonSort.Location = new System.Drawing.Point(223, 196);
            this.button3_NamebuttonSort.Name = "button3_NamebuttonSort";
            this.button3_NamebuttonSort.Size = new System.Drawing.Size(75, 23);
            this.button3_NamebuttonSort.TabIndex = 4;
            this.button3_NamebuttonSort.Text = "Сортувати";
            this.button3_NamebuttonSort.UseVisualStyleBackColor = true;
            this.button3_NamebuttonSort.Click += new System.EventHandler(this.button3_NamebuttonSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 267);
            this.Controls.Add(this.button3_NamebuttonSort);
            this.Controls.Add(this.button2_NamebuttonDelete);
            this.Controls.Add(this.button1_NamebuttonAdd);
            this.Controls.Add(this.peopleLіst);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Робота зі списками";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox memberLіst;
        private System.Windows.Forms.ComboBox peopleLіst;
        private System.Windows.Forms.Button button1_NamebuttonAdd;
        private System.Windows.Forms.Button button2_NamebuttonDelete;
        private System.Windows.Forms.Button button3_NamebuttonSort;
    }
}

