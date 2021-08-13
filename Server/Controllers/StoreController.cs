using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Server.Models;
using Server.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<StoreController> _logger;
        private readonly IMapper _mapper;
        public StoreController(IUnitOfWork unitOfWork, 
            ILogger<StoreController> logger,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetStores()
        {
            try
            {
                var stores = await _unitOfWork.Stores.GetAll();
                var result = _mapper.Map<IList<StoreDTO>>(stores);
                return Ok(result);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in {nameof(GetStores)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later");
            }
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetStore(int id)
        {
            try
            {
                var store = await _unitOfWork.Stores.Get(s => s.Id == id);
                var result = _mapper.Map<StoreDTO>(store);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in {nameof(GetStore)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later");
            }
        }
    }
}
