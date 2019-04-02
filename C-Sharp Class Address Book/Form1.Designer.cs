namespace C_Sharp_Class_Address_Book
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
            this.zipBox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.contactLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.viewButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zipBox
            // 
            this.zipBox.Location = new System.Drawing.Point(421, 246);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(75, 20);
            this.zipBox.TabIndex = 44;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(376, 249);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(22, 13);
            this.zipLabel.TabIndex = 43;
            this.zipLabel.Text = "Zip";
            // 
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(268, 246);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(75, 20);
            this.stateBox.TabIndex = 42;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(221, 249);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(32, 13);
            this.stateLabel.TabIndex = 41;
            this.stateLabel.Text = "State";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(456, 314);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 38;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(1, 53);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(44, 13);
            this.contactLabel.TabIndex = 37;
            this.contactLabel.Text = "Contact";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(1, 177);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 36;
            this.addressLabel.Text = "Address";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(71, 246);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(125, 20);
            this.cityBox.TabIndex = 35;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(0, 249);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 34;
            this.cityLabel.Text = "City";
            // 
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(71, 206);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(250, 20);
            this.streetBox.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Street";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(189, 314);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 28;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(71, 129);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(250, 20);
            this.phoneBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Phone";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(71, 314);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 25;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(71, 90);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(250, 20);
            this.nameBox.TabIndex = 24;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(0, 93);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 23;
            this.nameLabel.Text = "Name";
            // 
            // viewButt
            // 
            this.viewButt.Location = new System.Drawing.Point(323, 314);
            this.viewButt.Name = "viewButt";
            this.viewButt.Size = new System.Drawing.Size(75, 23);
            this.viewButt.TabIndex = 45;
            this.viewButt.Text = "View";
            this.viewButt.UseVisualStyleBackColor = true;
            this.viewButt.Click += new System.EventHandler(this.viewButt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.viewButt);
            this.Controls.Add(this.zipBox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.streetBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button viewButt;
    }
}

