describe("Christmas tree", function () {
  it ("should return correct christmas tree for height 1", function(){
  	Test.assertEquals(christmasTree(1), "*");
	});
	it ("should return correct christmas tree for height 2", function(){
		Test.assertEquals(christmasTree(2), " * \n***");
	});
	it ("should return correct christmas tree for height 3", function(){
		Test.assertEquals(christmasTree(3), "  *  \n *** \n*****");
	});
	it ("should return correct christmas tree for height 4", function(){
		Test.assertEquals(christmasTree(4), "   *   \n  ***  \n ***** \n*******");
	});
	it ("should return correct christmas tree for height 5", function(){
		Test.assertEquals(christmasTree(5), "    *    \n   ***   \n  *****  \n ******* \n*********");
	});
	it ("should return correct christmas tree for height 6", function(){
		Test.assertEquals(christmasTree(6), "     *     \n    ***    \n   *****   \n  *******  \n ********* \n***********");
	});
	it ("should return correct christmas tree for height 7", function(){
		Test.assertEquals(christmasTree(7), "      *      \n     ***     \n    *****    \n   *******   \n  *********  \n *********** \n*************");
	});
	it ("should return correct christmas tree for height 8", function(){
		Test.assertEquals(christmasTree(8), "       *       \n      ***      \n     *****     \n    *******    \n   *********   \n  ***********  \n ************* \n***************");
	});
	it ("should return correct christmas tree for height 9", function(){
		Test.assertEquals(christmasTree(9), "        *        \n       ***       \n      *****      \n     *******     \n    *********    \n   ***********   \n  *************  \n *************** \n*****************");
	});
	it ("should return correct christmas tree for height 10", function(){
		Test.assertEquals(christmasTree(10), "         *         \n        ***        \n       *****       \n      *******      \n     *********     \n    ***********    \n   *************   \n  ***************  \n ***************** \n*******************");
	});
});