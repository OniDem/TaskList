using TaskList.Entity;

namespace TaskList
{
    public partial class MainPage : ContentPage
    {
        List<TaskEntity> TaskList = new()
        {
            new TaskEntity
            {
                Name = "Помыть посуду",
                Description = "Посуду помыть",
            },
            new TaskEntity
            {
                Name = "Почистить картошку",
                Description = "Картошку почистить",
            },
            new TaskEntity
            {
                Name = "Подмести пол",
                Description = "Пол подмести",
            },
            new TaskEntity
            {
                Name = "Помыть посуду",
                Description = "Посуду помыть",
            },
            new TaskEntity
            {
                Name = "Почистить картошку",
                Description = "Картошку почистить",
            },
            new TaskEntity
            {
                Name = "Подмести пол",
                Description = "Пол подмести",
            },
            new TaskEntity
            {
                Name = "Помыть посуду",
                Description = "Посуду помыть",
            },
            new TaskEntity
            {
                Name = "Почистить картошку",
                Description = "Картошку почистить",
            },
            new TaskEntity
            {
                Name = "Подмести пол",
                Description = "Пол подмести",
            },
            new TaskEntity
            {
                Name = "Помыть посуду",
                Description = "Посуду помыть",
            },
            new TaskEntity
            {
                Name = "Почистить картошку",
                Description = "Картошку почистить",
            },
            new TaskEntity
            {
                Name = "Подмести пол",
                Description = "Пол подмести",
            }
    };

        public MainPage()
        {
            InitializeComponent();
            TaskListView.ItemsSource = TaskList;
        }


        private void CreateTask_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new CreateTaskPage());
        }
    }
}