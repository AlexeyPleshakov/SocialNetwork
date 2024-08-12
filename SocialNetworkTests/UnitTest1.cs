using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System.ComponentModel.DataAnnotations;

namespace SocialNetworkTests
{
    [TestFixture]
    public class Tests
    {
        UserService _userService;
        UserRegistrationData _registrationData;
        UserAuthenticationData _authenticationData;
        [Test]
        // Тест проходит с заданными данными однократно, повторный запуск
        // приведет к исключению из-за уже существующего email в базе(так и должно по идее)
        public void MustBeRegistrateUser()
        {
            _userService = new UserService();
            _registrationData = new UserRegistrationData();
            _registrationData.FirstName = "Test";
            _registrationData.LastName = "Test";
            _registrationData.Email = "email2@gmail.com";
            _registrationData.Password = "password";
            _userService.Register(_registrationData);
        }
        [Test]
        public void MustBeLogInUser()
        {
            _userService = new UserService();
            _authenticationData = new UserAuthenticationData();
            _authenticationData.Email = "email@gmail.com";
            _authenticationData.Password = "password";
            _userService.Authenticate(_authenticationData);
        }
    }
}