using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMME_Deneme1.Entity
{
    public class UserInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public Friends Friends { get; set; }
        public Location Location { get; set; }
    }

    public class Friends
    {
        public Summary Summary { get; set; }
    }

    public class Summary
    {
        public int total_count { get; set; }
    }
    public class Location
    {
        public string Name { get; set; }
    }


    public class PostData
    {
        public string message { get; set; }
        public string created_time { get; set; }
        public string full_picture { get; set; }
    }


    public class LikeData
    {
        public string Name { get; set; }
        public string Link { get; set; }
    }
}
