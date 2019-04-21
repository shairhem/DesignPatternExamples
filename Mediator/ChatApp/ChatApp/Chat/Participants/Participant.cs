using System;
using System.Collections.Generic;
using System.Text;
using ChatApp.Chat.Rooms;

namespace ChatApp.Chat.Participants
{
    public class Participant : IParticipant
    {
        public string Name { get; private set; }
        public IChatroom Chatroom { get; set; }

        public Participant(string name)
        {
            this.Name = name;
        }

        public void ReceiveMessage(string sender, string message)
        {
            Console.WriteLine($"[Normal Participant] {sender}: {message}");
        }

        public void SendMessage(string receiver, string message)
        {
            this.Chatroom.Send(this.Name, receiver, message);
        }
    }
}
