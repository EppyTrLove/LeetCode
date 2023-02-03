public bool ContainsDuplicate(int[] nums)
{
    bool result = false;
    var dict = new Dictionary<int, int>();
    foreach (var i in nums)
    {
        // When the key is not found, "count" will be initialized to 0
        dict.TryGetValue(i, out int count);
        dict[i] = count + 1;
    }
    foreach (var pair in dict)
    {
        Console.WriteLine(pair);
        if (pair.Value > 2)
            result = true;
    }
    return result;
}
