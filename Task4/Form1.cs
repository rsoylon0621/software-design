namespace Task4
{
    public partial class DesSort : Form
    {
        public DesSort()
        {
            InitializeComponent();
        }
        public int[] ProceduralSort(int[] numbers)
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
            return numbers;
        }

        private void btnSort_Click_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4 };
            int[] sortedNumbers = ProceduralSort(numbers);
            listBoxResults.DataSource = sortedNumbers;

        }

        private void DesSort_Load(object sender, EventArgs e)
        {

        }
    }
}
