using System;
using System.Collections.Generic;
using System.Text;
using ChatApp.Chat.Participants;

namespace ChatApp.Chat.Rooms
{
    public class Chatroom : IChatroom
    {
        private readonly Dictionary<string, IParticipant> participants;

        public Chatroom()
        {
            this.participants = new Dictionary<string, IParticipant>();
        }

        public void Register(IParticipant participant)
        {
            if(!this.participants.ContainsKey(participant.Name))
            {
                this.participants.Add(participant.Name, participant);
            }

            participant.Chatroom = this;
        }

        public void Send(string sender, string receiver, string message)
        {
            if(this.participants.ContainsKey(receiver))
            {
                var participant = this.participants[receiver];
                participant.ReceiveMessage(sender, message);
            }
        }
    }
}
