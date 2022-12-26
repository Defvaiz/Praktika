namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(" �������: " + listBox1.SelectedItem.ToString());
            listBox2.Items.Add(" ���������: " + comboBox1.Text + " ������/���������: " + comboBox2.Text + " ���: " + comboBox3.Text);
            listBox2.Items.Add("���������� � ���������: " + "����� ���������: " + textBox1.Text + " ���� �����: " + textBox2.Text + " ������� �����: " + textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1) // ���� �� ���� ������� �� ������ �� ����� ������� ������
                listBox2.Items.RemoveAt(listBox2.SelectedIndex); // ������� �� ������ ���������� �������
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > 0)
            {
                int index = listBox2.SelectedIndex;
                String text = listBox2.SelectedItem.ToString();
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                listBox2.Items.Insert(index - 1, text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex < listBox2.Items.Count)
            {
                int index = listBox2.SelectedIndex;
                String text = listBox2.SelectedItem.ToString();
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                listBox2.Items.Insert(index + 1, text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string nomer = textBox1.Text;
            string srok = textBox2.Text;
            string priznak = textBox3.Text;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    writer.WriteLine((string)listBox2.Items[i]);
                }
                writer.Close();
            }
            dlg.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}