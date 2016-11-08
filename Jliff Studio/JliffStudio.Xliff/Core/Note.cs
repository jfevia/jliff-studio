using System.Xml.Serialization;
using PropertyChanged;

namespace JliffStudio.Xliff
{
    [ImplementPropertyChanged]
    public class Note
    {
        public string Annotates { get; set; }
        public string From { get; set; }
        public string Priority { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}