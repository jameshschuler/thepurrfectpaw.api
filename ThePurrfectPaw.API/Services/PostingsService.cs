using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePurrfectPaw.API.Entities;

namespace ThePurrfectPaw.API.Services
{
    public interface IPostingsService 
    {
        Task<IEnumerable<Posting>> GetAll(bool includeAll = false);
        Task<Posting> GetPosting( int postingId );
    }

    public class PostingsService : IPostingsService
    {
        private readonly IPostingsRepository _postingsRespository;

        public PostingsService( IPostingsRepository postingsRespository )
        {
            _postingsRespository = postingsRespository;
        }

        public async Task<IEnumerable<Posting>> GetAll( bool includeAll = false )
        {
            var includeProperties = string.Join(",", "Shelter.Location");

            if ( includeAll )
            {
                return await _postingsRespository.GetAll( includeProperties );
            }

            return await _postingsRespository.GetWhere(e => e.IsPublic, includeProperties );
        }

        public async Task<Posting> GetPosting( int postingId )
        {
            return await _postingsRespository.GetById( postingId );
        }
    }
}
