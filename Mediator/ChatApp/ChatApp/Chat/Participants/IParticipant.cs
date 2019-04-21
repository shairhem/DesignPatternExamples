
using ChatApp.Chat.Rooms;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatApp.Chat.Participants
{
    public interface IParticipant
    {
        string Name { get; }

        IChatroom Chatroom { get; set; }

        void SendMessage(string receiver, string message);

        void ReceiveMessage(string sender, string message);
    }
}
