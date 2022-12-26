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
            listBox2.Items.Add(" Предмет: " + listBox1.SelectedItem.ToString());
            listBox2.Items.Add(" Факультет: " + comboBox1.Text + " Группа/подгруппа: " + comboBox2.Text + " ФИО: " + comboBox3.Text);
            listBox2.Items.Add("Информация о пересдаче: " + "Номер пересдачи: " + textBox1.Text + " Срок сдачи: " + textBox2.Text + " Признак сдачи: " + textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1) // если ни один элемент не выбран не можем удалить строку
                listBox2.Items.RemoveAt(listBox2.SelectedIndex); // Удаляем из строки выделенный элемент
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