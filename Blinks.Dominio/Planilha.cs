using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blinks.Dominio
{
    public class Planilha
    {
        public string id { get; set; }
        public DateTime date { get; set; }

        public string media { get; set; }

        public string client_id { get; set; }

        public string client_name { get; set; }

        public string campaign_id { get; set; }

        public string campaign_name { get; set; }

        public int clicks { get; set; }

        public int impressions { get; set; }

        public float investment { get; set; }


    }

}
