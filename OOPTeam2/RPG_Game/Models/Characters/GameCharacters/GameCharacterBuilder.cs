namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class GameCharacterBuilder {
        private int playTime;
        private Inventory inventory;
        private bool isEnemy;
        private bool isAlive;
        private double speed;
        private string skinId;
        private int healthRegeneration;
        private int age;
        private string name;
        private Position position;

        public GameCharacterBuilder WithPlayTime(int playTime) {
            this.playTime = playTime;
            return this;
        }

        public GameCharacterBuilder WithInventory(Inventory inventory) {
            this.inventory = inventory;
            return this;
        }

        public GameCharacterBuilder WithIsEnemy(bool isEnemy) {
            this.isEnemy = isEnemy;
            return this;
        }

        public GameCharacterBuilder WithIsAlive(bool isAlive) {
            this.isAlive = isAlive;
            return this;
        }

        public GameCharacterBuilder WithSpeed(double speed) {
            this.speed = speed;
            return this;
        }

        public GameCharacterBuilder WithSkinId(string skinId) {
            this.skinId = skinId;
            return this;
        }

        public GameCharacterBuilder WithHealthRegeneration(int healthRegeneration) {
            this.healthRegeneration = healthRegeneration;
            return this;
        }

        public GameCharacterBuilder WithAge(int age) {
            this.age = age;
            return this;
        }

        public GameCharacterBuilder WithName(string name) {
            this.name = name;
            return this;
        }

        public GameCharacterBuilder WithPosition(Position position) {
            this.position = position;
            return this;
        }

        public GameCharacter Build() {
            GameCharacter gameCharacter = new GameCharacter();
            gameCharacter.playTime = playTime;
            gameCharacter.inventory = inventory;
            gameCharacter.isEnemy = isEnemy;
            gameCharacter.isAlive = isAlive;
            gameCharacter.speed = speed;
            gameCharacter.skinId = skinId;
            gameCharacter.healthRegeneration = healthRegeneration;
            gameCharacter.age = age;
            gameCharacter.name = name;
            gameCharacter.position = position;
            return gameCharacter;
        }
    }
}