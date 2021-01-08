using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryNumberValidator
{
    class StateMachine
    {

        const int S1 = 0;   //no money entered
        const int S2 = 1;   //5p 
        const int S3 = 2;   //10p
        const int S4 = 3;   //15p
        const int S5 = 4;   //20p
        const int S6 = 4;   //25p
        const int S7 = 4;   //30p
        const int S8 = 4;   //35p
        const int S9 = 4;   //40p+

        private int[,] stateMachine;
        private int state;
        private int acceptState;

        public StateMachine()
        {

            stateMachine = new int[,] { { S2, S5 }, { S3, S6 }, { S4, S7 }, { S5, S8 }, { S6, S9 }, { S7, S9 }, { S8, S9 }, { S9, S9 }, { S9, S9 } };
            reset();
        }

        public void input(int message)
        {
            state = stateMachine[state, message];
        }

        public bool inAccept() { return acceptState == state; }

        public void reset()
        {
            state = S1;
            acceptState = S9;
        }
    }
}