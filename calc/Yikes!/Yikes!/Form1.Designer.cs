﻿namespace Yikes_
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bplus = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.bminus = new System.Windows.Forms.Button();
            this.bmult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // bplus
            // 
            this.bplus.Location = new System.Drawing.Point(13, 98);
            this.bplus.Name = "bplus";
            this.bplus.Size = new System.Drawing.Size(75, 23);
            this.bplus.TabIndex = 2;
            this.bplus.Text = "+";
            this.bplus.UseVisualStyleBackColor = true;
            this.bplus.Click += new System.EventHandler(this.rnd_Click);
            // 
            // bdiv
            // 
            this.bdiv.Location = new System.Drawing.Point(94, 98);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(75, 23);
            this.bdiv.TabIndex = 3;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = true;
            this.bdiv.Click += new System.EventHandler(this.rnd_Click);
            // 
            // bminus
            // 
            this.bminus.Location = new System.Drawing.Point(175, 98);
            this.bminus.Name = "bminus";
            this.bminus.Size = new System.Drawing.Size(75, 23);
            this.bminus.TabIndex = 4;
            this.bminus.Text = "-";
            this.bminus.UseVisualStyleBackColor = true;
            this.bminus.Click += new System.EventHandler(this.rnd_Click);
            // 
            // bmult
            // 
            this.bmult.Location = new System.Drawing.Point(94, 127);
            this.bmult.Name = "bmult";
            this.bmult.Size = new System.Drawing.Size(75, 23);
            this.bmult.TabIndex = 5;
            this.bmult.Text = "*";
            this.bmult.UseVisualStyleBackColor = true;
            this.bmult.Click += new System.EventHandler(this.rnd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SAMPLE TEXT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bmult);
            this.Controls.Add(this.bminus);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.bplus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bplus;
        private System.Windows.Forms.Button bdiv;
        private System.Windows.Forms.Button bminus;
        private System.Windows.Forms.Button bmult;
        private System.Windows.Forms.Label label1;
    }
}

