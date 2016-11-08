using PropertyChanged;

namespace JliffStudio.Xliff
{
    [ImplementPropertyChanged]
    public class Document
    {
        public File File { get; set; }
        public string SchemaLocation { get; set; }
        public string Version { get; set; }
        public string XmlNamespace { get; set; }
        public string XmlSchemaInstance { get; set; }
    }
}