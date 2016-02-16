namespace Tissue
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStartSim = new System.Windows.Forms.Button();
            this.pbTransferF = new System.Windows.Forms.PictureBox();
            this.btnSaveStart = new System.Windows.Forms.Button();
            this.btnQuickSave = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnStepSim = new System.Windows.Forms.Button();
            this.pbThresFun = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTHMax = new System.Windows.Forms.Label();
            this.lblTHMin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbBCType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTransferF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThresFun)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(349, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStartSim
            // 
            this.btnStartSim.Location = new System.Drawing.Point(79, 72);
            this.btnStartSim.Name = "btnStartSim";
            this.btnStartSim.Size = new System.Drawing.Size(62, 22);
            this.btnStartSim.TabIndex = 1;
            this.btnStartSim.Text = "Start Sim";
            this.btnStartSim.UseVisualStyleBackColor = true;
            this.btnStartSim.Click += new System.EventHandler(this.btnStartSim_Click);
            // 
            // pbTransferF
            // 
            this.pbTransferF.Location = new System.Drawing.Point(9, 19);
            this.pbTransferF.Name = "pbTransferF";
            this.pbTransferF.Size = new System.Drawing.Size(31, 31);
            this.pbTransferF.TabIndex = 2;
            this.pbTransferF.TabStop = false;
            this.pbTransferF.Click += new System.EventHandler(this.pbTransferF_Click);
            // 
            // btnSaveStart
            // 
            this.btnSaveStart.Location = new System.Drawing.Point(12, 12);
            this.btnSaveStart.Name = "btnSaveStart";
            this.btnSaveStart.Size = new System.Drawing.Size(81, 20);
            this.btnSaveStart.TabIndex = 3;
            this.btnSaveStart.Text = "Save to File";
            this.btnSaveStart.UseVisualStyleBackColor = true;
            this.btnSaveStart.Click += new System.EventHandler(this.btnSaveStart_Click);
            // 
            // btnQuickSave
            // 
            this.btnQuickSave.Location = new System.Drawing.Point(79, 125);
            this.btnQuickSave.Name = "btnQuickSave";
            this.btnQuickSave.Size = new System.Drawing.Size(62, 22);
            this.btnQuickSave.TabIndex = 4;
            this.btnQuickSave.Text = "Save";
            this.btnQuickSave.UseVisualStyleBackColor = true;
            this.btnQuickSave.Click += new System.EventHandler(this.btnQuickSave_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(79, 153);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(62, 22);
            this.btnRestore.TabIndex = 4;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(12, 38);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(81, 20);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnStepSim
            // 
            this.btnStepSim.Location = new System.Drawing.Point(79, 97);
            this.btnStepSim.Name = "btnStepSim";
            this.btnStepSim.Size = new System.Drawing.Size(62, 22);
            this.btnStepSim.TabIndex = 1;
            this.btnStepSim.Text = "Step Sim";
            this.btnStepSim.UseVisualStyleBackColor = true;
            this.btnStepSim.Click += new System.EventHandler(this.btnStepSim_Click);
            // 
            // pbThresFun
            // 
            this.pbThresFun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbThresFun.Location = new System.Drawing.Point(6, 75);
            this.pbThresFun.Name = "pbThresFun";
            this.pbThresFun.Size = new System.Drawing.Size(200, 10);
            this.pbThresFun.TabIndex = 5;
            this.pbThresFun.TabStop = false;
            this.pbThresFun.Click += new System.EventHandler(this.pbThresFun_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTHMax);
            this.groupBox1.Controls.Add(this.lblTHMin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbTransferF);
            this.groupBox1.Controls.Add(this.pbThresFun);
            this.groupBox1.Location = new System.Drawing.Point(12, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 136);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transfer Function";
            // 
            // lblTHMax
            // 
            this.lblTHMax.AutoSize = true;
            this.lblTHMax.Location = new System.Drawing.Point(180, 108);
            this.lblTHMax.Name = "lblTHMax";
            this.lblTHMax.Size = new System.Drawing.Size(26, 13);
            this.lblTHMax.TabIndex = 8;
            this.lblTHMax.Text = "max";
            // 
            // lblTHMin
            // 
            this.lblTHMin.AutoSize = true;
            this.lblTHMin.Location = new System.Drawing.Point(3, 108);
            this.lblTHMin.Name = "lblTHMin";
            this.lblTHMin.Size = new System.Drawing.Size(23, 13);
            this.lblTHMin.TabIndex = 7;
            this.lblTHMin.Text = "min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thresholds";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(147, 72);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbBCType);
            this.groupBox2.Location = new System.Drawing.Point(18, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 255);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Boundary Condition";
            // 
            // cbBCType
            // 
            this.cbBCType.FormattingEnabled = true;
            this.cbBCType.Location = new System.Drawing.Point(6, 39);
            this.cbBCType.Name = "cbBCType";
            this.cbBCType.Size = new System.Drawing.Size(121, 21);
            this.cbBCType.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BC Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 696);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnQuickSave);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnSaveStart);
            this.Controls.Add(this.btnStepSim);
            this.Controls.Add(this.btnStartSim);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTransferF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThresFun)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStartSim;
        private System.Windows.Forms.PictureBox pbTransferF;
        private System.Windows.Forms.Button btnSaveStart;
        private System.Windows.Forms.Button btnQuickSave;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnStepSim;
        private System.Windows.Forms.PictureBox pbThresFun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTHMax;
        private System.Windows.Forms.Label lblTHMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBCType;
    }
}

