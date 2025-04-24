namespace BookAuthorEditor
{
    partial class FormBookDatabaseViewer
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
            this.btnClose = new System.Windows.Forms.Button();
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.rbComicSans = new System.Windows.Forms.RadioButton();
            this.rbTimesNewRoman = new System.Windows.Forms.RadioButton();
            this.rbArial = new System.Windows.Forms.RadioButton();
            this.txtDisplayDatabase = new System.Windows.Forms.TextBox();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.grpFont.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(556, 564);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // grpFont
            // 
            this.grpFont.Controls.Add(this.rbComicSans);
            this.grpFont.Controls.Add(this.rbTimesNewRoman);
            this.grpFont.Controls.Add(this.rbArial);
            this.grpFont.Location = new System.Drawing.Point(17, 430);
            this.grpFont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFont.Name = "grpFont";
            this.grpFont.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFont.Size = new System.Drawing.Size(216, 162);
            this.grpFont.TabIndex = 3;
            this.grpFont.TabStop = false;
            this.grpFont.Text = "Font";
            // 
            // rbComicSans
            // 
            this.rbComicSans.AutoSize = true;
            this.rbComicSans.Location = new System.Drawing.Point(27, 90);
            this.rbComicSans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbComicSans.Name = "rbComicSans";
            this.rbComicSans.Size = new System.Drawing.Size(123, 20);
            this.rbComicSans.TabIndex = 2;
            this.rbComicSans.TabStop = true;
            this.rbComicSans.Text = "Comic Sans MS";
            this.rbComicSans.UseVisualStyleBackColor = true;
            this.rbComicSans.CheckedChanged += new System.EventHandler(this.rbComicSans_CheckedChanged);
            // 
            // rbTimesNewRoman
            // 
            this.rbTimesNewRoman.AutoSize = true;
            this.rbTimesNewRoman.Location = new System.Drawing.Point(27, 66);
            this.rbTimesNewRoman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTimesNewRoman.Name = "rbTimesNewRoman";
            this.rbTimesNewRoman.Size = new System.Drawing.Size(143, 20);
            this.rbTimesNewRoman.TabIndex = 1;
            this.rbTimesNewRoman.TabStop = true;
            this.rbTimesNewRoman.Text = "Times New Roman";
            this.rbTimesNewRoman.UseVisualStyleBackColor = true;
            this.rbTimesNewRoman.CheckedChanged += new System.EventHandler(this.rbTimesNewRoman_CheckedChanged);
            // 
            // rbArial
            // 
            this.rbArial.AutoSize = true;
            this.rbArial.Location = new System.Drawing.Point(27, 41);
            this.rbArial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbArial.Name = "rbArial";
            this.rbArial.Size = new System.Drawing.Size(55, 20);
            this.rbArial.TabIndex = 0;
            this.rbArial.TabStop = true;
            this.rbArial.Text = "Arial";
            this.rbArial.UseVisualStyleBackColor = true;
            this.rbArial.CheckedChanged += new System.EventHandler(this.rbArial_CheckedChanged);
            // 
            // txtDisplayDatabase
            // 
            this.txtDisplayDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplayDatabase.Location = new System.Drawing.Point(17, 16);
            this.txtDisplayDatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDisplayDatabase.Multiline = true;
            this.txtDisplayDatabase.Name = "txtDisplayDatabase";
            this.txtDisplayDatabase.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDisplayDatabase.Size = new System.Drawing.Size(638, 407);
            this.txtDisplayDatabase.TabIndex = 5;
            this.txtDisplayDatabase.TextChanged += new System.EventHandler(this.txtDisplayDatabase_TextChanged);
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.rbLarge);
            this.grpSize.Controls.Add(this.rbMedium);
            this.grpSize.Controls.Add(this.rbSmall);
            this.grpSize.Location = new System.Drawing.Point(240, 431);
            this.grpSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSize.Name = "grpSize";
            this.grpSize.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSize.Size = new System.Drawing.Size(191, 149);
            this.grpSize.TabIndex = 6;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(9, 89);
            this.rbLarge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(63, 20);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(9, 65);
            this.rbMedium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(76, 20);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(9, 39);
            this.rbSmall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(62, 20);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // FormBookDatabaseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 608);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.txtDisplayDatabase);
            this.Controls.Add(this.grpFont);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBookDatabaseViewer";
            this.Text = "Database Viewer";
            this.grpFont.ResumeLayout(false);
            this.grpFont.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpFont;
        private System.Windows.Forms.RadioButton rbComicSans;
        private System.Windows.Forms.RadioButton rbTimesNewRoman;
        private System.Windows.Forms.RadioButton rbArial;
        private System.Windows.Forms.TextBox txtDisplayDatabase;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
    }
}