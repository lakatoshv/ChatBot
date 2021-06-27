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

        /// <summary>
        /// Returns the true given time equal to delay in minutes.
        /// </summary>
        [Fact]
        public void ReturnTrue_GivenTimeEqualToDelayInMinutes()
        {
            var intervalTriggeredMessage = new IntervalTriggeredMessage()
            {
                DelayInMinutes = 1,
                Message = "Welcome! If you are enjoying the content, please follow this channel!",
            };

            intervalTriggeredMessage.Initialize(_currentTime);

            Assert.True(intervalTriggeredMessage.IsItTimeToDisplay(_currentTime.AddMinutes(intervalTriggeredMessage.DelayInMinutes)));
        }

        /// <summary>
        /// Returns the false immediately after sending message.
        /// </summary>
        [Fact]
        public void ReturnFalse_ImmediatelyAfterSendingMessage()
        {
            var intervalTriggeredMessage = new IntervalTriggeredMessage()
            {
                DelayInMinutes = 1,
                Message = "Welcome! If you are enjoying the content, please follow this channel!",
            };

            intervalTriggeredMessage.Initialize(_currentTime.AddMinutes(-1));
            intervalTriggeredMessage.GetMessage(_currentTime);

            Assert.False(intervalTriggeredMessage.IsItTimeToDisplay(DateTime.Now));
        }
    }
}