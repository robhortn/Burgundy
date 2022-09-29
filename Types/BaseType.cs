using System;

namespace burgundy_api.Types
{
  public abstract class BaseType
  {
    public DateTime? UpdatedAt { get; set; }
    public DateTime? CreatedAt { get; set; }
    public string UpdatedBy { get; set; }
    public string CreatedBy { get; set; }
  }
}
