namespace UniqueNumber
{
    public static class Solution
    {
        /*
            The solution this problem was implemented using a linear approach, which means that the algorithm processes the input elements in a sequential manner, 
            one after the other. To check whether a given number exists in the collection of input numbers, 
            a Dictionary data structure was used. This allowed for a reduction in the time complexity of the algorithm, 
            as looking up a value in a Dictionary is generally faster than searching through an array or list.

            However, it may be possible to improve the performance of the algorithm further by replacing the Dictionary with a HashSet. 
            A HashSet is a specialized data structure that is optimized for storing and retrieving unique values. 
            It is generally faster than a Dictionary for this purpose, so using a HashSet could potentially reduce the time complexity of the algorithm even further.
        */
        public static IEnumerable<int> GetUniqueNumbers(IEnumerable<int> input)
        {
            Dictionary<int, int> uniqueNumbers = new();

            foreach (var number in input)
            {
                if (uniqueNumbers.ContainsKey(number)) continue;

                uniqueNumbers.Add(number, number);
            }

            return uniqueNumbers.Select((key, val) => val);
        }
    }
}
