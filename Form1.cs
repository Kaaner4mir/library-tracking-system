using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryTrackingSystem
{
    public partial class mainForm : System.Windows.Forms.Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        string _connectionString;

        public mainForm()
        {
            try
            {
                InitializeComponent();
                
                if (ConfigurationManager.ConnectionStrings["BooksDB"] == null || 
                    string.IsNullOrWhiteSpace(ConfigurationManager.ConnectionStrings["BooksDB"].ConnectionString))
                {
                    MessageBox.Show("Database connection string is not configured. Please check App.config file.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return;
                }

                _connectionString = ConfigurationManager.ConnectionStrings["BooksDB"].ConnectionString;
                ToolTipMessage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while initializing the form: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Provides information about the functionality of the icons.
        /// </summary>
        private void ToolTipMessage()
        {
            toolTip.SetToolTip(btnSave, "Adds book information to the system");
            toolTip.SetToolTip(btnUpdate, "Updates book information");
            toolTip.SetToolTip(btnDelete, "Deletes book information");
            toolTip.SetToolTip(btnClear, "Clears input fields");
            toolTip.SetToolTip(pbxHelp, "Operation panel allows users to perform book adding, updating, deleting, and clearing operations sequentially.\r\nThrough the search panel, books can be filtered by ID number, title, author, and genre.\r\nIn the upper-left panel, the current date and time are displayed in the dd.MM.yyyy – dddd – HH:mm:ss format.");
            toolTip.SetToolTip(pbxAbout, "Go Web Site");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ListBooks();
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the form: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// List Books
        /// </summary>
        void ListBooks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Books", connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgwBooks.DataSource = table;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error occurred while loading books: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// You can drag the window using the top panel.
        /// </summary>
        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnCrossMark_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIconState_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnWindowControl_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal
                ? FormWindowState.Maximized
                : FormWindowState.Normal;
        }

        /// <summary>
        /// Adds books
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO Books
                                    (Title, Genre, Author, Language, Publisher, PageCount, PublicationYear)
                                    VALUES (@title, @genre, @author, @language, @publisher, @pageCount, @year)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@title", tbxTitle.Text);
                        command.Parameters.AddWithValue("@genre", tbxGenre.Text);
                        command.Parameters.AddWithValue("@author", tbxAuthor.Text);
                        command.Parameters.AddWithValue("@language", tbxLanguage.Text);
                        command.Parameters.AddWithValue("@publisher", tbxPublisher.Text);
                        command.Parameters.AddWithValue("@pageCount", int.Parse(tbxPageCount.Text));
                        command.Parameters.AddWithValue("@year", int.Parse(tbxPublicationYear.Text));

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Book added successfully.", "Successful transaction");
                Clear();
                ListBooks();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Page Count and Publication Year.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error occurred while adding the book: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// It performs the process of updating the requested book information.
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxId.Text))
                {
                    MessageBox.Show("Please select a book first.", "Warning");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = @"UPDATE Books SET
                                     Title=@title, Genre=@genre, Author=@author,
                                     Language=@language, Publisher=@publisher,
                                     PageCount=@pageCount, PublicationYear=@year
                                     WHERE BookId=@bookId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@bookId", int.Parse(tbxId.Text));
                        command.Parameters.AddWithValue("@title", tbxTitle.Text);
                        command.Parameters.AddWithValue("@genre", tbxGenre.Text);
                        command.Parameters.AddWithValue("@author", tbxAuthor.Text);
                        command.Parameters.AddWithValue("@language", tbxLanguage.Text);
                        command.Parameters.AddWithValue("@publisher", tbxPublisher.Text);
                        command.Parameters.AddWithValue("@pageCount", int.Parse(tbxPageCount.Text));
                        command.Parameters.AddWithValue("@year", int.Parse(tbxPublicationYear.Text));

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Book updated successfully.", "Successful transaction");
                Clear();
                ListBooks();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for ID, Page Count and Publication Year.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error occurred while updating the book: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This allows the information about the book in the selected row to be displayed in the panel.
        /// </summary>
        private void dgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                if (dgwBooks.Rows[e.RowIndex].Cells[0].Value == null)
                    return;

                int bookId = Convert.ToInt32(dgwBooks.Rows[e.RowIndex].Cells[0].Value);

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Books WHERE BookId=@bookId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@bookId", bookId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tbxId.Text = reader["BookId"].ToString();
                                tbxTitle.Text = reader["Title"].ToString();
                                tbxGenre.Text = reader["Genre"].ToString();
                                tbxAuthor.Text = reader["Author"].ToString();
                                tbxLanguage.Text = reader["Language"].ToString();
                                tbxPublisher.Text = reader["Publisher"].ToString();
                                tbxPageCount.Text = reader["PageCount"].ToString();
                                tbxPublicationYear.Text = reader["PublicationYear"].ToString();
                            }
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid book ID format.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error occurred while loading book details: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading book details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cleans the panel
        /// </summary>
        void Clear()
        {
            tbxId.Clear();
            tbxTitle.Clear();
            tbxAuthor.Clear();
            tbxGenre.Clear();
            tbxLanguage.Clear();
            tbxPublisher.Clear();
            tbxPublicationYear.Clear();
            tbxPageCount.Clear();
            tbxSearch.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        /// <summary>
        /// Deletes the selected book.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxId.Text))
                {
                    MessageBox.Show("Please select a book first.", "Warning");
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    return;

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string commandText = "DELETE FROM Books WHERE BookId=@bookId";

                    using (SqlCommand command = new SqlCommand(commandText, connection))
                    {
                        command.Parameters.AddWithValue("@bookId", int.Parse(tbxId.Text));
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("The book has been successfully deleted!", "Successful transaction");
                Clear();
                ListBooks();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid book ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error occurred while deleting the book: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxAbout_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(
                 new System.Diagnostics.ProcessStartInfo
                 {
                     FileName = "https://kaaner4mir.github.io/Bio/",
                     UseShellExecute = true
                 });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the website: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// It performs the filtering process
        /// </summary>
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgwBooks.DataSource is DataTable table)
                {
                    DataView dv = table.DefaultView;

                    string searchTerm = tbxSearch.Text.Replace("'", "''");

                    if (string.IsNullOrWhiteSpace(searchTerm))
                    {
                        dv.RowFilter = string.Empty;
                    }
                    else
                    {
                        dv.RowFilter = string.Format(
                            "CONVERT(BookId, 'System.String') LIKE '%{0}%' OR " +
                            "Title LIKE '%{0}%' OR " +
                            "Author LIKE '%{0}%' OR " +
                            "Genre LIKE '%{0}%'",
                            searchTerm
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                // Silently handle search errors to avoid disrupting user experience
                // Could log the error if logging is implemented
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                lblDateTime.Text = DateTime.Now.ToString("dd.MM.yyyy dddd HH:mm:ss", CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {
                // Silently handle timer errors to avoid disrupting user experience
                // Could log the error if logging is implemented
            }
        }
    }
}
