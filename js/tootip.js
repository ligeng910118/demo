var $win = $(window);

//默认的参数
 var default_options = {
     element: null, //要加提示的元素，必填项
     height:'auto',  //浮动层的高度
     width:'auto',
     message:null   //添加的提示信息，也可以在element的data-tip属性上加
     };

tipObj= {

    init:function(options){

        this.render(options)
    },
    //创建浮动层的dom结构，并填加到body中
    createDOM:function(element){

        var that = this;
        that.wrapper= $('<div class="tool-tip-box"></div> ');
        $('body').append(this.wrapper);

        return this;

    },
    //初始化
    render:function(options){

        var that = this,

            //参数合并
            options = $.extend(default_options,options),
            msg = options.message !=null?options.message : options.element.data('tip');

        that.createDOM(options.element);

        that.wrapper.css({
            width: options.width,
            height:options.height

        }).html(msg);

        that.setPosition(options.element);

        options.element.on('mouseleave',function(e){

            that.wrapper.remove();
        })

    },

        //设置提示浮动层的位置，定位
    setPosition:function(element){

       var left = element.offset().left,
           top = element.offset().top+element.height();

        this.wrapper.css({
            position:'absolute',
            left:left,
            top:top
        });

        return this;

    }

}

//接口
$.tip =$.Tip= function(options){
    return tipObj.init(options);
}