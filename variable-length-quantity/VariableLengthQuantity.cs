public static class VariableLengthQuantity
{
    public static uint[] Encode(uint[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return [];
        var result = new List<uint>();

        foreach (var number in numbers)
        {
            var temp = number;
            var encoded = new List<uint>();
            while (temp > 0 || encoded.Count == 0)
            {
                var byteValue = temp & 0x7F;
                temp >>= 7;
                encoded.Add(byteValue);
            }

            for (int i = encoded.Count - 1; i >= 0; i--)
            {
                if (i > 0)
                {
                    result.Add(encoded[i] | 0x80);
                }
                else
                {
                    result.Add(encoded[i]);
                }
            }
        }

        return result.ToArray();
    }

    public static uint[] Decode(uint[] bytes)
    {
        if (bytes == null || bytes.Length == 0)
            return [];
        var result = new List<uint>();
        uint currentnumber = 0;
        int shift = 0;

        for (int i = 0; i < bytes.Length; i++)
        {
            var value = bytes[i] & 0x7F;
            currentnumber = (currentnumber << 7) | value;
            shift += 7;
            if ((bytes[i] & 0x80) == 0)
            {
                if (shift > 35)
                {
                    throw new InvalidOperationException("Decoded value exceeds 32 bits.");
                }
                result.Add(currentnumber);
                currentnumber = 0;
                shift = 0;
            }
            else if (shift >= 35)
            {
                throw new InvalidOperationException("Incomplete sequence detected.");
            }

        }

        return shift > 0 ? throw new InvalidOperationException("Incomplete sequence detected.") : result.ToArray();
    }
}