//flyweight : 运用共享技术有效地支持大量的细粒度对象，避免对象间拥有想通内容造成多余的开销
/*  新手写法
var article = [1,2,3,4,5,6,7,8,9,10];
var dom = null,
	pager = 0;
	num = 3;
	len = article.length;
var  n = 0;
for(var i = 0; i < len ; i++)
{
	dom = document.createElement('div');
	dom.innerHTML = article[i];
	if( i >= num)
	{
		dom.style.display = 'none';
	}
	document.getElementById('container').appendChild(dom);
}

document.getElementById('next_page').onclick = function()
{
	var div = document.getElementById('container').getElementsByTagName('div');
	n = ++ pager % Math.ceil( len / num ) * num;
	for(var j = 0; j < len ; j++)
	{
		div[j].style.display = 'none';
		for( k = 0; k < num ; k++)
		{
			if(div[n + k])
					div[n + k].style.display = 'block';
		}
	}
}
*/

var Flyweight = function()
{
	var created = [];

	function create()
	{
		var dom = document.createElement('div');
		document.getElementById('container').appendChild(dom);
		created.push(dom);
		return dom;
	}

	return {
		getDiv : function()
		{
			if(created.length < 5)
			{
				return create();
			}else{
				var div = created.shift();
				created.push(div);
				return div;
			}
		}
	}
}

var article = [11,2,3,4,5,6,7,8,9,10];
var pager = 0,
	len = article.length,
	num = 3;
var n = 0;
for(var i = 0; i < num; i++)
{
	if(article[i])
		Flyweight().getDiv().innerHTML = article[i];
}

document.getElementById('next_page').onclick = function()
{
	if(article.length < 5)
		return ;

	n = ++ pager % Math.ceil( len / num ) * num;
	for(var j = 0; j < 5; j++)
	{
		if(article[ n + j ])
		{
			Flyweight().getDiv().innerHTML = article[ n + j ];
		}else if(article[ n + j - len ]){
			Flyweight().getDiv().innerHTML = article[ n + j - len ];
		}else{
			Flyweight().getDiv().innerHTML = "";
		}
	}
}