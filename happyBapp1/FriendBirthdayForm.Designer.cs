namespace happyBapp1
{
    partial class FriendBirthdayForm
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
            this.FnametxtBox = new System.Windows.Forms.TextBox();
            this.Fnamelabel = new System.Windows.Forms.Label();
            this.Lnamelabel = new System.Windows.Forms.Label();
            this.LnametxtBox = new System.Windows.Forms.TextBox();
            this.Bdatelabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Savebutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailtextBox1 = new System.Windows.Forms.TextBox();
            this.TimeZoneBox1 = new System.Windows.Forms.ComboBox();
            this.Statelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FnametxtBox
            // 
            this.FnametxtBox.Location = new System.Drawing.Point(107, 7);
            this.FnametxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.FnametxtBox.Name = "FnametxtBox";
            this.FnametxtBox.Size = new System.Drawing.Size(132, 22);
            this.FnametxtBox.TabIndex = 0;
            // 
            // Fnamelabel
            // 
            this.Fnamelabel.AutoSize = true;
            this.Fnamelabel.Location = new System.Drawing.Point(5, 7);
            this.Fnamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fnamelabel.Name = "Fnamelabel";
            this.Fnamelabel.Size = new System.Drawing.Size(76, 17);
            this.Fnamelabel.TabIndex = 1;
            this.Fnamelabel.Text = "First Name";
            // 
            // Lnamelabel
            // 
            this.Lnamelabel.AutoSize = true;
            this.Lnamelabel.Location = new System.Drawing.Point(5, 38);
            this.Lnamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lnamelabel.Name = "Lnamelabel";
            this.Lnamelabel.Size = new System.Drawing.Size(76, 17);
            this.Lnamelabel.TabIndex = 3;
            this.Lnamelabel.Text = "Last Name";
            // 
            // LnametxtBox
            // 
            this.LnametxtBox.Location = new System.Drawing.Point(107, 38);
            this.LnametxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.LnametxtBox.Name = "LnametxtBox";
            this.LnametxtBox.Size = new System.Drawing.Size(132, 22);
            this.LnametxtBox.TabIndex = 2;
            // 
            // Bdatelabel
            // 
            this.Bdatelabel.AutoSize = true;
            this.Bdatelabel.Location = new System.Drawing.Point(5, 68);
            this.Bdatelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bdatelabel.Name = "Bdatelabel";
            this.Bdatelabel.Size = new System.Drawing.Size(65, 17);
            this.Bdatelabel.TabIndex = 5;
            this.Bdatelabel.Text = "Birthdate";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 68);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2016, 11, 30, 0, 0, 0, 0);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(531, 112);
            this.Savebutton.Margin = new System.Windows.Forms.Padding(4);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(109, 54);
            this.Savebutton.TabIndex = 7;
            this.Savebutton.Text = "SAVE!";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 212);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(657, 311);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(5, 98);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailLabel.TabIndex = 9;
            this.EmailLabel.Text = "Email";
            // 
            // EmailtextBox1
            // 
            this.EmailtextBox1.Location = new System.Drawing.Point(107, 98);
            this.EmailtextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.EmailtextBox1.Name = "EmailtextBox1";
            this.EmailtextBox1.Size = new System.Drawing.Size(260, 22);
            this.EmailtextBox1.TabIndex = 4;
            // 
            // TimeZoneBox1
            // 
            this.TimeZoneBox1.FormattingEnabled = true;
            this.TimeZoneBox1.Items.AddRange(new object[] {
            "Atlantic Standard Time (AST)",
            "Eastern Standard Time (EST)",
            "Central Standard Time (CST)",
            "Mountain Standard Time (MST)",
            "Pacific Standard Time (PST)"});
            this.TimeZoneBox1.Location = new System.Drawing.Point(107, 128);
            this.TimeZoneBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimeZoneBox1.Name = "TimeZoneBox1";
            this.TimeZoneBox1.Size = new System.Drawing.Size(260, 24);
            this.TimeZoneBox1.TabIndex = 5;
            // 
            // Statelabel
            // 
            this.Statelabel.AutoSize = true;
            this.Statelabel.Location = new System.Drawing.Point(5, 128);
            this.Statelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Statelabel.Name = "Statelabel";
            this.Statelabel.Size = new System.Drawing.Size(76, 17);
            this.Statelabel.TabIndex = 12;
            this.Statelabel.Text = "Time Zone";
            // 
            // FriendBirthdayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 537);
            this.Controls.Add(this.Statelabel);
            this.Controls.Add(this.TimeZoneBox1);
            this.Controls.Add(this.EmailtextBox1);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Bdatelabel);
            this.Controls.Add(this.Lnamelabel);
            this.Controls.Add(this.LnametxtBox);
            this.Controls.Add(this.Fnamelabel);
            this.Controls.Add(this.FnametxtBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FriendBirthdayForm";
            this.Text = "Happy Birthday";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FriendBirthdayForm_FormClosing_1);
            this.Load += new System.EventHandler(this.FriendBirthdayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FnametxtBox;
        private System.Windows.Forms.Label Fnamelabel;
        private System.Windows.Forms.Label Lnamelabel;
        private System.Windows.Forms.TextBox LnametxtBox;
        private System.Windows.Forms.Label Bdatelabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailtextBox1;
        private System.Windows.Forms.ComboBox TimeZoneBox1;
        private System.Windows.Forms.Label Statelabel;
    }
}

