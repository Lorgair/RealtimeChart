namespace RTChartDesign
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
            this.realTimeSample1 = new RTChart.RealTimeSample();
            this.SuspendLayout();
            // 
            // realTimeSample1
            // 
            this.realTimeSample1.BackColor = System.Drawing.Color.Transparent;
            this.realTimeSample1.Font = new System.Drawing.Font("Verdana", 9F);
            this.realTimeSample1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.realTimeSample1.Location = new System.Drawing.Point(0, -1);
            this.realTimeSample1.Name = "realTimeSample1";
            this.realTimeSample1.Size = new System.Drawing.Size(855, 333);
            this.realTimeSample1.TabIndex = 0;
            this.realTimeSample1.Load += new System.EventHandler(this.realTimeSample1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 324);
            this.Controls.Add(this.realTimeSample1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        //private WinFormsChartSamples.RealTimeSample realTimeSample1;
        private RTChart.RealTimeSample realTimeSample1;

    }
}

