using System.Collections.Generic;
using System;

namespace PingPong.Models
{
    public class PingPongGenerator
    {

        public List<string> PingPongString(int number)
        {
            List<string> pingPongList = new List<string>{};
            for (int i = 1; i <= number; i++)
            {
                if (IfPingPong(i))
                {
                    pingPongList.Add("PingPong");
                }
                else if (IfPong(i))
                {
                    pingPongList.Add("Pong");
                }
                else if (IfPing(i))
                {
                    pingPongList.Add("Ping");
                }
                else
                {
                    pingPongList.Add(i.ToString());
                }
            }
            return pingPongList;
        }

        public bool IfPing(int number)
        {
            if (number % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IfPong(int number)
        {
            if (number % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IfPingPong(int number)
        {
            if ((number % 5 == 0) && (number % 3 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
