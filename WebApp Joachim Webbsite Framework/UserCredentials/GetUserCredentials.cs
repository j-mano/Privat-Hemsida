using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_Joachim_Webbsite_Framework.Models;

namespace WebApp_Joachim_Webbsite_Framework.UserCredentials
{
    public class GetUserCredentials
    {
        private static CredentialModell Storage = new CredentialModell();

        public static CredentialModell GetUserLoginstatus()
        {
            return Storage;
        }

        internal static void setLoginstatus(CredentialModell InputStorage)
        {
            Storage = InputStorage;

            try
            {
                string firstname = InputStorage.fName;
                string Lasttname = InputStorage.lName;

                Storage.username = firstname.Substring(0, 3);
                Storage.logdin = true;

                isAdmin(InputStorage);
            }
            catch(InvalidCastException e)
            {
                throw;
            }
        }

        private static void isAdmin(CredentialModell InputStorage)
        {
            bool databaseValidated = LvlApiClass.Apis.Accounts.ValidateAccount.ValidateAccountApi(InputStorage.email, InputStorage.gender);

            if (databaseValidated)
            {
                Storage.isAdmin = true;
            }
            else
            {
                Storage.isAdmin = false;
            }
        }

        internal static void LogOut()
        {
            Storage = new CredentialModell();
        }
    }
}