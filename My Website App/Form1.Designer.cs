namespace My_Website_App
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
            this.header = new System.Windows.Forms.Label();
            this.appDescription = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fontColourBox = new System.Windows.Forms.ComboBox();
            this.bgColorBox = new System.Windows.Forms.ColorDialog();
            this.bgColourButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.DodgerBlue;
            this.header.Location = new System.Drawing.Point(0, 1);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(384, 60);
            this.header.TabIndex = 0;
            this.header.Text = "My Website App";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // appDescription
            // 
            this.appDescription.AutoSize = true;
            this.appDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appDescription.ForeColor = System.Drawing.Color.White;
            this.appDescription.Location = new System.Drawing.Point(24, 61);
            this.appDescription.Margin = new System.Windows.Forms.Padding(0);
            this.appDescription.Name = "appDescription";
            this.appDescription.Padding = new System.Windows.Forms.Padding(8);
            this.appDescription.Size = new System.Drawing.Size(339, 106);
            this.appDescription.TabIndex = 2;
            this.appDescription.Text = resources.GetString("appDescription.Text");
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(33, 233);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(133, 20);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Enter description:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(33, 191);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(130, 20);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Enter your name:";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(177, 190);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(172, 26);
            this.nameBox.TabIndex = 5;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.createButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.createButton.Location = new System.Drawing.Point(100, 507);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(191, 35);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Create!";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(37, 259);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionBox.Size = new System.Drawing.Size(312, 108);
            this.descriptionBox.TabIndex = 7;
            this.descriptionBox.TextChanged += new System.EventHandler(this.descriptionBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "font colour:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "background colour:";
            // 
            // fontColourBox
            // 
            this.fontColourBox.BackColor = System.Drawing.SystemColors.Window;
            this.fontColourBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontColourBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontColourBox.FormattingEnabled = true;
            this.fontColourBox.Location = new System.Drawing.Point(209, 395);
            this.fontColourBox.Name = "fontColourBox";
            this.fontColourBox.Size = new System.Drawing.Size(140, 24);
            this.fontColourBox.TabIndex = 12;
            this.fontColourBox.SelectedIndexChanged += new System.EventHandler(this.fontColourBox_SelectedIndexChanged);
            // 
            // bgColourButton
            // 
            this.bgColourButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bgColourButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bgColourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bgColourButton.Location = new System.Drawing.Point(209, 441);
            this.bgColourButton.Name = "bgColourButton";
            this.bgColourButton.Size = new System.Drawing.Size(33, 29);
            this.bgColourButton.TabIndex = 13;
            this.bgColourButton.UseVisualStyleBackColor = true;
            this.bgColourButton.Click += new System.EventHandler(this.bgColourButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(384, 562);
            this.Controls.Add(this.bgColourButton);
            this.Controls.Add(this.fontColourBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.appDescription);
            this.Controls.Add(this.header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Website App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label appDescription;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fontColourBox;
        private System.Windows.Forms.ColorDialog bgColorBox;
        private System.Windows.Forms.Button bgColourButton;
    }
}

