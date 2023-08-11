namespace MyGameLife
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bstop = new System.Windows.Forms.Button();
            this.bstart = new System.Windows.Forms.Button();
            this.npdDensity = new System.Windows.Forms.NumericUpDown();
            this.npdResolution = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.LResolution = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bstop);
            this.splitContainer1.Panel1.Controls.Add(this.bstart);
            this.splitContainer1.Panel1.Controls.Add(this.npdDensity);
            this.splitContainer1.Panel1.Controls.Add(this.npdResolution);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.LResolution);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1646, 878);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 0;
            // 
            // bstop
            // 
            this.bstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bstop.Location = new System.Drawing.Point(13, 227);
            this.bstop.Name = "bstop";
            this.bstop.Size = new System.Drawing.Size(120, 49);
            this.bstop.TabIndex = 5;
            this.bstop.Text = "Stop";
            this.bstop.UseVisualStyleBackColor = true;
            this.bstop.Click += new System.EventHandler(this.bstop_Click);
            // 
            // bstart
            // 
            this.bstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bstart.Location = new System.Drawing.Point(13, 159);
            this.bstart.Name = "bstart";
            this.bstart.Size = new System.Drawing.Size(120, 45);
            this.bstart.TabIndex = 4;
            this.bstart.Text = "Start";
            this.bstart.UseVisualStyleBackColor = true;
            this.bstart.Click += new System.EventHandler(this.bstart_Click);
            // 
            // npdDensity
            // 
            this.npdDensity.Location = new System.Drawing.Point(13, 101);
            this.npdDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.npdDensity.Name = "npdDensity";
            this.npdDensity.Size = new System.Drawing.Size(120, 20);
            this.npdDensity.TabIndex = 3;
            this.npdDensity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // npdResolution
            // 
            this.npdResolution.Location = new System.Drawing.Point(13, 37);
            this.npdResolution.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.npdResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npdResolution.Name = "npdResolution";
            this.npdResolution.Size = new System.Drawing.Size(120, 20);
            this.npdResolution.TabIndex = 2;
            this.npdResolution.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Density";
            // 
            // LResolution
            // 
            this.LResolution.AutoSize = true;
            this.LResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LResolution.Location = new System.Drawing.Point(10, 7);
            this.LResolution.Name = "LResolution";
            this.LResolution.Size = new System.Drawing.Size(95, 20);
            this.LResolution.TabIndex = 0;
            this.LResolution.Text = "Resolution";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1431, 874);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1646, 878);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.npdDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bstop;
        private System.Windows.Forms.Button bstart;
        private System.Windows.Forms.NumericUpDown npdDensity;
        private System.Windows.Forms.NumericUpDown npdResolution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LResolution;
        private System.Windows.Forms.Timer timer1;
    }
}

