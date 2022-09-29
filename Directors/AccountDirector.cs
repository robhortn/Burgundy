using System;
using burgundy_api.Directors;
using burgundy_api.Types;

namespace burgundy_api.Interfaces
{
  public class AccountDirector : IAccountDirector
  {
    public Account GetAccountById(Guid accountId)
    {
      return new Account
      {
        Id = accountId,
        FirstName = "Bat",
        LastName = "Man",
        UserName = "ImBatMan",
        CreatedAt = new DateTime(2022, 06, 01),
        CreatedBy = "Admin",
        UpdatedBy = "Rob Horton",
        UpdatedAt = new DateTime(2022, 06, 09)
      };
    }
  }
}
