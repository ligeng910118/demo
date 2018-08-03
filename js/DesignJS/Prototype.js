var LoopImages = function(imgArr,container)
{
	this.imagesArray = imgArr;
	this.container = container;
	this.createImage = function(){}
	this.changeImage = function(){}
}

var SlideLoopImg = function(imgArr,container)
{
	LoopImages.call(this,imgArr,container);
	this.changeImage = function()
	{
		console.log("SlideLoopImg changeImage function");
	}
}

var FadeLoopImg = function(imgArr,container,arrow)
{
	LoopImages.call(this,imgArr,container);
	this.arrow = arrow;
	this.changeImage = function()
	{
		console.log("FadeLoopImg changeImage function");
	}
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
fadeImg.changeImage();