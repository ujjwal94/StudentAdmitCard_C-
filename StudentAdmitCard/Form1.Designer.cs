namespace StudentAdmitCard
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
            this.searchTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.schoolName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.addressLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Address = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.rollnumberLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RollNumber = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nameLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.classLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Class = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.image = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderColor = System.Drawing.Color.SeaGreen;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(79, 46);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(459, 45);
            this.searchTextBox.TabIndex = 0;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "SEARCH ";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 60D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(544, 46);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(134, 48);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "SEARCH ";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.schoolName);
            this.bunifuGradientPanel1.Controls.Add(this.addressLabel);
            this.bunifuGradientPanel1.Controls.Add(this.Address);
            this.bunifuGradientPanel1.Controls.Add(this.rollnumberLabel);
            this.bunifuGradientPanel1.Controls.Add(this.RollNumber);
            this.bunifuGradientPanel1.Controls.Add(this.nameLabel);
            this.bunifuGradientPanel1.Controls.Add(this.classLabel);
            this.bunifuGradientPanel1.Controls.Add(this.Class);
            this.bunifuGradientPanel1.Controls.Add(this.Name);
            this.bunifuGradientPanel1.Controls.Add(this.image);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Maroon;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(79, 135);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(606, 279);
            this.bunifuGradientPanel1.TabIndex = 2;
            this.bunifuGradientPanel1.Visible = false;
            // 
            // schoolName
            // 
            this.schoolName.AutoSize = true;
            this.schoolName.BackColor = System.Drawing.Color.Transparent;
            this.schoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolName.ForeColor = System.Drawing.Color.White;
            this.schoolName.Location = new System.Drawing.Point(209, 237);
            this.schoolName.Name = "schoolName";
            this.schoolName.Size = new System.Drawing.Size(192, 25);
            this.schoolName.TabIndex = 10;
            this.schoolName.Text = "bunifuCustomLabel1";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.Color.White;
            this.addressLabel.Location = new System.Drawing.Point(125, 158);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(192, 25);
            this.addressLabel.TabIndex = 9;
            this.addressLabel.Text = "bunifuCustomLabel1";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.BackColor = System.Drawing.Color.Transparent;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.White;
            this.Address.Location = new System.Drawing.Point(34, 158);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(85, 25);
            this.Address.TabIndex = 8;
            this.Address.Text = "Address";
            // 
            // rollnumberLabel
            // 
            this.rollnumberLabel.AutoSize = true;
            this.rollnumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.rollnumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollnumberLabel.ForeColor = System.Drawing.Color.White;
            this.rollnumberLabel.Location = new System.Drawing.Point(295, 103);
            this.rollnumberLabel.Name = "rollnumberLabel";
            this.rollnumberLabel.Size = new System.Drawing.Size(192, 25);
            this.rollnumberLabel.TabIndex = 7;
            this.rollnumberLabel.Text = "bunifuCustomLabel1";
            // 
            // RollNumber
            // 
            this.RollNumber.AutoSize = true;
            this.RollNumber.BackColor = System.Drawing.Color.Transparent;
            this.RollNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollNumber.ForeColor = System.Drawing.Color.White;
            this.RollNumber.Location = new System.Drawing.Point(161, 103);
            this.RollNumber.Name = "RollNumber";
            this.RollNumber.Size = new System.Drawing.Size(118, 25);
            this.RollNumber.TabIndex = 6;
            this.RollNumber.Text = "Roll Number";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(295, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(192, 25);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "bunifuCustomLabel1";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.BackColor = System.Drawing.Color.Transparent;
            this.classLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLabel.ForeColor = System.Drawing.Color.White;
            this.classLabel.Location = new System.Drawing.Point(295, 60);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(192, 25);
            this.classLabel.TabIndex = 4;
            this.classLabel.Text = "bunifuCustomLabel1";
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.BackColor = System.Drawing.Color.Transparent;
            this.Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.ForeColor = System.Drawing.Color.White;
            this.Class.Location = new System.Drawing.Point(161, 60);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(62, 25);
            this.Class.TabIndex = 3;
            this.Class.Text = "Class";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.BackColor = System.Drawing.Color.Transparent;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.ForeColor = System.Drawing.Color.White;
            this.Name.Location = new System.Drawing.Point(161, 19);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(69, 25);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name ";
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.Maroon;
            this.image.color = System.Drawing.Color.Maroon;
            this.image.colorActive = System.Drawing.Color.Maroon;
            this.image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.image.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.image.ForeColor = System.Drawing.Color.White;
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.ImagePosition = 20;
            this.image.ImageZoom = 50;
            this.image.LabelPosition = 41;
            this.image.LabelText = " ";
            this.image.Location = new System.Drawing.Point(24, 19);
            this.image.Margin = new System.Windows.Forms.Padding(6);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(128, 121);
            this.image.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.searchTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            //this.Name = "Form1";
            this.Text = "Form1";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuCustomTextbox searchTextBox;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel Name;
        private Bunifu.Framework.UI.BunifuTileButton image;
        private Bunifu.Framework.UI.BunifuCustomLabel schoolName;
        private Bunifu.Framework.UI.BunifuCustomLabel addressLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel Address;
        private Bunifu.Framework.UI.BunifuCustomLabel rollnumberLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel RollNumber;
        private Bunifu.Framework.UI.BunifuCustomLabel nameLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel classLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel Class;
    }
}

