function DNAStrand(dna) {
  let dnaArray = dna.split("");

  dnaArray.forEach((letter, index) => {
    switch (letter) {
      case "A":
        dnaArray[index] = "T";
        break;
      case "T":
        dnaArray[index] = "A";
        break;
      case "G":
        dnaArray[index] = "C";
        break;
      case "C":
        dnaArray[index] = "G";
        break;
    }
  });

  return dnaArray.join("");
}
