using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class Chat : Animal
    {

        public Chat(string name) : base(name)
        {
            _pattes = 4;
        }

        public override string Crier()
        {
            switch (Fed)
            {
                case AnimalState.Hungry:
                    return "Miaou (j'ai faim)";
                case AnimalState.Fed:
                    return "Miaou (c'est bon laisse moi tranquille humain)";
                case AnimalState.AteBubulle:
                    return "Miaou(Le poisson etait bon)";
                default:
                    return "";
            }
        }

    }
}
