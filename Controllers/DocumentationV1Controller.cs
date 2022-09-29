using System;
using System.Collections.Generic;
using burgundy_api.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace burgundy_api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class DocumentationV1Controller
  {
    private readonly ILogger<DocumentationV1Controller> _logger;

    public DocumentationV1Controller(ILogger<DocumentationV1Controller> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public CvDocument Get()
    {
      return new CvDocument
      {
        Id = Guid.NewGuid(),
        FirstName = "Bat",
        LastName = "Man",
        Email = "batman@superfriends.com",
        CreatedAt = new DateTime(2012, 05, 01),
        CreatedBy = "Admin",
        UpdatedBy = "Rob Horton",
        UpdatedAt = new DateTime(2022, 06, 01),
        Sections = new List<CvDocumentSection>
        {
          new()
          {
            Body = "I was awesome", Employer = "Justice League", StartDate = new DateTime(1969, 12, 11), EndDate = null, JobLocation = "Gotham City", JobTitle = "Batman", Note = "Tools used: Grappling hook, Batarang, BatMobile "
          }
        }
      };
    }
  }
}
