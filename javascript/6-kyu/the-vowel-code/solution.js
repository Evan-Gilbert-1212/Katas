function encode(string) {
  const vowelValues = { a: "1", e: "2", i: "3", o: "4", u: "5" };
  return string.replace(/a|e|i|o|u/g, function (match) {
    return vowelValues[match];
  });
}

function decode(string) {
  const numberValues = { "1": "a", "2": "e", "3": "i", "4": "o", "5": "u" };
  return string.replace(/1|2|3|4|5/g, function (match) {
    return numberValues[match];
  });
}
