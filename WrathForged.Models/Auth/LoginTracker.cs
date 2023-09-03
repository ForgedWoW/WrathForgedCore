using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrathForged.Models.Auth
{
    public class LoginTracker
    {
        public DateTime LastAttempt { get; set; }
        public int Attempts { get; set; }
    }
}
