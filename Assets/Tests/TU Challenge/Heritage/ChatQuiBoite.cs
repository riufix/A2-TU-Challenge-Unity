using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TU_Challenge.Heritage.Animal;

namespace TU_Challenge.Heritage
{
    public class ChatQuiBoite : Chat
    {
        public ChatQuiBoite(string name) : base(name)
        {
            _pattes = 3;
        }

        public override void EnterAnimalerie(Animalerie animalerie)
        {
            
        }
    }
}
