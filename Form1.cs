namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Butun xanalari doldurun!");
                return;
            }

            dataGridView1.Rows.Add(
                textBox1.Text,
                textBox2.Text,

          dateTimePicker1.Value.ToString("dd.MM.yyyy"),
                          false
                        );
            textBox1.Clear();
            textBox2.Clear();
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)

            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3) 
            {
                bool secilib = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[3].Value);

                if (secilib) 
                {
                    DialogResult cavab = MessageBox.Show("Bu tapsirigi silmek isteyirsinizmi?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cavab == DialogResult.Yes) 
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }

                    else 
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[3].Value = false;
                    }
                }
            }
        }
    }
}
