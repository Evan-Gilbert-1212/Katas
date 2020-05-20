function accum(s) {
  const letterArr = s.split("");

  let output = letterArr.map((letter, index) => {
    return letter.toUpperCase() + letter.repeat(index).toLowerCase();
  });

  return output.join("-");
}
