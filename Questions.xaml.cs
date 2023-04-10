namespace Calculator;

public partial class Questions : ContentPage
{
    public int currentQuestionNumber = 0;
    public string correctOptionValue;
    public Questions()
    {
        InitializeComponent();
        getQuestionNumberFromStorage();
        getQuestionData();
    }

    public async void getQuestionNumberFromStorage()
    {
        currentQuestionNumber = PageNumber.pageNum;
    }

    public void goToNextQuestion()
    {
        ++currentQuestionNumber;
        getQuestionData();
    }

    public async void getQuestionData()
    {
        ApiService apiService = new ApiService();
        var questionData = await apiService.getExamQuestion(currentQuestionNumber);
        questionText.Text = questionData.questionText;
        optionOneBtn.Text = questionData.optionOne;
        optionTwoBtn.Text = questionData.optionTwo;
        optionThreeBtn.Text = questionData.optionThree;
        correctOptionValue = questionData.correctOptionValue;
    }

    private async void optionBtn_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string buttonValue = button.Text;
        if (buttonValue != correctOptionValue)
        {
            await Navigation.PushAsync(new WrongAnswer());
            return;
        }

        await Task.Delay(1000);
        goToNextQuestion();
        return;
    }

}