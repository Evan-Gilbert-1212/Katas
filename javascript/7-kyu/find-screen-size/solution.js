function findScreenHeight(width, ratio) {
  let ratioArr = ratio.split(":");

  let height = width * (parseInt(ratioArr[1]) / parseInt(ratioArr[0]));

  return width.toString() + "x" + height.toString();
}
