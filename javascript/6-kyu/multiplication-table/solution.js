multiplicationTable = function (size) {
  let multiplicationTable = [];

  for (let i = 1; i <= size; i++) {
    multiplicationTable.push(
      Array.from({ length: size }, (_, index) => (index + 1) * i)
    );
  }

  return multiplicationTable;
};
