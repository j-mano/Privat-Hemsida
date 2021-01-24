using Backend_Processing.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Processing.Bussniess_logic.GoogleAccountStorage
{
    public class AccountValidation
    {
        public static bool ValidatAccount(string email, string gender)
        {
            bool returnValidationBool = false;

            BackendAccount DatabaseAccount = new BackendAccount();

            try
            {
                DatabaseAccount = Backend_Processing.Bussniess_logic.GoogleAccountStorage.GetAccount.LoadSpecificAccount(email);

                if (DatabaseAccount.gender == gender)
                {
                    returnValidationBool = true;
                }
            }
            catch
            {
                returnValidationBool = false; // if account dosent exist or databaseconection not estabisht = validation fail;
            }

            return returnValidationBool;
        }
    }
}
