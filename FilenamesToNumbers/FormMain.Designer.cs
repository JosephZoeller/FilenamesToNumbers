namespace FilenamesToNumbers
{
    partial class FormMain
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
            this.buttonSelectFiles = new System.Windows.Forms.Button();
            this.labelBeginCount = new System.Windows.Forms.Label();
            this.numericUpDownBeginCount = new System.Windows.Forms.NumericUpDown();
            this.labelPrefix = new System.Windows.Forms.Label();
            this.textBoxPrefix = new System.Windows.Forms.TextBox();
            this.labelExampleDesc = new System.Windows.Forms.Label();
            this.labelExample = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeginCount)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSelectFiles
            // 
            this.buttonSelectFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectFiles.Location = new System.Drawing.Point(12, 163);
            this.buttonSelectFiles.Name = "buttonSelectFiles";
            this.buttonSelectFiles.Size = new System.Drawing.Size(229, 62);
            this.buttonSelectFiles.TabIndex = 0;
            this.buttonSelectFiles.Text = "Select Files To Rename...";
            this.buttonSelectFiles.UseVisualStyleBackColor = true;
            this.buttonSelectFiles.Click += new System.EventHandler(this.buttonRenameFiles_Click);
            // 
            // labelBeginCount
            // 
            this.labelBeginCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBeginCount.AutoSize = true;
            this.labelBeginCount.Location = new System.Drawing.Point(12, 9);
            this.labelBeginCount.Name = "labelBeginCount";
            this.labelBeginCount.Size = new System.Drawing.Size(100, 13);
            this.labelBeginCount.TabIndex = 1;
            this.labelBeginCount.Text = "Begin File Count At:";
            // 
            // numericUpDownBeginCount
            // 
            this.numericUpDownBeginCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownBeginCount.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownBeginCount.Location = new System.Drawing.Point(124, 7);
            this.numericUpDownBeginCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownBeginCount.Name = "numericUpDownBeginCount";
            this.numericUpDownBeginCount.Size = new System.Drawing.Size(118, 20);
            this.numericUpDownBeginCount.TabIndex = 2;
            this.numericUpDownBeginCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBeginCount.ValueChanged += new System.EventHandler(this.numericUpDownBeginCount_ValueChanged);
            // 
            // labelPrefix
            // 
            this.labelPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrefix.AutoSize = true;
            this.labelPrefix.Location = new System.Drawing.Point(12, 36);
            this.labelPrefix.Name = "labelPrefix";
            this.labelPrefix.Size = new System.Drawing.Size(106, 13);
            this.labelPrefix.TabIndex = 3;
            this.labelPrefix.Text = "Add Prefix (Optional):";
            // 
            // textBoxPrefix
            // 
            this.textBoxPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrefix.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxPrefix.Location = new System.Drawing.Point(124, 33);
            this.textBoxPrefix.Name = "textBoxPrefix";
            this.textBoxPrefix.Size = new System.Drawing.Size(118, 20);
            this.textBoxPrefix.TabIndex = 4;
            this.textBoxPrefix.TextChanged += new System.EventHandler(this.textBoxPrefix_TextChanged);
            this.textBoxPrefix.Leave += new System.EventHandler(this.textBoxPrefix_Leave);
            // 
            // labelExampleDesc
            // 
            this.labelExampleDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExampleDesc.AutoSize = true;
            this.labelExampleDesc.Location = new System.Drawing.Point(12, 79);
            this.labelExampleDesc.Name = "labelExampleDesc";
            this.labelExampleDesc.Size = new System.Drawing.Size(211, 13);
            this.labelExampleDesc.TabIndex = 5;
            this.labelExampleDesc.Text = "For example, the first file will be renamed to:";
            // 
            // labelExample
            // 
            this.labelExample.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExample.AutoSize = true;
            this.labelExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExample.ForeColor = System.Drawing.Color.Green;
            this.labelExample.Location = new System.Drawing.Point(12, 97);
            this.labelExample.Name = "labelExample";
            this.labelExample.Size = new System.Drawing.Size(35, 13);
            this.labelExample.TabIndex = 6;
            this.labelExample.Text = "1.jpg";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(253, 237);
            this.Controls.Add(this.labelExample);
            this.Controls.Add(this.labelExampleDesc);
            this.Controls.Add(this.textBoxPrefix);
            this.Controls.Add(this.labelPrefix);
            this.Controls.Add(this.numericUpDownBeginCount);
            this.Controls.Add(this.labelBeginCount);
            this.Controls.Add(this.buttonSelectFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rename Files to Numbers";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeginCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectFiles;
        private System.Windows.Forms.Label labelBeginCount;
        private System.Windows.Forms.NumericUpDown numericUpDownBeginCount;
        private System.Windows.Forms.Label labelPrefix;
        private System.Windows.Forms.TextBox textBoxPrefix;
        private System.Windows.Forms.Label labelExampleDesc;
        private System.Windows.Forms.Label labelExample;
    }
}

