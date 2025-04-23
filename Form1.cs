using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BookAuthorEditor
{
    // ✅ STEP 1: Define EventArgs and Delegate outside Form1
    public delegate void BookAddedEventHandler(object sender, BookEventArgs e);
    

    public class BookEventArgs : EventArgs
    {
        public Book NewBook { get; set; }

        public BookEventArgs(Book book)
        {
            NewBook = book;
        }
    }
  

    public partial class Form1 : Form
    {
        // ✅ Event declaration
        public event BookAddedEventHandler BookAdded;

        private List<Book> books = new List<Book>();
        private ArrayList authors = new ArrayList(); // For dynamic author list
        private string[] bookFormats = { "Hardcover", "Paperback", "E-book" }; // Array usage

        public Form1()
        {
            InitializeComponent();
            cmbFormats.Items.AddRange(bookFormats);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFormats.Items.AddRange(bookFormats);

            if (cmbFormats.Items.Count > 0)
                cmbFormats.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please enter Title, Author, and select a Category.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> selectedGenres = new List<string>();
            foreach (var item in clbGenres.CheckedItems)
            {
                selectedGenres.Add(item.ToString());
            }

            if (!authors.Contains(txtAuthor.Text))
            {
                authors.Add(txtAuthor.Text);
                lstAuthors.Items.Add(txtAuthor.Text);
            }
            Book newBook = new Book(
            txtTitle.Text,
            txtDescription.Text,
            cmbCategory.SelectedItem?.ToString(),
            cmbFormats.SelectedItem?.ToString(),
            txtAuthor.Text,
            string.Join(", ", clbGenres.CheckedItems.Cast<string>())
);



            books.Add(newBook);
            lstBooks.Items.Add(newBook);

            // ✅ Custom event trigger
            BookAdded?.Invoke(this, new BookEventArgs(newBook));

            txtTitle.Clear();
            txtAuthor.Clear();
            txtDescription.Clear();
            cmbCategory.SelectedIndex = -1;
            for (int i = 0; i < clbGenres.Items.Count; i++)
            {
                clbGenres.SetItemChecked(i, false);
            }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            string newAuthor = txtAuthorName.Text.Trim();

            if (!string.IsNullOrEmpty(newAuthor) && !authors.Contains(newAuthor))
            {
                authors.Add(newAuthor);
                lstAuthors.Items.Add(newAuthor);
                txtAuthorName.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a unique author name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: logic when a genre is selected
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: logic when category changes
        }


        // 🎨 Style and text handling events remain unchanged
        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlack.Checked)
                txtDescription.ForeColor = Color.Black;
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked)
                txtDescription.ForeColor = Color.Red;
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
                txtDescription.ForeColor = Color.Blue;
        }

        private void rbArial_CheckedChanged(object sender, EventArgs e)
        {
            if (rbArial.Checked)
                txtDescription.Font = new Font("Arial", txtDescription.Font.Size);
        }

        private void rbTimesNewRoman_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTimesNewRoman.Checked)
                txtDescription.Font = new Font("Times New Roman", txtDescription.Font.Size);
        }

        private void rbComicSans_CheckedChanged(object sender, EventArgs e)
        {
            if (rbComicSans.Checked)
                txtDescription.Font = new Font("Comic Sans MS", txtDescription.Font.Size);
        }

        private void btnSaveText_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.Title = "Save Description";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, txtDescription.Text);
                    MessageBox.Show("Description saved successfully.");
                }
            }
        }

        private void btnLoadText_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                openFileDialog.Title = "Load Description";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDescription.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem is Book selectedBook)
            {
                txtTitle.Text = selectedBook.Title;
                txtAuthor.Text = selectedBook.Author;
                txtDescription.Text = selectedBook.Description;
            }
        }
    }
}
