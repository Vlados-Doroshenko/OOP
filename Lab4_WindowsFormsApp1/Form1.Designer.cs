
namespace WindowsFormsApp1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonAddMag = new System.Windows.Forms.Button();
            this.buttonOpenMag = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(400, 251);
            this.listBox1.TabIndex = 0;
            // 
            // buttonAddMag
            // 
            this.buttonAddMag.Location = new System.Drawing.Point(12, 316);
            this.buttonAddMag.Name = "buttonAddMag";
            this.buttonAddMag.Size = new System.Drawing.Size(116, 23);
            this.buttonAddMag.TabIndex = 1;
            this.buttonAddMag.Text = "Додати магазин";
            this.buttonAddMag.UseVisualStyleBackColor = true;
            this.buttonAddMag.Click += new System.EventHandler(this.buttonAddMag_Click);
            // 
            // buttonOpenMag
            // 
            this.buttonOpenMag.Enabled = false;
            this.buttonOpenMag.Location = new System.Drawing.Point(290, 316);
            this.buttonOpenMag.Name = "buttonOpenMag";
            this.buttonOpenMag.Size = new System.Drawing.Size(123, 23);
            this.buttonOpenMag.TabIndex = 2;
            this.buttonOpenMag.Text = "Відкрити магазин";
            this.buttonOpenMag.UseVisualStyleBackColor = true;
            this.buttonOpenMag.Click += new System.EventHandler(this.buttonOpenMag_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(134, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Видалити магазин";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(425, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonOpenMag);
            this.Controls.Add(this.buttonAddMag);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonAddMag;
        private System.Windows.Forms.Button buttonOpenMag;
        private System.Windows.Forms.Button button1;
    }
}

