namespace SRV
{
    public interface IUserService
    {

        void SendValiadationEmail(string emailAddress, string validationUrlFormat);



        UserModel GetById(int id);


        bool PasswordCorrect(string rpassword, string MD5PassWord);


        UserModel GetUser(string userName);



        bool ValiadationEmail(int id, string code);
        
    }
}