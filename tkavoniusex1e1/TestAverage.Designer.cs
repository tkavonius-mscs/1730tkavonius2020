﻿namespace tkavoniusex1e1
{
    partial class TestAverage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTest1 = new System.Windows.Forms.TextBox();
            this.txtTest2 = new System.Windows.Forms.TextBox();
            this.txtTest3 = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Test 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Test 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Test 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Average:";
            // 
            // txtTest1
            // 
            this.txtTest1.Location = new System.Drawing.Point(80, 42);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(39, 20);
            this.txtTest1.TabIndex = 0;
            this.txtTest1.Text = "0";
            this.txtTest1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTest2
            // 
            this.txtTest2.Location = new System.Drawing.Point(80, 76);
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(39, 20);
            this.txtTest2.TabIndex = 1;
            this.txtTest2.Text = "0";
            this.txtTest2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTest3
            // 
            this.txtTest3.Location = new System.Drawing.Point(80, 107);
            this.txtTest3.Name = "txtTest3";
            this.txtTest3.Size = new System.Drawing.Size(39, 20);
            this.txtTest3.TabIndex = 2;
            this.txtTest3.Text = "0";
            this.txtTest3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(80, 174);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(39, 20);
            this.txtAverage.TabIndex = 3;
            this.txtAverage.TabStop = false;
            this.txtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "C&lear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Ex&it";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TestAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 205);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtTest3);
            this.Controls.Add(this.txtTest2);
            this.Controls.Add(this.txtTest1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TestAverage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTest1;
        private System.Windows.Forms.TextBox txtTest2;
        private System.Windows.Forms.TextBox txtTest3;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

