function consecutiveDucks(num) {
  while (num > 2) {
    if (num % 2 != 0) return true;

    num = num / 2;
  }

  return false;
}
