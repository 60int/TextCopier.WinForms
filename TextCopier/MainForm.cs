namespace TextCopier
{
    enum DefectTypes
    {
        First,
        Second,
        Third,
        Fourth
    }
    public partial class MainForm : Form
    {
        public List<string> Defects1 { get; set; }
        public List<string> Defects2 { get; set; }
        public List<string> Defects3 { get; set; }
        public List<string> Defects4 { get; set; }
        public MainForm()
        {
            InitializeComponent();
            Defects1 = new List<string>()
            {
                "1. damage",
                "2. damage",
                "3. damage",
                "4. damage",
                "5. damage"
            };
            Defects2 = new List<string>()
            {
                "2. damage",
                "3. damage",
                "4. damage",
                "5. damage",
                "6. damage"
            };
            Defects3 = new List<string>()
            {
                "3. damage",
                "4. damage",
                "5. damage",
                "6. damage",
                "7. damage"
            };
            Defects4 = new List<string>()
            {
                "4. damage",
                "5. damage",
                "6. damage",
                "7. damage",
                "8. damage"
            };
            TopMost = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainListBox.Items.Clear();
            comboBox1.DataSource = Enum.GetValues(typeof(DefectTypes));
        }

        private void MainListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((DefectTypes)comboBox1.SelectedIndex)
            {
                case DefectTypes.First:
                    if (MainListBox.SelectedIndex != -1)
                    {
                        label2.Text = Defects1[MainListBox.SelectedIndex];
                        Clipboard.SetText(label2.Text);
                    }
                    break;
                case DefectTypes.Second:
                    if (MainListBox.SelectedIndex != -1)
                    {
                        label2.Text = Defects2[MainListBox.SelectedIndex];
                        Clipboard.SetText(label2.Text);
                    }
                    break;
                case DefectTypes.Third:
                    if (MainListBox.SelectedIndex != -1)
                    {
                        label2.Text = Defects3[MainListBox.SelectedIndex];
                        Clipboard.SetText(label2.Text);
                    }
                    break;
                case DefectTypes.Fourth:
                    if (MainListBox.SelectedIndex != -1)
                    {
                        label2.Text = Defects4[MainListBox.SelectedIndex];
                        Clipboard.SetText(label2.Text);
                    }
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((DefectTypes)comboBox1.SelectedIndex)
            {
                case DefectTypes.First:
                    MainListBox.DataSource = Defects1;
                    break;
                case DefectTypes.Second:
                    MainListBox.DataSource = Defects2;
                    break;
                case DefectTypes.Third:
                    MainListBox.DataSource = Defects3;
                    break;
                case DefectTypes.Fourth:
                    MainListBox.DataSource = Defects4;
                    break;
            }
        }
    }
}