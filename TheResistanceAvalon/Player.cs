using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheResistanceAvalon
{
    class Player
    {
        public string kind, playerName,vote,approve_or_reject; //kind= evil, good, mordred or merlin
        public bool hasVote,isKing;

        public Player(string playerName)
        {
            this.playerName = playerName;
            kind = "";
        } 
        public void setApprove_or_rejct(string aor)
        {
            approve_or_reject = aor;
        }
        public string getApprove_or_rejct()
        {
            return approve_or_reject;
        }
        public void setVote(string vote)//good isnt allowed to fail
        {
            this.vote = vote;
        }
        public string getVote()
        {
            return vote;
        }
        public void setKing(bool k)
        {
            isKing = true;
        }
        public bool getIsKing()//good isnt allowed to fail
        {
            return isKing;
        }
        public void setKind(string kind)
        {
            this.kind = kind;
        }
        public string GetKind()
        {
            return kind;
        }
        public void setHasVote(bool hasVote)
        {
            this.hasVote = hasVote;
        }
        public bool getHasVote()
        {
            return hasVote;
        }
        public string getInfo(tekes cer)
        {
            if (kind == "merlin")
                return cer.MerlinInfo();
            else if (kind.ToLower() == "evil" || kind.ToLower() == "assassin")
                return cer.evilsInfo();
            else return "generic goods are clueless";
        }
        public void setplayerName(string playerName)
        {
            this.playerName = playerName;
        }
        public string GetplayerName()
        {
            return playerName;
        }

    }
}
