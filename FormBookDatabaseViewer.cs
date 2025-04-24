using System.Drawing;
using System.Windows.Forms;

namespace BookAuthorEditor
{
    public partial class FormBookDatabaseViewer : Form

    {
        //Font family constants for use in the display text box
        const string ArialFontFamily = "Arial";
        const string TimeNewRomanFontFamily = "Times New Roman";
        const string ComicSansSerifFontFamily = "Comic Sans MS";
        //Font size constants (in points)
        const int SmallPointSize = 10;
        const int MediumPointFont = 14;
        const int LargePointFont = 18;

        // Constructor that accepts a string of book database text 
        public FormBookDatabaseViewer(string databaseText)
        {
            InitializeComponent();

            // start with medium size Arial font
            rbArial.Checked = true;
            rbMedium.Checked = true;
            fontName = ArialFontFamily;
            fontSize = MediumPointFont;

            // Display the book database text in a read-only text box
            txtDisplayDatabase.ReadOnly = false;
            txtDisplayDatabase.Text = databaseText;
            txtDisplayDatabase.ReadOnly = true;
        }

        private void rbArial_CheckedChanged(object sender, System.EventArgs e)
        {
            fontName = ArialFontFamily;
            SetFont();
        }

        private void rbTimesNewRoman_CheckedChanged(object sender, System.EventArgs e)
        {
            fontName = TimeNewRomanFontFamily;
            SetFont();
        }

        private void rbComicSans_CheckedChanged(object sender, System.EventArgs e)
        {
            fontName = ComicSansSerifFontFamily;
            SetFont();
        }

        private void rbSmall_CheckedChanged(object sender, System.EventArgs e)
        {
            fontSize = SmallPointSize;
            SetFont();
        }

        private void rbMedium_CheckedChanged(object sender, System.EventArgs e)
        {
            fontSize = MediumPointFont;
            SetFont();
        }

        private void rbLarge_CheckedChanged(object sender, System.EventArgs e)
        {
            fontSize = LargePointFont;
            SetFont();
        }

        private void SetFont()
        {
            txtDisplayDatabase.Font = new Font(fontName, fontSize);
        }

        private string fontName = ArialFontFamily;
        private int fontSize = MediumPointFont;

        private void txtDisplayDatabase_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
