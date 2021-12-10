using System;

namespace _24Days.Core.Ranges
{
    /// <summary>
    /// Represents the range interface.
    /// </summary>
    /// <typeparam name="T">The <see cref="Type"/>.</typeparam>
    public interface IRange<T>
    {
        /// <summary>
        /// Gets the start of the range.
        /// </summary>
        T Start { get;  }

        /// <summary>
        /// Gets the end of the range.
        /// </summary>
        T End { get;  }

        /// <summary>
        /// Checks if a value is between start and end.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>A value indicating whether a value is included in the range.</returns>
        bool Includes(T value);

        /// <summary>
        /// Checks if a value is before the start of the range.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>A value indicating whether a value is before the range.</returns>
        bool IsBefore(T value);

        /// <summary>
        /// Checks if a value is before the start of the range.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>A value indicating whether a value is after the range.</returns>
        bool IsAfter(T value);
    }
}
