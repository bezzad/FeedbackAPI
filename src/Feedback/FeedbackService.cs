namespace Feedback;

public class FeedbackService
{
    private readonly string _connectionString;

    public FeedbackService(string connectionString)
    {
        _connectionString = connectionString; // "Data Source=.;Persist Security Info=True;User ID=sa;Password=Admin@13;Trust Server Certificate=True"
    }

    public async Task Start()
    {
        using var context = new FeedbackContext(_connectionString);

        //creates db if not exists 
        context.Database.EnsureCreated();

        await context.SaveChangesAsync();
    }
}
