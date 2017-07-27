namespace Giyotin
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
            this.components = new System.ComponentModel.Container();
            this.btnkisi = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timersil = new System.Windows.Forms.Timer(this.components);
            this.timersonkisi = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnkisi
            // 
            this.btnkisi.Location = new System.Drawing.Point(299, 268);
            this.btnkisi.Name = "btnkisi";
            this.btnkisi.Size = new System.Drawing.Size(142, 72);
            this.btnkisi.TabIndex = 0;
            this.btnkisi.Text = "ŞANSLI KİŞİ KİM?";
            this.btnkisi.UseVisualStyleBackColor = true;
            this.btnkisi.Click += new System.EventHandler(this.btnkisi_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timersil
            // 
            this.timersil.Tick += new System.EventHandler(this.timersil_Tick);
            // 
            // timersonkisi
            // 
            this.timersonkisi.Tick += new System.EventHandler(this.timersonkisi_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 623);
            this.Controls.Add(this.btnkisi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkisi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timersil;
        private System.Windows.Forms.Timer timersonkisi;
    }
}

