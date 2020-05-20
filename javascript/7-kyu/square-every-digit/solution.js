function squareDigits(num) {
  const numArr = num.toString().split("");
  let resultStr = "";

  numArr.map((num) => {
    resultStr += (parseInt(num) * parseInt(num)).toString();
  });

  return parseInt(resultStr);
}
