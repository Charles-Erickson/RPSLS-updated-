using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    abstract public class Player
    {
        public int Score;
        public string Gesture;
        public virtual string PlayerInput()
        {
            return "";
        }
        //members variables





        //constructor






        //member methods

    }
}