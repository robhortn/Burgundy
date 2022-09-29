using System;

namespace burgundy_api.Interfaces
{
  public interface IAccount
  {
    string UserName { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    Guid Id { get; set; }
    DateTime? UpdatedAt { get; set; }
    DateTime? CreatedAt { get; set; }
    string UpdatedBy { get; set; }
    string CreatedBy { get; set; }
  }
}