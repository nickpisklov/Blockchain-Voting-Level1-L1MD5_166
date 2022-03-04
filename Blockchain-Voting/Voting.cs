using System;
using System.Collections.Generic;

namespace Blockchain_Voting
{
    internal class Voting
    {
        private int _id;
        private string _title;
        public Dictionary<string, int> _points;
        private DateTime _dateStart;
        private DateTime _dateEnd;
        private VotingState _state = VotingState.Opened;

        public string Title { get { return _title; } }

        public Voting(int id, string title, Dictionary<string, int> points, DateTime dateStart, DateTime dateEnd)
        {
            _id = id;
            _title = title;
            _points = points;
            _dateStart = dateStart;
            _dateEnd = dateEnd;
        }

        public override string ToString()
        {
            return $"Voting info: Voting ID: {_id}; Voting title: {_title}; Start date: {_dateStart.ToString("d")};  End date: {_dateEnd.ToString("d")}; Voting state: {_state}; Points: {GetPointsInfo()}";
        }

        public string GetPointsInfo()
        {
            string result = "";
            foreach (var point in _points)
            {
                result += $"Point title - {point.Key}, Number of votes - {point.Value}; ";
            }
            return result;
        }

        public int GetNumberOfVotesByVoteTitle(string title)
        {
            return _points[title];
        }
    }
    enum VotingState
    {
        Opened,
        Closed
    }
}
