using System;
using ChatBot.Core.Interfaces;

namespace ChatBot.Core.AutomatedMessaging
{
    /// <summary>
    /// Interval triggered message.
    /// </summary>
    /// <seealso cref="ChatBot.Core.Interfaces.IAutomatedMessage" />
    public class IntervalTriggeredMessage : IAutomatedMessage
    {
        /// <summary>
        /// The previous run time.
        /// </summary>
        private DateTime _previousRunTime;

        /// <summary>
        /// Gets or sets the delay in minutes.
        /// </summary>
        /// <value>
        /// The delay in minutes.
        /// </value>
        public int DelayInMinutes { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Initializes the specified current time.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        public void Initialize(DateTime currentTime)
        {
            _previousRunTime = currentTime;
        }

        /// <summary>
        /// Determines whether [is it time to display] [the specified current time].
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <returns>
        ///   <c>true</c> if [is it time to display] [the specified current time]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsItTimeToDisplay(DateTime currentTime) =>
            _previousRunTime.AddMinutes(DelayInMinutes) <= currentTime;

        /// <summary>
        /// Gets the message.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <returns>
        /// string.
        /// </returns>
        public string GetMessage(DateTime currentTime)
        {
            _previousRunTime = currentTime;

            return Message;
        }
    }
}