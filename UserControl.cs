namespace CIS_424_Final
{
    public class UserControl
    {
        #region Attributes
        private UserProfile? _currentUser;
        #endregion

        #region Constructors
        public UserControl()
        {
            this._currentUser = null;
        }
        #endregion

        #region Methods
        public void LogIn(UserProfile user)
        {
            this._currentUser = user;
        }

        public void LogOut()
        {
            this._currentUser = null;
        }

        public bool UserLoggedIn()
        {
            return this._currentUser != null;
        }

        public string _currentUserUsername()
        {
            if (this.UserLoggedIn())
            {
                return this._currentUser.Username;
            }
            else
            {
                throw new Exception();
            }
        }

        public string _currentUserName()
        {
            if (this.UserLoggedIn())
            {
                return this._currentUser.Name;
            }
            else
            {
                throw new Exception();
            }
        }

        public string _currentUserRegion()
        {
            if (this.UserLoggedIn())
            {
                return this._currentUser.Region;
            }
            else
            {
                throw new Exception();
            }
        }
        #endregion
    }
}
