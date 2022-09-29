using System;
using System.Collections.Generic;

namespace burgundy_api.Types
{
  public class CvDocument : BaseType
  {
    public CvDocument()
    {
      Sections = new List<CvDocumentSection>();
    }

    public Guid? Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public IEnumerable<CvDocumentSection> Sections { get; set; }
  }

  public class CvDocumentSection
  {
    public string Employer { get; set; }
    public string JobTitle { get; set; }
    public string JobLocation { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Body { get; set; }
    public string Note { get; set; }
  }
}
