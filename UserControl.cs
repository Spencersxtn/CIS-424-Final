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

        public string CurrentUserUsername()
        {
            if (this.CurrentUser != null)
            {
                return CurrentUser.Username;
            }
            else
            {
                throw new Exception();
            }
        }

        public string CurrentUserName()
        {
            if (this.CurrentUser != null)
            {
                return CurrentUser.Name;
            }
            else
            {
                throw new Exception();
            }
        }

        public string CurrentUserRegion()
        {
            if (this.CurrentUser != null)
            {
                return CurrentUser.Region;
            }
            else
            {
                throw new Exception();
            }
        }
        #endregion
    }
}
