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

    public class Game
    {
        public string name { get; set; }
        public Boolean active { get; set; }
        public string status { get; set; }
        public int board_players { get; set; }
        public string winners { get; set; }
        public string password { get; set; }
        public int numPlayers { get; set; }
        // etc...etc ....put all the scheme from games in mongoDB !!
    }
    public class player
    {
        public string name { get; set; }
        // public string role { get; set; }
        //public string member { get; set; }
        //public bool online { get; set; }
        //public string game { get; set; }
        // etc...etc ....put all the scheme from players in mongoDB
    }
    [Activity(Label = "AvalonApp", MainLauncher = true, Icon = "@drawable/Untitled")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource

            SetContentView(Resource.Layout.Main);
            // Get our UI controls from the loaded layout:
            EditText NickName = FindViewById<EditText>(Resource.Id.nickname);
            Button Enter = FindViewById<Button>(Resource.Id.Enter);
            // Add code to translate number
            string nickname = string.Empty;
            Enter.Click += (object sender, EventArgs e) =>
            {
                nickname = NickName.Text;
                if (nickname == null)
                {
                    nickname = "default1";
                }

                if (nickname != null)
                {

                    // general HTTP connection details:

                    var client = new RestClient();
                    client.BaseUrl = new Uri("http://208.113.133.116:5000");

                    var POSTrequest = new RestRequest("Players/", Method.POST);
                    POSTrequest.RequestFormat = DataFormat.Json;
                    var newPlayer = new player
                    {
                        name = nickname,
                    };
                    //insert this json doc into the Games collections:

                    POSTrequest.AddHeader("Content-Type", "application/json; charset=utf-8");
                    POSTrequest.AddBody(newPlayer);
                    IRestResponse POSTresponse = client.Execute(POSTrequest);

                   // Intent Lobbyintent = new Intent(this, typeof(Lobby));
                    //StartActivity(Lobbyintent);

                }

            };
            // general connection details:

            //var client = new RestClient();
            //client.BaseUrl = new Uri("http://208.113.133.116:5000");

            // GET to HTTP REST-API - get document from specific mongo collection:

            //var GETrequest = new RestRequest(Method.GET);
            //GETrequest.Resource = "/Games";
            //IRestResponse GETresponse = client.Execute(GETrequest);
            //Console.WriteLine(GETresponse.Content);

            // wait for user to input something to continue to next steps:
            //Console.ReadLine();

            // POST to HTTP REST-API - set document on specific mongo collection:

            //var POSTrequest = new RestRequest(Method.POST);
            //POSTrequest.Resource = "/Players";
            //POSTrequest.RequestFormat = DataFormat.Json;
            //var newGame = new Game
            //{
            //    name = "NEWGameName",
            //    active = true,
            //    status = "finished",
            //    board_players = 5,
            //    winners = "good"
            // etc...
            //};
            //var json = POSTrequest.JsonSerializer.Serialize(newGame);
            //POSTrequest.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
            //IRestResponse POSTresponse = client.Execute(POSTrequest);
            //Console.WriteLine(POSTresponse.Content);   //just show the results if 'OK' or some 'error' from the REST-API server
            //Console.ReadLine();
        }
    }
}

