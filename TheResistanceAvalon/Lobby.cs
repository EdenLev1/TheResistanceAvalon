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

    public class Lobby : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LobbyLayout);
            Button CreateGame = FindViewById<Button>(Resource.Id.Create);
            Button JoinGame = FindViewById<Button>(Resource.Id.Join);
            CreateGame.Click += (object sender, EventArgs e) =>
            {
                Intent CreateGameIntent = new Intent(this, typeof(GameCreation));
                StartActivity(CreateGameIntent);
            };
            JoinGame.Click += (object sender, EventArgs e) =>
            {
                Intent Join = new Intent(this, typeof(GameCreation));
                StartActivity(Join);
            };

        }
    }
}