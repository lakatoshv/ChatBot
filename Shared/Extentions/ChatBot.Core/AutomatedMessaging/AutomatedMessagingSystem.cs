using System;
using System.Collections.Generic;
using System.Linq;
using ChatBot.Core.Interfaces;

namespace ChatBot.Core.AutomatedMessaging
{
    /// <summary>
    /// Automated messaging system.
    /// </summary>
    public class AutomatedMessagingSystem
    {
        // TODO: lock down access to this.        
        /// <summary>
        /// Gets or sets the managed automated messages.
        /// </summary>
        /// <value>
        /// The managed automated messages.
        /// </value>
        public List<IAutomatedMessage> ManagedAutomatedMessages { get; set; } = new List<IAutomatedMessage>();

        // TODO: lock down access to this.        
        /// <summary>
        /// Gets or sets the queued messages.
        /// </summary>
        /// <value>
        /// The queued messages.
        /// </value>
        public List<string> QueuedMessages { get; set; } = new List<string>();

        /// <summary>
        /// Publishes the specified automated message.
        /// </summary>
        /// <param name="automatedMessage">The automated message.</param>
        public void Publish(IAutomatedMessage automatedMessage)
        {
            automatedMessage.Initialize(DateTime.Now);
            ManagedAutomatedMessages.Add(automatedMessage);
        }
    }
}