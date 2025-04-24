namespace BookAuthorEditor
{
    partial class FormBookDB
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
            this.clbCategory = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.tabBooks = new System.Windows.Forms.TabControl();
            this.tabBookDetails = new System.Windows.Forms.TabPage();
            this.lbl5 = new System.Windows.Forms.Label();
            this.tabControlName = new System.Windows.Forms.TabPage();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.tabStyle = new System.Windows.Forms.TabPage();
            this.grpColors = new System.Windows.Forms.GroupBox();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.rbComicSans = new System.Windows.Forms.RadioButton();
            this.rbTimesNewRoman = new System.Windows.Forms.RadioButton();
            this.rbArial = new System.Windows.Forms.RadioButton();
            this.linkSourceCode = new System.Windows.Forms.LinkLabel();
            this.btnSaveText = new System.Windows.Forms.Button();
            this.btnLoadText = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabBooks.SuspendLayout();
            this.tabBookDetails.SuspendLayout();
            this.tabControlName.SuspendLayout();
            this.tabStyle.SuspendLayout();
            this.grpColors.SuspendLayout();
            this.grpFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbCategory
            // 
            this.clbCategory.FormattingEnabled = true;
            this.clbCategory.Items.AddRange(new object[] {
            "Mystery",
            " Sci-Fi",
            "Fantasy",
            "Romance"});
            this.clbCategory.Location = new System.Drawing.Point(97, 370);
            this.clbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbCategory.Name = "clbCategory";
            this.clbCategory.Size = new System.Drawing.Size(513, 72);
            this.clbCategory.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 332);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // cmbGenre
            // 
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Items.AddRange(new object[] {
            "Fiction",
            "Non-Fiction",
            " Biography",
            "Science"});
            this.cmbGenre.Location = new System.Drawing.Point(96, 324);
            this.cmbGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(513, 24);
            this.cmbGenre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(96, 101);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(514, 204);
            this.txtDescription.TabIndex = 2;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthor.Location = new System.Drawing.Point(96, 54);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(514, 22);
            this.txtAuthor.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Location = new System.Drawing.Point(96, 14);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(514, 22);
            this.txtTitle.TabIndex = 0;
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.tabBookDetails);
            this.tabBooks.Controls.Add(this.tabControlName);
            this.tabBooks.Controls.Add(this.tabStyle);
            this.tabBooks.Location = new System.Drawing.Point(15, 11);
            this.tabBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.SelectedIndex = 0;
            this.tabBooks.Size = new System.Drawing.Size(640, 533);
            this.tabBooks.TabIndex = 1;
            // 
            // tabBookDetails
            // 
            this.tabBookDetails.Controls.Add(this.lbl5);
            this.tabBookDetails.Controls.Add(this.clbCategory);
            this.tabBookDetails.Controls.Add(this.txtDescription);
            this.tabBookDetails.Controls.Add(this.label4);
            this.tabBookDetails.Controls.Add(this.txtTitle);
            this.tabBookDetails.Controls.Add(this.label3);
            this.tabBookDetails.Controls.Add(this.txtAuthor);
            this.tabBookDetails.Controls.Add(this.cmbGenre);
            this.tabBookDetails.Controls.Add(this.label1);
            this.tabBookDetails.Controls.Add(this.label2);
            this.tabBookDetails.Location = new System.Drawing.Point(4, 25);
            this.tabBookDetails.Margin = new System.Windows.Forms.Padding(4);
            this.tabBookDetails.Name = "tabBookDetails";
            this.tabBookDetails.Size = new System.Drawing.Size(632, 504);
            this.tabBookDetails.TabIndex = 4;
            this.tabBookDetails.Text = "Book details";
            this.tabBookDetails.UseVisualStyleBackColor = true;
            this.tabBookDetails.Click += new System.EventHandler(this.tabBookDetails_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl5.Location = new System.Drawing.Point(26, 400);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(62, 16);
            this.lbl5.TabIndex = 7;
            this.lbl5.Text = "Category";
            // 
            // tabControlName
            // 
            this.tabControlName.Controls.Add(this.lstBooks);
            this.tabControlName.Location = new System.Drawing.Point(4, 25);
            this.tabControlName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlName.Name = "tabControlName";
            this.tabControlName.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlName.Size = new System.Drawing.Size(632, 504);
            this.tabControlName.TabIndex = 0;
            this.tabControlName.Text = "Book List";
            this.tabControlName.UseVisualStyleBackColor = true;
            // 
            // lstBooks
            // 
            this.lstBooks.AllowDrop = true;
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 16;
            this.lstBooks.Location = new System.Drawing.Point(5, 11);
            this.lstBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(531, 484);
            this.lstBooks.TabIndex = 0;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged);
            // 
            // tabStyle
            // 
            this.tabStyle.Controls.Add(this.grpColors);
            this.tabStyle.Controls.Add(this.grpFont);
            this.tabStyle.Location = new System.Drawing.Point(4, 25);
            this.tabStyle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabStyle.Name = "tabStyle";
            this.tabStyle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabStyle.Size = new System.Drawing.Size(632, 504);
            this.tabStyle.TabIndex = 2;
            this.tabStyle.Text = "Style";
            this.tabStyle.UseVisualStyleBackColor = true;
            // 
            // grpColors
            // 
            this.grpColors.Controls.Add(this.rbBlue);
            this.grpColors.Controls.Add(this.rbRed);
            this.grpColors.Controls.Add(this.rbBlack);
            this.grpColors.Location = new System.Drawing.Point(11, 185);
            this.grpColors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpColors.Name = "grpColors";
            this.grpColors.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpColors.Size = new System.Drawing.Size(527, 134);
            this.grpColors.TabIndex = 2;
            this.grpColors.TabStop = false;
            this.grpColors.Text = "Color";
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(21, 82);
            this.rbBlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(55, 20);
            this.rbBlue.TabIndex = 2;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(21, 59);
            this.rbRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(54, 20);
            this.rbRed.TabIndex = 1;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Location = new System.Drawing.Point(21, 36);
            this.rbBlack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(62, 20);
            this.rbBlack.TabIndex = 0;
            this.rbBlack.TabStop = true;
            this.rbBlack.Text = "Black";
            this.rbBlack.UseVisualStyleBackColor = true;
            this.rbBlack.CheckedChanged += new System.EventHandler(this.rbBlack_CheckedChanged);
            // 
            // grpFont
            // 
            this.grpFont.Controls.Add(this.rbComicSans);
            this.grpFont.Controls.Add(this.rbTimesNewRoman);
            this.grpFont.Controls.Add(this.rbArial);
            this.grpFont.Location = new System.Drawing.Point(11, 11);
            this.grpFont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFont.Name = "grpFont";
            this.grpFont.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFont.Size = new System.Drawing.Size(527, 162);
            this.grpFont.TabIndex = 0;
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
            // linkSourceCode
            // 
            this.linkSourceCode.AutoSize = true;
            this.linkSourceCode.Location = new System.Drawing.Point(467, 560);
            this.linkSourceCode.Name = "linkSourceCode";
            this.linkSourceCode.Size = new System.Drawing.Size(173, 16);
            this.linkSourceCode.TabIndex = 6;
            this.linkSourceCode.TabStop = true;
            this.linkSourceCode.Text = "View source code on Github";
            this.linkSourceCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSourceCode_LinkClicked);
            // 
            // btnSaveText
            // 
            this.btnSaveText.Location = new System.Drawing.Point(233, 554);
            this.btnSaveText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveText.Name = "btnSaveText";
            this.btnSaveText.Size = new System.Drawing.Size(100, 28);
            this.btnSaveText.TabIndex = 2;
            this.btnSaveText.Text = "Save Description";
            this.btnSaveText.UseVisualStyleBackColor = true;
            this.btnSaveText.Click += new System.EventHandler(this.btnSaveText_Click);
            // 
            // btnLoadText
            // 
            this.btnLoadText.Location = new System.Drawing.Point(339, 555);
            this.btnLoadText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadText.Name = "btnLoadText";
            this.btnLoadText.Size = new System.Drawing.Size(100, 28);
            this.btnLoadText.TabIndex = 3;
            this.btnLoadText.Text = "Load Description";
            this.btnLoadText.UseVisualStyleBackColor = true;
            this.btnLoadText.Click += new System.EventHandler(this.btnLoadText_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 554);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Book";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(128, 554);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormBookDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 591);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoadText);
            this.Controls.Add(this.btnSaveText);
            this.Controls.Add(this.linkSourceCode);
            this.Controls.Add(this.tabBooks);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBookDB";
            this.Text = "Book DB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabBooks.ResumeLayout(false);
            this.tabBookDetails.ResumeLayout(false);
            this.tabBookDetails.PerformLayout();
            this.tabControlName.ResumeLayout(false);
            this.tabStyle.ResumeLayout(false);
            this.grpColors.ResumeLayout(false);
            this.grpColors.PerformLayout();
            this.grpFont.ResumeLayout(false);
            this.grpFont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabBooks;
        private System.Windows.Forms.TabPage tabControlName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.CheckedListBox clbCategory;
        private System.Windows.Forms.LinkLabel linkSourceCode;
        private System.Windows.Forms.Button btnSaveText;
        private System.Windows.Forms.Button btnLoadText;
        private System.Windows.Forms.TabPage tabStyle;
        private System.Windows.Forms.GroupBox grpFont;
        private System.Windows.Forms.GroupBox grpColors;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.RadioButton rbComicSans;
        private System.Windows.Forms.RadioButton rbTimesNewRoman;
        private System.Windows.Forms.RadioButton rbArial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabBookDetails;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbl5;
    }
}

