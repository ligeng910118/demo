//prototype:用原型实例指向创建对象的类，使用创建新的对象的类共享原型对象的属性和方法
var LoopImages = function(imgArr,container)
{
	this.imagesArray = imgArr;
	this.container = container;
	
}

LoopImages.prototype = {
	createImage : function()
	{
		console.log('LoopImages createImage function');
	},
	changeImage : function()
	{
		console.log('LoopImages changeImage function');
	}
}

var SlideLoopImg = function(imgArr,container)
{
	LoopImages.call(this,imgArr,container);
}

SlideLoopImg.prototype = new LoopImages();

SlideLoopImg.prototype.changeImage = function()
{
	console.log('SlideLoopImg changeImage function');
}

var FadeLoopImg =  function(imgArr,container,arrow)
{
	LoopImages.call(this,imgArr,container);
	this.arrow = arrow;
}

FadeLoopImg.prototype = new LoopImages();

FadeLoopImg.prototype.changeImage = function()
{
	console.log('FadeLoopImg changeImage function');
}

var fadeImg = new FadeLoopImg([
		'01.jpg',
		'02.jpg',
		'03.jpg',
	],'slide',[
		'left.jpg',
		'right.jpg'
	]);
fadeImg.changeImage();
console.log(fadeImg);