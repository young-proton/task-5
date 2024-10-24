
namespace task_5
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
            this.button1 = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.ammount = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 157);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // previous
            // 
            this.previous.AutoSize = true;
            this.previous.Location = new System.Drawing.Point(12, 48);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(30, 24);
            this.previous.TabIndex = 1;
            this.previous.Text = "__";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(12, 131);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(257, 29);
            this.txt.TabIndex = 2;
            // 
            // ammount
            // 
            this.ammount.AutoSize = true;
            this.ammount.Location = new System.Drawing.Point(12, 90);
            this.ammount.Name = "ammount";
            this.ammount.Size = new System.Drawing.Size(30, 24);
            this.ammount.TabIndex = 3;
            this.ammount.Text = "__";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(12, 9);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(30, 24);
            this.result.TabIndex = 4;
            this.result.Text = "__";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(649, 338);
            this.Controls.Add(this.result);
            this.Controls.Add(this.ammount);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label previous;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label ammount;
        private System.Windows.Forms.Label result;
    }
}

