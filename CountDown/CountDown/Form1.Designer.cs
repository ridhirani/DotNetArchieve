
namespace CountDown
{
    partial class CountDown
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
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.txtResult1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.start.Location = new System.Drawing.Point(41, 118);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(90, 25);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(151, 117);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(90, 25);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // txtResult1
            // 
            this.txtResult1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtResult1.Location = new System.Drawing.Point(41, 25);
            this.txtResult1.Name = "txtResult1";
            this.txtResult1.ReadOnly = true;
            this.txtResult1.Size = new System.Drawing.Size(200, 26);
            this.txtResult1.TabIndex = 2;
            this.txtResult1.Text = "00:00:00";
            this.txtResult1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResult1.TextChanged += new System.EventHandler(this.Result1_TextChanged);
            // 
            // CountDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 230);
            this.Controls.Add(this.txtResult1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CountDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CountDown";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox txtResult1;
    }
}

