using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class GameCharacter: Character {
        private const int SleepTimeMilliseconds = 3000;
        public int HealthRegeneration { get; set; }
        public int ReceivedDamage { get; set; }
        public int PlayTime { get; set; }
        public bool IsEnemy { get; set; }
        public double Speed { get; set; }
        public string SkinId { get; set; }
        public Inventory Inventory { get; set; }
        public CharacterRace CharacterRace { get; set; }

        public GameCharacter() {
            Inventory = new Inventory();
            LifePoint = InitialHealth;
            CharacterRace = CharacterRace.Unknown;
            Text = new CharacterReply();
        }

        public GameCharacter(GameCharacter target) {
            if (target != null) {
                PlayTime = target.PlayTime;
                Inventory = target.Inventory;
                IsEnemy = target.IsEnemy;
                Speed = target.Speed;
                SkinId = target.SkinId;
                Age = target.Age;
                Name = target.Name;
                Position = target.Position;
                HealthRegeneration = target.HealthRegeneration;
                CharacterRace = target.CharacterRace;
                LifePoint = target.LifePoint;
                ReceivedDamage = target.ReceivedDamage;
                Text = target.Text;
            }
        }

        public override Character Clone() {
            return new GameCharacter(this);
        }

        private void RestoreHealth() {
            LifePoint += HealthRegeneration;
        }
        
        public void UseMedicine() {
            if (Inventory.Bags.UseMedicalLeaf()) {
                RestoreHealth();   
                NormalizeLifePoint();
            }
        }

        public string UseTree() {
            return Inventory.Bags.UseTree();
        }
        
        public void HandleDamage(int damage) {
            ApplyDamage(damage);
            NormalizeLifePoint();
        }

        private void ApplyDamage(int damage) {
            if (damage > 0) {
                LifePoint -= damage;    
            }
        }

        public void CallAvatarForHelp() {
            if (Inventory.Bags.IsAvailableCallAvatar()) {
                LifePoint = InitialHealth;
            }
        }

        public override string Talk() {
            return Text.GetText();
        }

        public override async void Sleep() {
            await Task.Delay(SleepTimeMilliseconds);
        }

        public override void Eat(Food food) {
            if (food.IsSufficientQuantity()) {
                food.Consume();
                LifePoint += (HealthRegeneration * food.Power);
            }
        }
    }
}