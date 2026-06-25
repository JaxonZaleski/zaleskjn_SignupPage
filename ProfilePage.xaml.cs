using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace zaleskjn_SignupPage;

[QueryProperty(nameof(Username), "Username")]
[QueryProperty(nameof(UserEmail), "UserEmail")]
[QueryProperty(nameof(Password), "Password")]
public partial class ProfilePage : ContentPage
{
    public string Username { get; set; }
    public string UserEmail { get; set; }
    public string Password { get; set; }

    public ProfilePage()
	{
		InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        displayAlert();
        displayAccData();
    }

    public async void displayAlert()
    {
        await DisplayAlert($"Welcome {Username}!", "You have succesfuly signed up!", "OK");
    }

    public void displayAccData()
    {
        nameLbl.Text += Username;
        emailLbl.Text += UserEmail;
    }

    public async void onSignupClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///SignupPage");
    }
}