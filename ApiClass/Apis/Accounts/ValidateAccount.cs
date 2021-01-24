using LvlApiClass.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LvlApiClass.Apis.Accounts
{
    public class ValidateAccount
    {
        public static bool ValidateAccountApi(string email, string gender)
        {
            bool returnValidationBool;

            returnValidationBool = Backend_Processing.Bussniess_logic.GoogleAccountStorage.AccountValidation.ValidatAccount(email, gender);

            return returnValidationBool;
        }
    }
}
