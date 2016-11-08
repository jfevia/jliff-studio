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
    [XmlRoot(ElementName = "file", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
    public class File
    {
        [XmlElement(ElementName = "header", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
        public Header Header { get; set; }
        [XmlElement(ElementName = "body", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
        public Body Body { get; set; }
        [XmlAttribute(AttributeName = "build-num")]
        public string BuildNumber { get; set; }
        [XmlAttribute(AttributeName = "datatype")]
        public string DataType { get; set; }

        [XmlAttribute(AttributeName = "original")]
        public string Original { get; set; }
        [XmlAttribute(AttributeName = "product-name")]
        public string ProductName { get; set; }
        [XmlAttribute(AttributeName = "product-version")]
        public string ProductVersion { get; set; }
        [XmlAttribute(AttributeName = "source-language")]
        public string SourceLanguage { get; set; }
        [XmlAttribute(AttributeName = "target-language")]
        public string TargetLanguage { get; set; }
        [XmlAttribute(AttributeName = "tool-id")]
        public string ToolId { get; set; }
    }
}
