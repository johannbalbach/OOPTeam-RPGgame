namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class GameCharacterBuilder {
        private int playTime;
        private Inventory inventory;
        private bool isEnemy;
        private double speed;
        private string skinId;
        private int healthRegeneration;
        private int age;
        private int lifePoint;
        private string name;
        private Position position;
        private CharacterRace characterRace;
        private CharacterReply text;

        public GameCharacterBuilder WithPlayTime(int playTime) {
            this.playTime = playTime;
            return this;
        }

        public GameCharacterBuilder WithInventory(Inventory inventory) {
            this.inventory = inventory;
            return this;
        }
        
        public GameCharacterBuilder WithText(CharacterReply text) {
            this.text = text;
            return this;
        }

        public GameCharacterBuilder WithIsEnemy(bool isEnemy) {
            this.isEnemy = isEnemy;
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
        
        public GameCharacterBuilder WithCharacterRace(CharacterRace characterRace) {
            this.characterRace = characterRace;
            return this;
        }

        public GameCharacterBuilder WithPosition(Position position) {
            this.position = position;
            return this;
        }
        
        public GameCharacterBuilder WithLifePoint(int lifePoint) {
            this.lifePoint = lifePoint;
            return this;
        }
        public GameCharacterBuilder WithWeapon(Weapon weapon) {
            inventory.Weapons.CurrentWeapon = weapon;
            return this;
        }

        public GameCharacter Build() {
            GameCharacter gameCharacter = new GameCharacter();
            gameCharacter.PlayTime = playTime;
            gameCharacter.Inventory = inventory;
            gameCharacter.IsEnemy = isEnemy;
            gameCharacter.Speed = speed;
            gameCharacter.SkinId = skinId;
            gameCharacter.HealthRegeneration = healthRegeneration;
            gameCharacter.Age = age;
            gameCharacter.Name = name;
            gameCharacter.Position = position;
            gameCharacter.LifePoint = lifePoint;
            gameCharacter.CharacterRace = characterRace;
            gameCharacter.Text = text;
            return gameCharacter;
        }
    }
}