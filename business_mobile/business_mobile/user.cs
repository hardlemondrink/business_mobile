using System;
using System.Collections.Generic;
using System.Text;

namespace business_mobile
{
    public class User
    {
        public string UserId { get; set;}
        public string Deviceid { get; set; }
        public string ClientUid { get; set; }
        public string TypeClient { get; private set; }
        public void SetTypeClient()
        {

        }
    }
}
