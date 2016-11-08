using System.Collections.Generic;
using System.Xml.Serialization;
using PropertyChanged;

namespace JliffStudio.Xliff
{
    [ImplementPropertyChanged]
    [XmlRoot(ElementName = "group", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
    public class Group
    {
        [XmlAttribute(AttributeName = "datatype")]
        public string Datatype { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "trans-unit", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
        public List<TranslationUnit> TranslationUnits { get; set; }
    }
}