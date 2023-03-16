using System.Windows.Media;

namespace BankSystem.ViewModels
{
    public class UserProfileVM
    {
        public string Name { get; set; }
        public int Balance { get; set; }

        public static ImageSource ProfilePicture { get; set; }


        public UserProfileVM()
        {
            this.Name = System.Environment.UserName;
            this.Balance = Balance;
        }

    }
}
