namespace Warm_up_loops
{
    public class ForLoop
    {
        /// <summary>
        /// Return lowest number in array
        /// </summary>
        /// <param name="arr">System.Int32[]</param>
        /// <returns>Returns lowest number in array.  If array is empty, returns null</returns>
        public int? GetLowest(int[] arr)
        {
            if (arr.Length == 0)
            {
                return null;
            }
            else
            {
                int number = arr[0];
                for (int i = 1; i < arr.Length; i++)
                    if (number >= arr[i]) number = arr[i];

                return number;
            }

        }

        /// <summary>
        /// Return highest number in array
        /// </summary>
        /// <param name="arr">System.Int32[]</param>
        /// <returns>Returns highest number in array.  If array is empty, returns null</returns>
        public int? GetHighest(int[] arr)
        {
            if (arr.Length == 0)
            {
                return null;
            }
            else
            {
                int number = arr[0];
                for (int i = 1000; i < arr.Length; i--)
                    if (number >= arr[i]) number = arr[i];

                return number;
            }

        }

        /// <summary>
        /// Return highest number in jagged array
        /// </summary>
        /// <param name="arr">System.Int32[][]</param>
        /// <returns>Returns highest number in array.  If there are no numbers provided, returns null</returns>
        public int? GetHighest(int[][] arr)
        {




            if (arr.Length == 0 || arr == null) return null;
            int? number = null;
            for (var r = 0; arr.Length > r; r++)
            {
                for (var c = 0; arr[r].Length > c; c++)
                {
                    if (number == null || number < arr[r][c])
                        number = arr[r][c];
                }

            }

            return number;
        }
    }
}















