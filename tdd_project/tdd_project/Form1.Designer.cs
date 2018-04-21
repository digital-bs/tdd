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
            this.textBoxActualCity = new System.Windows.Forms.TextBox();
            this.textBoxNewCity = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelWhoseMove = new System.Windows.Forms.Label();
            this.labelNamePlayer1 = new System.Windows.Forms.Label();
            this.labelNamePlayer2 = new System.Windows.Forms.Label();
            this.labelPointsPlayer1 = new System.Windows.Forms.Label();
            this.labelPointsPlayer2 = new System.Windows.Forms.Label();
            this.labelConsole = new System.Windows.Forms.Label();
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
            this.buttonStart.Location = new System.Drawing.Point(37, 81);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(102, 51);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStartForm
            // 
            this.buttonStartForm.Location = new System.Drawing.Point(532, 5);
            this.buttonStartForm.Name = "buttonStartForm";
            this.buttonStartForm.Size = new System.Drawing.Size(81, 33);
            this.buttonStartForm.TabIndex = 5;
            this.buttonStartForm.Text = "Заново";
            this.buttonStartForm.UseVisualStyleBackColor = true;
            this.buttonStartForm.Click += new System.EventHandler(this.buttonStartForm_Click);
            // 
            // textBoxActualCity
            // 
            this.textBoxActualCity.Location = new System.Drawing.Point(201, 83);
            this.textBoxActualCity.Name = "textBoxActualCity";
            this.textBoxActualCity.ReadOnly = true;
            this.textBoxActualCity.Size = new System.Drawing.Size(100, 22);
            this.textBoxActualCity.TabIndex = 6;
            // 
            // textBoxNewCity
            // 
            this.textBoxNewCity.Location = new System.Drawing.Point(307, 83);
            this.textBoxNewCity.Name = "textBoxNewCity";
            this.textBoxNewCity.Size = new System.Drawing.Size(100, 22);
            this.textBoxNewCity.TabIndex = 6;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(201, 132);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(206, 28);
            this.buttonEnter.TabIndex = 7;
            this.buttonEnter.Text = "Ввод";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // labelWhoseMove
            // 
            this.labelWhoseMove.AutoSize = true;
            this.labelWhoseMove.Location = new System.Drawing.Point(254, 112);
            this.labelWhoseMove.Name = "labelWhoseMove";
            this.labelWhoseMove.Size = new System.Drawing.Size(100, 17);
            this.labelWhoseMove.TabIndex = 2;
            this.labelWhoseMove.Text = "Ходит игрок 1";
            // 
            // labelNamePlayer1
            // 
            this.labelNamePlayer1.AutoSize = true;
            this.labelNamePlayer1.Location = new System.Drawing.Point(198, 41);
            this.labelNamePlayer1.Name = "labelNamePlayer1";
            this.labelNamePlayer1.Size = new System.Drawing.Size(58, 17);
            this.labelNamePlayer1.TabIndex = 3;
            this.labelNamePlayer1.Text = "Игрок 1";
            // 
            // labelNamePlayer2
            // 
            this.labelNamePlayer2.AutoSize = true;
            this.labelNamePlayer2.Location = new System.Drawing.Point(304, 41);
            this.labelNamePlayer2.Name = "labelNamePlayer2";
            this.labelNamePlayer2.Size = new System.Drawing.Size(58, 17);
            this.labelNamePlayer2.TabIndex = 3;
            this.labelNamePlayer2.Text = "Игрок 2";
            // 
            // labelPointsPlayer1
            // 
            this.labelPointsPlayer1.AutoSize = true;
            this.labelPointsPlayer1.Location = new System.Drawing.Point(198, 58);
            this.labelPointsPlayer1.Name = "labelPointsPlayer1";
            this.labelPointsPlayer1.Size = new System.Drawing.Size(61, 17);
            this.labelPointsPlayer1.TabIndex = 3;
            this.labelPointsPlayer1.Text = "Очков : ";
            // 
            // labelPointsPlayer2
            // 
            this.labelPointsPlayer2.AutoSize = true;
            this.labelPointsPlayer2.Location = new System.Drawing.Point(304, 58);
            this.labelPointsPlayer2.Name = "labelPointsPlayer2";
            this.labelPointsPlayer2.Size = new System.Drawing.Size(61, 17);
            this.labelPointsPlayer2.TabIndex = 3;
            this.labelPointsPlayer2.Text = "Очков : ";
            // 
            // labelConsole
            // 
            this.labelConsole.AutoSize = true;
            this.labelConsole.ForeColor = System.Drawing.Color.DarkRed;
            this.labelConsole.Location = new System.Drawing.Point(210, 163);
            this.labelConsole.Name = "labelConsole";
            this.labelConsole.Size = new System.Drawing.Size(0, 17);
            this.labelConsole.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 251);
            this.Controls.Add(this.labelConsole);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxNewCity);
            this.Controls.Add(this.textBoxActualCity);
            this.Controls.Add(this.buttonStartForm);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelNamePlayer2);
            this.Controls.Add(this.labelPointsPlayer2);
            this.Controls.Add(this.labelName2);
            this.Controls.Add(this.labelNamePlayer1);
            this.Controls.Add(this.labelPointsPlayer1);
            this.Controls.Add(this.labelName1);
            this.Controls.Add(this.labelWhoseMove);
            this.Controls.Add(this.labelNames);
            this.Controls.Add(this.textBoxName2);
            this.Controls.Add(this.textBoxName1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox textBoxActualCity;
        private System.Windows.Forms.TextBox textBoxNewCity;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelWhoseMove;
        private System.Windows.Forms.Label labelNamePlayer1;
        private System.Windows.Forms.Label labelNamePlayer2;
        private System.Windows.Forms.Label labelPointsPlayer1;
        private System.Windows.Forms.Label labelPointsPlayer2;
        private System.Windows.Forms.Label labelConsole;
    }
}

