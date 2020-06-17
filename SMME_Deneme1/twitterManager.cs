using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetSharp;
using TweetSharp.Model;

namespace SMME_Deneme1
{
    public partial class twitterManager : Form
    {
        TwitterService servis;

        public twitterManager()
        {
            InitializeComponent();

            servis = new TwitterService("dTMK6m1S5ESaAYOkD7uO01Way", "DSRXujpG26GIbttWc0Zxc4zUA6hyWeo04Ik3P3dMabHN9GDQXp", "609285151-2YteSBo7xkv1PoGGQlukfMH1yi9J3QL3adYKJbbV", "mv1gUKpT66dCQBcWAI0itFKYYdjNU1B2kRubqx4psWoGE");
            //var requesttoken = servis.GetRequestToken();
            //var uri = servis.GetAuthorizationUri(requesttoken);
            //Uri uri = servis.GetAuthenticationUrl(requesttoken);
            //Process.Start(uri.ToString());
            //VerifyCredentialsOptions option = new VerifyCredentialsOptions();
            //TwitterUser user = servis.VerifyCredentials(option);
            //var access = servis.GetAccessToken(requesttoken);
            //OAuthAccessToken accessToken = servis.GetAccessToken(requesttoken, "aEFizII0hIvnqJd1P99WjjBqoab1Mf5y");

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            timeLine.Items.Clear();
            myRetweet.Items.Clear();
            myFavorite.Items.Clear();
        }

        private void timelineButton_Click(object sender, EventArgs e)
        {
            var tweetal = servis.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions { Count = 5 });
            foreach (var tweet in tweetal) 
            {
                timeLine.Items.Add(tweet.User.Name + " : " + tweet.Text);
                myTweet.Items.Add(tweet.Id);
            }
        }

        private void favButton_Click(object sender, EventArgs e)
        {
            myTweet.SelectedIndex = timeLine.SelectedIndex;

            var fav = servis.FavoriteTweet(new FavoriteTweetOptions() { Id = long.Parse(myTweet.SelectedItem.ToString()) });
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var search = servis.Search(new SearchOptions() { Q = mainTextBox.Text });
            foreach (var tweet in search.Statuses) 
            {
                timeLine.Items.Add(tweet.User.Name + " : " + tweet.Text);
                myTweet.Items.Add(tweet.Id);
            }
        }

        private void myrtButton_Click(object sender, EventArgs e)
        {
            var getRet = servis.ListRetweetsOfMyTweets(new ListRetweetsOfMyTweetsOptions { Count = 5 });
            foreach (var tweet in getRet) 
            {
                myRetweet.Items.Add(tweet.User.Name + " : " + tweet.Text);
            }
        }

        private void tweetButton_Click(object sender, EventArgs e)
        {
            var tweetat = servis.SendTweet(new SendTweetOptions() { Status = mainTextBox.Text });
        }

        private void mytwButton_Click(object sender, EventArgs e)
        {
            var tweetal = servis.ListTweetsOnUserTimeline(new ListTweetsOnUserTimelineOptions { Count = 5 });
            foreach (var tweet in tweetal) 
            {
                timeLine.Items.Add(tweet.User.Name + " : " + tweet.Text);
                myTweet.Items.Add(tweet.Id);
            }
        }

        private void rtButton_Click(object sender, EventArgs e)
        {
            myTweet.SelectedIndex = timeLine.SelectedIndex;
            var retweet = servis.Retweet(new RetweetOptions() { Id = long.Parse(myTweet.SelectedItem.ToString()) });
        }

        private void myfavButton_Click(object sender, EventArgs e)
        {
            var getFav = servis.ListFavoriteTweets(new ListFavoriteTweetsOptions { Count = 5 });
            foreach (var tweet in getFav)
            {
                myFavorite.Items.Add(tweet.User.Name + " : " + tweet.Text);

            }
        }
    }
}
