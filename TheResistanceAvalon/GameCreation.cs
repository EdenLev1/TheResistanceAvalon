using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using RestSharp;

namespace TheResistanceAvalon
{
    [Activity(Label = "AvalonApp", MainLauncher = false, Icon = "@drawable/Untitled")]
    public class GameCreation : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetContentView(Resource.Layout.CreateGame);
            Button CreateTable = FindViewById<Button>(Resource.Id.CreateTable);
            EditText TableName = FindViewById<EditText>(Resource.Id.TName);
            EditText TablePass = FindViewById<EditText>(Resource.Id._password);
            TextView errors = FindViewById<TextView>(Resource.Id.errors);
            EditText NumOfPlayers = FindViewById<EditText>(Resource.Id.NumOfPlayers);
            string tn = "";
            string tp = "";
            int n = 0;
            CreateTable.Click += (object sender, EventArgs e) =>
            {
                tp = TablePass.Text;
                tn = TableName.Text;
                try
                { 
                n = int.Parse(NumOfPlayers.Text);
                }
                catch {errors.Text="please enter a number in the number of players tab" ;}
                if (tn != "" && tp != "" && n <= 10 && n >= 5)
                {
                    comm c = new comm();
                    coll data = new coll();
                    if (!c.GETF("Games", "\"name\"", tn).Contains("total=0"))
                        errors.Text = "game name already exists please use a different one";

                    else
                    {
                        data.name = tn;
                        GlobalVariables.Gamename = tn;
                        data.status = "login";
                        data.game_password = tp;
                        data.NumberOfPlayers = n;
                        data.players.Add(MainActivity.playername);
                        c.POST("Games", data);
                        coll d2 = new coll();
                        d2.active_game = tn;
                        c.PATCH("Players", GlobalVariables.playername, d2);
                        Intent Lobbyintent = new Intent(this, typeof(Ceremony));
                        StartActivity(Lobbyintent);
                    }
                }
                else errors.Text = "wrong inputs, please follow the instructions";
            };

            }}
}