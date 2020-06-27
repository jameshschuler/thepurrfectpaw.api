using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePurrfectPaw.API.Entities;
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

        [HttpGet("{postingId}", Name="GetPosting")]
        public async Task<ActionResult<PostingDto>> GetPosting( int postingId )
        {
            var posting = await _postingsService.GetPosting( postingId );

            if (posting == null)
            {
                return NotFound();
            }

            return Ok( _mapper.Map<PostingDto>(posting) );
        }

        [HttpPost]
        public async Task<ActionResult<PostingDto>> CreatePosting( CreatePostingDto request )
        {
            if ( request == null )
            {
                return BadRequest();
            }
            // TODO: location stuff when creating a shelter
            // TODO: validation
            var posting = _mapper.Map<Posting>( request );

            var createdPosting = await _postingsService.CreatePosting( posting );

            return CreatedAtRoute("GetPosting", new { postingId = createdPosting.PostingId } );
        }
    }
}
