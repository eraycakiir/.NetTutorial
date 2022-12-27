using e_ticket.Data.Base;
using e_ticket.Data.ViewModels;
using e_ticket.Models;
using System.Threading.Tasks;

namespace e_ticket.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();

        Task AddMewMovieAsync(NewMovieVM data);
    }
}
