
namespace TestFramework
{
    public static class Pages
    {
        public static LoginPage LoginPage
        {
            get
            {
                var loginPage = new LoginPage();
                //PageFactory
                return loginPage;
            }
        }

        public static HomePage HomePage
        {
            get
            {
                var HomePage = new HomePage();
                return HomePage;
            }
        }
    }
}
