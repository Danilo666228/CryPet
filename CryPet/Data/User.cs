using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryPet.Data
{
    public class User
    {
        public int Id { get; set; }
        public byte[] Photo { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; } = 0;

        
        public async Task<Tuple<string,string>> FillMiniProfile(int userId,string lastname,string balance)
        {
            using(ConnectDb db = new ConnectDb())
            {
                User user = await Task.Run(() => db.Users.FirstOrDefaultAsync(x => x.Id == userId));
                if (user != null)
                {
                    lastname = user.LastName;
                    balance = user.Balance.ToString();
                }
                return Tuple.Create(lastname,balance);
                
            }
        }
        public async Task<string> GetUserName(int userId)
        {
            using (ConnectDb db = new ConnectDb())
            {
                User user = await Task.Run(() => db.Users.FirstOrDefaultAsync(a => a.Id == userId));
                if(user != null)
                {
                    return user.LastName;
                }
                return null;
            }
        }
        public async Task<bool> AddUser(string lastName, string firstName, string middleName, string login, string password)
        {
            using (ConnectDb db = new ConnectDb())
            {
                User user = await Task.Run(() => db.Users.FirstOrDefaultAsync(a => a.Login == login));
                if (user != null)
                {
                    MessageBox.Show("Этот логин уже занят", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                db.Users.Add(new User()
                {
                    LastName = lastName,
                    FirstName = firstName,
                    MiddleName = middleName,
                    Login = login,
                    Password = password
                });
                await db.SaveChangesAsync();
                return true;
            }
        }
        public async Task<int?> GetUserId(string login, string password)
        {
            using (ConnectDb db = new ConnectDb())
            {
                User ExistUser = await Task.Run(() => db.Users.FirstOrDefaultAsync(a => a.Login == login && a.Password == password));
                if (ExistUser == null)
                {
                    MessageBox.Show("Неверный логин или пароль", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                return ExistUser.Id;
            }
        }
        
    }
}
