using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePurrfectPaw.API.Models.Request;
using ThePurrfectPaw.API.Models.Response;
using ThePurrfectPaw.API.Services;

namespace ThePurrfectPaw.API.Controllers
{
    [Route("api/v1/postings")]
    [ApiController]
    public class PostingsController : ControllerBase
    {
        private readonly IPostingsService _postingsService;
        private readonly IMapper _mapper;

        public PostingsController( IPostingsService postingsService, IMapper mapper )
        {
            _postingsService = postingsService ?? throw new ArgumentNullException(nameof(postingsService));
            _mapper = mapper ?? throw new ArgumentNullException( nameof( mapper ) );
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<PostingDto>>> GetPostings( [FromQuery] PostingsResourceParameters parameters )
        {
            var postings = await _postingsService.GetAll( parameters );

            return Ok( _mapper.Map<IEnumerable<PostingDto>>( postings ) );
        }

        [HttpGet("{postingId}")]
        public async Task<ActionResult<PostingDto>> GetPosting(int postingId)
        {
            var posting = await _postingsService.GetPosting( postingId );

            if (posting == null)
            {
                return NotFound();
            }

            return Ok( _mapper.Map<PostingDto>(posting) );
        }
    }
}
