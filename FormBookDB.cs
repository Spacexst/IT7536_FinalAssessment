/*
 * Student ID: 20220897
 * Project Name: Book Author Editor
 * Description: A Windows Forms application that allows users to add and edit books with
 *              title, author, category, and genres. Users can customize text appearance,
 *              and save/load book descriptions from text files.
 * Features:
 * - Uses TabControl and Panel for UI layout
 * - Uses Labels, TextBoxes, ComboBox, ListBox, CheckedListBox
 * - Handles validation and error checking
 * - Uses SaveFileDialog/OpenFileDialog to manage text files
 * - Allows font and color customization with radio buttons
 * - Includes event handlers for user interaction
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BookAuthorEditor
{
    // Define EventArgs and Delegate outside Form1
    public delegate void BookAddedEventHandler(object sender, BookEventArgs e);
    
    public partial class FormBookDB : Form
    {
        private List<Book> books = new List<Book>();

        // ArrayList to dynamically manage authors
        private ArrayList authors = new ArrayList(); 

        // Array to store predefined book formats
        private string[] bookFormats = { "Hardcover", "Paperback", "E-book" };
        private Counter bookCounter;

        public FormBookDB()
        {
            InitializeComponent();
        }

        // Event triggered when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            const int READING_MILESTONE = 5;

            bookCounter = new Counter(READING_MILESTONE);
            bookCounter.ThresholdReached += BookCounter_ThresholdReached;
        }
        
        // Adds 1 to the counter and triggers the event if threshold is reached
        private void BookCounter_ThresholdReached(object sender, EventArgs e)
        {
            MessageBox.Show("🎉 You have added another 5 books, Congratulations!");
        }

        // Event triggered when "Add Book" button is clicked
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                cmbGenre.SelectedItem == null)
            {
                MessageBox.Show("Please enter Title, Author, and Genre.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            
            // Create a new book object
            Book newBook = new Book(
                txtTitle.Text,
                txtDescription.Text,
                clbGenres.SelectedItem.ToString(),
                cmbGenre.SelectedItem?.ToString(),
                txtAuthor.Text
            );
            // Check if the book already exists to prevent duplicates
            if (!BookExists(newBook))
            {
                books.Add(newBook);
                bookCounter.Add();
                lstBooks.Items.Add(newBook.Title + " by " + newBook.Author);
            }
            else
            {
                MessageBox.Show("This book has already been added.", "Duplicate book",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }


        // Check if a book with the same title already exists
        private bool BookExists(Book newBook)
        {
            foreach (Book book in books)
            {
                if (book.Title == newBook.Title)
                {
                    return true;
                }
            }

            return false;
        }

        // Change font color of the description based on radio button selection
        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlack.Checked)
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

        // Change font family of the description based on radio button selection
        private void rbArial_CheckedChanged(object sender, EventArgs e)
        {
            if (rbArial.Checked)
            {
                txtDescription.Font = new Font("Arial", txtDescription.Font.Size);
            }
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

        // Save all book entries to a text file
        private void btnSaveText_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.Title = "Save Description";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    
                    foreach (Book book in books)
                    {
                        book.AddForWriting(sb);
                    }

                    File.WriteAllText(saveFileDialog.FileName, sb.ToString());

                    MessageBox.Show("Book database saved.");
                }
            }
        }

        // Load text content from a file and display in a separate form
        private void btnLoadText_Click(object sender, EventArgs e)
        {
            string dbText = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                openFileDialog.Title = "Load Description";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dbText = File.ReadAllText(openFileDialog.FileName);
                }
            }

            FormBookDatabaseViewer viewer = new FormBookDatabaseViewer(dbText);
            viewer.ShowDialog();
        }

        // Populate book details when a book is selected from the list
        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem is Book selectedBook)
            {
                txtTitle.Text = selectedBook.Title;
                txtAuthor.Text = selectedBook.Author;
                txtDescription.Text = selectedBook.Description;
            }
        }

        // Clear input fields when Clear button is clicked
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAuthor.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtTitle.Text = string.Empty;
        }

        // Open the GitHub repository when the source code link is clicked
        private void linkSourceCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkSourceCode.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Spacexst/IT7536_FinalAssessment");
        }

        // Placeholder for tab click event (not used currently)
        private void tabBookDetails_Click(object sender, EventArgs e)
        {

        }
    }

    // Custom EventArgs class to pass Book data when BookAdded event is raised
    public class BookEventArgs : EventArgs
    {
        public Book NewBook { get; set; }

        public BookEventArgs(Book book)
        {
            NewBook = book;
        }
    }
}
