using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Reptiles
{
    public class Alligator
    {

        //bool get_IsAquatic()
        //{
        //    return true;
        //}

        //private bool _isAquatic;

        //public bool IsAquatic
        //{
        //    get { return _isAquatic; }
        //    set { _isAquatic = value; }
        //}

        public bool IsAquatic { get; set; }
        private int _stepGoal;
        private int _stepCount;

        public Alligator(int stepGoal)
        {
            IsAquatic = true;
            _stepGoal = stepGoal;
        }

        internal void Grunt()
        {
            if (IsAquatic)
            {
                Console.WriteLine("Bubble Bubble");
            }
            else
            {
                Console.WriteLine("GRRRRRR!");
            }
        }

        public void Run(int steps)
        {
            _stepCount += steps;

            Console.WriteLine($"You ran {steps} steps.");

            if (_stepCount >= _stepGoal)
            {
                Console.WriteLine("Congratulations, you achieved your goal!!!!!!!!!!!!!!!");
            }
        }
    }
}
