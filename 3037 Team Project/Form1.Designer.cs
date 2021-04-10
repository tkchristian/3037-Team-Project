
namespace _3037_Team_Project
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
            this.exit_button = new System.Windows.Forms.Button();
            this.clock_in_button = new System.Windows.Forms.Button();
            this.clock_out_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Black;
            this.exit_button.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Location = new System.Drawing.Point(886, 528);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(80, 54);
            this.exit_button.TabIndex = 0;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // clock_in_button
            // 
            this.clock_in_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clock_in_button.BackColor = System.Drawing.Color.Black;
            this.clock_in_button.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14F);
            this.clock_in_button.ForeColor = System.Drawing.Color.White;
            this.clock_in_button.Location = new System.Drawing.Point(149, 474);
            this.clock_in_button.Name = "clock_in_button";
            this.clock_in_button.Size = new System.Drawing.Size(280, 108);
            this.clock_in_button.TabIndex = 2;
            this.clock_in_button.Text = "Clock in";
            this.clock_in_button.UseVisualStyleBackColor = false;
            // 
            // clock_out_button
            // 
            this.clock_out_button.BackColor = System.Drawing.Color.Black;
            this.clock_out_button.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14F);
            this.clock_out_button.ForeColor = System.Drawing.Color.White;
            this.clock_out_button.Location = new System.Drawing.Point(549, 474);
            this.clock_out_button.Name = "clock_out_button";
            this.clock_out_button.Size = new System.Drawing.Size(280, 108);
            this.clock_out_button.TabIndex = 3;
            this.clock_out_button.Text = "Clock out";
            this.clock_out_button.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.MaximumSize = new System.Drawing.Size(305, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 133);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to Clockwork, the all-in-one employee time management program!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clock_out_button);
            this.Controls.Add(this.clock_in_button);
            this.Controls.Add(this.exit_button);
            this.Name = "Form1";
            this.Text = "Clockwork";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button clock_in_button;
        private System.Windows.Forms.Button clock_out_button;
        private System.Windows.Forms.Label label1;
    }
}

