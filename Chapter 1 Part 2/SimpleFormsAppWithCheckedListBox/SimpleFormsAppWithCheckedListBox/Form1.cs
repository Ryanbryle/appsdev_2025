namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] movies = { "28 Days Later", "A Quiet Place: Day One", "The Conjuring", "Stranger Things", "All of Us Are Dead", "The Last of Us", "Chucky", "Reality Z", "The Order", "The Outsider", "Monster", "Parasyte: The Grey", "Don't Move", "The Autopsy of Jane Doe", "The Shining", "The Witch", "The Gorge", "Pearl", "Trap" };
            checkedListBox.Items.AddRange(movies);

            checkedListBox.CheckOnClick = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (var movies in checkedListBox.Items)
            {
                bool isSelected = checkedListBox.GetItemChecked(checkedListBox.Items.IndexOf(movies));
                if (isSelected && !listBox.Items.Contains(movies))
                {
                    listBox.Items.Add(movies);
                }
            }
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count >= 1)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }

        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
