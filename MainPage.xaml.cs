
using System.Formats.Tar;

namespace CalculatorApp;

public partial class MainPage : ContentPage
{
    double one, two;
    string mathOperator;
	public MainPage()
	{
		InitializeComponent();
	}

	private void NumberClicked(object sender, EventArgs e)
    {
        //get the number that was pressed
        Button button = (Button)sender;
        CurrentCalculation.Text += button.Text; 
    }
    private void OperatorClicked(object sender, EventArgs e)
    {
        //get the operator that was pressed
        Button button = (Button)sender;
        mathOperator = button.Text;
        //store the first number
        one = Convert.ToDouble(CurrentCalculation.Text);
        //display that expression in the result label
        ResultCalculation.Text = CurrentCalculation.Text + " "+mathOperator + " ";
        //clear the current label
        CurrentCalculation.Text = "";
    }
    private void EqualClicked(object sender, EventArgs e)
    {
        if(mathOperator == null)
        {
            ResultCalculation.Text = "";
        }
        //store the second num
        two = Convert.ToDouble(CurrentCalculation.Text);
        CurrentCalculation.Text = "";
        ResultCalculation.Text += two;
        ResultCalculation.Text += " = ";
        switch(mathOperator)
        {
            case "+":
                ResultCalculation.Text += Convert.ToString(one + two);
                break;
            case "-":
                ResultCalculation.Text += Convert.ToString(one - two);
                break;
            case "*":
                ResultCalculation.Text += Convert.ToString(one * two);
                break;
            case "/":
                ResultCalculation.Text += Convert.ToString(one / two);
                break;
        }
        mathOperator = null;
    }
    private void DecimalClicked(object sender, EventArgs e)
    {
        CurrentCalculation.Text += ".";
    }
    private void PercentageClicked(object sender, EventArgs e)
    {
        if (mathOperator != null)
        {
            two = Convert.ToDouble(CurrentCalculation.Text);
            CurrentCalculation.Text = "";
            ResultCalculation.Text += two;
            ResultCalculation.Text += "% = ";
            two /= 100;
            two = Math.Round(one * two,2);
            switch (mathOperator)
            {
                case "+":
                    ResultCalculation.Text += one + two;
                    break;
                case "-":
                    ResultCalculation.Text += one - two;
                    break;
                case "*":
                    ResultCalculation.Text += two;
                    break;
            }
        }
        mathOperator= null;
    }
    private void PosNegClicked(object sender, EventArgs e)
    {
        //change the sign of the number by multipling by one
        double temp = Convert.ToDouble(CurrentCalculation.Text);
        temp *= -1;
        CurrentCalculation.Text = temp.ToString();
    }    
    private void ClearClicked(object sender, EventArgs e)
    {
        CurrentCalculation.Text = "";
        ResultCalculation.Text = "";
        mathOperator= null;
        one = 0;
        two = 0;
    }
}

