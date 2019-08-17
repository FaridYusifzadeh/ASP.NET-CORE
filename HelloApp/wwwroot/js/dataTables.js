$(document).ready(function () {
    $(".angle").click(function() {
        $("html, body").animate({ scrollTop: 0 },1000);
        
    });

        $(window).scroll(function () {
            if (scrollY > 250) {
              $(".head-bg2").addClass("fixed-top");
              $(".head-bg2").css("transition", "1s");
              $(".head-bg2").css("padding-top", "15px");
              $(".head-bg2").css("box-shadow", "0px 5px 15px red");
            } else {
              $(".head-bg2").removeClass("fixed-top");
              $(".head-bg2").css("box-shadow", "");
              $(".head-bg2").css("padding-top", "");
              $(".head-bg2").css("transition", "");
            }
          })

   
   
})

$(document).ready(function() {
    $('#example').DataTable();
} );