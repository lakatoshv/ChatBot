using System;
using ChatBot.Core.AutomatedMessaging;
using ChatBot.UnitTests.AutomatedMessagingTests.DataForTests;
using Xunit;

namespace ChatBot.UnitTests.AutomatedMessagingTests.AutomatedMessagingSystemTests
{
    /// <summary>
    /// Check messages should test.
    /// </summary>
    public class CheckMessagesShouldTest
    {
        /// <summary>
        /// Adds the no messages to queue given no automated messages.
        /// </summary>
        [Fact]
        public void AddNoMessagesToQueue_GivenNoAutomatedMessages()
        {
            var automatedMessagingSystem = new AutomatedMessagingSystem();
            automatedMessagingSystem.CheckMessages(DateTime.Now);

            Assert.Empty(automatedMessagingSystem.QueuedMessages);
        }
    }
}