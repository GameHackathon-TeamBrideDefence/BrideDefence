using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrideDefence
{
    public class Bride : GameEngine
    {
        private int currentBrideHitpoints;
        private int brideLevel;
        private int bridePosition;

        public int CurrentBrideHitpoints
        {
            get
            {
                return this.currentBrideHitpoints;
            }
            set
            {
                if (value < 0)
                {
                    this.currentBrideHitpoints = 0;
                }
                else
                {
                    this.currentBrideHitpoints = value;
                }
            }
        }

        public int BrideLevel
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int BridePosition
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
