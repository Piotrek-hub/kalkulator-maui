namespace MauiApp1;

public partial class MainPage : ContentPage
{
	string mathOperator= "";

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnClear(object sender, EventArgs e)
	{
		input.Text = null;
		this.mathOperator = "";
    }

	private void OnSelectNumber(object sender, EventArgs e)
	{
        Button button = (Button)sender;
        string buttonValue = button.Text;

		input.Text += buttonValue;
    }

	private void OnSelectOperator(object sender, EventArgs e)
	{
		Button button = (Button)sender;
		string buttonValue = button.Text;
		
		if(this.input.Text != null && this.mathOperator == "")
		{
            this.mathOperator = buttonValue;
            input.Text += mathOperator;
        }

    }

	private void OnCalculate(object sender, EventArgs e)
	{
        string result = "ESSA";

        if (this.input.Text != null)
		{
            Int64 firstNumber = Int64.Parse(input.Text.Split(this.mathOperator)[0]);
            Int64 secondNumber = Int64.Parse(input.Text.Split(this.mathOperator)[1]);
            switch (this.mathOperator)
            {
                case "+":
                    result = (firstNumber + secondNumber).ToString();
                    break;
				case "-":
					result = (firstNumber - secondNumber).ToString();
					break;
				case "×":
					result = (firstNumber * secondNumber).ToString();
					break;
                case "÷":
                    result = (firstNumber / secondNumber).ToString();
                    break;
                case "%":
                    result = (firstNumber % secondNumber).ToString();
                    break;

                default: break;
            }
        }
		this.mathOperator = "";
		this.input.Text = result;
	}

	private void OnSignChange(object sender, EventArgs e)
	{
		if(this.input.Text != null)
		{
			if()
			Int64 tmp = Int64.Parse(this.input.Text);
			tmp *= -1;
			this.input.Text = tmp.ToString();
		}
	}
}

