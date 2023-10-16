using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PR_1 {
    public partial class Matrix_Form : Form {
        public Matrix_Form() {
            InitializeComponent();
        }

        private void Matrix_Form_Closed(object sender, EventArgs e) {
            Function_Form form = new Function_Form();
            form.Show();
        }

        private void PerformCalculation_Click(object sender, EventArgs e) {
            try {
                int i = Convert.ToInt32(i_box.Text);
                int j = Convert.ToInt32(j_box.Text);
                Matrix matrix = new Matrix(i, j);

                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();

                DataGridViewTextBoxColumn numberColumn = new DataGridViewTextBoxColumn();
                dataGridView1.Columns.Add(numberColumn);
                dataGridView1.Columns[0].HeaderText = "Бригада";

                for (int k = 0; k < j; k++) {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    dataGridView1.Columns.Add(column);
                }

                dataGridView1.RowCount = matrix.x_length;
                dataGridView1.ColumnCount = matrix.y_length + 1;
                for (int x = 0; x < matrix.x_length; x++)

                    dataGridView1.Rows[x].Cells[0].Value = (x + 1).ToString();

                for (int x = 0; x < matrix.x_length; x++)
                for (int y = 0; y < matrix.y_length; y++)
                    dataGridView1.Rows[x].Cells[y + 1].Value = matrix[x, y].ToString();


                var res = matrix.Min_;
                sum_label.Text = res.Item1.ToString();
                num_label.Text = res.Item2.ToString();

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}