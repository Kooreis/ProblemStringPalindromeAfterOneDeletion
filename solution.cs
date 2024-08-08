Here is a JavaScript solution for the problem:

```javascript
function validPalindrome(s) {
    for (let i = 0, j = s.length - 1; i < j; i++, j--) {
        if (s[i] !== s[j]) {
            return isPalindromeRange(s, i, j - 1) || isPalindromeRange(s, i + 1, j);
        }
    }
    return true;
}

function isPalindromeRange(s, i, j) {
    for (let k = i; k <= i + (j - i) / 2; k++) {
        if (s[k] !== s[j - k + i]) return false;
    }
    return true;
}

console.log(validPalindrome('abca')); // true
console.log(validPalindrome('abc')); // false
```

This console application checks if a string can become a palindrome after at most one character deletion. It uses two functions: `validPalindrome` and `isPalindromeRange`. The `validPalindrome` function iterates over the string from both ends towards the center. If it encounters a pair of characters that don't match, it calls `isPalindromeRange` twice, once with the left character removed, and once with the right character removed. If either of these checks returns true, then the string can become a palindrome with one character deletion. If it finishes the iteration without finding any mismatched pairs, then the string is already a palindrome. The `isPalindromeRange` function checks if a substring of the input string is a palindrome.