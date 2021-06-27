using System;
using ChatBot.Core.Interfaces;

namespace ChatBot.UnitTests.AutomatedMessagingTests.DataForTests
{
    /// <summary>
    /// Never ready message.
    /// </summary>
    /// <seealso cref="IAutomatedMessage" />
    public class NeverReadyMessage : IAutomatedMessage
    {
        /// <inheritdoc cref="IAutomatedMessage"/>
        public void Initialize(DateTime currentTime)
        {
        }

        /// <inheritdoc cref="IAutomatedMessage"/>
        public bool IsItTimeToDisplay(DateTime currentTime)
        {
            return false;
        }

        /// <inheritdoc cref="IAutomatedMessage"/>
        public string GetMessage(DateTime currentTime)
        {
            throw new NotImplementedException("Something went wrong!");
        }
    }
}