using Npgsql;
using TaskList.Const;
using TaskList.Entity;

namespace TaskList
{
    public partial class MainPage : ContentPage
    {
        List<TaskEntity> TaskList = new();

        NpgsqlCommand command = new();
        NpgsqlConnection con = new();

        public MainPage()
        {
            InitializeComponent();
            LoadData();
        }


        private void CreateTask_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new CreateTaskPage());
        }

        private async void LoadData()
        {
            try
            {
                con = new(ConnectionString.connectionString);
                await con.OpenAsync();
                command = new($"SELECT * FROM task", con);
                var reader = await command.ExecuteReaderAsync();
                while (reader.Read())
                {
                    TaskEntity Task = new();
                    Task.Name = (string)reader["taskname"];
                    Task.Description = (string)reader["taskdescription"];
                    TaskList.Add(Task);
                }
                await con.CloseAsync();
                //TaskListView.ItemsSource = TaskList;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}