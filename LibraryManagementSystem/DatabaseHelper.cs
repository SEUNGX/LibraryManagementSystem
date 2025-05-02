using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using BCrypt.Net;
using System.Security.Principal;
using System.Data;
namespace LibraryManagementSystem
{
    public class DatabaseHelper
    {
        string connectionString = @"Server=.\SQLEXPRESS;Database=LibraryDB;Integrated Security=True;TrustServerCertificate=True;";


        public bool RegisterUser(string username, string passwordHash, string firstName, string lastName, string email)
        {


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Users (Username, PasswordHash, FirstName, LastName, Email) VALUES (@Username, @PasswordHash, @FirstName, @LastName, @Email)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@PasswordHash", passwordHash); // Store hashed password
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        //cmd.Parameters.AddWithValue("@Role", role);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0; // Returns true if insertion is successful
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public int GetTotalBooks()
        {
            int totalBooks = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Books";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        totalBooks = (int)cmd.ExecuteScalar(); // Get the count
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return totalBooks;
        }

        

        public void InsertCategory(string categoryName, string description, long addedByUserID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                INSERT INTO BookCategories (CategoryName, Description, AddedByUserID)
                VALUES (@CategoryName, @Description, @AddedByUserID)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                    cmd.Parameters.AddWithValue("@Description", string.IsNullOrWhiteSpace(description) ? DBNull.Value : (object)description);
                    cmd.Parameters.AddWithValue("@AddedByUserID", addedByUserID); // if nullable, adjust accordingly

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void InsertAuthor(string firstName, string lastName, long addedByUserID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            INSERT INTO Authors (FirstName, LastName, AddedByUserID)
            VALUES (@FirstName, @LastName, @AddedByUserID)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@AddedByUserID", addedByUserID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool InsertLibrarian(string username, string password, string firstName, string lastName, string email)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password); // Secure password hash

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            INSERT INTO Librarians (Username, PasswordHash, FirstName, LastName, Email)
            VALUES (@Username, @PasswordHash, @FirstName, @LastName, @Email)";

                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Email", email);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving librarian: " + ex.Message);
                    return false;
                }
            }
        }

