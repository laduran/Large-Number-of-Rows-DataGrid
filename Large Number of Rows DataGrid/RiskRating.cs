using System;

namespace Large_Number_of_Rows_DataGrid
{
    public enum RiskLevel : short
    {
        Critical = 1,
        High = 2,
        Medium = 3,
        Low = 4,
        None = Int16.MaxValue // None=MaxValue so we can use findings.Min() to find the highest risk in a collection
    }

    public class RiskRating : IComparable<RiskRating>
    {
        public RiskLevel Rating { get; private set; }
        public string Level { get; private set; }

        public RiskRating(RiskLevel rating)
        {
            Rating = rating;
            SetRatingDesc();
        }

        public RiskRating(RiskLevel rating, string level)
        {
            Rating = rating;
            Level = level;
        }

        public static RiskRating Default()
        {
            return new RiskRating(RiskLevel.None);
        }
        private void SetRatingDesc()
        {
            Level = "Unknown";

            // For some reason, 0 is 'none'
            if (Rating == RiskLevel.None) Level = "None";
            if (Rating == RiskLevel.Critical) Level = "Critical";
            if (Rating == RiskLevel.High) Level = "High";
            if (Rating == RiskLevel.Medium) Level = "Medium";
            if (Rating == RiskLevel.Low) Level = "Low";
        }
        public override string ToString()
        {
            return Level;
        }

        // implement IComparable CompareTo method - provide default sort order
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            if (obj is RiskRating otherRating)
                return this.Rating.CompareTo(otherRating.Rating);
            else
                throw new ArgumentException("Object is not a RiskRating");
        }

        public int CompareTo(RiskRating other)
        {
            return Rating.CompareTo(other.Rating);
        }
    }
}
