using System;
using System.Collections.Generic;
using System.Text;

namespace business_mobile
{
    class ServerQuery
    {
        private void ConnectServer()
        {

        }
        public static string[] Tasks(string id, string status)
        {
            if (status == "new")
            {
                return new string[] { "Долбиться в жопу", "Позвонить Олегу", "Послать Краса" };
            }
            if (status == "inProgress")
            {
                return new string[] { "Бизнесвумены", "Олеговны", "АЛО" };
            }
            if (status == "Done")
            {
                return new string[] { "Долбиться в жопу", "Позвонить Олегу", "Послать Краса" };
            }
            if (status == "settings")
            {
                return new string[] { "id: " + user.userid };
            }

            return null;
        }
    }
}
