
namespace device_controller
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.device1_img = new System.Windows.Forms.PictureBox();
            this.device2_img = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.device1_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.device2_img)).BeginInit();
            this.SuspendLayout();
            // 
            // device1_img
            // 
            this.device1_img.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.device1_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.device1_img.Image = global::device_controller.Properties.Resources.Movie_Projector;
            this.device1_img.Location = new System.Drawing.Point(44, 84);
            this.device1_img.Name = "device1_img";
            this.device1_img.Size = new System.Drawing.Size(200, 215);
            this.device1_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.device1_img.TabIndex = 0;
            this.device1_img.TabStop = false;
            // 
            // device2_img
            // 
            this.device2_img.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.device2_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.device2_img.Image = global::device_controller.Properties.Resources.Alternator;
            this.device2_img.Location = new System.Drawing.Point(378, 84);
            this.device2_img.Name = "device2_img";
            this.device2_img.Size = new System.Drawing.Size(200, 215);
            this.device2_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.device2_img.TabIndex = 1;
            this.device2_img.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Movie Projector";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alternator";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(91, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(424, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Show Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 463);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.device2_img);
            this.Controls.Add(this.device1_img);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.Text = "Device Controller";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.device1_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.device2_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox device1_img;
        private System.Windows.Forms.PictureBox device2_img;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

