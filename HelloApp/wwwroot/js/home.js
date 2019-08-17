
$(window).on('load', function () {





  if ($(".main-carousel").length != 0) {

    // individual slide animations-slider
    var slides = function slides(i) {
      // var _from = '#slide-1';
      var _to = '#slide-' + i;
      var bg = '#slide-' + i + ' .bg';
      var title = '#slide-' + i + ' h1';
      var text = '#slide-' + i + ' p';

      TweenLite.from(bg, 1, { scale: 1.25 });
      TweenLite.from(title, 1, { y: '60px', autoAlpha: 0 });
      TweenLite.from(text, 1, { delay: .5, y: '60px', autoAlpha: 0 });
    };

    // setup for the flickity slider
    var slideFlickity = function slideFlickity() {
      // flickity init	
      var slideList = $('.main-carousel').flickity({
        cellAlign: 'center',
        wrapAround: true,
        pageDots: true
      });

      slideClick(slideList);
    };

    var slideClick = function slideClick(slideList) {

      slideList.data('flickity').on('select', function () {
        var index = this.selectedIndex + 1;
        slides(index);
      });

    };

    // load flickity first
    slideFlickity();

    // intro animation second
    TweenLite.from('#slide-1 .bg', 1, { autoAlpha: 0 });
    TweenLite.from('#slide-1 h1', 1.5, { autoAlpha: 0, y: '-105px' });
    TweenLite.from('#slide-1 p', 1.5, { autoAlpha: 0, y: '105px' });
    TweenLite.from('.previous', .5, { x: '-50px' });
    TweenLite.from('.next', .5, { x: '50px' });
    TweenLite.from('.flickity-page-dots', .5, { y: '105%' });


    // $(window).scroll(function(){
    //     if(scrollY>50){
    //         $("header").css("display","none")


    //     }else{
    //         $("header").css("display","")



    //     }
    //     if(scrollY>300){
    //         $("header").css("display","block");
    //         $("header  a").css("color","white")
    //         $("header #barbla ").css("background-color","black");
    //         $("header #barbla ").css("height","70px")




    //       }else{
    //         $("header  a").css("color","")
    //         $("header #barbla ").css("background-color","");
    //         $("header #barbla ").css("height","")
    //       }
    // })
    $(document).ready(function () {
      $('.img-list a').on('click', function (e) {
        e.preventDefault();

        var imgLink = $(this).children('img').attr('src');

        $('.mask').html('<div class="img-box"><img src="' + imgLink + '"><a class="close">&times;</a>');

        $('.mask').addClass('is-visible fadein').on('animationend', function () {
          $(this).removeClass('fadein is-visible').addClass('is-visible');
        });

        $('.close').on('click', function () {
          $(this).parents('.mask').addClass('fadeout').on('animationend', function () {
            $(this).removeClass('fadeout is-visible')
          });
        });

      });
    });




  }


 

  // // Numbers Start
  $.fn.jQuerySimpleCounter = function (options) {
    var settings = $.extend({
      start: 0,
      end: 100,
      easing: 'swing',
      duration: 400,
      complete: ''
    }, options);

    var thisElement = $(this);

    $({ count: settings.start }).animate({ count: settings.end }, {
      duration: settings.duration,
      easing: settings.easing,
      step: function () {
        var mathCount = Math.ceil(this.count);
        thisElement.text(mathCount);
      },
      complete: settings.complete
    });
  };


  $('#number1').jQuerySimpleCounter({ end: 12456, duration: 3000 });
  $('#number2').jQuerySimpleCounter({ end: 365, duration: 3000 });
  $('#number3').jQuerySimpleCounter({ end: 114, duration: 2000 });
  $('#number4').jQuerySimpleCounter({ end: 14825, duration: 2500 });

  // // Numbers End


  // /*	Client carousel  Start  */
  // 	/**********************/
  // 		/**********************/
  // 	/*	Client carousel   */
  // 	/**********************/
  (function () {
    // setup your carousels as you normally would using JS
    // or via data attributes according to the documentation
    // https://getbootstrap.com/javascript/#carousel
    $('#carousel123').carousel({ interval: 2000 });
    $('#carouselABC').carousel({ interval: 3600 });
  }());

  (function () {
    $('.carousel-showmanymoveone .item').each(function () {
      var itemToClone = $(this);

      for (var i = 1; i < 4; i++) {
        itemToClone = itemToClone.next();

        // wrap around if at end of item collection
        if (!itemToClone.length) {
          itemToClone = $(this).siblings(':first');
        }

        // grab item, clone, add marker class, add to collection
        itemToClone.children(':first-child').clone()
          .addClass("cloneditem-" + (i))
          .appendTo($(this));
      }
    });
  }());




})


