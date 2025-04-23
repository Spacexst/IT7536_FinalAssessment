namespace BookAuthorEditor
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
            this.panelInput = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabControlName = new System.Windows.Forms.TabPage();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clbGenres = new System.Windows.Forms.CheckedListBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.tabStyle = new System.Windows.Forms.TabPage();
            this.grpColors = new System.Windows.Forms.GroupBox();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.rbComicSans = new System.Windows.Forms.RadioButton();
            this.rbTimesNewRoman = new System.Windows.Forms.RadioButton();
            this.rbArial = new System.Windows.Forms.RadioButton();
            this.tabFormatsAuthors = new System.Windows.Forms.TabPage();
            this.lstAuthors = new System.Windows.Forms.ListBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.cmbFormats = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.linkAuthor = new System.Windows.Forms.LinkLabel();
            this.btnSaveText = new System.Windows.Forms.Button();
            this.btnLoadText = new System.Windows.Forms.Button();
            this.panelInput.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabControlName.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabStyle.SuspendLayout();
            this.grpColors.SuspendLayout();
            this.grpFont.SuspendLayout();
            this.tabFormatsAuthors.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Controls.Add(this.txtDescription);
            this.panelInput.Controls.Add(this.txtAuthor);
            this.panelInput.Controls.Add(this.txtTitle);
            this.panelInput.Location = new System.Drawing.Point(10, 10);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(350, 199);
            this.panelInput.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(113, 121);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 60);
            this.txtDescription.TabIndex = 2;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(113, 76);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 22);
            this.txtAuthor.TabIndex = 1;
            this.txtAuthor.Text = "hh";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(102, 25);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 22);
            this.txtTitle.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabControlName);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabStyle);
            this.tabControl1.Controls.Add(this.tabFormatsAuthors);
            this.tabControl1.Location = new System.Drawing.Point(370, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(438, 214);
            this.tabControl1.TabIndex = 1;
            // 
            // tabControlName
            // 
            this.tabControlName.Controls.Add(this.lstBooks);
            this.tabControlName.Location = new System.Drawing.Point(4, 25);
            this.tabControlName.Name = "tabControlName";
            this.tabControlName.Padding = new System.Windows.Forms.Padding(3);
            this.tabControlName.Size = new System.Drawing.Size(430, 185);
            this.tabControlName.TabIndex = 0;
            this.tabControlName.Text = "Book List";
            this.tabControlName.UseVisualStyleBackColor = true;
            // 
            // lstBooks
            // 
            this.lstBooks.AllowDrop = true;
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 16;
            this.lstBooks.Location = new System.Drawing.Point(42, 51);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(120, 84);
            this.lstBooks.TabIndex = 0;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.clbGenres);
            this.tabPage1.Controls.Add(this.cmbCategory);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(430, 185);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Categories";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // clbGenres
            // 
            this.clbGenres.FormattingEnabled = true;
            this.clbGenres.Items.AddRange(new object[] {
            "Mystery",
            " Sci-Fi",
            "Fantasy",
            "Romance"});
            this.clbGenres.Location = new System.Drawing.Point(282, 48);
            this.clbGenres.Name = "clbGenres";
            this.clbGenres.Size = new System.Drawing.Size(120, 89);
            this.clbGenres.TabIndex = 1;
            this.clbGenres.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Fiction",
            "Non-Fiction",
            " Biography",
            "Science"});
            this.cmbCategory.Location = new System.Drawing.Point(17, 21);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(150, 24);
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // tabStyle
            // 
            this.tabStyle.Controls.Add(this.grpColors);
            this.tabStyle.Controls.Add(this.groupBox2);
            this.tabStyle.Controls.Add(this.grpFont);
            this.tabStyle.Location = new System.Drawing.Point(4, 25);
            this.tabStyle.Name = "tabStyle";
            this.tabStyle.Padding = new System.Windows.Forms.Padding(3);
            this.tabStyle.Size = new System.Drawing.Size(430, 185);
            this.tabStyle.TabIndex = 2;
            this.tabStyle.Text = "Style";
            this.tabStyle.UseVisualStyleBackColor = true;
            // 
            // grpColors
            // 
            this.grpColors.Controls.Add(this.rbBlue);
            this.grpColors.Controls.Add(this.rbRed);
            this.grpColors.Controls.Add(this.rbBlack);
            this.grpColors.Location = new System.Drawing.Point(204, 11);
            this.grpColors.Name = "grpColors";
            this.grpColors.Size = new System.Drawing.Size(191, 163);
            this.grpColors.TabIndex = 2;
            this.grpColors.TabStop = false;
            this.grpColors.Text = "Chose color";
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(21, 108);
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
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(54, 20);
            this.rbRed.TabIndex = 1;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Location = new System.Drawing.Point(21, 20);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(62, 20);
            this.rbBlack.TabIndex = 0;
            this.rbBlack.TabStop = true;
            this.rbBlack.Text = "Black";
            this.rbBlack.UseVisualStyleBackColor = true;
            this.rbBlack.CheckedChanged += new System.EventHandler(this.rbBlack_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(10, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // grpFont
            // 
            this.grpFont.Controls.Add(this.rbComicSans);
            this.grpFont.Controls.Add(this.rbTimesNewRoman);
            this.grpFont.Controls.Add(this.rbArial);
            this.grpFont.Location = new System.Drawing.Point(10, 11);
            this.grpFont.Name = "grpFont";
            this.grpFont.Size = new System.Drawing.Size(136, 163);
            this.grpFont.TabIndex = 0;
            this.grpFont.TabStop = false;
            this.grpFont.Text = "Chose Font";
            // 
            // rbComicSans
            // 
            this.rbComicSans.AutoSize = true;
            this.rbComicSans.Location = new System.Drawing.Point(27, 110);
            this.rbComicSans.Name = "rbComicSans";
            this.rbComicSans.Size = new System.Drawing.Size(100, 36);
            this.rbComicSans.TabIndex = 2;
            this.rbComicSans.TabStop = true;
            this.rbComicSans.Text = "Comic Sans\r\n MS";
            this.rbComicSans.UseVisualStyleBackColor = true;
            this.rbComicSans.CheckedChanged += new System.EventHandler(this.rbComicSans_CheckedChanged);
            // 
            // rbTimesNewRoman
            // 
            this.rbTimesNewRoman.AutoSize = true;
            this.rbTimesNewRoman.Location = new System.Drawing.Point(27, 59);
            this.rbTimesNewRoman.Name = "rbTimesNewRoman";
            this.rbTimesNewRoman.Size = new System.Drawing.Size(96, 36);
            this.rbTimesNewRoman.TabIndex = 1;
            this.rbTimesNewRoman.TabStop = true;
            this.rbTimesNewRoman.Text = "Times New\r\n Roman";
            this.rbTimesNewRoman.UseVisualStyleBackColor = true;
            this.rbTimesNewRoman.CheckedChanged += new System.EventHandler(this.rbTimesNewRoman_CheckedChanged);
            // 
            // rbArial
            // 
            this.rbArial.AutoSize = true;
            this.rbArial.Location = new System.Drawing.Point(27, 18);
            this.rbArial.Name = "rbArial";
            this.rbArial.Size = new System.Drawing.Size(55, 20);
            this.rbArial.TabIndex = 0;
            this.rbArial.TabStop = true;
            this.rbArial.Text = "Arial";
            this.rbArial.UseVisualStyleBackColor = true;
            this.rbArial.CheckedChanged += new System.EventHandler(this.rbArial_CheckedChanged);
            // 
            // tabFormatsAuthors
            // 
            this.tabFormatsAuthors.Controls.Add(this.lstAuthors);
            this.tabFormatsAuthors.Controls.Add(this.btnAddAuthor);
            this.tabFormatsAuthors.Controls.Add(this.txtAuthorName);
            this.tabFormatsAuthors.Controls.Add(this.cmbFormats);
            this.tabFormatsAuthors.Location = new System.Drawing.Point(4, 25);
            this.tabFormatsAuthors.Name = "tabFormatsAuthors";
            this.tabFormatsAuthors.Padding = new System.Windows.Forms.Padding(3);
            this.tabFormatsAuthors.Size = new System.Drawing.Size(430, 185);
            this.tabFormatsAuthors.TabIndex = 3;
            this.tabFormatsAuthors.Text = "Formats & Authors";
            this.tabFormatsAuthors.UseVisualStyleBackColor = true;
            // 
            // lstAuthors
            // 
            this.lstAuthors.FormattingEnabled = true;
            this.lstAuthors.ItemHeight = 16;
            this.lstAuthors.Location = new System.Drawing.Point(178, 90);
            this.lstAuthors.Name = "lstAuthors";
            this.lstAuthors.Size = new System.Drawing.Size(120, 84);
            this.lstAuthors.TabIndex = 10;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(20, 133);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnAddAuthor.TabIndex = 9;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(20, 96);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(100, 22);
            this.txtAuthorName.TabIndex = 1;
            this.txtAuthorName.Text = "Author";
            // 
            // cmbFormats
            // 
            this.cmbFormats.FormattingEnabled = true;
            this.cmbFormats.Location = new System.Drawing.Point(129, 51);
            this.cmbFormats.Name = "cmbFormats";
            this.cmbFormats.Size = new System.Drawing.Size(121, 24);
            this.cmbFormats.TabIndex = 0;
            this.cmbFormats.Text = "Select Book Format";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Book";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(254, 367);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // linkAuthor
            // 
            this.linkAuthor.AutoSize = true;
            this.linkAuthor.Location = new System.Drawing.Point(607, 416);
            this.linkAuthor.Name = "linkAuthor";
            this.linkAuthor.Size = new System.Drawing.Size(126, 16);
            this.linkAuthor.TabIndex = 6;
            this.linkAuthor.TabStop = true;
            this.linkAuthor.Text = "Visit Author Website";
            // 
            // btnSaveText
            // 
            this.btnSaveText.Location = new System.Drawing.Point(41, 415);
            this.btnSaveText.Name = "btnSaveText";
            this.btnSaveText.Size = new System.Drawing.Size(75, 23);
            this.btnSaveText.TabIndex = 7;
            this.btnSaveText.Text = "Save Description";
            this.btnSaveText.UseVisualStyleBackColor = true;
            this.btnSaveText.Click += new System.EventHandler(this.btnSaveText_Click);
            // 
            // btnLoadText
            // 
            this.btnLoadText.Location = new System.Drawing.Point(277, 408);
            this.btnLoadText.Name = "btnLoadText";
            this.btnLoadText.Size = new System.Drawing.Size(75, 23);
            this.btnLoadText.TabIndex = 8;
            this.btnLoadText.Text = "Load Description";
            this.btnLoadText.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadText);
            this.Controls.Add(this.btnSaveText);
            this.Controls.Add(this.linkAuthor);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabControlName.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabStyle.ResumeLayout(false);
            this.grpColors.ResumeLayout(false);
            this.grpColors.PerformLayout();
            this.grpFont.ResumeLayout(false);
            this.grpFont.PerformLayout();
            this.tabFormatsAuthors.ResumeLayout(false);
            this.tabFormatsAuthors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabControlName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.CheckedListBox clbGenres;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.LinkLabel linkAuthor;
        private System.Windows.Forms.Button btnSaveText;
        private System.Windows.Forms.Button btnLoadText;
        private System.Windows.Forms.TabPage tabStyle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpFont;
        private System.Windows.Forms.GroupBox grpColors;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.RadioButton rbComicSans;
        private System.Windows.Forms.RadioButton rbTimesNewRoman;
        private System.Windows.Forms.RadioButton rbArial;
        private System.Windows.Forms.TabPage tabFormatsAuthors;
        private System.Windows.Forms.ComboBox cmbFormats;
        private System.Windows.Forms.ListBox lstAuthors;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.TextBox txtAuthorName;
    }
}

