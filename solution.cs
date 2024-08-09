function validPalindrome(s) {
    for (let i = 0, j = s.length - 1; i < j; i++, j--) {
        if (s[i] !== s[j]) {
            return isPalindromeRange(s, i, j - 1) || isPalindromeRange(s, i + 1, j);
        }
    }
    return true;
}