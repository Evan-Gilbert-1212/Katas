function openOrSenior(data) {
  let outputArray = [];

  for (let arrayIndex in data) {
    if (data[arrayIndex][0] > 54 && data[arrayIndex][1] > 7) {
      outputArray.push("Senior");
    } else {
      outputArray.push("Open");
    }
  }

  return outputArray;
}
