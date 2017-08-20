﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriDETracker
{
    public enum TrackerLayout
    {
        RandomizerAllTrees,
        RandomizerAllEvents,
        AllSkills,
        AllCells,
        ReverseEventOrder
    }
    class MapstoneText
    {
        public int X;
        public int Y;
        public int TextSize;

        public MapstoneText(int a, int b, int size)
        {
            X = a;
            Y = b;
            TextSize = size;
        }
    }
}