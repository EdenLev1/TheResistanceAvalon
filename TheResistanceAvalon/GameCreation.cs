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
            SetContentView(Resource.Layout.LobbyLayout);
            Button CreateTable = FindViewById<Button>(Resource.Id.Join);
            EditText TableName = FindViewById<EditText>(Resource.Id.TName);
            EditText TablePass = FindViewById<EditText>(Resource.Id._password);
            EditText NumOfPlayers = FindViewById<EditText>(Resource.Id.NumOfPlayers);
            string tn = "";
            string tp = "";
            int n = 0;
            CreateTable.Click += (object sender, EventArgs e) =>
            {
                tn = CreateTable.Text;
                tp = TableName.Text;
                n = int.Parse(NumOfPlayers.Text);
                if (tn != "" && tp != "" && n <= 10 && n >= 5)
                {

                    // general HTTP connection details:

                    var client = new RestClient();
                    client.BaseUrl = new Uri("http://208.113.133.116:5000");

                    var POSTrequest = new RestRequest("Games/", Method.POST);
                    POSTrequest.RequestFormat = DataFormat.Json;
                    var newPlayer = new player
                    {
                        name = tn,

                    };
                    //insert this json doc into the Games collections:

                    var json = POSTrequest.JsonSerializer.Serialize(newPlayer);
                    POSTrequest.AddHeader("Content-Type", "application/json; charset=utf-8");
                    POSTrequest.RequestFormat = DataFormat.Json;
                    POSTrequest.AddBody(new Game { name = tn, password = tp , numPlayers=n,});
                    IRestResponse POSTresponse = client.Execute(POSTrequest);

                    Intent Lobbyintent = new Intent(this, typeof(Ceremony));
                    StartActivity(Lobbyintent);
                }
            };

            }}
}