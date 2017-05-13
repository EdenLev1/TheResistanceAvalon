using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//test
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Timers;
namespace TheResistanceAvalon
{
    [Activity(Label = "Ceremony")]
    public class Ceremony : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.GameCeremony);
            Button Play = FindViewById<Button>(Resource.Id.Move);
            Button Refresh = FindViewById<Button>(Resource.Id.Refresh);
            Button BeginC = FindViewById<Button>(Resource.Id.cere);
            TextView info = FindViewById<TextView>(Resource.Id.info);
            TextView Status = FindViewById<TextView>(Resource.Id.status);
            string playrname = GlobalVariables.playername;
            string gamename = GlobalVariables.Gamename;
            comm c = new comm();
            string playerInfo = "";
            string status = "";
            Play.Enabled = true;
            info.Text = "Your info: " + c.GET("Players", playrname).location;
            if (c.GET("Games", gamename).status == "login"&& c.GET("Games", gamename).players.Count == c.GET("Games", gamename).NumberOfPlayers)
            {
                BeginC.Enabled = true;
                status = "Bceremony";
            }
            if ( status == "Bceremony")
            {
                Play.Enabled = false;
                status = "Bceremony";
                BeginC.Click += (object sender, EventArgs e) =>
                {                   
                    status = "ceremony";
                    BeginC.Enabled = false;
                    coll data = new coll();
                    Status.Text = "begining ceremony, keep tight";
                    string[] infos = ManageCeremony();

                    playerInfo = infos[c.GET("Games", gamename).number];
                    data.status = "gamestart";
                    status = "gamestart";
                    c.PATCH("Games", gamename, data);
                    info.Text += " " + playerInfo;
                    Play.Enabled = true;
                    BeginC.Enabled = false;
                    Refresh.Enabled = false;
                };               
            }

            Play.Click += (object sender, EventArgs e) =>
            {
                coll d2 = new coll();
                coll d3 = new coll();
                d3.is_leader = true;
                d2.status="game";
                d2.leader = c.GET("Games", gamename).players[0];
                GlobalVariables.Leader = 0;
                c.PATCH("Games", gamename, d2);
                c.PATCH("Players", playrname, d3);
                Intent Game = new Intent(this, typeof(Game));
                StartActivity(Game);
            };

            Refresh.Click += (object sender, EventArgs e) =>
            {
                int nop = c.GET("Games", gamename).NumberOfPlayers;

                if (c.GET("Games", gamename).status == "login" && c.GET("Games", gamename).players.Count == c.GET("Games", gamename).NumberOfPlayers)
                {
                    BeginC.Enabled = true;
                    status = "Bceremony";
                }
                if (status == "Bceremony")
                {
                    Play.Enabled = false;
                    BeginC.Enabled = true;

                    BeginC.Click += (object s, EventArgs e2) =>
                    {
                        status = "ceremony";
                        BeginC.Enabled = false;
                        coll data = new coll();
                        Status.Text = "begining ceremony, keep tight";
                        string[] infos = ManageCeremony();
                        playerInfo = infos[c.GET("Games", gamename).number];
                        info.Text += " " + playerInfo;
                        Play.Enabled = true;
                        data.status = "game";
                        c.PATCH("Games", gamename, data);
                        BeginC.Enabled = false;
                        Refresh.Enabled = false;
                    };   
                }
                info.Text = "Your info: "+c.GET("Players", playrname).location;
            };
        }

        public string[] ManageCeremony()
        {
            coll data = new coll();
            data.status = "ceremony";
            comm c = new comm();
            c.PATCH("Games", GlobalVariables.Gamename, data);
            int nop = c.GET("Games", GlobalVariables.Gamename).NumberOfPlayers;
            string[] infos = new string[nop];
            tekes Cer = new tekes(nop, makePlayerArray());// add players array 
            Cer.assign();// assign each player his role
            Player[] p = Cer.players;
            coll d=new coll();
            for (int i = 0; i < nop; i++)
            {
                d = new coll();
                d.role = p[i].GetKind();// assigns the player his role from the random role generator
                if (i == 0)
                    d.is_leader = true;
                if (p[i].GetKind() == "merlin")//merlin info problem
                    d.member = "good";
                else if (p[i].GetKind() == "mordred"|| p[i].GetKind() == "assassin")//mordred info problem
                    d.member = "evil";
                else
                    d.member = p[i].GetKind();
                d.number = i;
                infos[i] = "you're: " + p[i].GetKind() + " " + p[i].getInfo(Cer);
                d.location = infos[i];
                string reply = c.PATCH("Players", p[i].playerName, d);  
            }
            return infos;
        }     
        private Player[] makePlayerArray()
        {
            comm c=new comm();
            List <string> pps= c.GET("Games", GlobalVariables.Gamename).players;
            int nop = c.GET("Games", GlobalVariables.Gamename).NumberOfPlayers;
            Player[] p = new Player[nop];
            for(int i=0; i<nop;i++)
            {
                p[i] = new Player(pps[i]);
            }
            return p;
        }
        
    }
}