namespace tdd_project
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
            this.textBoxName1 = new System.Windows.Forms.TextBox();
            this.textBoxName2 = new System.Windows.Forms.TextBox();
            this.labelNames = new System.Windows.Forms.Label();
            this.labelName1 = new System.Windows.Forms.Label();
            this.labelName2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStartForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName1
            // 
            this.textBoxName1.Location = new System.Drawing.Point(68, 25);
            this.textBoxName1.Name = "textBoxName1";
            this.textBoxName1.Size = new System.Drawing.Size(100, 22);
            this.textBoxName1.TabIndex = 0;
            // 
            // textBoxName2
            // 
            this.textBoxName2.Location = new System.Drawing.Point(68, 53);
            this.textBoxName2.Name = "textBoxName2";
            this.textBoxName2.Size = new System.Drawing.Size(100, 22);
            this.textBoxName2.TabIndex = 1;
            // 
            // labelNames
            // 
            this.labelNames.AutoSize = true;
            this.labelNames.Location = new System.Drawing.Point(88, 5);
            this.labelNames.Name = "labelNames";
            this.labelNames.Size = new System.Drawing.Size(51, 17);
            this.labelNames.TabIndex = 2;
            this.labelNames.Text = "Имена";
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.Location = new System.Drawing.Point(4, 28);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(58, 17);
            this.labelName1.TabIndex = 3;
            this.labelName1.Text = "Игрок 1";
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.Location = new System.Drawing.Point(4, 56);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(58, 17);
            this.labelName2.TabIndex = 3;
            this.labelName2.Text = "Игрок 2";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(190, 24);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(102, 51);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStartForm
            // 
            this.buttonStartForm.Location = new System.Drawing.Point(629, 12);
            this.buttonStartForm.Name = "buttonStartForm";
            this.buttonStartForm.Size = new System.Drawing.Size(81, 33);
            this.buttonStartForm.TabIndex = 5;
            this.buttonStartForm.Text = "Заново";
            this.buttonStartForm.UseVisualStyleBackColor = true;
            this.buttonStartForm.Click += new System.EventHandler(this.buttonStartForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 465);
            this.Controls.Add(this.buttonStartForm);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelName2);
            this.Controls.Add(this.labelName1);
            this.Controls.Add(this.labelNames);
            this.Controls.Add(this.textBoxName2);
            this.Controls.Add(this.textBoxName1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName1;
        private System.Windows.Forms.TextBox textBoxName2;
        private System.Windows.Forms.Label labelNames;
        private System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStartForm;
    }
}

