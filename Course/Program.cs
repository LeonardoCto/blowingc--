// public class Solution {
//     public static void Main(string[] args)
//     {
//         Solution solution = new Solution();
//         int[] nums = { 1, 2, 5, 3 };
//         int target = 10;
//         int[] result = solution.TwoSum(nums, target);
//         Console.WriteLine($"Indices: {result[0]}, {result[1]}");

//     }
//     public int[] TwoSum(int[] nums, int target)
//     {
//         Dictionary<int, int> numMap = new Dictionary<int, int>();
//         //Dictionary store the value and its index
//         //key: value, value: index 1:0 2:1 5:2 3:3

//         for (int i = 0; i < nums.Length; i++)
//         {
//             int complement = target - nums[i]; // 8 - 1 = 7, 8 - 2 = 6, 8 - 5 = 3, 8 - 3 = 5
//             //When fell into 5 return numMap[5] =2 and, i = 3
//             //so return {2, 3}
//             if (numMap.ContainsKey(complement))
//             {
//                 return new int[] { numMap[complement], i };
//             }
//             //Before fell into 5 here is stored nums[0] = 1, nums[1] = 2, nums[2] = 5
//             //That enter into the dictionary like this: 1:0, 2:1, 5:2 because nums[i] get the value and i get the index
//             numMap[nums[i]] = i;
//         }

//       return new int[] { }; // If no solution found, return an empty array


//     }
// }

// public class Solution {
//     public static void Main(string[] args)
//     {
//         Solution solution = new Solution();
//         int number = 121;
//         bool isPalindrome = solution.IsPalindrome(number);
//         Console.WriteLine($"Is {number} a palindrome? {isPalindrome}");
//     }

//         //Metodo que verifica se o numero x eh um palindromo
//         //Exemplo: 121, 12321, 1221
//     public bool IsPalindrome(int x)//supondo que x seja 121
//     {
//         if (x < 0)
//             return false; //menor que 0 retorna false (numeros negativos nao sao palindrome)

//         var reversed = Reverse(x); //chama metodo reverse para reverter x
//         return reversed == x; //revertido == x? 121
//     }

//     public static int Reverse(int x)
//     {
//         long num = 0;

//         while (x != 0)
//         {
//             num *= 10;  // =0  -> num = 10  -> num = 120          
//             num += x % 10; //num = 1 -> num = 12 -> num = 121
//             x /= 10; //x = 12 -> x = 1 -> x = 0
//         }

//         return (num > int.MaxValue || num < int.MinValue) ? 0 : Convert.ToInt32(num);
//         //num = 121, num > int.MaxValue ou num < int.MinValue? retorna 0
//         //caso contrario converte num para int e retorna
//         }
// }

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
public class Solution {
    
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        ListNode mergedList = solution.MergeTwoLists(list1, list2);
        
        while (mergedList != null)
        {
            Console.Write(mergedList.val + " ");
            mergedList = mergedList.next;
        }
    }
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy = new ListNode(0);
        ListNode op = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                op.next = list1;
                list1 = list1.next;
            }
            else
            {
                op.next = list2;
                list2 = list2.next;
            }
            op = op.next;
        }

        op.next = list1 ?? list2;
        return dummy.next;
    }
}