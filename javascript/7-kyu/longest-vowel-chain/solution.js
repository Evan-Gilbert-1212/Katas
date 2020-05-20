function solve(s) {
  let longestCount = 0;
  let currentCount = 0;

  for (i = 0; i < s.length; i++) {
    if (
      s.charAt(i) === "a" ||
      s.charAt(i) === "e" ||
      s.charAt(i) === "i" ||
      s.charAt(i) === "o" ||
      s.charAt(i) === "u"
    ) {
      ++currentCount;
    } else {
      if (currentCount > longestCount) {
        longestCount = currentCount;
      }

      currentCount = 0;
    }
  }

  return longestCount;
}
