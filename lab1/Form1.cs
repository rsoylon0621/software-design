namespace lab1
{
    public partial class AsSort : Form
    {
        public AsSort()
        {
            InitializeComponent();
        }
        public int[] ProceduralSort(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4 };
            int[] sortedNumbers = ProceduralSort(numbers);
            listBoxResults.DataSource = sortedNumbers;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
