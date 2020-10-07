namespace SimpleScan
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnScan = new System.Windows.Forms.Button();
            this.lstListOfScanner = new System.Windows.Forms.ListBox();
            this.lblListOfScan = new System.Windows.Forms.Label();
            this.pictureBoxReview = new System.Windows.Forms.PictureBox();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnRotateRight = new System.Windows.Forms.Button();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.lblVersionText = new System.Windows.Forms.Label();
            this.lblVersionValue = new System.Windows.Forms.Label();
            this.btnSelectArea = new System.Windows.Forms.Button();
            this.btnCrop = new System.Windows.Forms.Button();
            this.lblDimensions = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Save = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Dateiname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGetPath = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxScan = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnScan);
            this.panel1.Controls.Add(this.lstListOfScanner);
            this.panel1.Controls.Add(this.lblListOfScan);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 189);
            this.panel1.TabIndex = 0;
            // 
            // btnScan
            // 
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.Location = new System.Drawing.Point(6, 141);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(178, 35);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lstListOfScanner
            // 
            this.lstListOfScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListOfScanner.FormattingEnabled = true;
            this.lstListOfScanner.ItemHeight = 16;
            this.lstListOfScanner.Location = new System.Drawing.Point(6, 35);
            this.lstListOfScanner.Name = "lstListOfScanner";
            this.lstListOfScanner.Size = new System.Drawing.Size(178, 84);
            this.lstListOfScanner.TabIndex = 1;
            // 
            // lblListOfScan
            // 
            this.lblListOfScan.AutoSize = true;
            this.lblListOfScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfScan.Location = new System.Drawing.Point(3, 16);
            this.lblListOfScan.Name = "lblListOfScan";
            this.lblListOfScan.Size = new System.Drawing.Size(112, 16);
            this.lblListOfScan.TabIndex = 0;
            this.lblListOfScan.Text = "List Of Scanner";
            // 
            // pictureBoxReview
            // 
            this.pictureBoxReview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxReview.Location = new System.Drawing.Point(706, 12);
            this.pictureBoxReview.Name = "pictureBoxReview";
            this.pictureBoxReview.Size = new System.Drawing.Size(207, 211);
            this.pictureBoxReview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxReview.TabIndex = 2;
            this.pictureBoxReview.TabStop = false;
            // 
            // btnTake
            // 
            this.btnTake.Enabled = false;
            this.btnTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTake.Location = new System.Drawing.Point(922, 192);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(87, 31);
            this.btnTake.TabIndex = 3;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotateRight.Location = new System.Drawing.Point(212, 588);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(107, 31);
            this.btnRotateRight.TabIndex = 5;
            this.btnRotateRight.Text = "Rotate";
            this.btnRotateRight.UseVisualStyleBackColor = true;
            this.btnRotateRight.Click += new System.EventHandler(this.btnRotateLeft_Click);
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenImage.Location = new System.Drawing.Point(18, 207);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(178, 35);
            this.btnOpenImage.TabIndex = 2;
            this.btnOpenImage.Text = "Open Image";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // lblVersionText
            // 
            this.lblVersionText.AutoSize = true;
            this.lblVersionText.Location = new System.Drawing.Point(15, 606);
            this.lblVersionText.Name = "lblVersionText";
            this.lblVersionText.Size = new System.Drawing.Size(45, 13);
            this.lblVersionText.TabIndex = 9;
            this.lblVersionText.Text = "Version:";
            // 
            // lblVersionValue
            // 
            this.lblVersionValue.AutoSize = true;
            this.lblVersionValue.Location = new System.Drawing.Point(67, 606);
            this.lblVersionValue.Name = "lblVersionValue";
            this.lblVersionValue.Size = new System.Drawing.Size(31, 13);
            this.lblVersionValue.TabIndex = 10;
            this.lblVersionValue.Text = "0.0.0";
            // 
            // btnSelectArea
            // 
            this.btnSelectArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectArea.Location = new System.Drawing.Point(526, 588);
            this.btnSelectArea.Name = "btnSelectArea";
            this.btnSelectArea.Size = new System.Drawing.Size(107, 31);
            this.btnSelectArea.TabIndex = 11;
            this.btnSelectArea.Text = "Select Area";
            this.btnSelectArea.UseVisualStyleBackColor = true;
            this.btnSelectArea.Click += new System.EventHandler(this.btnSelectArea_Click);
            // 
            // btnCrop
            // 
            this.btnCrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrop.Location = new System.Drawing.Point(668, 192);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(32, 31);
            this.btnCrop.TabIndex = 12;
            this.btnCrop.Text = "+";
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // lblDimensions
            // 
            this.lblDimensions.AutoSize = true;
            this.lblDimensions.Location = new System.Drawing.Point(919, 175);
            this.lblDimensions.Name = "lblDimensions";
            this.lblDimensions.Size = new System.Drawing.Size(61, 13);
            this.lblDimensions.TabIndex = 13;
            this.lblDimensions.Text = "Dimensions";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Save,
            this.Column1,
            this.Dateiname});
            this.dataGridView1.Location = new System.Drawing.Point(668, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(341, 353);
            this.dataGridView1.TabIndex = 14;
            // 
            // Save
            // 
            this.Save.FillWeight = 25F;
            this.Save.HeaderText = "Save";
            this.Save.Name = "Save";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Picture";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Dateiname
            // 
            this.Dateiname.HeaderText = "Dateiname";
            this.Dateiname.Name = "Dateiname";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(922, 588);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 31);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGetPath
            // 
            this.btnGetPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPath.Location = new System.Drawing.Point(668, 589);
            this.btnGetPath.Name = "btnGetPath";
            this.btnGetPath.Size = new System.Drawing.Size(59, 30);
            this.btnGetPath.TabIndex = 18;
            this.btnGetPath.Text = "Path:";
            this.btnGetPath.UseVisualStyleBackColor = true;
            this.btnGetPath.Click += new System.EventHandler(this.btnGetPath_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(733, 599);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(29, 13);
            this.lblPath.TabIndex = 19;
            this.lblPath.Text = "Path";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBoxScan);
            this.panel2.Location = new System.Drawing.Point(212, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 570);
            this.panel2.TabIndex = 20;
            // 
            // pictureBoxScan
            // 
            this.pictureBoxScan.Location = new System.Drawing.Point(3, 26);
            this.pictureBoxScan.Name = "pictureBoxScan";
            this.pictureBoxScan.Size = new System.Drawing.Size(355, 490);
            this.pictureBoxScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxScan.TabIndex = 0;
            this.pictureBoxScan.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(325, 588);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(195, 45);
            this.trackBar1.TabIndex = 21;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 634);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnGetPath);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRotateRight);
            this.Controls.Add(this.lblDimensions);
            this.Controls.Add(this.btnCrop);
            this.Controls.Add(this.btnSelectArea);
            this.Controls.Add(this.lblVersionValue);
            this.Controls.Add(this.lblVersionText);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.pictureBoxReview);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JaHobi Picture Scan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstListOfScanner;
        private System.Windows.Forms.Label lblListOfScan;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.PictureBox pictureBoxReview;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnRotateRight;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Label lblVersionText;
        private System.Windows.Forms.Label lblVersionValue;
        private System.Windows.Forms.Button btnSelectArea;
        private System.Windows.Forms.Button btnCrop;
        private System.Windows.Forms.Label lblDimensions;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Save;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dateiname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGetPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxScan;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

