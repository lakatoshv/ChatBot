using System;
using ChatBot.Core.AutomatedMessaging;
using Xunit;

namespace ChatBot.UnitTests.AutomatedMessagingTests.IntervalTriggeredMessagesTests
{
    /// <summary>
    /// Is it time to display should test.
    /// </summary>
    public class IsItTimeToDisplayShouldTest
    {
        /// <summary>
        /// The current time.
        /// </summary>
        private readonly DateTime _currentTime;

        /// <summary>
        /// Initializes a new instance of the <see cref="IsItTimeToDisplayShouldTest"/> class.
        /// </summary>
        public IsItTimeToDisplayShouldTest()
        {
            _currentTime = DateTime.Now;
        }

        /// <summary>
        /// Returns the false at initial creation.
        /// </summary>
        [Fact]
        public void ReturnFalse_AtInitialCreation()
        {
            var intervalTriggeredMessage = new IntervalTriggeredMessage()
            {
                DelayInMinutes = 1,
                Message = "Welcome! If you are enjoying the content, please follow this channel!",
            };

            intervalTriggeredMessage.Initialize(_currentTime);

            Assert.False(intervalTriggeredMessage.IsItTimeToDisplay(_currentTime));
        }
    }
}