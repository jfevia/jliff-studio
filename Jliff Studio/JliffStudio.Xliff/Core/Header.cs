using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PropertyChanged;

namespace JliffStudio.Xliff
{

    /// <summary>
    /// Element that contains metadata relating to the file element.
    /// </summary>
    [ImplementPropertyChanged]
    [XmlRoot(ElementName = "header", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
    public class Header
    {
        /// <summary>
        /// The tool that has been used to execute a given task in the document.
        /// </summary>
        [XmlElement(ElementName = "tool", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
        public Tool Tool { get; set; }
    }
}
