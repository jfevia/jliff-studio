using System;

namespace JliffStudio.Xliff
{
    public class State
    {
        /// <summary>
        ///     Indicates the terminating state.
        /// </summary>
        public State Final = new State("final", false);

        /// <summary>
        ///     Indicates only non-textual information needs adaptation.
        /// </summary>
        public State NeedsAdaptation = new State("needs-adaptation", false);

        /// <summary>
        ///     Indicates both text and non-textual information needs adaptation.
        /// </summary>
        public State NeedsLocalization = new State("needs-l10n", false);

        /// <summary>
        ///     Indicates only non-textual information needs review.
        /// </summary>
        public State NeedsReviewAdaptation = new State("needs-review-adaptation", false);

        /// <summary>
        ///     Indicates both text and non-textual information needs review.
        /// </summary>
        public State NeedsReviewLocalization = new State("needs-review-l10n", false);

        /// <summary>
        ///     Indicates that only the text of the item needs to be reviewed.
        /// </summary>
        public State NeedsReviewTranslation = new State("needs-review-translation", false);

        /// <summary>
        ///     Indicates that the item needs to be translated.
        /// </summary>
        public State NeedsTranslation = new State("needs-translation", false);

        /// <summary>
        ///     Indicates that the item is new. For example, translation units that were not in a previous version of the document.
        /// </summary>
        public State New = new State("new", false);

        /// <summary>
        ///     Indicates that changes are reviewed and approved.
        /// </summary>
        public State SignedOff = new State("signed-off", false);

        /// <summary>
        ///     Indicates that the item has been translated.
        /// </summary>
        public State Translated = new State("translated", false);

        public string Value { get; }

        public State(string value)
            : this(value, true)
        {
        }

        private State(string value, bool userDefined)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(nameof(value));
            }

            Value = userDefined ? $"x-{value}" : value;
        }
    }
}