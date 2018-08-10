var article = document.getElementById('article');
article.onclick = function()
{
	var e = e || window.event,
	tar = e.target || e.srcElement;
	if(tar.nodeName.toLowerCase() === 'p')
	{
		tar.innerHTML = "change content";
	}
}

var p = document.createElement('p');
p.innerHTML = 'add new content';
article.appendChild(p);