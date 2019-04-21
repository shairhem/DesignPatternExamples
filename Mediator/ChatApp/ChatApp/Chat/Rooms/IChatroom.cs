using ChatApp.Chat.Participants;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatApp.Chat.Rooms
{
    public interface IChatroom
    {
        void Register(IParticipant participant);

        void Send(string sender, string receiver, string message);
    }
}
