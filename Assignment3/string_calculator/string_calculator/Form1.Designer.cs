
namespace string_calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.reverse_btn = new System.Windows.Forms.Button();
            this.reverse_result = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.reverse_str = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pelindrome_btn = new System.Windows.Forms.Button();
            this.pelindrome_result = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pelindrome_str = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.equality_btn = new System.Windows.Forms.Button();
            this.equality_result = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.equality_str2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.equality_str1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.concat_btn = new System.Windows.Forms.Button();
            this.concat_result = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.concat_str2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.concat_str1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.reverse_btn);
            this.panel1.Controls.Add(this.reverse_result);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.reverse_str);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.pelindrome_btn);
            this.panel1.Controls.Add(this.pelindrome_result);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pelindrome_str);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.equality_btn);
            this.panel1.Controls.Add(this.equality_result);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.equality_str2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.equality_str1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.concat_btn);
            this.panel1.Controls.Add(this.concat_result);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.concat_str2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.concat_str1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(36, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 496);
            this.panel1.TabIndex = 0;
            // 
            // reverse_btn
            // 
            this.reverse_btn.Location = new System.Drawing.Point(233, 269);
            this.reverse_btn.Name = "reverse_btn";
            this.reverse_btn.Size = new System.Drawing.Size(100, 28);
            this.reverse_btn.TabIndex = 26;
            this.reverse_btn.Text = "Reverse";
            this.reverse_btn.UseVisualStyleBackColor = true;
            this.reverse_btn.Click += new System.EventHandler(this.reverse_btn_Click);
            // 
            // reverse_result
            // 
            this.reverse_result.Location = new System.Drawing.Point(351, 273);
            this.reverse_result.Multiline = true;
            this.reverse_result.Name = "reverse_result";
            this.reverse_result.Size = new System.Drawing.Size(113, 24);
            this.reverse_result.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(348, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Result";
            // 
            // reverse_str
            // 
            this.reverse_str.Location = new System.Drawing.Point(98, 273);
            this.reverse_str.Multiline = true;
            this.reverse_str.Name = "reverse_str";
            this.reverse_str.Size = new System.Drawing.Size(113, 24);
            this.reverse_str.TabIndex = 23;
            this.reverse_str.TextChanged += new System.EventHandler(this.reverse_str_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(95, 254);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "String";
            // 
            // pelindrome_btn
            // 
            this.pelindrome_btn.Location = new System.Drawing.Point(233, 206);
            this.pelindrome_btn.Name = "pelindrome_btn";
            this.pelindrome_btn.Size = new System.Drawing.Size(100, 28);
            this.pelindrome_btn.TabIndex = 21;
            this.pelindrome_btn.Text = "Is Pelindrome";
            this.pelindrome_btn.UseVisualStyleBackColor = true;
            this.pelindrome_btn.Click += new System.EventHandler(this.pelindrome_btn_Click);
            // 
            // pelindrome_result
            // 
            this.pelindrome_result.Location = new System.Drawing.Point(351, 210);
            this.pelindrome_result.Multiline = true;
            this.pelindrome_result.Name = "pelindrome_result";
            this.pelindrome_result.Size = new System.Drawing.Size(113, 24);
            this.pelindrome_result.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(348, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Result";
            // 
            // pelindrome_str
            // 
            this.pelindrome_str.Location = new System.Drawing.Point(98, 210);
            this.pelindrome_str.Multiline = true;
            this.pelindrome_str.Name = "pelindrome_str";
            this.pelindrome_str.Size = new System.Drawing.Size(113, 24);
            this.pelindrome_str.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(95, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "String";
            // 
            // equality_btn
            // 
            this.equality_btn.Location = new System.Drawing.Point(402, 139);
            this.equality_btn.Name = "equality_btn";
            this.equality_btn.Size = new System.Drawing.Size(100, 28);
            this.equality_btn.TabIndex = 16;
            this.equality_btn.Text = "Is Equal";
            this.equality_btn.UseVisualStyleBackColor = true;
            this.equality_btn.Click += new System.EventHandler(this.equality_btn_Click);
            // 
            // equality_result
            // 
            this.equality_result.Location = new System.Drawing.Point(520, 143);
            this.equality_result.Multiline = true;
            this.equality_result.Name = "equality_result";
            this.equality_result.Size = new System.Drawing.Size(113, 24);
            this.equality_result.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(517, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Result";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(229, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "+";
            // 
            // equality_str2
            // 
            this.equality_str2.Location = new System.Drawing.Point(267, 143);
            this.equality_str2.Multiline = true;
            this.equality_str2.Name = "equality_str2";
            this.equality_str2.Size = new System.Drawing.Size(113, 24);
            this.equality_str2.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(264, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "String2";
            // 
            // equality_str1
            // 
            this.equality_str1.Location = new System.Drawing.Point(97, 143);
            this.equality_str1.Multiline = true;
            this.equality_str1.Name = "equality_str1";
            this.equality_str1.Size = new System.Drawing.Size(113, 24);
            this.equality_str1.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(94, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "String1";
            // 
            // concat_btn
            // 
            this.concat_btn.Location = new System.Drawing.Point(402, 72);
            this.concat_btn.Name = "concat_btn";
            this.concat_btn.Size = new System.Drawing.Size(100, 28);
            this.concat_btn.TabIndex = 8;
            this.concat_btn.Text = "Concat";
            this.concat_btn.UseVisualStyleBackColor = true;
            this.concat_btn.Click += new System.EventHandler(this.concat_btn_Click);
            // 
            // concat_result
            // 
            this.concat_result.Location = new System.Drawing.Point(520, 76);
            this.concat_result.Multiline = true;
            this.concat_result.Name = "concat_result";
            this.concat_result.Size = new System.Drawing.Size(113, 24);
            this.concat_result.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(517, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "+";
            // 
            // concat_str2
            // 
            this.concat_str2.Location = new System.Drawing.Point(267, 76);
            this.concat_str2.Multiline = true;
            this.concat_str2.Name = "concat_str2";
            this.concat_str2.Size = new System.Drawing.Size(113, 24);
            this.concat_str2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Substring2";
            // 
            // concat_str1
            // 
            this.concat_str1.Location = new System.Drawing.Point(97, 76);
            this.concat_str1.Multiline = true;
            this.concat_str1.Name = "concat_str1";
            this.concat_str1.Size = new System.Drawing.Size(113, 24);
            this.concat_str1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Substring1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "String Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "String Calculator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reverse_btn;
        private System.Windows.Forms.TextBox reverse_result;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox reverse_str;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button pelindrome_btn;
        private System.Windows.Forms.TextBox pelindrome_result;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pelindrome_str;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button equality_btn;
        private System.Windows.Forms.TextBox equality_result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox equality_str2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox equality_str1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button concat_btn;
        private System.Windows.Forms.TextBox concat_result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox concat_str2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox concat_str1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

