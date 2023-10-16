using System;
using System.Windows.Forms;

namespace PR_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Perform_Calc_Click(object sender, EventArgs e) {
            Table tab = new Table();
            double xn, xk, h, a;
            
            try {
                xn = Convert.ToDouble(this.Xn.Text);
                xk = Convert.ToDouble(this.Xk.Text);
                h = Convert.ToDouble(this.h.Text);
                a = Convert.ToDouble(this.a.Text);
            }
            catch (Exception ex) {
                MessageBox.Show("Перевірте правильність введених данних.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();

            tab.Calc(xn, xk, h, a);

            for (int i = 0; i < tab.n; i++) {
                dataGridView1.Rows.Add(Math.Round(tab.xy[i, 0], 2).ToString(),
                    Math.Round(tab.xy[i, 1], 3).ToString());
                chart1.Series[0].Points.AddXY(tab.xy[i, 0], tab.xy[i, 1]);
            }
        }
    }
}