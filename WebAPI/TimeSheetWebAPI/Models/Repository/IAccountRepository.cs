using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetWebAPI.Models.Repository
{
    public interface IAccountRepository
    {
        string GetUserName(string FirstName, string LastName);
    }
}
