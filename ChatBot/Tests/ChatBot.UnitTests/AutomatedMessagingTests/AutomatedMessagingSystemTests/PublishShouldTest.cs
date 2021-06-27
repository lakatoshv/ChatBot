using System;
using ChatBot.Core.AutomatedMessaging;
using Xunit;

namespace ChatBot.UnitTests.AutomatedMessagingTests.AutomatedMessagingSystemTests
{
    /// <summary>
    /// Publish should test.
    /// </summary>
    public class PublishShouldTest
    {
        /// <summary>
        /// Automated the message to managed message.
        /// </summary>
        [Fact]
        public void AutomatedMessageToManagedMessage()
        {
            var messagingSystem = new AutomatedMessagingSystem();
            var intervalTriggeredMessage = new IntervalTriggeredMessage
            {
                DelayInMinutes = 1,
                Message = "Welcome! If you are enjoying the content, please follow this channel!",
            };
            intervalTriggeredMessage.Initialize(DateTime.Now);
            messagingSystem.Publish(intervalTriggeredMessage);

            Assert.Contains(intervalTriggeredMessage, messagingSystem.ManagedAutomatedMessages);
        }
    }
}