
using System.IO;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace BookAuthorEditor
{
    public partial class Form1 : Form

    {
        private List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please enter Title, Author, and select a Category.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected genres from CheckedListBox
            List<string> selectedGenres = new List<string>();
            foreach (var item in clbGenres.CheckedItems)
            {
                selectedGenres.Add(item.ToString());
            }

            // Create new book
            Book newBook = new Book
            {
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Description = txtDescription.Text,
                Category = cmbCategory.SelectedItem.ToString(),
                Genres = selectedGenres
            };

            // Add to list and ListBox
            books.Add(newBook);
            lstBooks.Items.Add(newBook); // Uses ToString()

            // Clear inputs
            txtTitle.Clear();
            txtAuthor.Clear();
            txtDescription.Clear();
            cmbCategory.SelectedIndex = -1;
            for (int i = 0; i < clbGenres.Items.Count; i++)
            {
                clbGenres.SetItemChecked(i, false);
            }
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
        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbArial.Checked)
            {
                txtDescription.ForeColor = Color.Black;
            }
        }
        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked)
            {
                txtDescription.ForeColor = Color.Red;
            }
        }
        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
            {
                txtDescription.ForeColor = Color.Blue;
            }
        }

     
    }
}











