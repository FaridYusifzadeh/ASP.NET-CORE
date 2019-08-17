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


    var titles = document.querySelectorAll(".title");


    for (var i = 0; i < titles.length; i++) {
        
        titles[i].addEventListener("click", function (e) {

            if (this.nextElementSibling.style.maxHeight == "") {                
               hideAccordion(titles);
               
                this.nextElementSibling.style.maxHeight = this.nextElementSibling.scrollHeight + "px";
                this.children[1].classList.replace("fa-plus", "fa-minus");
                
            } else {
                this.nextElementSibling.style.maxHeight = "";

                this.children[1].classList.replace("fa-minus", "fa-plus");
            }
            //this.classList.toggle("active");
        




        })
        
    }
   function hideAccordion(titles)
   {
    for(j=0;j<titles.length;j++)
    {
        titles[j].nextElementSibling.style.maxHeight = "";
        titles[j].children[1].classList.replace("fa-minus", "fa-plus");
    }
   }
})


