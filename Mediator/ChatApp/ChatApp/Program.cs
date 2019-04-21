using ChatApp.Chat.Participants;
using ChatApp.Chat.Rooms;
using System;

namespace ChatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatroom = new Chatroom();
            var p1 = new Participant("User1");
            var p2 = new Participant("User2");
            var p3 = new Participant("User3");

            chatroom.Register(p1);
            chatroom.Register(p2);
            chatroom.Register(p3);

            p1.SendMessage("User2", "Hi! ");
            p2.SendMessage("User1", "Hi aswell! ");
        }
    }
}
