﻿using System;
using System.Collections.Generic;
using System.Text;
using CFX.Structures;

namespace CFX.Production
{
    /// <summary>
    /// Sent by a process endpoint to identify that a specific production unit is disqualified or scrapped.
    /// This includes logical disqualification in the case that a unit is abandoned during manufacturing
    /// </summary>
    public class UnitsDisqualified : CFXMessage
    {
        public UnitsDisqualified()
        {
            Units = new List<UnitPosition>();
        }

        /// <summary>
        /// The number of individual production units
        /// </summary>
        public int UnitCount
        {
            get
            {
                return Units.Count;
            }
            private set
            {
            }
        }

        /// <summary>
        /// List of structures that identify each specific instance of production unit to be disqualified (could be within a carrier or panel). 
        /// </summary>
        public List<UnitPosition> Units
        {
            get;
            set;
        }
    }
}