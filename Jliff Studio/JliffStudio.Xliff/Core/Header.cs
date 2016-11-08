using PropertyChanged;

namespace JliffStudio.Xliff
{
    /// <summary>
    ///     Element that contains metadata relating to the file element.
    /// </summary>
    [ImplementPropertyChanged]
    public class Header
    {
        /// <summary>
        ///     The tool that has been used to execute a given task in the document.
        /// </summary>
        public Tool Tool { get; set; }
    }
}