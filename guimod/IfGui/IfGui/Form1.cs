namespace IfGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            first.Text = Properties.Settings.Default.first.ToString();
            second.Text = Properties.Settings.Default.second.ToString();
            third.Text = Properties.Settings.Default.third.ToString();
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
            int first;
            int second;
            int third;
            try
            {
                first = int.Parse(this.first.Text);
                second = int.Parse(this.second.Text);
                third = int.Parse(this.third.Text);
            }
            catch (FormatException)
            {
                return;
            }

            Properties.Settings.Default.first = first;
            Properties.Settings.Default.second = second;
            Properties.Settings.Default.third = third;
            Properties.Settings.Default.Save();
            int result = Logic.Multiply(first, second, third);
            MessageBox.Show("Вроде стока должно быть: " + result.ToString());
        }
    }
}
