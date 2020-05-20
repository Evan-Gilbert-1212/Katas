function myLanguages(results) {
  let resultArr = [];

  const myLangArr = Object.keys(results).map(function (lang) {
    return [lang, results[lang]];
  });

  myLangArr.sort(function (first, second) {
    return second[1] - first[1];
  });

  myLangArr.forEach((lang) => {
    if (lang[1] >= 60) {
      resultArr.push(lang[0]);
    }
  });

  return resultArr;
}
