using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.User
{
    public class UserEndpoint : FbClient
    {
        public UserEndpoint(string username, string password)
            : base(username, password)
        {
        }
        /// <summary>
        /// Post to wall
        /// </summary>
        /// <param name="message">Content you want to post</param>                  
        public void Post(string message)
        {
            HtmlNode document = __BuildDomFromUrl("https://m.facebook.com/");
            HtmlNode postForm = document.SelectSingleNode("//form[contains(@action, '/composer')]");
            if (postForm == null)
                throw new Exception("UserEndpoint_Post: //form[contains(@action, '/composer')] node is null");

            string actionUrl = postForm.GetAttributeValue("action", null);
            if (actionUrl == null)
                throw new Exception("Post action address not found!");

            List<string> postData = __ExtractHidenInputNodes(postForm.ParentNode);
            postData.Add("view_post=Post");
            postData.Add("xc_message=" + Uri.EscapeDataString(message));
            _requestHandler.SendPOSTRequest("https://m.facebook.com" + actionUrl, __CreatePayload(postData));
        }
       
    }
}
