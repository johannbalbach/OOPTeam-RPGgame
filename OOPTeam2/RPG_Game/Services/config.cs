using OOPTeam2.RPG_Game.Models.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services
{
    internal class config
    {
        public const int playerSize = 10;
        public const int attackDistance = 5;
        public const int botSize = 10;
        public const int talkProbability = 10;
        public const int talkMax = 100;
        public const int avatarDistance = 70;

        public static bool InDistance(Position player, Position managedCharacter)
        {
            if ((managedCharacter.X - config.botSize - config.attackDistance >= player.X + config.playerSize)
                || (managedCharacter.X + config.botSize + config.attackDistance <= player.X - config.playerSize))
            {
                return false;
            }  
            else
            {
                return true;
            }
        }
        public static bool InDistance(Position exception, int x)
        {
            if ((exception.X - config.playerSize - config.attackDistance >= x + config.botSize) || (exception.X + config.playerSize + config.attackDistance <= x - config.botSize))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
