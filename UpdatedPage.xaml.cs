using System.Data;

namespace Calculator;

public partial class UpdatedPage : ContentPage
{
    string currentEntry = "";
    int currentState = 1;
    string mathOperator;
    double num1, num2;
    string input = "";
    string decimalFormat = "N0";


    public UpdatedPage()
    {
        InitializeComponent();
        OnClearEvent(this, null);
    }

    void OnSelectNumber(object sender, EventArgs e)
    {

        Button button = (Button)sender;
        String btnpressed = button.Text;
        if (btnpressed == "mod")
        {
            input += "%";
        }
        else if (btnpressed == "�")
        {
            input += "*";
        }
        else if (btnpressed == "�")
        {
            input += "/";
        }
        else if (btnpressed == "%")
        {
            input += ".01";
        }
        else
        {
            input += btnpressed;
        }

        resultText.Text = input;
        
    }

    void OnSelectOperator(object sender, EventArgs e)
    {
        LockNumberValue(resultText.Text);

        currentState = -2;
        Button button = (Button)sender;
        string pressed = button.Text;
        if (pressed == "mod")
        {
            mathOperator = "%";
        }
        else
        {
            mathOperator = pressed;
        }
    }

    private void LockNumberValue(string text)
    {
        double number;
        if (double.TryParse(text, out number))
        {
            if (currentState == 1)
            {
                num1 = number;
            }
            else
            {
                num2 = number;
            }


            currentEntry = string.Empty;
        }
    }

    void OnClearEvent(object sender, EventArgs e)
    {
        input = String.Empty;
        this.resultText.Text = "0";
        
        currentEntry = string.Empty;
    }

    void OnCalculate(object sender, EventArgs ev)
    {
        var dt = new DataTable();
        var temp = dt.Compute(input, "");
        this.resultText.Text = temp.ToString();

        currentState = -1;
        input = this.resultText.Text;
    }

    void OnNegative(object sender, EventArgs e)
    {
        var neg = float.Parse(input) * -1;
        this.resultText.Text = neg.ToString();
        input = this.resultText.Text;
    }

    void OnSquareroot(object sender, EventArgs e)
    {
        var num = int.Parse(input);
        var res = Math.Sqrt(num);
        this.resultText.Text = res.ToString();
        input = res.ToString();

    }
}