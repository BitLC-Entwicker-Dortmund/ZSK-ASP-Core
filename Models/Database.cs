using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZSK_ASP_Core.Models {
    public  static class Database {
        private static ZSKExchange CurrentZSKRate = new ZSKExchange ( );
        public static ZSKExchange GetCurrentZSKRate ( ) => CurrentZSKRate;
    }
}
