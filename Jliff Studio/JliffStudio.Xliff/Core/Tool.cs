using PropertyChanged;

namespace JliffStudio.Xliff
{
    /// <summary>
    ///     Describes the tool that has been used to execute a given task in the document.
    /// </summary>
    [ImplementPropertyChanged]
    public class Tool
    {
        /// <summary>
        ///     Specifies the company from which the tool originates.
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        ///     The unique identification of a tool element. It is also used in other elements in the
        ///     file to refer to the given tool element.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     Specifies the name of the tool.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Specifies the version of the tool.
        /// </summary>
        public string Version { get; set; }
    }
}