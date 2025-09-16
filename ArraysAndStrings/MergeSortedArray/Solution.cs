namespace ArraysAndStrings.MergeSortedArray;

public class Solution
{
    public void Merge1(int[] nums1, int m, int[] nums2, int n)
    {
        var merged = new int[m + n];
        int i = 0, j = 0, k = 0;
        while (i < m && j < n)
        {
            if (nums1[i] < nums2[j])
                merged[k++] = nums1[i++];
            else
                merged[k++] = nums2[j++];
        }
        
        while(i < m)
            merged[k++] = nums1[i++];
        
        while(j < n)
            merged[k++] = nums2[j++];

        for (var p = 0; p < merged.Length; p++)
            nums1[p] = merged[p];

    }
    
    public void Merge2(int[] nums1, int m, int[] nums2, int n)
    {
        short i = (short)( m - 1), j = (short) (n - 1), k = (short)(m + n - 1);
        while (i >= 0 && j >= 0)
        {
            if (nums1[i] > nums2[j])
                nums1[k--] = nums1[i--];
            else
                nums1[k--] = nums2[j--];
        }
        
        while(i >= 0)
            nums1[k--] = nums1[i--];
        
        while(j >= 0)
            nums1[k--] = nums2[j--];
    }

    public static void Main(string[] args)
    {
    }
}