var LoopImages = function(imgArr,container)
{
	this.imagesArray = imgArr;
	this.container = container;
}
LoopImages.prototype = {
	createImage : function()
	{
		console.log("LoopImages createImage function");
	},
	changeImage:function()
	{
		console.log("LoopImages changeImage function");
	}
}

var SlideLoopImg = function(imgArr,container)
{
	LoopImages.call(this,imgArr,container);
}
SlideLoopImg.prototype = new LoopImages();
SlideLoopImg.prototype.changeImage= function(){
		console.log("SlideLoopImg changeImage function");
}

var FadeLoopImg = function(imgArr,container,arrow)
{
	LoopImages.call(this,imgArr,container);
	this.arrow = arrow;
}
FadeLoopImg.prototype = new LoopImages();
FadeLoopImg.prototype.changeImage = function(){
		console.log("FadeLoopImg changeImage function");
}

var fadeImg = new FadeLoopImg(
	[
	'01.jpg',
	'02.jpg'
	],
	'silde',
	[
	'left.jpg',
	'right.jpg'
	]);
console.log(fadeImg);
console.log(fadeImg.container);
fadeImg.changeImage();