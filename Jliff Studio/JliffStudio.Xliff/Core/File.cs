using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PropertyChanged;

namespace JliffStudio.Xliff
{

    [ImplementPropertyChanged]
    public class File
    {
        public Header Header { get; set; }
        public Body Body { get; set; }
        public string BuildNumber { get; set; }
        public string DataType { get; set; }
        public string Original { get; set; }
        public string ProductName { get; set; }
        public string ProductVersion { get; set; }
        public string SourceLanguage { get; set; }
        public string TargetLanguage { get; set; }
        public string ToolId { get; set; }
    }
}
