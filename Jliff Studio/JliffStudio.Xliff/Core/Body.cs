using System.Xml.Serialization;
using PropertyChanged;

namespace JliffStudio.Xliff
{
    [ImplementPropertyChanged]
    [XmlRoot(ElementName = "body", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
    public class Body
    {
        [XmlElement(ElementName = "group", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
        public Group Group { get; set; }
    }
}