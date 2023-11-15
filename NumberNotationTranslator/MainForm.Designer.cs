namespace NumberNotationTranslator
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
            this.textBoxInputNumber = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNotationFrom = new System.Windows.Forms.TextBox();
            this.textBoxNotationTo = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInputNumber
            // 
            this.textBoxInputNumber.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInputNumber.Location = new System.Drawing.Point(33, 75);
            this.textBoxInputNumber.Name = "textBoxInputNumber";
            this.textBoxInputNumber.Size = new System.Drawing.Size(482, 50);
            this.textBoxInputNumber.TabIndex = 0;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.Location = new System.Drawing.Point(548, 272);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(122, 50);
            this.SubmitBtn.TabIndex = 3;
            this.SubmitBtn.Text = "Вычислить";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите число";
            // 
            // textBoxNotationFrom
            // 
            this.textBoxNotationFrom.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNotationFrom.Location = new System.Drawing.Point(548, 75);
            this.textBoxNotationFrom.Name = "textBoxNotationFrom";
            this.textBoxNotationFrom.Size = new System.Drawing.Size(122, 50);
            this.textBoxNotationFrom.TabIndex = 8;
            // 
            // textBoxNotationTo
            // 
            this.textBoxNotationTo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNotationTo.Location = new System.Drawing.Point(548, 175);
            this.textBoxNotationTo.Name = "textBoxNotationTo";
            this.textBoxNotationTo.Size = new System.Drawing.Size(122, 50);
            this.textBoxNotationTo.TabIndex = 9;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(33, 272);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(482, 50);
            this.textBoxResult.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Результат";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(542, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Его система счисления";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(542, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Перевести в";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 408);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxNotationTo);
            this.Controls.Add(this.textBoxNotationFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.textBoxInputNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Перевод чисел из одной системаы счисления в другую";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputNumber;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNotationFrom;
        private System.Windows.Forms.TextBox textBoxNotationTo;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

