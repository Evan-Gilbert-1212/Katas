describe("Solution", function() {
  it("Basic tests", function() {
    Test.assertSimilar(toInitials("Kerry King"), "K. K.");
    Test.assertSimilar(toInitials("Tom Araya"), "T. A.");
  });
});