using static System.String;
using static CalculationTemperature.CalculationMethods;

namespace TemperatureConverter.GUI;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    public void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        if (IsNullOrEmpty(textBox1.Text))
        {
            ClearAll();
            return;
        }
        if (CelsiusToFahrenheit(Convert.ToDouble(textBox1.Text)) < -459.67)
        {
            MessageBox.Show("Temperature cannot be lower than -459.67 °F");
            ClearAll();
        }
        else
        {
            label2.Text = "°C";
            label3.Text = CelsiusToFahrenheit(Convert.ToDouble(textBox1.Text)).ToString();
            label4.Text = "°F";
        }
    }

    public void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
        if (IsNullOrEmpty(textBox1.Text))
        {
            ClearAll();
            return;
        }
        if (FahrenheitToCelsius(Convert.ToDouble(textBox1.Text)) < -273.15)
        {
            MessageBox.Show("Temperature cannot be lower than -273.15 °C");
            ClearAll();
        }
        else
        {
            label2.Text = "°F";
            label3.Text = FahrenheitToCelsius(Convert.ToDouble(textBox1.Text)).ToString();
            label4.Text = "°C";
        }

    }

    public void radioButton3_CheckedChanged(object sender, EventArgs e)
    {
        //Validation for Kelvin
        if (IsNullOrEmpty(textBox1.Text))
        {
            ClearAll();
            return;
        }
        if (CelsiusToKelvin(Convert.ToDouble(textBox1.Text)) <= 0)
        {
            MessageBox.Show("Temperature cannot be lower than 0 °K");
            ClearAll();
        }
        else
        {
            label2.Text = "°C";
            label3.Text = CelsiusToKelvin(Convert.ToDouble(textBox1.Text)).ToString();
            label4.Text = "°K";
        }
    }

    public void radioButton4_CheckedChanged(object sender, EventArgs e)
    {
        if (IsNullOrEmpty(textBox1.Text))
        {
            ClearAll();
            return;
        }
        if (KelvinToCelsius(Convert.ToDouble(textBox1.Text)) <= -273.15)
        {
            MessageBox.Show("Temperature cannot be lower than -273.15 °C");
            ClearAll();
        }
        else
        {
            label2.Text = "°K";
            label3.Text = KelvinToCelsius(Convert.ToDouble(textBox1.Text)).ToString();
            label4.Text = "°C";
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        ClearAll();
    }

    private void ClearAll()
    {
        textBox1.Clear();
        radioButton1.Checked = false;
        radioButton2.Checked = false;
        radioButton3.Checked = false;
        radioButton4.Checked = false;
        label2.Text = "";
        label3.Text = "";
        label4.Text = "";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Close();
    }
}