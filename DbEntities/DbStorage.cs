using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxLesson.DbEntities
{
    public static class DbStorage
    {
        public static TradeEntities DB { get; set; } = new TradeEntities();
    }
}
