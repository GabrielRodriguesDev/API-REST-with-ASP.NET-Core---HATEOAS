using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST_with_ASP.NET_Core_HATEOAS.Hateoas
{
    public class Hateoas
    {
        private string url;

        private string protocol = "https://";

        public List<Link> actions = new List<Link>();

        public Hateoas(string url)
        {
            this.url = url;
        }

        public Hateoas(string url, string protocol)
        {
            this.url = url;
            this.protocol = protocol;
        }


        public void AddAction(string rel, string method) {
            this.actions.Add(new Link(this.protocol + this.url, rel, method));
        }
    }
}