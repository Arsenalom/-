namespace laba_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dateTimePickerBirthDate.MaxDate = DateTime.Now;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            DateTime birthDate = dateTimePickerBirthDate.Value;
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.Month < birthDate.Month || (DateTime.Now.Month == birthDate.Month && DateTime.Now.Day < birthDate.Day))
            {
                age--;
            }
            labelAge.Text = $"Возраст:{age}";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBoxTemp.Text = TrackBarTemp.Value.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal radius = numericUpDown1.Value;
            double area = 4 * Math.PI * Math.Pow((double)radius, 2);
            double perimeter = 2 * Math.PI * (double)radius;
            labelPlohad.Text = $"Площадь: {Math.Round(area, 2)}";
            labelPerimetr.Text = $"Периметр: {Math.Round(perimeter, 2)}";
        }
    }
}
