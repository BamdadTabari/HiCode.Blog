﻿using HC.Common.Models;
using HC.Entity.Identity;
using HC.Service.Contracts;

namespace HC.Api.Controllers.v1;

public class ArticleController : BaseController
{
    private readonly IRepository<Role> _repository;

    public ArticleController(IRepository<Role> repository)
    {
        _repository = repository;
    }
}
