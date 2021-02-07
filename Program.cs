using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordRPC;

namespace DRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var Context = new DiscordRpcClient("795615344319528980"); // this id is for a minecraft rpc that I tried making a bit ago
            Context.Initialize();

            Context.UpdateState("for 2 years");
            Context.UpdateLargeAsset("minecraft");
            
            System.Threading.Thread.Sleep(-1);
        }
        private static void JoinRequested(object sender, DiscordRPC.Message.JoinRequestMessage args)
        {
            
        }
    }
}
