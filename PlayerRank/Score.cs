﻿namespace PlayerRank
{
    public class Score
    {
        private readonly double m_Score;

        public Score(double score)
        {
            m_Score = score;
        }

        internal double GetValue()
        {
            return m_Score;
        }

        protected bool Equals(Score other)
        {
            return m_Score.Equals(other.m_Score);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Score) obj);
        }

        public override int GetHashCode()
        {
            return m_Score.GetHashCode();
        }

        public static Score operator +(Score scoreA, Score scoreB)
        {
            return new Score(scoreA.m_Score + scoreB.m_Score);
        }

        public static Score operator -(Score scoreA, Score scoreB)
        {
            return new Score(scoreA.m_Score - scoreB.m_Score);
        }
    }
}