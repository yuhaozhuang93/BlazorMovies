using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Pages
{
    public partial class Counter
    {
        List<Movie> movies;
        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(3000);
            movies = new List<Movie>()
            {
                new Movie(){Title = "Joker", ReleaseDate = new DateTime(2019, 7, 2)},
                new Movie(){Title = "Avengers", ReleaseDate = new DateTime(2016, 11, 23)},

            };
        }

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
            transient.Value = currentCount;
            singleton.Value = currentCount;
        }
    }
}
