using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CampgroundRecords {
    /// <summary>
    /// Campground Class
    /// </summary>
    /// <remarks>Author: Prof. R.</remarks>
    public class Campground {
        /// <summary>
        /// Parameterized Constructor for Campground
        /// </summary>
        /// <param name="_name">Name of the campground</param>
        public Campground(string _name, string _state, string _cityTown, int _numSites, double _dailyRate, bool _wifiFlag, bool _poolFlag) {
            Name = _name;
            State = _state;
            CityTown = _cityTown;
            NumSites = _numSites;
            DailyRate = _dailyRate;
            HasWiFi = _wifiFlag;
            HasPool = _poolFlag;
        }

        /// <summary>
        /// Name of the campground
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// State the campground is in
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// CityTown Associated with the campground
        /// </summary>
        public string CityTown { get; set; }

        /// <summary>
        /// Number of Camping Sites
        /// </summary>
        public int NumSites { get; set; }

        /// <summary>
        /// Daily Rate
        /// </summary>
        public double DailyRate { get; set; }

        /// <summary>
        /// Wifi flag
        /// </summary>
        public bool HasWiFi { get; set; }

        /// <summary>
        /// Pool flag
        /// </summary>
        public bool HasPool { get; set; }
    }
}