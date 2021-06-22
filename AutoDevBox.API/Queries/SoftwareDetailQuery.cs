using System.IO;

namespace AutoDevBox.Api.Models.Queries
{
    public class SoftwareDetailQuery
    {
        public SoftwareDetailQuery() { }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public bool IsTrial { get; set; }
        public Stream InstallFile { get; set; }
    }
}
