namespace BerlinClock.RowTransformers
{
    public abstract class RowTransformer : ITimeTransformer
    {
        /// <summary>
        /// Returns the matching color based on given number values.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="valueToCompare"></param>
        /// <param name="charWhenTrue"></param>
        /// <param name="charWhenFalse"></param>
        /// <returns></returns>
        protected char GetMatchingColor(int value, int valueToCompare, char charWhenTrue = 'R', char charWhenFalse = 'O')
        {
            return value < valueToCompare ? charWhenFalse : charWhenTrue;
        }

        public abstract string Transform(int minutes);
    }
}
