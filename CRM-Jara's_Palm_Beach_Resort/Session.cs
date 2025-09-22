using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Jara_s_Palm_Beach_Resort
{
    public static class Session
    {
        public static int CurrentUserID { get; set; } = -1;
        public static string CurrentPosition { get; set; } = null;
    }
}
