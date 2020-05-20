function createPhoneNumber(numbers) {
  let phoneNumber = "";

  numbers.map((num, index) => {
    if (index === 0) {
      phoneNumber += "(";
    } else if (index === 3) {
      phoneNumber += ") ";
    } else if (index === 6) {
      phoneNumber += "-";
    }

    phoneNumber += num.toString();
  });

  return phoneNumber;
}
