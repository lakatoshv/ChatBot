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

        /// <summary>
        /// Adds the one messages to queue given one ready automated messages.
        /// </summary>
        [Fact]
        public void AddOneMessagesToQueue_GivenOneReadyAutomatedMessages()
        {
            var automatedMessagingSystem = new AutomatedMessagingSystem();
            automatedMessagingSystem.Publish(new AlwaysReadyMessage());
            automatedMessagingSystem.CheckMessages(DateTime.Now);

            Assert.Single(automatedMessagingSystem.QueuedMessages);
        }

        /// <summary>
        /// Adds the one messages to queue given many messages given one ready automated messages.
        /// </summary>
        [Fact]
        public void AddOneMessagesToQueue_GivenManyMessages_GivenOneReadyAutomatedMessages()
        {
            var automatedMessagingSystem = new AutomatedMessagingSystem();
            automatedMessagingSystem.Publish(new AlwaysReadyMessage());
            automatedMessagingSystem.Publish(new NeverReadyMessage());
            automatedMessagingSystem.Publish(new NeverReadyMessage());
            
            automatedMessagingSystem.CheckMessages(DateTime.Now);

            Assert.Single(automatedMessagingSystem.QueuedMessages);
        }
    }
}