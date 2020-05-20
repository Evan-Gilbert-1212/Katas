function explode(s) {
  const numArr = s.split("");

  let output = numArr.map((num) => {
    return num.repeat(parseInt(num));
  });

  return output.join("");
}
