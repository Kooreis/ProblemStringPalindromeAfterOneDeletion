Here is a TypeScript solution for the problem:

```typescript
function validPalindrome(s: string): boolean {
    let i = 0, j = s.length - 1;
    while (i < j) {
        if (s[i] !== s[j]) {
            return isPalindrome(s, i + 1, j) || isPalindrome(s, i, j - 1);
        }
        i++;
        j--;
    }
    return true;
}

function isPalindrome(s: string, i: number, j: number): boolean {
    while (i < j) {
        if (s[i] !== s[j]) {
            return false;
        }
        i++;
        j--;
    }
    return true;
}

// Test the function
console.log(validPalindrome('radar'));  // true
console.log(validPalindrome('hello'));  // false
console.log(validPalindrome('racecar'));  // true
console.log(validPalindrome('deed'));  // true
console.log(validPalindrome('apple'));  // false
```

This TypeScript program defines two functions: `validPalindrome` and `isPalindrome`. The `validPalindrome` function checks if a string can become a palindrome after at most one character deletion. The `isPalindrome` function checks if a substring of the input string is a palindrome. The program then tests these functions with several example strings.