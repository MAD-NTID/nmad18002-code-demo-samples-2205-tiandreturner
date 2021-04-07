using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    public enum MovieType
    {
        Action,
        Adventure,
        Comedy,
        Romance,
        Thriller
    }
    class Movie
    {
        private string genreName;

        public string GenreName
        {
            get { return genreName; }
        }

        public Movie()
        {
            GenerateRandom();
        }

        private void GenerateRandom()
        {
            Random rand = new Random();
            int currentRandomNumber =  rand.Next(Enum.GetNames(typeof(MovieType)).Length);
            MovieType currentMovieType = (MovieType)currentRandomNumber;
            genreName = currentMovieType.ToString();
        }

    }
}
