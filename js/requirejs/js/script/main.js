//  js/script/main.js
require(['config'],function(){
    require(['jquery'],function ($) {
             $(document).on('click','#contentBtn',function(){
                $('#messagebox').html('You have access Jquery by using require()');
                require(['script/desc'],function(desc){
                    console.log(JSON.stringify(desc));
                });

                require(['script/alertdesc'],function(alertdesc){
                        alertdesc();
                });
             });
    });
});
