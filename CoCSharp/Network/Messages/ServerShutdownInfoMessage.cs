﻿namespace CoCSharp.Network.Messages
{
    public class ServerShutdownInfoMessage : Message
    {
        /// Initializes a new instance of the <see cref="ServerShutdownInfoMessage"/> class.
        /// </summary>
        public ServerShutdownInfoMessage()
        {
            // Space
        }

        /// <summary>
        /// Gets the ID of the <see cref="ServerShutdownInfoMessage"/>.
        /// </summary>
        public override ushort ID { get { return 20161; } }

        /// <summary>
        /// Reads the <see cref="ServerShutdownInfoMessage"/> from the specified <see cref="MessageReader"/>.
        /// </summary>
        /// <param name="reader">
        /// <see cref="MessageReader"/> that will be used to read the <see cref="ServerShutdownInfoMessage"/>.
        /// </param>
        public override void ReadMessage(MessageReader reader)
        {
            // Space
        }

        /// <summary>
        /// Writes the <see cref="ServerShutdownInfoMessage"/> to the specified <see cref="MessageWriter"/>.
        /// </summary>
        /// <param name="writer">
        /// <see cref="MessageWriter"/> that will be used to write the <see cref="ServerShutdownInfoMessage"/>.
        /// </param>
        public override void WriteMessage(MessageWriter writer)
        {
            // Space
        }
    }
}
