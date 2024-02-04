// See https://aka.ms/new-console-template for more information
using LeetCode.CodeChallenges.Easy;

Console.WriteLine("Hello, World!");

//var palindromeChallenge = new IsPalindromeNumberChallenge();
//Console.WriteLine(palindromeChallenge.IsPalindrome(-121));

//var longestPrefix = new LongestCommonPrefixChallenge();
//Console.WriteLine(longestPrefix.LongestCommonPrefix(new[] { "flower", "flow", "flight" }));

//var validParentheses = new ValidParenthesesChallenge();
//Console.WriteLine(validParentheses.IsValid("]"));

//var mergeSortedList = new MergeTwoSortedListChallenge();

//var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
//var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
//var resultado = mergeSortedList.MergeTwoLists(list1, list2);

//var firstOccurence = new FirstOccurenceInAStringChallenge();
//Console.WriteLine(firstOccurence.StrStr("sadbutsad", "sad"));

//var plusOne = new PlusOneChallenge();
//Console.WriteLine(plusOne.PlusOne(new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 }));
//Console.WriteLine(plusOne.PlusOne(new int[] { 9,9,9,9 }));

var addBinary = new AddBynaryChallenge();
Console.WriteLine(addBinary.AddBinary("10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101", "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011").Length + " " + "110111101100010011000101110110100000011101000101011001000011011000001100011110011010010011000000000".Length);
