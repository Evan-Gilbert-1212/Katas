function capitalize(s) {
  const arr = s.split("");
  let output1 = "";
  let output2 = "";
  let result = [];

  arr.map((c, index) => {
    if (index % 2 === 0) {
      output1 += c.toUpperCase();
      output2 += c.toLowerCase();
    } else {
      output1 += c.toLowerCase();
      output2 += c.toUpperCase();
    }
  });

  result.push(output1);
  result.push(output2);

  return result;
}
