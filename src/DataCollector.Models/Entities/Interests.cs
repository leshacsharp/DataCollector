﻿using System.Collections.Generic;

namespace DataCollector.Models.Entities
{
    /// <summary>
    /// The class contains user interests.
    /// </summary>
    public class Interests
    {
        /// <summary>
        /// Contains the liked types of books.
        /// </summary>
        public IEnumerable<string> TypesOfBooks { get; set; }

        /// <summary>
        /// Contains the liked types of films.
        /// </summary>
        public IEnumerable<string> TypesOfFilms { get; set; }

        /// <summary>
        /// Contains the liked types of games.
        /// </summary>
        public IEnumerable<string> TypesOfGames { get; set; }

        /// <summary>
        /// Contains the liked types of music.
        /// </summary>
        public IEnumerable<string> TypesOfMusic { get; set; }
    }
}
