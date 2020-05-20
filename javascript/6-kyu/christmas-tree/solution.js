function christmasTree(height) {
  let width = height + (height - 1);
  let output = "";

  for (let i = height - 1; i >= 0; i--) {
    if (output == "") {
      output = " ".repeat(i) + "*".repeat(width - i * 2) + " ".repeat(i);
    } else {
      output =
        output +
        "\n" +
        " ".repeat(i) +
        "*".repeat(width - i * 2) +
        " ".repeat(i);
    }
  }

  return output;
}
