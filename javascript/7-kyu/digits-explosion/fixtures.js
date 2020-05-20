describe("Testing", function(){
  it("Example tests", function(){
    var tests = [["312", "333122"],["102269","12222666666999999999"],["0", ""],["000", ""],["123", "122333"]];
    for(let i = 0; i < tests.length; i++) {
      Test.assertEquals(explode(tests[i][0]), tests[i][1], 'Input: ' + tests[i][0]);
    }
  });
});