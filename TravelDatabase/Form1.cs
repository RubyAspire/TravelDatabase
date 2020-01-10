using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace TravelDatabase
{
    public partial class Form1 : Form
    {
        String con = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Travel;Integrated Security=True";
        DataTable dt = new DataTable();
        int R = 0;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Kintoki - " + DateTime.Now.ToShortDateString();
        }
        
        private void GetData(int index)
        {

            
            txtHolidayNo.Text = dt.Rows[index][0].ToString();
             txtDestination.Text = dt.Rows[index][1].ToString();
             txtCost.Text =  dt.Rows[index][2].ToString();
             txtDepartureDate.Text = Convert.ToDateTime(dt.Rows[index][3]).ToString("dd/MM/yyyy");
             txtNoOfDays.Text = dt.Rows[index][4].ToString();
             chkAvailable.Checked = Convert.ToBoolean(dt.Rows[index][5]);
             RecordCount();
        }
        #region Pictures
        private void Pictures()
        {
            if (txtDestination.Text == "Barcelona")
            {
                picBoxBar.Show();
                picBoxDubai.Hide();
                picBoxRome.Hide();
                picBoxTokyo.Hide();
                picBoxParis.Hide();
            }
            else
            {
                picBoxBar.Hide();
            }
            if(txtDestination.Text == "Rome")
            {
                picBoxRome.Show();
                picBoxBar.Hide();
                picBoxTokyo.Hide();
                picBoxParis.Hide();
            }
            else
            {
                
                picBoxRome.Hide();
                
            }
            if (txtDestination.Text == "Tokyo")
            {
                picBoxTokyo.Show();
                picBoxBar.Hide();
                picBoxRome.Hide();
                picBoxParis.Hide();
                picBoxDubai.Hide();
            }
            else
            {
                
                picBoxTokyo.Hide();
                
            }
            if (txtDestination.Text == "Paris")
            {
                picBoxParis.Show();
                picBoxBar.Hide();
                picBoxRome.Hide();
                picBoxTokyo.Hide();
                picBoxDubai.Hide();
            }
            else
            {
               
                picBoxParis.Hide();
            }
            if (txtDestination.Text == "Dubai")
            {
                picBoxDubai.Show();
                picBoxBar.Hide();
                picBoxRome.Hide();
                picBoxTokyo.Hide();
                picBoxParis.Hide();
            }
            else
            {
                picBoxDubai.Hide();
                
            }
        }
        #endregion
        private void RecordCount()
        {
            if (R == 0)
            {
                btnFirst.Enabled = false;
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
            else if (R >= dt.Rows.Count - 1)
            {
                btnFirst.Enabled = true;
                btnPrev.Enabled = true;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                btnFirst.Enabled = true;
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
            

            txtRecordCount.Text =  R + 1 + " Of " + dt.Rows.Count;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(con))
                {
                    
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    DataTable dte = new DataTable();
                    
                    
                    string query2 = "SELECT HolidayNo, Destination, DepartureDate, FORMAT(Cost, 'C', 'af-ZA') AS Cost, CASE WHEN Available = 1 THEN 'Yes' ELSE 'No' END AS Available FROM tblHoliday";
                    SqlDataAdapter adapter = new SqlDataAdapter(query2, conn);
                    adapter.Fill(dte);
                    dataGVHoliday.DataSource = dte;
                    dataGVHoliday.CellBorderStyle = DataGridViewCellBorderStyle.None;
                    
                    dataGVHoliday.ScrollBars = ScrollBars.None;
                    dataGVHoliday.Hide();
                    string query = "SELECT HolidayNo, Destination, Cost, DepartureDate, NoOfDays, Available FROM tblHoliday";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(query, conn);
                        da.Fill(dt);
                    }

                    if (dt.Rows.Count > 0)
                    {
                        GetData(R);
                        Pictures();
                    }
                    else
                    {
                        MessageBox.Show("There Are no records in the database");
                    }
                   

                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            R = 0;
            GetData(R);
            Pictures();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            R--;
            GetData(R);
            Pictures();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            R++;
            GetData(R);
            Pictures();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            R = dt.Rows.Count - 1;
            GetData(R);
            Pictures();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dt.Reset();
            Form1_Load(null, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want exit", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(con))
                {
                    conn.Open();
                    string query = "UPDATE tblHoliday SET HolidayNo = @HolidayNo, Destination = @Destination, Cost = @Cost, DepartureDate = CONVERT(date, @DepartureDate, 103), NoOfDays = @NoOfDays, Available = @Available WHERE HolidayNo = @OldHolidayNo";
                    
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        int i;
                        if (int.TryParse(txtHolidayNo.Text, out i))
                        {
                            if (i >= 200 && i <= 1000)
                            {
                                command.Parameters.AddWithValue("@OldHolidayNo", dt.Rows[R]["HolidayNo"]);
                                command.Parameters.AddWithValue("@HolidayNo", txtHolidayNo.Text);
                                command.Parameters.AddWithValue("@Destination", txtDestination.Text);
                                command.Parameters.AddWithValue("@Cost", Convert.ToDecimal(txtCost.Text.Trim('R')));
                                command.Parameters.AddWithValue("@DepartureDate", txtDepartureDate.Text);
                                command.Parameters.AddWithValue("@NoOfDays", txtNoOfDays.Text);
                                command.Parameters.AddWithValue("@Available", chkAvailable.Checked);
                                command.ExecuteNonQuery();
                                MessageBox.Show("Updated");
                            }
                            else
                            {
                                MessageBox.Show("1: Holiday number must be in range 200 to 1000");
                            }

                        }
                    }
                    conn.Close();
                    dt.Reset();
                    Form1_Load(null, null);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(con))
                {
                    conn.Open();
                   
                    string query = "INSERT INTO tblHoliday(HolidayNo, Destination, Cost, DepartureDate, NoOfDays, Available) VALUES(@HolidayNo, @Destination, @Cost, CONVERT(date, @DepartureDate, 103), @NoOfDays, @Available)";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        
                                command.Parameters.AddWithValue("@HolidayNo", txtHolidayNo.Text);
                                command.Parameters.AddWithValue("@Destination", txtDestination.Text);
                                command.Parameters.AddWithValue("@Cost", Convert.ToDecimal(txtCost.Text.TrimStart('R')));
                                command.Parameters.AddWithValue("@DepartureDate", txtDepartureDate.Text);
                                command.Parameters.AddWithValue("@NoOfDays", txtNoOfDays.Text);
                                command.Parameters.AddWithValue("@Available", chkAvailable.Checked);
                                command.ExecuteNonQuery();
                                MessageBox.Show("Added");
                            
                            
                                
                        
                       
                    }
                    conn.Close();
                    dt.Reset();
                   
                    Form1_Load(null, null);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(con))
                {
                    conn.Open();
                    string query = "DELETE FROM tblHoliday WHERE HolidayNo = @HolidayNo";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {

                        command.Parameters.AddWithValue("@HolidayNo", txtHolidayNo.Text);
                        
                        command.ExecuteNonQuery();
                        MessageBox.Show("Deleted");
                    }
                    conn.Close();
                    dt.Reset();
                    R = 0;
                    Form1_Load(null, null);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPrvDialog1.Document = printDocument1;
            printPrvDialog1.Size = new Size(775, 460);
            printPrvDialog1.PrintPreviewControl.Zoom = 1.0;
            printPrvDialog1.StartPosition = FormStartPosition.CenterScreen;
            printPrvDialog1.ShowDialog();
        
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            string count = "Page 1"; 
            e.Graphics.DrawString(dt.Columns.ToString(), new Font("Comic Sans MS", 20, FontStyle.Regular), Brushes.Black, new Point(270, 43));
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Comic Sans MS", 12, FontStyle.Regular), Brushes.Black, new Point(350, 100));
            e.Graphics.DrawString(count, new Font("Comic Sans MS", 12, FontStyle.Regular), Brushes.Black, new Point(700, 43));

            Bitmap objBmp = new Bitmap(this.dataGVHoliday.Width, this.dataGVHoliday.Height);
            dataGVHoliday.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGVHoliday.Width, this.dataGVHoliday.Height));

            e.Graphics.DrawImage(objBmp, 50, 150);
        }
    }
}