        public List<string> GetAllAuthorNames()
        {
            List<string> authors = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT FirstName, LastName FROM Authors ORDER BY LastName, FirstName";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string fullName = $"{reader["FirstName"]} {reader["LastName"]}";
                        authors.Add(fullName);
                    }
                }
            }

            return authors;
        }

        //public long GetAuthorIDByName(string authorName)
        //{
        //    long authorID = 0;
        //    string query = "SELECT AuthorID FROM Authors WHERE FirstName + ' ' + LastName = @authorName";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand(query, connection);
        //        cmd.Parameters.AddWithValue("@authorName", authorName);
        //        connection.Open();

        //        authorID = Convert.ToInt64(cmd.ExecuteScalar());
        //    }

        //    return authorID;
        //}


        //public void InsertBook(string isbn, string title, string publisher, int pubYear, string edition, string author, long categoryId, int totalCopies, string description, long currentUserId)
        //{
        //    // SQL query to insert a new book
        //    string query = @"INSERT INTO Books (ISBN, Title, Publisher, PublicationYear, Edition, Author, CategoryID, TotalCopies, AvailableCopies, Description, AddedByUserID)
        //             VALUES (@ISBN, @Title, @Publisher, @PublicationYear, @Edition, @Author, @CategoryID, @TotalCopies, @TotalCopies, @Description, @AddedByUserID)";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand(query, connection);
        //        cmd.Parameters.AddWithValue("@ISBN", isbn);
        //        cmd.Parameters.AddWithValue("@Title", title);
        //        cmd.Parameters.AddWithValue("@Publisher", publisher);
        //        cmd.Parameters.AddWithValue("@PublicationYear", pubYear);
        //        cmd.Parameters.AddWithValue("@Edition", edition);
        //        cmd.Parameters.AddWithValue("@Author", author);
        //        cmd.Parameters.AddWithValue("@CategoryID", categoryId);
        //        cmd.Parameters.AddWithValue("@TotalCopies", totalCopies);
        //        cmd.Parameters.AddWithValue("@Description", description);
        //        cmd.Parameters.AddWithValue("@AddedByUserID", currentUserId);

        //        connection.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //}


        //public List<string> GetAllCategories()
        //{
        //    List<string> categories = new List<string>();

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();
        //        string query = "SELECT CategoryName FROM BookCategories";
        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                categories.Add(reader["CategoryName"].ToString());
        //            }
        //        }
        //    }

        //    return categories;
        //}

        public List<string> GetAllCategories()
        {
            List<string> categories = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT CategoryName FROM BookCategories ORDER BY CategoryName"; // Query for category names

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string categoryName = reader["CategoryName"].ToString();
                        categories.Add(categoryName);
                    }
                }
            }

            return categories;
        }


        //public long GetCategoryIdByName(string categoryName)
        //{
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();
        //        string query = "SELECT CategoryID FROM BookCategories WHERE CategoryName = @CategoryName";
        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@CategoryName", categoryName);
        //            object result = cmd.ExecuteScalar();
        //            return result != null ? Convert.ToInt64(result) : -1;
        //        }
        //    }
        //}

        //**********

        public long GetAuthorIDByName(string authorName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT AuthorID FROM Authors WHERE FirstName + ' ' + LastName = @AuthorName";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AuthorName", authorName);
                    object result = cmd.ExecuteScalar();

                    return result != null ? Convert.ToInt64(result) : 0;
                }
            }
        }

        // Method to get CategoryID by category name
        public long GetCategoryIdByName(string categoryName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT CategoryID FROM BookCategories WHERE CategoryName = @CategoryName";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                    object result = cmd.ExecuteScalar();

                    return result != null ? Convert.ToInt64(result) : 0;
                }
            }
        }

        // Method to insert a book into the database
        public void InsertBook(string isbn, string title, long authorID, string publisher, int publicationYear, string edition,
                              long categoryID, int totalCopies, string description, long addedByUserID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Insert into Books table
                    string bookQuery = @"INSERT INTO Books (ISBN, Title, Publisher, PublicationYear, Edition, CategoryID,
                                                    TotalCopies, AvailableCopies, Description, AddedByUserID, 
                                                    DateAdded, Status, AuthorID)
                                 OUTPUT INSERTED.BookID
                                 VALUES (@ISBN, @Title, @Publisher, @PublicationYear, @Edition, @CategoryID,
                                         @TotalCopies, @TotalCopies, @Description, @AddedByUserID,
                                         GETDATE(), 'Available', @AuthorID)";

                    long bookID;
                    using (SqlCommand cmd = new SqlCommand(bookQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@ISBN", isbn);
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Publisher", publisher);
                        cmd.Parameters.AddWithValue("@PublicationYear", publicationYear);
                        cmd.Parameters.AddWithValue("@Edition", edition);
                        cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                        cmd.Parameters.AddWithValue("@TotalCopies", totalCopies);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@AddedByUserID", addedByUserID);
                        cmd.Parameters.AddWithValue("@AuthorID", authorID);

                        bookID = (long)cmd.ExecuteScalar();
                    }

                    // Insert into BookCopies
                    string copyQuery = @"INSERT INTO BookCopies (BookID, IsAvailable) VALUES (@BookID, 1)";
                    using (SqlCommand copyCmd = new SqlCommand(copyQuery, conn, transaction))
                    {
                        copyCmd.Parameters.Add("@BookID", SqlDbType.BigInt);

                        for (int i = 0; i < totalCopies; i++)
                        {
                            copyCmd.Parameters["@BookID"].Value = bookID;
                            copyCmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    //MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error adding book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void InsertMember(string firstName, string lastName, string email, string phone,
                         string address, DateTime dateOfBirth, long registeredByUserID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string query = @"INSERT INTO Members 
                            (FirstName, LastName, Email, Phone, Address, DateOfBirth, RegisteredByUserID, MembershipDate, Status)
                             VALUES
                            (@FirstName, @LastName, @Email, @Phone, @Address, @DateOfBirth, @RegisteredByUserID, GETDATE(), 'Active')";

                    using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? DBNull.Value : (object)email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(address) ? DBNull.Value : (object)address);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        cmd.Parameters.AddWithValue("@RegisteredByUserID", registeredByUserID);

                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    // You can show a message in the calling code if needed
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error adding member: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public List<string> GetActiveMemberNames()
        {
            List<string> members = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT FirstName + ' ' + LastName AS FullName FROM Members WHERE Status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        members.Add(reader["FullName"].ToString());
                    }
                }
            }

            return members;
        }

        // Method to get available book titles (only one per book)
        public List<BookDisplay> GetAvailableBooks()
        {
            List<BookDisplay> books = new List<BookDisplay>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT DISTINCT B.BookID, B.Title
            FROM Books B
            WHERE EXISTS (
                SELECT 1 FROM BookCopies BC
                WHERE BC.BookID = B.BookID AND BC.Status = 'Available'
            )
        ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        books.Add(new BookDisplay
                        {
                            BookID = Convert.ToInt64(reader["BookID"]),
                            Title = reader["Title"].ToString()
                        });
                    }
                }
            }

            return books;
        }

        public long GetFirstAvailableCopyID(long bookID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT TOP 1 CopyID 
            FROM BookCopies 
            WHERE BookID = @BookID AND IsAvailable = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt64(result) : 0;
                }
            }
        }



        public long InsertLoan(long memberID, long copyID, long checkedOutBy, DateTime loanDate, DateTime dueDate)
        {
            long loanID = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction(); // Start a transaction

                try
                {
                    // 1. Insert the new loan record
                    string query = @"
                INSERT INTO Loans (MemberID, CopyID, CheckedOutByUserID, LoanDate, DueDate, Status)
                VALUES (@MemberID, @CopyID, @CheckedOutByUserID, @LoanDate, @DueDate, @Status);
                SELECT SCOPE_IDENTITY();";  // Get the inserted loan's ID

                    using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberID);
                        cmd.Parameters.AddWithValue("@CopyID", copyID);
                        cmd.Parameters.AddWithValue("@CheckedOutByUserID", checkedOutBy);  // Assuming this is the logged-in user
                        cmd.Parameters.AddWithValue("@LoanDate", loanDate);
                        cmd.Parameters.AddWithValue("@DueDate", dueDate);
                        cmd.Parameters.AddWithValue("@Status", "Active");  // Assuming the loan status is active initially

                        loanID = Convert.ToInt64(cmd.ExecuteScalar());  // Get the LoanID of the newly inserted loan
                    }

                    // 2. Update the IsAvailable status to false for the borrowed book copy
                    string updateQuery = "UPDATE BookCopies SET IsAvailable = 0 WHERE CopyID = @CopyID";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction))
                    {
                        updateCmd.Parameters.AddWithValue("@CopyID", copyID);
                        int rowsAffected = updateCmd.ExecuteNonQuery();  // Returns number of rows updated

                        if (rowsAffected == 0)
                        {
                            throw new Exception("Failed to update book availability. CopyID might be incorrect.");
                        }
                    }


                    // Commit the transaction
                    transaction.Commit();
                }
                catch (Exception)
                {
                    // Rollback in case of any error
                    transaction.Rollback();
                    throw;
                }
            }

            return loanID;  // Return the new LoanID
        }



        public long GetMemberIdByName(string fullName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MemberID FROM Members WHERE CONCAT(FirstName, ' ', LastName) = @FullName";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt64(result);
                    }
                    else
                    {
                        throw new Exception("Member not found in database.");
                    }
                }
            }
        }

        public void MarkCopyAsUnavailable(long copyID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
        UPDATE BookCopies 
        SET IsAvailable = 0 
        WHERE CopyID = @CopyID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CopyID", copyID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //public void GenerateDailyFines()
        //{
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();

        //        string query = @"
        //    SELECT L.LoanID, L.MemberID, L.DueDate
        //    FROM Loans L
        //    LEFT JOIN Fines F ON L.LoanID = F.LoanID
        //    WHERE L.Status = 'Active' 
        //      AND L.DueDate < GETDATE()
        //      AND F.LoanID IS NULL";

        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                long loanId = Convert.ToInt64(reader["LoanID"]);
        //                long memberId = Convert.ToInt64(reader["MemberID"]);
        //                DateTime dueDate = Convert.ToDateTime(reader["DueDate"]);

        //                int overdueDays = (DateTime.Now.Date - dueDate.Date).Days;
        //                decimal amount = overdueDays * 20m;

        //                InsertFine(loanId, memberId, amount);
        //            }
        //        }
        //    }
        //}

        public void GenerateDailyFines()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
        SELECT L.LoanID, L.MemberID, L.DueDate
        FROM Loans L
        LEFT JOIN Fines F ON L.LoanID = F.LoanID
        WHERE L.Status = 'Active' 
          AND CAST(L.DueDate AS DATE) < CAST(GETDATE() AS DATE)
          AND F.LoanID IS NULL";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long loanId = Convert.ToInt64(reader["LoanID"]);
                        long memberId = Convert.ToInt64(reader["MemberID"]);
                        DateTime dueDate = Convert.ToDateTime(reader["DueDate"]);

                        int overdueDays = (DateTime.Now.Date - dueDate.Date).Days;
                        decimal amount = overdueDays * 20m;

                        InsertFine(loanId, memberId, amount);
                    }
                }
            }
        }


        public void UpdateDailyFines()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            UPDATE Fines
            SET Amount = 20 * DATEDIFF(DAY, L.DueDate, GETDATE())
            FROM Fines F
            INNER JOIN Loans L ON F.LoanID = L.LoanID
            WHERE F.Status = 'Pending'
              AND L.Status = 'Active'
              AND L.ReturnDate IS NULL
              AND GETDATE() > L.DueDate";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void InsertFine(long loanId, long memberId, decimal amount)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            INSERT INTO Fines (LoanID, MemberID, FineDate, Amount, Status)
            VALUES (@LoanID, @MemberID, CAST(GETDATE() AS DATE), @Amount, 'Pending')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LoanID", loanId);
                    cmd.Parameters.AddWithValue("@MemberID", memberId);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllFines()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
        SELECT 
            F.FineID,
            B.Title AS BookTitle,
            M.FirstName + ' ' + M.LastName AS MemberName,
            L.DueDate,
            L.ReturnDate,
            F.Status,
            F.Amount
        FROM Fines F
        JOIN Loans L ON F.LoanID = L.LoanID
        JOIN Members M ON F.MemberID = M.MemberID
        JOIN BookCopies BC ON L.CopyID = BC.CopyID
        JOIN Books B ON BC.BookID = B.BookID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        //public DataTable GetPaidFines()
        //{
        //    DataTable dt = new DataTable();
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        string query = @"
        //    SELECT F.FineID, B.Title AS BookTitle, 
        //           M.FirstName + ' ' + M.LastName AS MemberName,
        //           L.DueDate, L.ReturnDate, L.Status
        //    FROM Fines F
        //    JOIN Loans L ON F.LoanID = L.LoanID
        //    JOIN Books B ON L.CopyID = B.BookID
        //    JOIN Members M ON F.MemberID = M.MemberID
        //    WHERE F.Status = 'Paid'";

        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        {
        //            conn.Open();
        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //            adapter.Fill(dt);
        //        }
        //    }
        //    return dt;
        //}

        public DataTable GetPaidFines()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT 
            F.FineID, 
            B.Title AS BookTitle, 
            M.FirstName + ' ' + M.LastName AS MemberName,
            L.DueDate, 
            L.ReturnDate, 
            L.Status,
            F.Amount
        FROM Fines F
        JOIN Loans L ON F.LoanID = L.LoanID
        JOIN BookCopies BC ON L.CopyID = BC.CopyID
        JOIN Books B ON BC.BookID = B.BookID
        JOIN Members M ON F.MemberID = M.MemberID
        WHERE F.Status = 'Paid'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }


        public DataTable GetUnpaidFines()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
        SELECT 
            F.FineID,
            B.Title AS BookTitle,
            M.FirstName + ' ' + M.LastName AS MemberName,
            L.DueDate,
            L.ReturnDate,
            F.Status,
            F.Amount
        FROM Fines F
        JOIN Loans L ON F.LoanID = L.LoanID
        JOIN Members M ON F.MemberID = M.MemberID
        JOIN BookCopies BC ON L.CopyID = BC.CopyID
        JOIN Books B ON BC.BookID = B.BookID
        WHERE F.Status = 'Pending'"; // this line filters unpaid

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public void DeleteFine(long fineId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Fines WHERE FineID = @FineID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FineID", fineId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void MarkFinesAsPaid(List<long> fineIds)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (long fineId in fineIds)
                {
                    string query = "UPDATE Fines SET Status = 'Paid' WHERE FineID = @fineId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fineId", fineId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public DataTable SearchAllFines(string keyword)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT F.FineID, B.Title AS BookTitle, 
               M.FirstName + ' ' + M.LastName AS MemberName,
               L.DueDate, L.ReturnDate, F.Amount, F.Status
        FROM Fines F
        JOIN Loans L ON F.LoanID = L.LoanID
        JOIN Books B ON L.CopyID = B.BookID
        JOIN Members M ON F.MemberID = M.MemberID
        WHERE LOWER(B.Title) LIKE '%' + @keyword + '%' 
           OR LOWER(M.FirstName + ' ' + M.LastName) LIKE '%' + @keyword + '%'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", keyword.ToLower());
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }


        public DataTable SearchPaidFines(string keyword)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT F.FineID, B.Title AS BookTitle, 
               M.FirstName + ' ' + M.LastName AS MemberName,
               L.DueDate, L.ReturnDate, F.Amount, F.Status
        FROM Fines F
        JOIN Loans L ON F.LoanID = L.LoanID
        JOIN Books B ON L.CopyID = B.BookID
        JOIN Members M ON F.MemberID = M.MemberID
        WHERE F.Status = 'Paid' AND 
              (LOWER(B.Title) LIKE '%' + @keyword + '%' 
              OR LOWER(M.FirstName + ' ' + M.LastName) LIKE '%' + @keyword + '%')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", keyword.ToLower());
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }


        public DataTable SearchUnpaidFines(string keyword)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT F.FineID, B.Title AS BookTitle, 
               M.FirstName + ' ' + M.LastName AS MemberName,
               L.DueDate, F.Amount
        FROM Fines F
        JOIN Loans L ON F.LoanID = L.LoanID
        JOIN Books B ON L.CopyID = B.BookID
        JOIN Members M ON F.MemberID = M.MemberID
        WHERE F.Status = 'Pending' AND 
              (LOWER(B.Title) LIKE '%' + @keyword + '%' 
              OR LOWER(M.FirstName + ' ' + M.LastName) LIKE '%' + @keyword + '%')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", keyword.ToLower());
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public void WaiveFines(List<long> fineIds, long waivedByUserId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (long fineId in fineIds)
                {
                    string query = @"
                UPDATE Fines
                SET Status = 'Waived',
                    Notes = 'Waived by UserID: ' + CAST(@UserID AS NVARCHAR),
                    PaidProcessedByUserID = @UserID,
                    PaidDate = GETDATE()
                WHERE FineID = @FineID AND Status = 'Pending'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FineID", fineId);
                        cmd.Parameters.AddWithValue("@UserID", waivedByUserId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }



        public DataTable GetWaivedFines()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT F.FineID, B.Title AS BookTitle, 
               M.FirstName + ' ' + M.LastName AS MemberName,
               L.DueDate, F.PaidDate, F.Status
        FROM Fines F
        JOIN Loans L ON F.LoanID = L.LoanID
        JOIN Books B ON L.CopyID = B.BookID
        JOIN Members M ON F.MemberID = M.MemberID
        WHERE F.Status = 'Waived'";  // Only select fines that are waived

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public void CreateReservation(long copyId, long memberId, long createdByUserId, DateTime expiryDate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            INSERT INTO Reservations (CopyID, MemberID, CreatedByUserID, ExpiryDate)
            VALUES (@CopyID, @MemberID, @CreatedByUserID, @ExpiryDate)
        ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CopyID", copyId);
                    cmd.Parameters.AddWithValue("@MemberID", memberId);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserId);
                    cmd.Parameters.AddWithValue("@ExpiryDate", expiryDate);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateBookCopyStatusToReserved(long copyId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            UPDATE BookCopies
            SET Status = 'Reserved', IsAvailable = 0
            WHERE CopyID = @CopyID
        ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CopyID", copyId);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public List<string> GetAvailableBookTitles()
        {
            List<string> bookTitles = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT DISTINCT B.Title
            FROM Books B
            JOIN BookCopies BC ON B.BookID = BC.BookID
            WHERE BC.Status IN ('Available', 'On Loan')
        ";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bookTitles.Add(reader["Title"].ToString());
                    }
                }
            }

            return bookTitles;
        }

        public (bool, DateTime?) GetCopyStatus(long copyId)
        {
            DateTime? dueDate = null;
            bool isAvailable = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT B.IsAvailable, L.DueDate 
            FROM BookCopies B
            LEFT JOIN Loans L ON B.CopyID = L.CopyID AND L.Status = 'Active'
            WHERE B.CopyID = @CopyID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CopyID", copyId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isAvailable = reader["IsAvailable"] != DBNull.Value && Convert.ToBoolean(reader["IsAvailable"]);
                            dueDate = reader["DueDate"] as DateTime?;
                        }
                    }
                }
            }

            return (isAvailable, dueDate);
        }



        public long GetBestCopyIdByBookTitle(string bookTitle)
        {
            long bestCopyId = 0;
            bool foundAvailableCopy = false;
            DateTime? earliestDueDate = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT B.CopyID, B.IsAvailable, L.DueDate
            FROM BookCopies B
            LEFT JOIN Loans L ON B.CopyID = L.CopyID AND L.Status = 'Active'
            WHERE B.BookID = (SELECT BookID FROM Books WHERE Title = @Title)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", bookTitle);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bool isAvailable = Convert.ToBoolean(reader["IsAvailable"]);
                            DateTime? dueDate = reader["DueDate"] as DateTime?;

                            if (isAvailable)
                            {
                                // Found an available copy, stop searching
                                bestCopyId = Convert.ToInt64(reader["CopyID"]);
                                foundAvailableCopy = true;
                                break;  // Found an available copy, no need to check others
                            }
                            else
                            {
                                // Track the earliest due date for unavailable copies
                                if (!foundAvailableCopy && dueDate.HasValue)
                                {
                                    if (!earliestDueDate.HasValue || dueDate.Value < earliestDueDate.Value)
                                    {
                                        bestCopyId = Convert.ToInt64(reader["CopyID"]);
                                        earliestDueDate = dueDate;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return bestCopyId;
        }



        public List<Member> GetActiveMembers()
        {
            List<Member> members = new List<Member>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MemberID, FirstName + ' ' + LastName AS FullName FROM Members WHERE Status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        members.Add(new Member
                        {
                            MemberID = Convert.ToInt64(reader["MemberID"]),
                            FullName = reader["FullName"].ToString()
                        });
                    }
                }
            }

            return members;
        }

        public DataTable GetReservationDisplayData()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT 
                R.ReservationID,
                B.Title AS BookTitle,
                (M.FirstName + ' ' + M.LastName) AS MemberName,
                R.ReservationDate,
                R.ExpiryDate,
                R.Status
            FROM Reservations R
            JOIN BookCopies BC ON R.CopyID = BC.CopyID
            JOIN Books B ON BC.BookID = B.BookID
            JOIN Members M ON R.MemberID = M.MemberID
            ORDER BY R.ReservationDate DESC
        ";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        public DataTable GetFilteredReservationsByStatus(string status)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT 
                R.ReservationID,
                B.Title AS BookTitle,
                (M.FirstName + ' ' + M.LastName) AS MemberName,
                R.ReservationDate,
                R.ExpiryDate,
                R.Status,
                R.ActionDate
            FROM Reservations R
            JOIN BookCopies BC ON R.CopyID = BC.CopyID
            JOIN Books B ON BC.BookID = B.BookID
            JOIN Members M ON R.MemberID = M.MemberID
            WHERE R.Status = @Status
            ORDER BY R.ReservationDate DESC";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Status", status);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        public void MarkReservationsAsClaimed(List<int> reservationIds, long userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (int reservationId in reservationIds)
                {
                    string query = @"
                UPDATE Reservations
                SET Status = 'Claimed',
                    ActionDate = @ActionDate,
                    ActionByUserID = @UserId
                WHERE ReservationID = @ReservationID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ActionDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void CancelReservation(int reservationID, long userID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Reservations 
                         SET Status = 'Cancelled', 
                             ActionDate = @ActionDate, 
                             ActionByUserID = @UserID 
                         WHERE ReservationID = @ReservationID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ActionDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void MarkExpiredReservations()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            UPDATE Reservations
            SET Status = 'Expired',
                ActionDate = @Today
            WHERE Status = 'Pending'
              AND CAST(ExpiryDate AS DATE) < @Today;
        ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Today", DateTime.Today);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetFilteredReservationsByStatus(string status, string keyword = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT 
                r.ReservationID,
                b.Title AS BookTitle,
                (m.FirstName + ' ' + m.LastName) AS MemberName,
                r.ReservationDate,
                r.ExpiryDate,
                r.Status,
                r.ActionDate
            FROM Reservations r
            JOIN Members m ON r.MemberID = m.MemberID
            JOIN BookCopies bc ON r.CopyID = bc.CopyID
            JOIN Books b ON bc.BookID = b.BookID
            WHERE (@status = 'All' OR r.Status = @status)";

                if (!string.IsNullOrEmpty(keyword))
                {
                    query += " AND (LOWER(b.Title) LIKE @keyword OR LOWER(m.FirstName + ' ' + m.LastName) LIKE @keyword)";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword.ToLower() + "%");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }








    }
}

// at the very bottom of DatabaseHelper.cs (outside the class)
public class BookDisplay
{
    public long BookID { get; set; }
    public string Title { get; set; }
}


public class Member
{
    public long MemberID { get; set; }
    public string FullName { get; set; }
}

