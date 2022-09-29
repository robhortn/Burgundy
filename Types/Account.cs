using System;
using burgundy_api.Interfaces;

namespace burgundy_api.Types
{
  public class Account : BaseType, IAccount
  {
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Guid Id { get; set; }
  }
}
