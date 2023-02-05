namespace Names
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
            this.Names = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Names
            // 
            this.Names.AutoSize = true;
            this.Names.Location = new System.Drawing.Point(12, 9);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(59, 20);
            this.Names.TabIndex = 0;
            this.Names.Text = "Names";
            this.Names.Click += new System.EventHandler(this.Names_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(138, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Name";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 20;
            this.lstNames.Location = new System.Drawing.Point(12, 27);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(120, 84);
            this.lstNames.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 124);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Names);
            this.Name = "Form1";
            this.Text = "Names";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Names;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.TextBox txtName;
    }
}

