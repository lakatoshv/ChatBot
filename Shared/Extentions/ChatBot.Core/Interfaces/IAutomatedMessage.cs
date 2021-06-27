using System;

namespace ChatBot.Core.Interfaces
{
    /// <summary>
    /// Automated message interface.
    /// </summary>
    public interface IAutomatedMessage
    {
        /// <summary>
        /// Initializes the specified current time.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        void Initialize(DateTime currentTime);

        /// <summary>
        /// Determines whether [is it time to display] [the specified current time].
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <returns>
        ///   <c>true</c> if [is it time to display] [the specified current time]; otherwise, <c>false</c>.
        /// </returns>
        bool IsItTimeToDisplay(DateTime currentTime);

        /// <summary>
        /// Gets the message.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <returns>string.</returns>
        string GetMessage(DateTime currentTime);
    }
}