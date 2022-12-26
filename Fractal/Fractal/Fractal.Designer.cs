namespace Fractal
{
    partial class frmFractal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pbFractal = new System.Windows.Forms.PictureBox();
            this.txtGenerate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFractal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(722, 163);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(126, 44);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pbFractal
            // 
            this.pbFractal.BackColor = System.Drawing.Color.Transparent;
            this.pbFractal.Location = new System.Drawing.Point(0, 0);
            this.pbFractal.Name = "pbFractal";
            this.pbFractal.Size = new System.Drawing.Size(605, 605);
            this.pbFractal.TabIndex = 1;
            this.pbFractal.TabStop = false;
            // 
            // txtGenerate
            // 
            this.txtGenerate.Location = new System.Drawing.Point(722, 107);
            this.txtGenerate.Name = "txtGenerate";
            this.txtGenerate.Size = new System.Drawing.Size(125, 27);
            this.txtGenerate.TabIndex = 2;
            // 
            // frmFractal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(882, 609);
            this.Controls.Add(this.txtGenerate);
            this.Controls.Add(this.pbFractal);
            this.Controls.Add(this.btnGenerate);
            this.Name = "frmFractal";
            this.Text = "Fractal";
            ((System.ComponentModel.ISupportInitialize)(this.pbFractal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGenerate;
        private PictureBox pbFractal;
        private TextBox txtGenerate;
    }
}