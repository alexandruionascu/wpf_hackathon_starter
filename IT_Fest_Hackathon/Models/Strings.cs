using System.IO;
using System.Reflection;

namespace IT_Fest_Hackathon.Models
{
    public static class Strings
    {
        public static string AssemblyTitle
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    var titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }

                return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }
        public static string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
        public static string AssemblyDescription
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "No description";
                }

                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }
        public static string AssemblyProduct
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }

                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }
        public static string AssemblyCopyright
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "No copyright";
                }

                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }
        public static string AssemblyCompany
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "No company";
                }

                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        // Login form.
        public static string authenticationFailed { get { return "Invalid username or password."; } }
        public static string authentificationSucceded { get { return "Connection succeded."; } }

        // Management
        public static string sameUserPass { get { return "The username and the password are the same."; } }
        public static string invalidData { get { return "Invalid data."; } }
        public static string takenUsername { get { return "The username is already taken. Please try again."; } }
        public static string samePasswords { get { return "The old password and the new one are the same."; } }
        public static string differentPasswords { get { return "The passwords are not the same."; } }
        public static string updateError { get { return "Could not save your changes."; } }
        public static string addNewUserError { get { return "Could not add a new user."; } }
        public static string DeleteConfirmation { get { return "Are you sure that you want to delete this?"; } }
        public static string DeleteSucces { get { return "The deletion was performed succesfully."; } }
        public static string ConfirmationTitle { get { return "Confirmation"; } }

    }
}
