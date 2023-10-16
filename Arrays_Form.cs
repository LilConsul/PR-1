using System;
using System.Windows.Forms;

namespace PR_1 {
    public partial class Arrays_Form : Form {
        public Arrays_Form() {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void Arrays_Form_Closed(object sender, EventArgs e) {
            Function_Form form = new Function_Form();
            form.Show();
        }

        private void PerformCalculation_Click(object sender, EventArgs e) {
            dataGridView1.Rows.Clear();
            try {
                int n = Convert.ToInt32(sizeBox.Text);
                Array a = new Array(n);
                for (int i = 0; i < a.Length; i++) {
                    dataGridView1.Rows.Add(a[i].ToString());
                }
                
                MinField.Text = a.Min.ToString();
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}