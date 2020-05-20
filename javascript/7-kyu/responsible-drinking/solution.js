function hydrate(s) {
  const numInt = s
    .match(/\d+/g)
    .reduce((sum, number) => (sum += parseInt(number)), 0);

  return numInt === 1
    ? numInt + " glass of water"
    : numInt + " glasses of water";
}
