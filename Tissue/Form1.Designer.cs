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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTransferF)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(234, 72);
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
            this.btnStartSim.Location = new System.Drawing.Point(165, 72);
            this.btnStartSim.Name = "btnStartSim";
            this.btnStartSim.Size = new System.Drawing.Size(63, 22);
            this.btnStartSim.TabIndex = 1;
            this.btnStartSim.Text = "Start Sim";
            this.btnStartSim.UseVisualStyleBackColor = true;
            this.btnStartSim.Click += new System.EventHandler(this.btnStartSim_Click);
            // 
            // pbTransferF
            // 
            this.pbTransferF.Location = new System.Drawing.Point(234, 36);
            this.pbTransferF.Name = "pbTransferF";
            this.pbTransferF.Size = new System.Drawing.Size(30, 30);
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
            this.btnQuickSave.Location = new System.Drawing.Point(165, 125);
            this.btnQuickSave.Name = "btnQuickSave";
            this.btnQuickSave.Size = new System.Drawing.Size(62, 22);
            this.btnQuickSave.TabIndex = 4;
            this.btnQuickSave.Text = "Save";
            this.btnQuickSave.UseVisualStyleBackColor = true;
            this.btnQuickSave.Click += new System.EventHandler(this.btnQuickSave_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(166, 145);
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
            this.btnStepSim.Location = new System.Drawing.Point(166, 97);
            this.btnStepSim.Name = "btnStepSim";
            this.btnStepSim.Size = new System.Drawing.Size(63, 22);
            this.btnStepSim.TabIndex = 1;
            this.btnStepSim.Text = "Step Sim";
            this.btnStepSim.UseVisualStyleBackColor = true;
            this.btnStepSim.Click += new System.EventHandler(this.btnStepSim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Branch: Integer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 696);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnQuickSave);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnSaveStart);
            this.Controls.Add(this.pbTransferF);
            this.Controls.Add(this.btnStepSim);
            this.Controls.Add(this.btnStartSim);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTransferF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
    }
}

