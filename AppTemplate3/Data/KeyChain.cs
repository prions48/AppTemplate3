namespace AppTemplate3.Data
{
    /// <summary>
    /// In-app settings not needed to be abstracted to user secrets
    /// </summary>
    public static class KeyChain
    {
        public static string AppName
        {
            get
            {
                return "App Template 3";
            }
        }
        public static string AppCode
        {
            get
            {
                return "Template3";
            }
        }
        public static string OwnerEmail
        {
            get
            {
                return "prions48@gmail.com";
            }
        }
    }
    public enum Environ
    {
        MainApp
    }

}