using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain
{    
    internal class Transaction
    {
        private string _id;
        private Voting _voting;
        private string _vote;
        private int _nonce;

        public Transaction(Voting voting, string vote) 
        {
            _nonce = voting.GetNumberOfVotesByVoteTitle(vote);
            _id = HashFunction.GetHashCodeForMessage($"{vote}{_nonce}{voting.ToString()}");
            _voting = voting;
            _vote = vote;
        }

        public override string ToString()
        {
            return $"Transaction ID: {_id}; Voting: {_voting.Title}; Vote: {_vote}; Nonce: {_nonce}";
        }

        public void Print() 
        {
            Console.WriteLine($"ID - {_id};\nVoting - {_voting.Title};\nVote - {_vote};\nNonce - {_nonce}.");
        }
    }
}
