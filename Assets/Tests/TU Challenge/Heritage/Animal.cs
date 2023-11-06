using System;

namespace TU_Challenge.Heritage
{

    public class Animal
    {

        public event Action OnDie;

        public bool IsAlive { get; set; }
        public bool Pattes { get; set; }
        public bool Name { get; set; }

        public bool Crier()
        {
            throw new NotImplementedException();
        }
        public void Die()
        {
            throw new NotImplementedException();
        }
    }
}
