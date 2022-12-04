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
        string result = "";

        if (this.input.Text != null)
		{
            Double firstNumber = Double.Parse(input.Text.Split(this.mathOperator)[0]);
            Double secondNumber = Double.Parse(input.Text.Split(this.mathOperator)[1]);
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
					if(secondNumber != 0)
					{
                        result = (firstNumber / secondNumber).ToString();
                    }
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
			Int64 tmp = Int64.Parse(this.input.Text);
			tmp *= -1;
			this.input.Text = tmp.ToString();
		}
	}
}

// <Button Text = "+/-" Grid.Row="1" Grid.Column="1" FontSize="Large" TextColor="White" Background="#2196F3"
//             Clicked="OnSignChange"/>