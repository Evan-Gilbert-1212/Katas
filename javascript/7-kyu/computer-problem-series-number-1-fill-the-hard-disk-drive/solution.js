function save(sizes, hd) {
  let totalFileSize = 0;

  for (let i = 0; i < sizes.length; i++) {
    if (totalFileSize + sizes[i] <= hd) {
      totalFileSize += sizes[i];
    } else {
      return i;
    }
  }

  return sizes.length;
}
