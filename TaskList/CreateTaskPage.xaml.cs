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
			var toast = Toast.Make("������ ������� ���������!", CommunityToolkit.Maui.Core.ToastDuration.Short, 10);
			await DisplayAlert("�������", "������ ������� �������", "��");
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
			var toast = Toast.Make("���� �� ���������!", CommunityToolkit.Maui.Core.ToastDuration.Short, 10);
            await DisplayAlert("�����", "���� �� ���������", "��");
        }
	}
}