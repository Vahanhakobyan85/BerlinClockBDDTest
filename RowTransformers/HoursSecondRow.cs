﻿using System;

namespace BerlinClock.RowTransformers
{
    /// <summary>
    /// Represents the second row of hours section.
    /// </summary>
    public class HoursSecondRow : RowTransformer
    {
        public override string Transform(int hours)
        {
            return String.Format("{3}{2}{1}{0}",
                GetMatchingColor(hours, 4),
                GetMatchingColor(hours, 3),
                GetMatchingColor(hours, 2),
                GetMatchingColor(hours, 1));
        }
    }
}
