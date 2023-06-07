﻿using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using HC.Api.Dto.Identity;
using HC.DataAccess.Contracts;
using HC.Entity.Identity;

namespace HC.Api.Controllers.v2
{
    [ApiVersion("2")]
    public class RoleController : v1.RoleController
    {
        public RoleController(IRepository<Role> repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public override Task<List<RoleSelectDto>> Get(CancellationToken cancellationToken)
        {
            return base.Get(cancellationToken);
        }

        public override Task<RoleSelectDto> Get(int id, CancellationToken cancellationToken)
        {
            return base.Get(id, cancellationToken);
        }

        public override Task<RoleSelectDto> Create(RoleDto dto, CancellationToken cancellationToken)
        {
            return base.Create(dto, cancellationToken);
        }

        public override Task<RoleSelectDto> Update(int id, RoleDto dto, CancellationToken cancellationToken)
        {
            return base.Update(id, dto, cancellationToken);
        }

        public override Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            return base.Delete(id, cancellationToken);
        }
    }
}
