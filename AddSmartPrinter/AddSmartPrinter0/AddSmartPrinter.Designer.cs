namespace AddSmartPrinter0
{
    partial class AddSmartPrinter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSmartPrinter));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.location_box = new System.Windows.Forms.ComboBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.instructionsBox = new System.Windows.Forms.TextBox();
            this.ptrNotFound_link = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(148, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Printer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // location_box
            // 
            this.location_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location_box.FormattingEnabled = true;
            this.location_box.Location = new System.Drawing.Point(148, 165);
            this.location_box.Name = "location_box";
            this.location_box.Size = new System.Drawing.Size(155, 21);
            this.location_box.TabIndex = 2;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(399, 57);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // instructionsBox
            // 
            this.instructionsBox.BackColor = System.Drawing.SystemColors.Window;
            this.instructionsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructionsBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsBox.Location = new System.Drawing.Point(12, 75);
            this.instructionsBox.Multiline = true;
            this.instructionsBox.Name = "instructionsBox";
            this.instructionsBox.ReadOnly = true;
            this.instructionsBox.Size = new System.Drawing.Size(399, 84);
            this.instructionsBox.TabIndex = 4;
            this.instructionsBox.Text = resources.GetString("instructionsBox.Text");
            this.instructionsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.instructionsBox.WordWrap = false;
            this.instructionsBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ptrNotFound_link
            // 
            this.ptrNotFound_link.AutoSize = true;
            this.ptrNotFound_link.Location = new System.Drawing.Point(134, 239);
            this.ptrNotFound_link.Name = "ptrNotFound_link";
            this.ptrNotFound_link.Size = new System.Drawing.Size(178, 13);
            this.ptrNotFound_link.TabIndex = 5;
            this.ptrNotFound_link.TabStop = true;
            this.ptrNotFound_link.Text = "Locaiton for my printer was not listed";
            this.ptrNotFound_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ptrNotFound_link_LinkClicked);
            // 
            // AddSmartPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(423, 261);
            this.Controls.Add(this.ptrNotFound_link);
            this.Controls.Add(this.instructionsBox);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.location_box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "AddSmartPrinter";
            this.ShowIcon = false;
            this.Text = "Add a branch printer";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox location_box;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox instructionsBox;
        private System.Windows.Forms.LinkLabel ptrNotFound_link;
    }
}

