using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TheResistanceAvalon
{
    [Activity(Label = "sPlayers")]
    public class sPlayers : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.sPlayers);
            TextView msn = FindViewById<TextView>(Resource.Id.msn);
            TextView fdb = FindViewById<TextView>(Resource.Id.fdb);
            CheckBox[] buttons = new CheckBox[10];
            buttons[0] = FindViewById<CheckBox>(Resource.Id.p1);
            buttons[1] = FindViewById<CheckBox>(Resource.Id.p2);
            buttons[2] = FindViewById<CheckBox>(Resource.Id.p3);
            buttons[3] = FindViewById<CheckBox>(Resource.Id.p4);
            buttons[4] = FindViewById<CheckBox>(Resource.Id.p5);
            buttons[5] = FindViewById<CheckBox>(Resource.Id.p6);
            buttons[6] = FindViewById<CheckBox>(Resource.Id.p7);
            buttons[7] = FindViewById<CheckBox>(Resource.Id.p8);
            buttons[8] = FindViewById<CheckBox>(Resource.Id.p9);
            buttons[9] = FindViewById<CheckBox>(Resource.Id.p10);
            Button submit = FindViewById<Button>(Resource.Id.sd);

            Player[] pps = makePlayerArray();
            int nop = pps.Length;
            
            comm c = new comm();
            string activeG = c.GET("Players", pps[0].playerName).active_game;
            int m= c.GET("Games", activeG).mission;
            double playersToTake = numP(nop, m);
            msn.Text += " " + (playersToTake);
            GlobalVariables.Leader = c.GET("Players", GlobalVariables.playername).number;
            string[] ps = new string[nop];
            for (int i = 0; i < 10; i++)
            {
                if (i < nop)
                {
                    buttons[i].Text = pps[i].GetplayerName();
                    ps[i]= pps[i].GetplayerName();
                }
                else buttons[i].Visibility = ViewStates.Gone;
            }

            submit.Click += (object sender, EventArgs e) =>
            {
                string[] players = new string[(int)playersToTake];
                int countSelected = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (buttons[i].Checked==true)
                    {
                        countSelected++;
                    }
               }
                if(countSelected==players.Length)
                { 
                    for (int i = 0,j=0; i < 10; i++)
                    {
                        if (buttons[i].Checked)
                        {
                            players[j] = ps[i];
                            j++;
                        }
                    }

                    coll data = new coll();
                    coll p1Data = new coll();
                    coll p2Data = new coll();
                    data.mission = m + 1;       //////// not updating the leader and the game
                    data.team = players.ToList();
                    if (playersToTake == 4.5 || playersToTake == 5.5)
                        data.fail_factor = 2;
                    else data.fail_factor = 1;
                    data.team_count = (int)playersToTake;
                    data.previous_leaders = new List<string>(nop);
                    string bLead= c.GET("Games", activeG).players[GlobalVariables.Leader];
                    if(GlobalVariables.Leader==nop)
                        GlobalVariables.Leader=0;
                    else
                        GlobalVariables.Leader++;
                    string lead= c.GET("Games", activeG).players[GlobalVariables.Leader];
                    data.leader = lead;
                    data.status = "appORrej";
                    p1Data.is_leader = false;
                    p2Data.is_leader = true;
                    c.PATCH("Games", activeG, data);
                    c.PATCH("Players", bLead, p1Data);
                    System.Threading.Thread.Sleep(1000);
                    c.PATCH("Players", lead, p2Data);
                    fdb.Text += "going to vote";
                    Intent goVote = new Intent(this, typeof(Game));
                    StartActivity(goVote);
                }
                else
                {
                    fdb.Text = "you have to select the amount of players listed above.";
                }
            };
        }
        private Player[] makePlayerArray()
        {
            comm c = new comm();
            List<string> pps = c.GET("Games", GlobalVariables.Gamename).players;
            int nop = c.GET("Games", GlobalVariables.Gamename).NumberOfPlayers;
            Player[] p = new Player[nop];
            for (int i = 0; i < nop; i++)
            {
                p[i] = new Player(pps[i]);
            }
            return p;
        }
        private double numP(int AmountOfPlayers,int mission)
        {
            double[] missions;
            if (AmountOfPlayers == 5)
                missions = new double[5] { 2, 3, 2, 3, 3 };
            else if (AmountOfPlayers == 6)
                missions = new double[5] { 2, 3, 4, 3, 4 };
            else if (AmountOfPlayers == 7)
                missions = new double[5] { 2, 3, 3, 4.5, 4 };
            else
                missions = new double[5] { 3, 4, 4, 5.5, 5 };

            return missions[mission];
        }
    }
}