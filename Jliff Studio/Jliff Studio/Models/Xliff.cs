using System.Collections.Generic;
using System.Xml.Serialization;

namespace JliffStudio.Models
{
    [XmlRoot(ElementName = "tool", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
    public class Tool
    {
        [XmlAttribute(AttributeName = "tool-company")]
        public string Company { get; set; }
        [XmlAttribute(AttributeName = "tool-id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "tool-name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "tool-version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "header", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
    public class Header
    {
        [XmlElement(ElementName = "tool", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
        public Tool Tool { get; set; }
    }

    [XmlRoot(ElementName = "target", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
    public class Target
    {
        [XmlAttribute(AttributeName = "state")]
        public string State { get; set; }
        [XmlAttribute(AttributeName = "state-qualifier")]
        public string StateQualifier { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "trans-unit", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
    public class TranslationUnit
    {
        [XmlAttribute(AttributeName = "extype")]
        public string ExtendedType { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "source", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
        public string Source { get; set; }
        [XmlElement(ElementName = "target", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
        public Target Target { get; set; }
        [XmlElement(ElementName = "note", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
        public Note Note { get; set; }

        [XmlAttribute(AttributeName = "space", Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string Space { get; set; }

        [XmlAttribute(AttributeName = "translate")]
        public string Translate { get; set; }
    }

    [XmlRoot(ElementName = "note", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
    public class Note
    {
        [XmlAttribute(AttributeName = "annotates")]
        public string Annotates { get; set; }
        [XmlAttribute(AttributeName = "from")]
        public string From { get; set; }
        [XmlAttribute(AttributeName = "priority")]
        public string Priority { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

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

    [XmlRoot(ElementName = "body", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
    public class Body
    {
        [XmlElement(ElementName = "group", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
        public Group Group { get; set; }
    }

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

    [XmlRoot(ElementName = "xliff", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
    public class Xliff
    {
        [XmlElement(ElementName = "file", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
        public File File { get; set; }
        [XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string XmlNamespace { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string XmlSchemaInstance { get; set; }
    }
}