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

                // ������� ��������� ���������������
                string param1 = domainUpDown2.Text; // �������� �������
                string param2 = domainUpDown1.Text; // ������� �������

                // ����������� �� ����������� � �������
                if (param1 == "F" && param2 == "C")
                {
                    numberOut = (numberIn - 32) * 5 / 9;
                }
                // ����������� �� �������� � ����������
                else if (param1 == "C" && param2 == "F")
                {
                    numberOut = (numberIn * 9 / 5) + 32;
                }
                else
                {
                    numberOut = numberIn; // ���� ������ ���������� ������, ������ �������� ��������
                }

                textBox2.Text = Convert.ToString(numberOut);
            }
            catch
            {
                MessageBox.Show("������������ ����");
            }

        }
    }
}
