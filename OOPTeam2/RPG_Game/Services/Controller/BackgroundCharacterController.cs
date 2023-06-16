using OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters;
using OOPTeam2.RPG_Game.Models.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services.Controller
{
    public class BackgroundCharacterController
    {
        public NonPlayerCharacter character { get; protected set; }

        protected int currentIndex = 7;

        private static int[,] directions = new int[8, 2] {
                    { -1, -1},
                    {-1, 0},
                    {-1, 1 },
                    { 0, 1},
                    { 1, 1},
                    { 1, 0},
                    { 1, -1},
                    { 0, -1} };
        
        private const int turnChance = 1;
        private const int randomMax = 4;

        public void Update()
        {
            character.position = NextPosition();
        }

        protected Position NextPosition()
        {
            SingletonRand rnd = SingletonRand.getInstance();
            if (rnd.Next(randomMax) <= turnChance)
            {
                turnRight();
            }
            else if (rnd.Next(randomMax) <= turnChance)
            {
                turnLeft();
            }

            int x = character.position.x + directions[currentIndex, 0];
            int y = character.position.y + directions[currentIndex, 1];

            return new Position(x, y);
        }
        protected virtual void turnLeft() { }
        protected virtual void turnRight() { }

    }
}
