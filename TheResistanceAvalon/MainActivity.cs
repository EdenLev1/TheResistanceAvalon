using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using RestSharp;
using System.Collections.Generic;

namespace TheResistanceAvalon
{

    [Activity(Label = "AvalonApp", MainLauncher = true, Icon = "@drawable/Untitled")]
    public class MainActivity : Activity
    {
        public static string playername = "";
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource

            SetContentView(Resource.Layout.Main);
            // Get our UI controls from the loaded layout:
            EditText NickName = FindViewById<EditText>(Resource.Id.nickname);
            EditText pass = FindViewById<EditText>(Resource.Id._pass);
            TextView error = FindViewById<TextView>(Resource.Id.errors);
            Button Enter = FindViewById<Button>(Resource.Id.Enter);
            // Add code to translate number
            string nickname,passW,errorM;
            Enter.Click += (object sender, EventArgs e) =>
            {
                comm c = new comm();
                nickname = NickName.Text;
                passW = pass.Text;
                if (nickname == null ||passW==null)
                {
                    errorM = "Invalid inputs please try again, password or username can not be empty";
                    error.Text = errorM;

                }
                
                else if (!c.GETF("Players", "\"name\"", nickname).Contains("total=0") && c.GET("Players", nickname).password!=passW)
                    error.Text = "username already exists, please choose a different one or enter a correct password for that username";
                else if(c.GETF("Players", "\"name\"", nickname).Contains("total=0") && c.GET("Players", nickname).password != passW)
                {
                    playername = nickname;
                    Intent Lobbyintent = new Intent(this, typeof(Lobby));
                    StartActivity(Lobbyintent);
                }
                else
                {
                    playername = nickname;
                    coll data = new coll();
                    data.name = nickname;
                    data.password = passW;
                    string post = c.POST("Players", data);
                    Intent Lobbyintent = new Intent(this, typeof(Lobby));
                    StartActivity(Lobbyintent);
                }
            };
          

         }

        //GET a JSON document back from a collection in the DB

        // coll get1 = c.GET("Boards", "test_coll");
        //this option below will print all the Board json document with all the data and statused etc:
        // string json = JsonConvert.SerializeObject(get1);
        //Console.WriteLine(json);
        //this can get more details parameters from the json document:
        //Console.WriteLine(get1.players_role.player2);
        //Console.WriteLine(get1.status);

        //coll get2 = c.GET("Players", "eden");
        //string json2 = JsonConvert.SerializeObject(get2);
        //print all eden player:
        //Console.WriteLine(json2);
        //or just some specific details:
        //Console.WriteLine(get2.location);
        //Console.WriteLine(get2.active_game);

        //coll get3 = c.GET("Missions", "game1m1");
        //Console.WriteLine(get3.leader);
        //Console.WriteLine(get3.team_count);
        //Console.WriteLine(get3.team[1]);
        //or even :   Console.WriteLine(string.Join(",", get3.team.ToArray()));

        //Console.Read();


        //// GET a string back from DB that match query from "collection", where "key" = "value"

        //string getf = c.GETF("Players", "\"quests.m1q\"", "false");
        //Console.WriteLine(getf);
        //Console.Read();
        //Console.Read();

        //POST a JSON document data to a collection in the DB

        //coll data = new coll();
        //data.name = "stamTESTgame";
        //data.status = "login";
        //data.players = new List<string> { "Arthur", "Betty", "koren", "yakov" };
        //data.variant = new Variant { mordred = true, lady = true, morgana = true, percival = true, excalibur = false };
        //data.game_password = "new-password";
        //string post = c.POST("Games", data);
        //Console.WriteLine(post);
        //Console.Read();
        //Console.Read();

        //DELETE a document from a collection in the DB

        //string del = c.DELETE("Games", "stamTESTgame");
        //Console.WriteLine(del);
        //Console.Read();
        //Console.Read();

        //UPDATE(PATCH) a document in a collection in the DB

        //coll update = new coll();
        //update.status = "game";
        //update.players = new List<string> { "me", "update", "Arthur", "Betty", "koren", "yakov" };
        //update.variant = new Variant { mordred = true, lady = true, morgana = true, percival = true, excalibur = true };
        //string patch = c.PATCH("Games", "demo-game", update);
        //Console.WriteLine(patch);
        //Console.Read();
        //Console.Read();
    }
    }
}

