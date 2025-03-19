namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] cuisineGenre = { "Filipino", "Chinese", "German", "Italian" };
            comboBox1.Items.AddRange(cuisineGenre);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] filipinoCuisineList = { "Pancit Canton", "Nilat-ang Baka", "Nguyong", "Fried Siomai", "Pritong Aso" };
            string[] chineseCuisineList = { "Udon", "Shandong", "Sichuan", "Cantonese" };
            string[] germanCuisineList = { "Schnitzel", "Currywurst", "Bratwurst" };
            string[] italianCuisineList = { "Pasta", "Pizza", "Risotto", "Tiramisu" };

            checkedListBox1.Items.Clear();

            if (comboBox1.SelectedItem.ToString().Contains("Filipino"))
            {
                checkedListBox1.Items.AddRange(filipinoCuisineList);
            }
            else if
               (comboBox1.SelectedItem.ToString().Contains("Chinese"))
            {
                checkedListBox1.Items.AddRange(chineseCuisineList);
            }
            else if
               (comboBox1.SelectedItem.ToString().Contains("German"))
            {
                checkedListBox1.Items.AddRange(germanCuisineList);
            }
            else if
               (comboBox1.SelectedItem.ToString().Contains("Italian"))
            {
                checkedListBox1.Items.AddRange(italianCuisineList);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.Items)
            {
                bool isSelected = checkedListBox1.GetItemChecked(checkedListBox1.Items.IndexOf(item));
                if (isSelected && !listBox1.Items.Contains(item))
                {
                    listBox1.Items.Add(item);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 1)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
