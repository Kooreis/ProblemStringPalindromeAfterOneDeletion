function isPalindromeRange(s, i, j) {
    for (let k = i; k <= i + (j - i) / 2; k++) {
        if (s[k] !== s[j - k + i]) return false;
    }
    return true;
}