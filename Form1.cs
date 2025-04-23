
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
using System.Collections;

namespace BookAuthorEditor
{
    public partial class Form1 : Form

    {
        
        private List<Book> books = new List<Book>();


        private ArrayList authors = new ArrayList(); // For dynamic author list
        private string[] bookFormats = { "Hardcover", "Paperback", "E-book" }; // Array usage
        private object txtNewAuthor;


        public Form1()
        {
            
            InitializeComponent();
            cmbFormats.Items.AddRange(bookFormats); // Load array into ComboBox

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

            // Add author if not already added
           


            if (!authors.Contains(txtAuthor.Text))
            {
                authors.Add(txtAuthor.Text);
                lstAuthors.Items.Add(txtAuthor.Text);
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

        private void rbArial_CheckedChanged(object sender, EventArgs e)
        {
            if (rbArial.Checked)
            {
                txtDescription.Font = new Font("Arial", txtDescription.Font.Size);
            }
        }

        private void rbTimesNew_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbTimesNewRoman_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTimesNewRoman.Checked)
            {
                txtDescription.Font = new Font("Times New Roman", txtDescription.Font.Size);
            }

        }

        private void rbComicSans_CheckedChanged(object sender, EventArgs e)
        {
            if (rbComicSans.Checked)
            {
                txtDescription.Font = new Font("Comic Sans MS", txtDescription.Font.Size);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        {
            // Populate ComboBox with bookFormats array
            cmbFormats.Items.AddRange(bookFormats);

            // Optional: Set first item selected
            if (cmbFormats.Items.Count > 0)
                cmbFormats.SelectedIndex = 0;
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

       
        }
    }












