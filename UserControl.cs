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

        public string CurrentUserUsername()
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

        public string CurrentUserName()
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

        public string CurrentUserRegion()
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

        public void UpdateUserPassword(string password)
        {
            if (this.UserLoggedIn())
            {
                this._currentUser.Password = password;
                this._currentUser.UpdatePassword(Program.JsonPath, password);
            }
            else
            {
                throw new Exception();
            }
        }

        public void UpdateUserName(string name)
        {
            if (this.UserLoggedIn())
            {
                this._currentUser.Name = name;
                this._currentUser.UpdatePassword(Program.JsonPath, name);
            }
            else
            {
                throw new Exception();
            }
        }

        public void UpdateUserRegion(string region)
        {
            if (this.UserLoggedIn())
            {
                this._currentUser.Region = region;
                this._currentUser.UpdatePassword(Program.JsonPath, region);
            }
            else
            {
                throw new Exception();
            }
        }
        #endregion
    }
}
