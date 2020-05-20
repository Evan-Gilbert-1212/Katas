function filter_list(l) {
  let resultArr = [];

  l.map((item) => {
    if (typeof item === "number") {
      resultArr.push(item);
    }
  });

  return resultArr;
}
