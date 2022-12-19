using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.Inheritance
{
    abstract class Character
    {
        protected string characterType;
        protected Character(string characterType) => this.characterType = characterType;
        public abstract int DamagePoints(Character target);
        public virtual bool Vulnerable() => false;
        public override string ToString() => $"Character is a {characterType}";
    }

    class Warrior : Character
    {
        public Warrior() : base("Warrior") { }
        public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
    }

    class Wizard : Character
    {
        private bool spellIsPrepared = false;
        public Wizard() : base("Wizard") { }
        public override bool Vulnerable() => !spellIsPrepared;
        public override int DamagePoints(Character target) => spellIsPrepared ? 12 : 3;
        public void PrepareSpell() => spellIsPrepared= true;

    }
}
