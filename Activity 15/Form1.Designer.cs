namespace Activity_15
{
    partial class form_LuckyNumbers
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
            this.cmBxDay = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_day = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.lbl_month = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.cmBxYear = new System.Windows.Forms.ComboBox();
            this.cmBxMonth = new System.Windows.Forms.ComboBox();
            this.cmBxColor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmBxDay
            // 
            this.cmBxDay.FormattingEnabled = true;
            this.cmBxDay.Location = new System.Drawing.Point(350, 130);
            this.cmBxDay.Name = "cmBxDay";
            this.cmBxDay.Size = new System.Drawing.Size(121, 21);
            this.cmBxDay.TabIndex = 0;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_submit.Location = new System.Drawing.Point(141, 273);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(214, 35);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Find your lucky number!";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_day
            // 
            this.lbl_day.AutoSize = true;
            this.lbl_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day.Location = new System.Drawing.Point(138, 137);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(146, 20);
            this.lbl_day.TabIndex = 2;
            this.lbl_day.Text = "Enter your birth day";
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_color.Location = new System.Drawing.Point(138, 177);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(176, 20);
            this.lbl_color.TabIndex = 3;
            this.lbl_color.Text = "Enter your favorite color";
            // 
            // lbl_month
            // 
            this.lbl_month.AutoSize = true;
            this.lbl_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_month.Location = new System.Drawing.Point(138, 97);
            this.lbl_month.Name = "lbl_month";
            this.lbl_month.Size = new System.Drawing.Size(166, 20);
            this.lbl_month.TabIndex = 4;
            this.lbl_month.Text = "Enter your birth month";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_year.Location = new System.Drawing.Point(138, 57);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(151, 20);
            this.lbl_year.TabIndex = 5;
            this.lbl_year.Text = "Enter your birth year";
            // 
            // cmBxYear
            // 
            this.cmBxYear.BackColor = System.Drawing.SystemColors.Window;
            this.cmBxYear.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmBxYear.FormattingEnabled = true;
            this.cmBxYear.Location = new System.Drawing.Point(350, 57);
            this.cmBxYear.Name = "cmBxYear";
            this.cmBxYear.Size = new System.Drawing.Size(121, 21);
            this.cmBxYear.TabIndex = 6;
            // 
            // cmBxMonth
            // 
            this.cmBxMonth.FormattingEnabled = true;
            this.cmBxMonth.Location = new System.Drawing.Point(350, 97);
            this.cmBxMonth.Name = "cmBxMonth";
            this.cmBxMonth.Size = new System.Drawing.Size(121, 21);
            this.cmBxMonth.TabIndex = 7;
            // 
            // cmBxColor
            // 
            this.cmBxColor.FormattingEnabled = true;
            this.cmBxColor.Location = new System.Drawing.Point(350, 169);
            this.cmBxColor.Name = "cmBxColor";
            this.cmBxColor.Size = new System.Drawing.Size(121, 21);
            this.cmBxColor.TabIndex = 8;
            // 
            // form_LuckyNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(518, 351);
            this.Controls.Add(this.cmBxColor);
            this.Controls.Add(this.cmBxMonth);
            this.Controls.Add(this.cmBxYear);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.lbl_month);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.lbl_day);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.cmBxDay);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "form_LuckyNumbers";
            this.Text = "Lucky Numbers";
            this.Load += new System.EventHandler(this.form_LuckyNumbers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmBxDay;
        public System.Windows.Forms.Button btn_submit;
        public System.Windows.Forms.Label lbl_day;
        public System.Windows.Forms.Label lbl_color;
        public System.Windows.Forms.Label lbl_month;
        public System.Windows.Forms.Label lbl_year;
        public System.Windows.Forms.ComboBox cmBxYear;
        public System.Windows.Forms.ComboBox cmBxMonth;
        public System.Windows.Forms.ComboBox cmBxColor;
    }
}