// accordion komenti silinmelidir
// var titles = document.querySelectorAll(".title");


// for (var i = 0; i < titles.length; i++) {
//   titles[i].addEventListener("click", function () {
//     if (this.nextElementSibling.style.maxHeight == "") {
//       this.nextElementSibling.style.maxHeight = this.nextElementSibling.scrollHeight + "px";
//       this.children[1].classList.replace("fa-plus", "fa-minus");
//     } else {
//       this.nextElementSibling.style.maxHeight = "";
//       this.children[1].classList.replace("fa-minus", "fa-plus");
//     }
//     this.classList.toggle("active");
//   })
// }
$(document).ready(function () {
  $(window).scroll(function () {
    if (scrollY > 50) {
      $("header").css("display", "none")


    } else {
      $("header").css("display", "")



    }
    if (scrollY > 100) {
      $("header").css("display", "block");
      $("header  a").css("color", "white")
      $("header #barbla ").css("background-color", "black");
      $("header #barbla ").css("height", "70px")




    } else {
      $("header  a").css("color", "")
      $("header #barbla ").css("background-color", "");
      $("header #barbla ").css("height", "")
    }
  })
})



$('#scroll-down a').bind('click', function (event) {
  var $anchor = $(this);
  $('html, body').stop().animate({
    scrollTop: $($anchor.attr('href')).offset().top
  }, 1500, 'easeInOutExpo');
  event.preventDefault();
});


function GetUnique(e) {
  var l = [],
    s = temp_c = [],
    t = ["col-md-1", "col-md-2", "col-md-3", "col-md-4", "col-md-6", "col-md-12", "col-sm-1", "col-sm-2", "col-sm-3", "col-sm-4", "col-sm-6", "col-sm-12", "col-lg-1", "col-lg-2", "col-lg-3", "col-lg-4", "col-lg-6", "col-lg-12", "col-xs-1", "col-xs-2", "col-xs-3", "col-xs-4", "col-xs-6", "col-xs-12", "col-xl-1", "col-xl-2", "col-xl-3", "col-xl-4", "col-xl-6", "col-xl-12"];
  $(e).each(function () {
    for (var l = $(e + " > div").attr("class").split(/\s+/), t = 0; t < l.length; t++) s.push(l[t])
  });
  for (var c = 0; c < s.length; c++) temp_c = s[c].split("-"), 2 == temp_c.length && (temp_c.push(""), temp_c[2] = temp_c[1], temp_c[1] = "xs", s[c] = temp_c.join("-")), -1 == $.inArray(s[c], l) && $.inArray(s[c], t) && l.push(s[c]);
  return l
}

