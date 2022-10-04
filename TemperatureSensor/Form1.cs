using static System.String;
using static TemperatureConverter.Models.CalculationMethods;

namespace TemperatureConverter.GUI;

/// <summary>
/// This class contains the GUI for the temperature converter.
/// </summary>

public partial class Form1 : Form
{
    /// <summary>
    /// This Method is the Constructor for the Form1.
    /// </summary>
    public Form1()
    {
        InitializeComponent();
    }

    

    /// <summary>
    /// The radioButton1_CheckedChanged method.
    /// </summary>
    /// <remarks>
    /// When the Value of the RadioButton 1 change this Method is called and the Value of the TextBox1 is converted to Celsius.
    /// </remarks>
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



    
    /// <summary>
    /// The radioButton2_CheckedChanged method.
    /// </summary>
    /// <remarks>
    /// When the Value of the RadioButton 2 change this Method is called and the Value of the TextBox1 is converted to Fahrenheit.
    /// </remarks>
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



    
    /// <summary>
    /// The radioButton3_CheckedChanged method.
    /// </summary>
    /// <remarks>
    /// When the Value of the RadioButton 3 change this Method is called and the Value of the TextBox1 is converted to Kelvin.
    /// </remarks>
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




    
    /// <summary>
    /// The radioButton3_CheckedChanged method.
    /// </summary>
    /// <remarks>
    /// When the Value of the RadioButton 4 change this Method is called and the Value of the TextBox1 is converted to Celsius.
    /// </remarks>
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



    
    /// <summary>
    /// The radioButton1_CheckedChanged method.
    /// </summary>
    /// <remarks>
    ///  When you click on the Button Clear all Values of the GUI are cleared.
    /// </remarks>
    private void ClearAllValues(object sender, EventArgs e)
    {
        ClearAll();
    }



    
    /// <summary>
    /// The radioButton1_CheckedChanged method.
    /// </summary>
    /// <remarks>
    /// This Method is called when you call the ClearAllValues Method.
    /// </remarks>
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



    
    /// <summary>
    /// The radioButton1_CheckedChanged method.
    /// </summary>
    /// <remarks>
    /// When you click on the Button Exit the Application is closed.
    /// </remarks>
    private void CloseButton(object sender, EventArgs e)
    {
        Close();
    }
}