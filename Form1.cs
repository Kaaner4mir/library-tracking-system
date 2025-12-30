using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryTrackingSystem
{
    public partial class Form : System.Windows.Forms.Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        string _connectionString = ConfigurationManager.ConnectionStrings["BooksDB"].ConnectionString;

        public Form()
        {
            InitializeComponent();

            toolTip.SetToolTip(btnSave, "Adds book information to the system");
            toolTip.SetToolTip(btnUpdate, "Updates book information");
            toolTip.SetToolTip(btnDelete, "Deletes book information");
            toolTip.SetToolTip(btnClear, "Clears input fields");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListBooks();
        }

        void ListBooks()
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

        private void btnSave_Click(object sender, EventArgs e)
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

            MessageBox.Show("Book added successfully.");
            ListBooks();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxId.Text))
            {
                MessageBox.Show("Please select a book first.");
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

            MessageBox.Show("Book updated successfully.");
            ListBooks();
        }

        private void dgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

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
    }
}
