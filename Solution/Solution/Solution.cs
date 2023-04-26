namespace Solution;

public class Solution
{
    public static int[] solution(string[] A, string[] B)
    {
        var forbiddenHosts = new HashSet<string>(B);
        var allowedIndexes = new List<int>();

        for (int i = 0; i < A.Length; i++)
        {
            var isForbidden = false;
            var hostParts = A[i].Split('.');
            var currentHost = "";

            for (int j = hostParts.Length - 1; j >= 0; j--)
            {
                currentHost = hostParts[j] + (j < hostParts.Length - 1 ? "." : "") + currentHost;
                if (!forbiddenHosts.Contains(currentHost)) continue;
                isForbidden = true;
                break;
            }

            if (!isForbidden)
            {
                allowedIndexes.Add(i);
            }
        }

        return allowedIndexes.ToArray();
    }
}