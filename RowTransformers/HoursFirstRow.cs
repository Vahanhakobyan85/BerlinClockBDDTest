﻿using System;

namespace BerlinClock.RowTransformers
{
    /// <summary>
    /// Represents the first row of hours section.
    /// </summary>
    public class HoursFirstRow : RowTransformer
    {
        public override string Transform(int minutes)
        {
            return String.Format("{3}{2}{1}{0}",
                GetMatchingColor(minutes, 20),
                GetMatchingColor(minutes, 15),
                GetMatchingColor(minutes, 10),
                GetMatchingColor(minutes, 5));
        }
    }
}
