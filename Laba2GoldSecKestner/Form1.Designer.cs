﻿namespace golden_section
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
            this.Elbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Elbutton
            // 
            this.Elbutton.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Elbutton.Location = new System.Drawing.Point(317, 374);
            this.Elbutton.Name = "Elbutton";
            this.Elbutton.Size = new System.Drawing.Size(176, 71);
            this.Elbutton.TabIndex = 0;
            this.Elbutton.Text = "VAMOS";
            this.Elbutton.UseVisualStyleBackColor = true;
            this.Elbutton.Click += new System.EventHandler(this.Elbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.Elbutton);
            this.Font = new System.Drawing.Font("Old English Text MT", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Elbutton;
    }
}

