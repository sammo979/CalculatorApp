namespace CalculatorApp;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void ZeroClicked(object sender, EventArgs e)
    {
        CurrentCalculation.Text += "0"; 
    }
    private void OneClicked(object sender, EventArgs e)
	{
        CurrentCalculation.Text += "1";
    }
    private void TwoClicked(object sender, EventArgs e)
    {
        CurrentCalculation.Text += "2";
    }
    private void ThreeClicked(object sender, EventArgs e)
    {
        CurrentCalculation.Text += "3";
    }
    private void FourClicked(object sender, EventArgs e)
    {
        CurrentCalculation.Text += "4";
    }
    private void FiveClicked(object sender, EventArgs e)
    {
        CurrentCalculation.Text += "5";
    }
    private void SixClicked(object sender, EventArgs e)
    {
        CurrentCalculation.Text += "6";
    }
    private void SevenClicked(object sender, EventArgs e)
    {
        CurrentCalculation.Text += "7";
    }
    private void EightClicked(object sender, EventArgs e)
    {
        CurrentCalculation.Text += "8";
    }
    private void NineClicked(object sender, EventArgs e)
    {
        CurrentCalculation.Text += "9";
    }
    private void ClearClicked(object sender, EventArgs e)
    {

    }
    private void PosNegClicked(object sender, EventArgs e)
    {

    }
    private void PercentageClicked(object sender, EventArgs e)
    {

    }
    private void DivideClicked(object sender, EventArgs e)
    {

    }
    private void MultiplyClicked(object sender, EventArgs e)
    {

    }
    private void PlusClicked(object sender, EventArgs e)
    {

    }
    private void MinusClicked(object sender, EventArgs e)
    {

    }
    private void EqualClicked(object sender, EventArgs e)
    {

    }
    private void DecimalClicked(object sender, EventArgs e)
    {

    }
   
}

