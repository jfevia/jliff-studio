using System.Collections.Generic;
using System.Xml.Serialization;
using PropertyChanged;

namespace JliffStudio.Xliff
{
    [ImplementPropertyChanged]
    public class Group
    {
        public string Datatype { get; set; }
        public string Id { get; set; }
        public List<TranslationUnit> TranslationUnits { get; set; }
    }
}