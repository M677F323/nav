namespace Calculator;

public partial class WrongAnswer : ContentPage
{
    public WrongAnswer()
    {
        InitializeComponent();
    }

    public async void navigateToNextQuestion(object sender, EventArgs e)
    {
        var int_num = PageNumber.pageNum + 1;
        PageNumber.setPage(int_num);
        await Navigation.PushAsync(new Questions());
    }

    public async void trySameQuestionAgain(object sender, EventArgs e)
    {
        var int_num = PageNumber.pageNum;
        PageNumber.setPage(int_num);
        await Navigation.PushAsync(new Questions());
    }
}