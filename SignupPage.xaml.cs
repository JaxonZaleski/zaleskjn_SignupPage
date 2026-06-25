using Microsoft.Maui.Controls;
using System.Text.RegularExpressions;

namespace zaleskjn_SignupPage;

public partial class SignupPage : ContentPage
{
	public string username = "";
	public string email = "";
    public string password = "";
	public string confirmPass = "";

    public SignupPage()
	{
		InitializeComponent();
	}

	public void onSubmitClicked(object sender, EventArgs e)
    {
		username = entryUsername.Text;
		email = entryEmail.Text;
		password = entryPassword.Text;
		confirmPass = entryConfirm.Text;
        string emailPattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";

		if (true == true)
		{
			if (string.IsNullOrWhiteSpace(username))
			{
				errorBorder.IsVisible = true;
				errorLbl.IsVisible = true;
				errorLbl.Text = "Alert: One or more fields are empty";
				return;
			}
			if (string.IsNullOrWhiteSpace(email))
			{
				errorBorder.IsVisible = true;
				errorLbl.IsVisible = true;
				errorLbl.Text = "Alert: One or more fields are empty!";
				return;
			}
			if (string.IsNullOrWhiteSpace(password))
			{
				errorBorder.IsVisible = true;
				errorLbl.IsVisible = true;
				errorLbl.Text = "Alert: One or more fields are empty!";
				return;
			}
			if (string.IsNullOrWhiteSpace(confirmPass))
			{
				errorBorder.IsVisible = true;
				errorLbl.IsVisible = true;
				errorLbl.Text = "Alert: One or more fields are empty!";
				return;
			}
			if (!Regex.IsMatch(email, emailPattern))
			{
				errorBorder.IsVisible = true;
				errorLbl.IsVisible = true;
				errorLbl.Text = "Alert: Not a valid Email!";
				return;
			}
			if (password != confirmPass)
			{
				errorBorder.IsVisible = true;
				errorLbl.IsVisible = true;
				errorLbl.Text = "Alert: Passwords do not match!";
				return;
			}
		}

		entryUsername.Text = "";
		entryEmail.Text = "";
		entryPassword.Text = "";
		entryConfirm.Text = "";
		errorBorder.IsVisible = false;
		errorLbl.IsVisible = false;

		toProfilePage();
	}

	public async void toProfilePage()
	{
        await Shell.Current.GoToAsync("ProfilePage", new ShellNavigationQueryParameters
		{
			{ "Username", username },
			{ "UserEmail", email },
			{ "Password", password }
        });
    }
}