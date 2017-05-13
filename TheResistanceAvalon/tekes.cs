using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheResistanceAvalon
{
    class tekes
    {
        public int amountOfPlayers;
        public Player[] players;
        Stack<string> types;

        public tekes(int amountOfPlayers, Player[] players)
        {
            this.amountOfPlayers = amountOfPlayers;
            this.players = players;
            types = new Stack<string>();
        }

        public int goods()
        {
            if (amountOfPlayers == 9)
                return 6;
            else
                return (amountOfPlayers / 2 + 1);
        }
        public int evils()
        {
            return amountOfPlayers - goods();
        }
        public void assign()
        {
            for (int g = 0; g < goods(); g++)
            {
                if (g == 0)
                    types.Push("merlin");
                else types.Push("good");
            }
            for (int e = 0; e < evils(); e++)
            {
                if (e == 0)
                    types.Push("mordred");
                else if(e==1)
                    types.Push("assassin");
                else types.Push("evil");
            }

            Random r = new Random();
            int rnd;
            while (!(types.Count==0))
            {
                rnd = r.Next(amountOfPlayers);
                if (players[rnd].GetKind() == "")
                    players[rnd].setKind(types.Pop());
            }
        }
        public string MerlinInfo()
        {
            string evils = "";
            for (int i = players.Length-1; i >= 0; i--)
            {
                if (players[i].GetKind() == "evil" || players[i].GetKind() == "assassin")
                    evils += players[i].GetplayerName() + " is evil ,";
            }
            return evils;
        }
        public string evilsInfo()
        {
            string evils = "";
            for (int i = players.Length-1; i >= 0; i--)
            {
                if (players[i].GetKind() == "evil" || players[i].GetKind() == "assassin" || players[i].GetKind() == "mordred")
                {
                    evils += players[i].GetplayerName() + "is evil ,";
                }
            }
            return evils;
        }

    }
}
