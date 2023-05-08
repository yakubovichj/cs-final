namespace Geekbrains.IT.Final;

public class ArrayFilter
{
    public string[] ByLength(string[] input, int maxLength = 3) {
        return Array.FindAll(input, elem => elem.Length <= maxLength);
    }

    public string[] ByLengthVerbose(string[] input, int maxLength = 3) {
        string[] result = (string[]) Array.CreateInstance(typeof(string), input.Length);

        int resultCount = 0;

        for (int i = 0; i < input.Length; i++) {
            string elem = input[i];
            
            if (elem.Length <= maxLength) {
                result[resultCount++] = elem;
            }
        }

        Array.Resize(ref result, resultCount);

        return result;
    }
}
