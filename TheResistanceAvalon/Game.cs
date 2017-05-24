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
    [Activity(Label = "Game")]
    public class Game : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main_Game);

            Button info = FindViewById<Button>(Resource.Id.info2);
            Button missions = FindViewById<Button>(Resource.Id.missions);
            Button Refresh = FindViewById<Button>(Resource.Id.refresh2);
            Button Submit = FindViewById<Button>(Resource.Id.submit);
            //decision buttons
            int approveCount = 0;
            int successCount = 0;
      //      Button Approve = FindViewById<Button>(Resource.Id.Approve);
        //    Button Reject = FindViewById<Button>(Resource.Id.Reject);
            Button Fail = FindViewById<Button>(Resource.Id.Fail);
            Button Success = FindViewById<Button>(Resource.Id.Succes);
            string decision = "",decision2="";
            TextView feedback = FindViewById<TextView>(Resource.Id.feedback);
            comm c = new comm();
            int nop = c.GET("Games", GlobalVariables.Gamename).NumberOfPlayers;
            string playrname = GlobalVariables.playername;
            List<string> votes = c.GET("Games", GlobalVariables.Gamename).previous_leaders;
            string gamename = GlobalVariables.Gamename;
            info.Click += (object sender, EventArgs e) =>
            {
                Intent cer = new Intent(this, typeof(Ceremony));
                StartActivity(cer);
            };
            missions.Click += (object sender, EventArgs e) =>
            {
                //TO DO: add mission intent
            };
            
            if (c.GET("Games", gamename).status == "game")
            {

                if (playrname == c.GET("Games", gamename).leader)
                {
                    feedback.Text = "you are the leader! taking you to pick a team...";
                    System.Threading.Thread.Sleep(2000);
                    Intent sPlayers = new Intent(this, typeof(sPlayers));
                    StartActivity(sPlayers);
                }
                else feedback.Text = "please refresh when you have been told the team has been picked then vote";
            }
            if (c.GET("Games", gamename).status == "appORrej" || c.GET("Players", playrname).online == true)
            {
                Fail.Text = "Reject";
                Fail.Enabled = true;
                Success.Text = "Approve";
                Success.Enabled = true;
                Success.Click += (object sender, EventArgs e) =>
                {
                    decision = "Approve";
                    feedback.Text = "you are approving";
                };
                Fail.Click += (object sender, EventArgs e) =>
                {
                    decision = "Reject";
                    feedback.Text = "you are rejecting";
                };
            }
            Submit.Click += (object sender, EventArgs e) =>
            {
                if (decision != "")
                {
                    approveCount++;
                    Fail.Enabled = false;
                    Success.Enabled = false;
                    coll Data = new coll();
                    if (votes.Count != nop && approveCount==1)
                        votes.Add(decision);
                    c.PATCH("Games", gamename, Data);
                    Data.previous_leaders = votes;
                    coll pD = new coll();
                    pD.online = false;
                    c.PATCH("Games", gamename, Data);
                    c.PATCH("Players", playrname, pD);
                    feedback.Text = "when everyone has voted please press REFRESH";
                }
                else
                    feedback.Text = "please select approve or reject";
            };
            if(votes.Count==nop)
            {
                Fail.Enabled = false;
                Success.Enabled = false;
                Fail.Text = "Fail";
                Success.Text = "Succes";
                coll da = new coll();
                int x = c.GET("Games", gamename).vote;
                int countA = 0;
                int countR = 0;
                for(int i=0;i<nop;i++)
                {
                    if (votes[i] == "Approve")
                        countA++;
                    else countR++;
                }
                if(countA>countR || x==5)
                {
                    string status = "FailOrSucc";
                    da.team_approved = true;
                    da.status = status;
                    int countTeam = c.GET("Games", gamename).team.Count;
                    votes = new List<string>();
                    Fail.Enabled = false;
                    Success.Enabled = false;
                    if (c.GET("Game", gamename).team.Contains(playrname))
                    {
                        Success.Enabled = true;
                        if (c.GET("Players", playrname).member == "evil")
                            Fail.Enabled = true;
                        else Fail.Text = "Fail (only evils can fail a mission)";
                        Success.Click += (object sender, EventArgs e) =>
                        {
                            decision2 = "Success";
                            feedback.Text = "you are voting success";
                        };
                        Fail.Click += (object sender, EventArgs e) =>
                        {
                            decision2 = "Fail";
                            feedback.Text = "you are voting fail";
                        };
                        int mission = 0;
                        Submit.Click += (object sender, EventArgs e) =>
                        {
                            if (decision2 != "")
                            {
                                successCount++;
                                Fail.Enabled = false;
                                Success.Enabled = false;
                                coll Data = new coll();
                                votes.Add(decision2);
                                Data.previous_leaders = votes;
                                mission = c.GET("Games", gamename).mission + 1; ;
                                Data.mission = mission;
                                c.PATCH("Games", gamename, Data);
                                feedback.Text = "please Refresh, results are on mission info ";
                                decision2 = "";
                               
                                
                                feedback.Text = "when everyone has voted please press REFRESH";
                                if (successCount != 1)
                                    feedback.Text = "you cant vote more than once";
                            }
                            else
                                feedback.Text = "please select Fail or Success";
                        };
                        if (votes.Count == countTeam)
                        {
                            coll d = new coll();
                            string result = "Success";
                            int countF = 0, countS = 0;
                            for (int i = 0; i < countTeam; i++)
                            {
                                if (votes[i] == "Fail")
                                {
                                    countF++;
                                    result = "Fail";
                                }
                                else countS++;

                            }
                            d.result = result;
                            d.success = countS;
                            d.failure = countF;
                            d.name = gamename + mission;
                            d.mission = mission;
                            d.active_game = gamename;
                            c.POST("Missions", d);
                        }
                       



                    }
                    if (x == 5)

                    {
                        coll d = new coll();
                        d.vote = 1;
                        c.PATCH("Games", gamename, d);
                    }
                    coll pd2 = new coll();
                    pd2.online = true;
                    c.PATCH("Players", playrname, pd2);


                }
                else
                {
                    coll d = new coll();
                    d.vote = x + 1;
                    d.team = new List<string>();
                    d.previous_leaders = new List<string>();
                    feedback.Text = "please refresh";
                }

            }
            Refresh.Click += (object sender, EventArgs e) =>
            {
                info.Click += (object s, EventArgs e2) =>
                {
                    Intent cer = new Intent(this, typeof(Ceremony));
                    StartActivity(cer);
                };
                missions.Click += (object s, EventArgs e2) =>
                {
                    //TO DO: add mission intent
                };

                if (c.GET("Games", gamename).status == "game")
                {

                    if (playrname == c.GET("Games", gamename).leader)
                    {
                        feedback.Text = "you are the leader! taking you to pick a team...";
                        System.Threading.Thread.Sleep(2000);
                        Intent sPlayers = new Intent(this, typeof(sPlayers));
                        StartActivity(sPlayers);
                    }
                    else feedback.Text = "please refresh when you have been told the team has been picked then vote";
                }
                if (c.GET("Games", gamename).status == "appORrej" || c.GET("Players", playrname).online == true)
                {
                    Fail.Text = "Reject";
                    Fail.Enabled = true;
                    Success.Text = "Approve";
                    Success.Enabled = true;
                    Success.Click += (object s, EventArgs e2) =>
                    {
                        decision = "Approve";
                        feedback.Text = "you are approving";
                    };
                    Fail.Click += (object s, EventArgs e2) =>
                    {
                        decision = "Reject";
                        feedback.Text = "you are rejecting";
                    };
                }
                Submit.Click += (object s, EventArgs e2) =>
                {
                    if (decision != "")
                    {
                        approveCount++;
                        Fail.Enabled = false;
                        Success.Enabled = false;
                        coll Data = new coll();
                        if (votes.Count != nop && approveCount == 1)
                            votes.Add(decision);
                        c.PATCH("Games", gamename, Data);
                        Data.previous_leaders = votes;
                        coll pD = new coll();
                        pD.online = false;
                        c.PATCH("Games", gamename, Data);
                        c.PATCH("Players", playrname, pD);
                        feedback.Text = "when everyone has voted please press REFRESH";
                    }
                    else
                        feedback.Text = "please select approve or reject";
                };
                if (votes.Count == nop)
                {
                    Fail.Enabled = false;
                    Success.Enabled = false;
                    Fail.Text = "Fail";
                    Success.Text = "Succes";
                    coll da = new coll();
                    int x = c.GET("Games", gamename).vote;
                    int countA = 0;
                    int countR = 0;
                    for (int i = 0; i < nop; i++)
                    {
                        if (votes[i] == "Approve")
                            countA++;
                        else countR++;
                    }
                    if (countA > countR || x == 5)
                    {
                        string status = "FailOrSucc";
                        da.team_approved = true;
                        da.status = status;
                        int countTeam = c.GET("Games", gamename).team.Count;
                        votes = new List<string>();
                        Fail.Enabled = false;
                        Success.Enabled = false;
                        if (c.GET("Game", gamename).team.Contains(playrname))
                        {
                            Success.Enabled = true;
                            if (c.GET("Players", playrname).member == "evil")
                                Fail.Enabled = true;
                            else Fail.Text = "Fail (only evils can fail a mission)";
                            Success.Click += (object s, EventArgs e2) =>
                            {
                                decision2 = "Success";
                                feedback.Text = "you are voting success";
                            };
                            Fail.Click += (object s, EventArgs e2) =>
                            {
                                decision2 = "Fail";
                                feedback.Text = "you are voting fail";
                            };
                            int mission = 0;
                            Submit.Click += (object s, EventArgs e2) =>
                            {
                                if (decision2 != "")
                                {
                                    successCount++;
                                    Fail.Enabled = false;
                                    Success.Enabled = false;
                                    coll Data = new coll();
                                    votes.Add(decision2);
                                    Data.previous_leaders = votes;
                                    mission = c.GET("Games", gamename).mission + 1; ;
                                    Data.mission = mission;
                                    c.PATCH("Games", gamename, Data);
                                    decision2 = "";


                                    feedback.Text = "when everyone has voted please press REFRESH";
                                    if (successCount != 1)
                                        feedback.Text = "you cant vote more than once";
                                }
                                else
                                    feedback.Text = "please select Fail or Success";
                            };
                            if (votes.Count == countTeam)
                            {
                                coll d = new coll();
                                string result = "Success";
                                int countF = 0, countS = 0;
                                for (int i = 0; i < countTeam; i++)
                                {
                                    if (votes[i] == "Fail")
                                    {
                                        countF++;
                                        result = "Fail";
                                    }
                                    else countS++;

                                }
                                d.result = result;
                                d.success = countS;
                                d.failure = countF;
                                d.name = gamename + mission;
                                d.mission = mission;
                                d.active_game = gamename;
                                c.POST("Missions", d);
                                feedback.Text = "please Refresh, results are on mission info ";
                            }




                        }
                        if (x == 5)

                        {
                            coll d = new coll();
                            d.vote = 1;
                            c.PATCH("Games", gamename, d);
                        }
                        coll pd2 = new coll();
                        pd2.online = true;
                        c.PATCH("Players", playrname, pd2);


                    }
                    else
                    {
                        coll d = new coll();
                        d.vote = x + 1;
                        d.team = new List<string>();
                        d.previous_leaders = new List<string>();
                        feedback.Text = "please refresh";
                    }

                }
            };
        }
    }
}