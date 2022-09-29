using burgundy_api.Directors;
using burgundy_api.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace burgundy_api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class AccountV1Controller
  {
    private readonly ILogger<AccountV1Controller> _logger;
    private readonly IAccountDirector _accountDirector;

    public AccountV1Controller(ILogger<AccountV1Controller> logger, IAccountDirector accountDirector)
    {
      _logger = logger;
      _accountDirector = accountDirector;
    }

    [HttpGet]
    public Account Get(Guid accountId)
    {
      return _accountDirector.GetAccountById(accountId);
    }
  }
}
