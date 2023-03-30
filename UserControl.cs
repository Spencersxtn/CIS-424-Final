namespace CIS_424_Final
{
    public class UserControl
    {
        #region Attributes
        private UserProfile? CurrentUser { get; set; }
        #endregion

        #region Constructors
        public UserControl()
        {
            this.CurrentUser = null;
        }
        #endregion

        #region Methods
        public void LogIn(UserProfile user)
        {
            this.CurrentUser = user;
        }

        public void LogOut()
        {
            this.CurrentUser = null;
        }

        public bool UserLoggedIn()
        {
            return this.CurrentUser != null;
        }

        public string CurrentUserUsername()
        {
            if (this.UserLoggedIn())
            {
                return this.CurrentUser.Username;
            }
            else
            {
                throw new Exception();
            }
        }

        public string CurrentUserName()
        {
            if (this.UserLoggedIn())
            {
                return this.CurrentUser.Name;
            }
            else
            {
                throw new Exception();
            }
        }

        public string CurrentUserRegion()
        {
            if (this.UserLoggedIn())
            {
                return this.CurrentUser.Region;
            }
            else
            {
                throw new Exception();
            }
        }
        #endregion
    }
}
