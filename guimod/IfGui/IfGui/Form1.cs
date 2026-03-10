namespace IfGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Logic
        {
            public static int Multiply(int firstInt, int secondInt, int thirdInt)
            {
                int[] numbers = new int[] { firstInt, secondInt, thirdInt };
                Array.Sort(numbers);
                return numbers[0] * numbers[1];
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int first = int.Parse(this.first.Text);
            int second = int.Parse(this.second.Text);
            int third = int.Parse(this.third.Text);
            int result = Logic.Multiply(first, second, third);
            MessageBox.Show("Вроде стока должно быть: " + result.ToString());
        }
    }
}
