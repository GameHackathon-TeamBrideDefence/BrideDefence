﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrideDefence
{
    public abstract class Tower : GameEngine
    {
        private bool isActive;
        private int towerDamage;
        private int towerRange;
        private object towerType;
    
        public int IsActive
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int TowerDamage
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int TowerRange
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int TowerType
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
