const binaryArrayToNumber = (arr) => {
  const reversed = arr.reverse();
  let binaryValue = 1;
  let result = 0;

  reversed.forEach((num) => {
    result += num * binaryValue;
    binaryValue = binaryValue * 2;
  });

  return result;
};
