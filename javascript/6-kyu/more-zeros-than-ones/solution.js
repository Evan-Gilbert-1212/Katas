function moreZeros(s){
  let charArray = s.split('')
                  .map(character => {return character.charCodeAt(0).toString(2)})
                  .filter(string => string.split("0").length > string.split("1").length)
                  .map(binaryValue => {return String.fromCharCode(parseInt(binaryValue, 2))})
  
  return [...new Set(charArray)]
}