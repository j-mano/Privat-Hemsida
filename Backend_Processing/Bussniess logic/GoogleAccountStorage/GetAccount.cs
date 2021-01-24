using Backend_Processing.DataAcess;
using Backend_Processing.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Processing.Bussniess_logic.GoogleAccountStorage
{
    internal class GetAccount
    {
        public static BackendAccount LoadSpecificAccount(string Email)
        {
            string sqlQuestion = @"select AcountAdress, gender, isAdmin from dbo.projects where AcountAdress = @Email"; // The Sql question for getting all projects

            // todo: Check if sql question is a bvalid sql question as expecteed.

            List<BackendAccount> lists = new List<BackendAccount>();
            BackendAccount chosenAccount = new BackendAccount();

            try
            {
                lists = SqlDataAcess.asyncLoadData<BackendAccount>(sqlQuestion);

                foreach (var Account in lists)
                {
                    chosenAccount.isAdmin = Account.isAdmin;
                    chosenAccount.gender = Account.gender;
                    chosenAccount.AcountAdress = Account.AcountAdress;
                }
            }
            catch
            {
                throw;
            }

            return chosenAccount;
        }
    }
}
