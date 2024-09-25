namespace FarenheitToCelcius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double numberIn = Convert.ToDouble(textBox1.Text);
                double numberOut = 0;

                // текущие параметры конвертирования
                string param1 = domainUpDown2.Text; // Исходная единица
                string param2 = domainUpDown1.Text; // Целевая единица

                // Конвертация из Фаренгейтов в Цельсии
                if (param1 == "F" && param2 == "C")
                {
                    numberOut = (numberIn - 32) * 5 / 9;
                }
                // Конвертация из Цельсиев в Фаренгейты
                else if (param1 == "C" && param2 == "F")
                {
                    numberOut = (numberIn * 9 / 5) + 32;
                }
                else
                {
                    numberOut = numberIn; // Если выбран одинаковый формат, просто копируем значение
                }

                textBox2.Text = Convert.ToString(numberOut);
            }
            catch
            {
                MessageBox.Show("Некорректный ввод");
            }

        }
    }
}
