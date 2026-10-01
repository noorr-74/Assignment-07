using System;

namespace Assi_session8
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            int totalSeconds = hours * 3600 + minutes * 60 + seconds;

            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;

            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;

            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }

        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Duration other)
                return false;

            return Hours == other.Hours &&
                   Minutes == other.Minutes &&
                   Seconds == other.Seconds;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }

        private int TotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.TotalSeconds() + d2.TotalSeconds());
        }

        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.TotalSeconds() + seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return new Duration(d.TotalSeconds() + seconds);
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.TotalSeconds() + 1);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(d.TotalSeconds() - 1);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(d1.TotalSeconds() - d2.TotalSeconds());
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() > d2.TotalSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() < d2.TotalSeconds();
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() >= d2.TotalSeconds();
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() <= d2.TotalSeconds();
        }

        public static bool operator ==(Duration d1, Duration d2)
        {
            if (ReferenceEquals(d1, d2))
                return true;

            if (d1 is null || d2 is null)
                return false;

            return d1.Equals(d2);
        }

        public static bool operator !=(Duration d1, Duration d2)
        {
            return !(d1 == d2);
        }

        public static bool operator true(Duration d)
        {
            return d.TotalSeconds() > 0;
        }

        public static bool operator false(Duration d)
        {
            return d.TotalSeconds() <= 0;
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(
                1,
                1,
                1,
                d.Hours % 24,
                d.Minutes,
                d.Seconds
            );
        }
    }
}