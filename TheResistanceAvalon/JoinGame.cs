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
    [Activity(Label = "AvalonApp", MainLauncher = false, Icon = "@drawable/Untitled")]
    public class JoinGame : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.JoinGame);
            EditText pass = FindViewById<EditText>(Resource.Id.pass);
            EditText TableN = FindViewById<EditText>(Resource.Id.TableN);
            Button join = FindViewById<Button>(Resource.Id.EnterG);
            TextView errors= FindViewById<TextView>(Resource.Id.e);
            string tn = "",p="";
            join.Click += (object sender, EventArgs e) =>
            {
                tn = TableN.Text;
                p = pass.Text;
                comm c = new comm();
                coll update = new coll();
                if (tn != "" && p != "")
                {
                    if (c.GET("Games", tn).name == null)
                        errors.Text = "sorry, the table name does not exist on our data base, please try again";

                    else
                    {

                        if (c.GET("Games", tn).game_password == p && c.GET("Games", tn).players.Count < c.GET("Games", tn).NumberOfPlayers)
                        {
                            if(c.GET("Games", tn).players.Contains(GlobalVariables.playername))
                            {
                                GlobalVariables.Gamename = tn;
                                Intent ci = new Intent(this, typeof(Ceremony));
                                StartActivity(ci);
                            }
                            else
                            {
                                GlobalVariables.Gamename = tn;
                                List<string> pl = c.GET("Games", tn).players;
                                pl.Add(GlobalVariables.playername);
                                update.players = pl;
                                c.PATCH("Games", tn, update);
                                Intent CeremonyIntent = new Intent(this, typeof(Ceremony));
                                StartActivity(CeremonyIntent);
                            }
                        }
                        else errors.Text = "table is either full or you have entered the wrong password";
                        //update.players = new List<string> { "me", "update", "Arthur", "Betty", "koren", "yakov" };
                        //update.variant = new Variant { mordred = true, lady = true, morgana = true, percival = true, excalibur = true };
                    }
                }
                else errors.Text = "you can not enter empty values";
            };

            }

    }
}