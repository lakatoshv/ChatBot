using System;
using ChatBot.Core.Interfaces;

namespace ChatBot.UnitTests.AutomatedMessagingTests.DataForTests
{
    /// <summary>
    /// Always ready message.
    /// </summary>
    /// <seealso cref="IAutomatedMessage" />
    public class AlwaysReadyMessage : IAutomatedMessage
    {
        /// <inheritdoc cref="IAutomatedMessage"/>
        public void Initialize(DateTime currentTime)
        {
        }

        /// <inheritdoc cref="IAutomatedMessage"/>
        public bool IsItTimeToDisplay(DateTime currentTime)
        {
            return true;
        }

        /// <inheritdoc cref="IAutomatedMessage"/>
        public string GetMessage(DateTime currentTime)
        {
            return "Always ready";
        }
    }
}