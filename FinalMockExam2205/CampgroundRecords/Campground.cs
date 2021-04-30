namespace CampgroundRecords
{
    class Campground
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int NumberOfSites { get; set; }
        public double Rate { get; set; }
        public bool HasWiFi { get; set; }
        public bool HasPool { get; set; }

        public Campground(string name, string location, int numberOfSites, double rate, bool hasWiFi, bool hasPool)
        {
            Name = name;
            Location = location;
            NumberOfSites = numberOfSites;
            Rate = rate;
            HasWiFi = hasWiFi;
            HasPool = hasPool;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Location: {Location}\n" +
                   $"Number Of Sites: {NumberOfSites}\n" +
                   $"Rate: {Rate:C}\n" +
                   $"Has Wifi: {(HasWiFi ? "Yes" : "No")}\n" +
                   $"Has Pool: {(HasPool ? "Yes" : "No")}\n";
        }
    }
}