using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ThePurrfectPaw.API.Entities;
using ThePurrfectPaw.API.Models.Request;
using ThePurrfectPaw.API.Models.Response;

namespace ThePurrfectPaw.API.Services
{
    public interface IPostingsService 
    {
        Task<Posting> CreatePosting( Posting posting );
        Task<IEnumerable<Posting>> GetAll( PostingsResourceParameters parameters );
        Task<Posting> GetPosting( int postingId );
        Task<ValidationRequest> ValidateCreatePostingRequest( CreatePostingDto request );
    }

    public class PostingsService : IPostingsService
    {
        private readonly IPostingsRepository _postingsRespository;

        public PostingsService( IPostingsRepository postingsRespository )
        {
            _postingsRespository = postingsRespository;
        }

        public async Task<Posting> CreatePosting( Posting posting )
        {
            var createdPosting = await _postingsRespository.Add( posting );

            return createdPosting;
        }

        public async Task<IEnumerable<Posting>> GetAll( PostingsResourceParameters parameters )
        {
            if ( parameters  == null )
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            var includeProperties = string.Join( ",", "Shelter.Location", "Animal" );

            if ( parameters.ShelterId == null && string.IsNullOrWhiteSpace( parameters.SearchQuery ) )
            {
                return await GetPublicPostings( includeProperties );
            }

            var query = _postingsRespository.GetWhere( includeProperties ).Where(e => e.IsPublic );

            if ( parameters.ShelterId != null )
            {
                query = query.Where( e => e.ShelterId == parameters.ShelterId );
            }

            if ( !string.IsNullOrWhiteSpace( parameters.SearchQuery ) )
            {
                var searchQuery = parameters.SearchQuery.Trim();
                query = query.Where( e => e.Title.Contains( searchQuery ) );
            }

            return query.ToList();
        }

        public async Task<Posting> GetPosting( int postingId )
        {
            return await _postingsRespository.GetById( postingId );
        }

        public async Task<ValidationRequest> ValidateCreatePostingRequest( CreatePostingDto request )
        {
            return null;
        }

        private async Task<IEnumerable<Posting>> GetPublicPostings(string includeProperties)
        {
            return await _postingsRespository.GetWhere( e => e.IsPublic, includeProperties );
        }
    }
}
