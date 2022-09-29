using System;
using burgundy_api.Types;

namespace burgundy_api.Directors
{
  public interface IAccountDirector
  {
    Account GetAccountById(Guid accountId);
  }
}