using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MosqueManagement.Core.Interfaces;
using MosqueManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MosqueManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController:MosqueManagementController
    {
        private readonly IUnitOfWork _unitOfWork;

        public MemberController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET api/Members
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IEnumerable<Member>> Get()
        {
            return await _unitOfWork.Members.GetAllMembersAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }
}
