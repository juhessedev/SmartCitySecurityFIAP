using NUnit.Framework;
using System;
using System.Windows.Forms;

namespace Simple_Login_FORM.Tests
{
    [TestFixture]
    public class LoginFormTests
    {
        private LoginForm _loginForm;

        [SetUp]
        public void Setup()
        {
            _loginForm = new LoginForm();
        }

        [Test]
        public void LoginButton_Click_WithEmptyUsername_ShouldShowErrorMessage()
        {
            // Arrange
            _loginForm.UsernameBox.Text = "";
            _loginForm.PasswordBox.Text = "password";

            // Act
            _loginForm.LoginButton.PerformClick();

            // Assert
            Assert.AreEqual("O campo nome de usuário é obrigatório.", _loginForm.LastMessage);
        }

        [Test]
        public void LoginButton_Click_WithEmptyPassword_ShouldShowErrorMessage()
        {
            // Arrange
            _loginForm.UsernameBox.Text = "username";
            _loginForm.PasswordBox.Text = "";

            // Act
            _loginForm.LoginButton.PerformClick();

            // Assert
            Assert.AreEqual("O campo senha é obrigatório.", _loginForm.LastMessage);
        }

        [Test]
        public void LoginButton_Click_WithValidCredentials_ShouldShowSuccessMessage()
        {
            // Arrange
            _loginForm.UsernameBox.Text = "username";
            _loginForm.PasswordBox.Text = "password";

            // Act
            _loginForm.LoginButton.PerformClick();

            // Assert
            Assert.AreEqual("Login realizado com sucesso!", _loginForm.LastMessage);
        }
    }
}
