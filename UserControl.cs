namespace CIS_424_Final
{
    public class UserControl
    {
        #region Attributes
        public UserProfile? currentUser { get; private set; }
        #endregion

        #region Constructors
        public UserControl()
        {
            this.currentUser = null;
        }
        #endregion

        #region Methods
        public void LogIn(UserProfile user)
        {
            this.currentUser = user;
        }

        public void LogOut()
        {
            this.currentUser = null;
        }
        #endregion
    }
}