function setcss(e, l, s) {
  for (var t = ["", "", "", "", "", ""], c = d = f = g = 0, r = [1200, 992, 768, 567, 0], o = [], a = 0; a < e.length; a++) {
    var i = e[a].split("-");
    if (3 == i.length) {
      switch (i[1]) {
        case "xl":
          d = 0;
          break;
        case "lg":
          d = 1;
          break;
        case "md":
          d = 2;
          break;
        case "sm":
          d = 3;
          break;
        case "xs":
          d = 4
      }
      t[d] = i[2]
    }
  }
  for (var n = 0; n < t.length; n++)
    if ("" !== t[n]) {
      if (0 === c && (c = 12 / t[n]), f = 12 / t[n], g = 100 / f, a = s + " > .carousel-item.active.carousel-item-right," + s + " > .carousel-item.carousel-item-next {-webkit-transform: translate3d(" + g + "%, 0, 0);transform: translate3d(" + g + ", 0, 0);left: 0;}" + s + " > .carousel-item.active.carousel-item-left," + s + " > .carousel-item.carousel-item-prev {-webkit-transform: translate3d(-" + g + "%, 0, 0);transform: translate3d(-" + g + "%, 0, 0);left: 0;}" + s + " > .carousel-item.carousel-item-left, " + s + " > .carousel-item.carousel-item-prev.carousel-item-right, " + s + " > .carousel-item.active {-webkit-transform: translate3d(0, 0, 0);transform: translate3d(0, 0, 0);left: 0;}", f > 1) {
        for (k = 0; k < f - 1; k++) o.push(l + " .cloneditem-" + k);
        o.length && (a = a + o.join(",") + "{display: block;}"), o = []
      }
      0 !== r[n] && (a = "@media all and (min-width: " + r[n] + "px) and (transform-3d), all and (min-width:" + r[n] + "px) and (-webkit-transform-3d) {" + a + "}"), $("#slider-css").prepend(a)
    } $(l).each(function () {
      for (var e = $(this), l = 0; l < c - 1; l++)(e = e.next()).length || (e = $(this).siblings(":first")), e.children(":first-child").clone().addClass("cloneditem-" + l).appendTo($(this))
    })
}

//Use Different Slider IDs for multiple slider
$(document).ready(function () {
  var item = '#slider-1 .carousel-item';
  var item_inner = "#slider-1 .carousel-inner";
  classes = GetUnique(item);
  setcss(classes, item, item_inner);







// fade in
$(window).scroll( function(){
  $('.fadein').each( function(i){
      
      var bottom_of_element = $(this).offset().top + $(this).outerHeight();
      var bottom_of_window = $(window).scrollTop() + $(window).height();
      
      if( bottom_of_window > bottom_of_element ){
          $(this).animate({'opacity':'1'},500);
      }
      
  }); 
});

// Get the modal
var modal = document.getElementById("myModal");

// Get the image and insert it inside the modal - use its "alt" text as a caption
var img = document.getElementById("myImg");
var modalImg = document.getElementById("img01");
var captionText = document.getElementById("caption");
img.onclick = function(){
  modal.style.display = "block";
  modalImg.src = this.src;
  captionText.innerHTML = this.alt;
}

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks on <span> (x), close the modal
span.onclick = function() { 
  modal.style.display = "none";
}



// Get the modal
var modal = document.getElementById("myModal");

// Get the image and insert it inside the modal - use its "alt" text as a caption
var img = document.getElementById("myImg1");
var modalImg = document.getElementById("img01");
var captionText = document.getElementById("caption");
img.onclick = function(){
  modal.style.display = "block";
  modalImg.src = this.src;
  captionText.innerHTML = this.alt;
}

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks on <span> (x), close the modal
span.onclick = function() { 
  modal.style.display = "none";
}

// Get the modal
var modal = document.getElementById("myModal");

// Get the image and insert it inside the modal - use its "alt" text as a caption
var img = document.getElementById("myImg3");
var modalImg = document.getElementById("img01");
var captionText = document.getElementById("caption");
img.onclick = function(){
  modal.style.display = "block";
  modalImg.src = this.src;
  captionText.innerHTML = this.alt;
}

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks on <span> (x), close the modal
span.onclick = function() { 
  modal.style.display = "none";
}





  
});


// image effect2

