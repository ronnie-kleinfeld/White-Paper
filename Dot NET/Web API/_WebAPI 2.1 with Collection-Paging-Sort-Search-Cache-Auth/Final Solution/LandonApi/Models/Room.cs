using LandonApi.Infrastructure;
using Newtonsoft.Json;

namespace LandonApi.Models {
    public class Room : Resource, IEtaggable {
        [Sortable]
        [SearchableString]
        public string Name { get; set; }

        [Sortable(Default = true)]
        [SearchableDecimal]
        public decimal Rate { get; set; }

        public Form Book { get; set; }

        public Link Openings { get; set; }

        public string GetEtag() {
            var serialized = JsonConvert.SerializeObject(this);
            return Md5Hash.ForString(serialized);
        }
    }
}