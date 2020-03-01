using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=LAPTOP-ENHD60TK\SQLEXPRESS;Initial Catalog=WS;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            dataGridViewPositionTOutput();
            dataGridViewEmployeeTOutput();
        }

        void dataGridViewPositionTOutput()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM PositionT", sqlCon);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                cbxPositionID.ValueMember = "PositionID";
                cbxPositionID.DisplayMember = "Position";
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "-=SELECT=-";
                dt.Rows.InsertAt(topItem, 0);
                cbxPositionID.DataSource = dt;
            }
        }

        void dataGridViewEmployeeTOutput()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM EmployeeT", sqlCon);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = dataGridView1.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("EmployeeAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    //INSERT
                    if (dgvRow.Cells["txtEmployeeID"].Value == DBNull.Value)
                    {
                        sqlCmd.Parameters.AddWithValue("@EmployeeID", 0);
                    }

                    //UPDATE
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(dgvRow.Cells["txtEmployeeID"].Value));
                    }

                    sqlCmd.Parameters.AddWithValue("@Name", dgvRow.Cells["txtName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtName"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@PositionID", Convert.ToInt32(dgvRow.Cells["cbxPositionID"].Value == DBNull.Value ? "1" : dgvRow.Cells["cbxPositionID"].Value.ToString()));
                    sqlCmd.Parameters.AddWithValue("@Office", dgvRow.Cells["txtOffice"].Value == DBNull.Value ? "" : dgvRow.Cells["txtOffice"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@Age", Convert.ToInt32(dgvRow.Cells["txtAge"].Value == DBNull.Value ? "0" : dgvRow.Cells["txtAge"].Value.ToString()));

                    sqlCmd.ExecuteNonQuery();
                    dataGridViewEmployeeTOutput();
                }
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["txtEmployeeID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("asd", "asdasd", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("EmployeeDelete", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(dataGridView1.CurrentRow.Cells["txtEmployeeID"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }

                else
                {
                    e.Cancel = true;
                }
            }

            else
            {
                e.Cancel = true;
            }
        }
    }
}
