namespace BouncingBalls
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
            this.ballsWidget1 = new BouncingBalls.BDraw();
            this.SuspendLayout();
            // 
            // ballsWidget1
            // 
            this.ballsWidget1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ballsWidget1.Location = new System.Drawing.Point(0, 0);
            this.ballsWidget1.Name = "ballsWidget1";
            this.ballsWidget1.Size = new System.Drawing.Size(686, 574);
            this.ballsWidget1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 574);
            this.Controls.Add(this.ballsWidget1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private BDraw ballsWidget1;
    }
}

