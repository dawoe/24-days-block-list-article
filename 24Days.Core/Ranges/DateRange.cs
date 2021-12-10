using System;

namespace _24Days.Core.Ranges
{
    /// <inheritdoc/>
    public class DateRange : IRange<DateTime>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateRange"/> class.
        /// </summary>
        /// <param name="start">The start date.</param>
        /// <param name="end">The end date.</param>
        /// <remarks>
        /// If the end date is lower than the start date they will be switched.
        /// </remarks>
        public DateRange(DateTime? start = null, DateTime? end = null)
        {
            this.Start = start ?? DateTime.MinValue;
            this.End = end ?? DateTime.MaxValue;

            if (this.Start <= this.End)
            {
                return;
            }

            var temp = this.End;
            this.End = this.Start;
            this.Start = temp;
        }

        /// <inheritdoc/>
        public DateTime Start { get; }

        /// <inheritdoc/>
        public DateTime End { get; }

        /// <inheritdoc/>
        public bool Includes(DateTime value) => !this.IsBefore(value) && !this.IsAfter(value);

        /// <inheritdoc/>
        public bool IsBefore(DateTime value) => value < this.Start;

        /// <inheritdoc/>
        public bool IsAfter(DateTime value) => value > this.End;
    }
}
