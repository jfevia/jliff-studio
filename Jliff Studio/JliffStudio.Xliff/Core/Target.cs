using PropertyChanged;

namespace JliffStudio.Xliff
{
    /// <summary>
    ///     The translation of the content of the sibling source element.
    /// </summary>
    [ImplementPropertyChanged]
    public class Target
    {
        /// <summary>
        ///     The translation of the content of the sibling source element.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        ///     Indicate in which state the target is.
        /// </summary>
        public State State { get; set; }

        /// <summary>
        ///     Describes the state of the translation.
        /// </summary>
        public StateQualifier StateQualifier { get; set; }
    }
}