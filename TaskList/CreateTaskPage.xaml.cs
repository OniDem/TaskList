using CommunityToolkit.Maui.Alerts;
using TaskList.Entity;

namespace TaskList;

public partial class CreateTaskPage : ContentPage
{
	List<TaskEntity> Tasks = new();
	public CreateTaskPage()
	{
		InitializeComponent();
	}

	private async void Save_Clicked(object sender, EventArgs e)
	{
		if (TaskName.Text != "" && TaskDescription.Text != "")
		{
			var toast = Toast.Make("Задача успешно добавлена!", CommunityToolkit.Maui.Core.ToastDuration.Short, 10);
			await DisplayAlert("Успешно", "Задача успешно создана", "ОК");
            await Navigation.PopModalAsync();
			TaskEntity newTask = new()
			{
				Name = TaskName.Text,
				Description = TaskDescription.Text,
			};
			Tasks.Add(newTask);
        }
		else
		{
			var toast = Toast.Make("Поля не заполнены!", CommunityToolkit.Maui.Core.ToastDuration.Short, 10);
            await DisplayAlert("Пусто", "Поля не заполнены", "ОК");
        }
	}
}