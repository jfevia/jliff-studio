using System.Collections.Generic;
using PropertyChanged;

namespace JliffStudio.Xliff
{
    [ImplementPropertyChanged]
    public class TranslationUnit
    {
        public string ExtendedType { get; set; }
        public string Id { get; set; }
        public List<Note> Notes { get; set; }
        public string Source { get; set; }
        public string Space { get; set; }
        public Target Target { get; set; }
        public string Translate { get; set; }
    }
}