namespace Golf_Sim_CYOA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputLabel = new System.Windows.Forms.Label();
            this.option01 = new System.Windows.Forms.Button();
            this.option02 = new System.Windows.Forms.Button();
            this.option03 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(593, 85);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(436, 458);
            this.outputLabel.TabIndex = 0;
            // 
            // option01
            // 
            this.option01.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option01.Location = new System.Drawing.Point(16, 314);
            this.option01.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.option01.Name = "option01";
            this.option01.Size = new System.Drawing.Size(565, 70);
            this.option01.TabIndex = 1;
            this.option01.Text = "START NEW GAME";
            this.option01.UseVisualStyleBackColor = true;
            this.option01.Click += new System.EventHandler(this.option01_Click);
            // 
            // option02
            // 
            this.option02.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option02.Location = new System.Drawing.Point(16, 391);
            this.option02.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.option02.Name = "option02";
            this.option02.Size = new System.Drawing.Size(565, 70);
            this.option02.TabIndex = 2;
            this.option02.Text = "LOAD SAVE GAME";
            this.option02.UseVisualStyleBackColor = true;
            this.option02.Visible = false;
            this.option02.Click += new System.EventHandler(this.option02_Click);
            // 
            // option03
            // 
            this.option03.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option03.Location = new System.Drawing.Point(16, 469);
            this.option03.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.option03.Name = "option03";
            this.option03.Size = new System.Drawing.Size(565, 70);
            this.option03.TabIndex = 3;
            this.option03.UseVisualStyleBackColor = true;
            this.option03.Visible = false;
            this.option03.Click += new System.EventHandler(this.option03_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(593, 26);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(436, 41);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("OCR A Extended", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(16, 11);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1013, 203);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "GOLFING SIM";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(75, 26);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(440, 271);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.option03);
            this.Controls.Add(this.option02);
            this.Controls.Add(this.option01);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Golfing Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button option01;
        private System.Windows.Forms.Button option02;
        private System.Windows.Forms.Button option03;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

