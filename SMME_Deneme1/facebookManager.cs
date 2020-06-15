using Facebook.User;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SMME_Deneme1.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMME_Deneme1
{
    public partial class facebookManager : Form
    {
        //static string endpoint = "me";
        static string accessToken = "EAACyvduI16kBAC11R6WwpZAHqsikyUpEYcdDKHBOmd2cIaD18CkpNMiIdETq2nZCkCHpkmTfoDJeOBzOm3sAU36ZAb7pQu0YjSe6F8GYNFVovJEvFMrdzneuZBfCZBroprxJ3chvZB7ckFnuvW414OZBEI6AsBiZCUfJ6ZCkH0hId1XYDzaMqYPJeF1LfRZAtgqkxOvG6IOZAno4QZDZD";
        //static string args = "fields=name,email,first_name,last_name,age_range,birthday,gender,locale";

        private UserEndpoint _user;
        private HttpClient _http;
        public facebookManager(UserEndpoint user)
        {
            _user = user;
            InitializeComponent();
            _http = new HttpClient()
            {
                BaseAddress = new Uri("https://graph.facebook.com/v7.0/")
            };
            _http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            getUser();

        }

        private void getUser()
        {
            var endpoint = "me";
            var args = "fields=name,email,birthday,friends,location";

            var response = _http.GetAsync($"{endpoint}?access_token={accessToken}&{args}").Result;

            if (!response.IsSuccessStatusCode)
            {
                //Show dialog some error
            }

            var result = response.Content.ReadAsStringAsync().Result;

            var obj = JsonConvert.DeserializeObject<UserInfo>(result);

            //this.txtEmail.Text = obj.Name;
            //this.txtEmail.Text = obj.Friends.Summary.total_count.ToString();
        }



        private void sharePost()
        {


        }


        //Get Post
        private void button1_Click(object sender, EventArgs e)
        {

            var endpoint = "me";
            var args = "fields=posts.limit(10){message,name,full_picture,created_time}";
            var response = _http.GetAsync($"{endpoint}?access_token={accessToken}&{args}").Result;

            if (!response.IsSuccessStatusCode)
            {
                //Show dialog some error
            }

            var result = response.Content.ReadAsStringAsync().Result;
            var posts = JsonConvert.DeserializeObject(result) as dynamic;

            List<PostData> postList = new List<PostData>(); 

            foreach (var item in ((JArray)posts.posts.data).ToObject<List<PostData>>())
            {
                if(item.message != null ||item.full_picture != null)
                {
                    postList.Add(item);
                }
            }
        }

        //get Like
        private void button2_Click(object sender, EventArgs e)
        {
            var endpoint = "me";
            var args = "fields=likes.limit(10){name,link}";

            var response = _http.GetAsync($"{endpoint}?access_token={accessToken}&{args}").Result;

            if (!response.IsSuccessStatusCode)
            {
                //Show dialog some error
            }

            var result = response.Content.ReadAsStringAsync().Result;

            var likes = JsonConvert.DeserializeObject(result) as dynamic;

            List<LikeData> likeList = new List<LikeData>();

            foreach (var item in ((JArray)likes.likes.data).ToObject<List<LikeData>>())
            {
                if (item.Name != null)
                {
                    likeList.Add(item);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPost.Text))
            {
                _user.Post(txtPost.Text);
                txtPost.Text = "";
                button1_Click(sender, e);
            }
            else
            {
                //Show error dialog 
                // error txtPost text is empty
            }
        }
    }
}
