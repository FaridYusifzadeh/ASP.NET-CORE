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

    // date-time part
    $('input[name="daterange"]').daterangepicker({
        opens: 'left'
      }, function(start, end, label) {
        console.log("A new date selection was made: " + start.format('YYYY-MM-DD') + ' to ' + end.format('YYYY-MM-DD'));
      });

   

        var start = moment().subtract(29, 'days');
        var end = moment();
    
        function cb(start, end) {
            $('#reportrange span').html(start.format('MMMM D, YYYY') + ' - ' + end.format('MMMM D, YYYY'));
            $('#reportrange2 span').html(start.format('MMMM D, YYYY') + ' - ' + end.format('MMMM D, YYYY'));
        }
    
        $('#reportrange').daterangepicker({
            startDate: start,
            endDate: end,
            ranges: {
               'Today': [moment(), moment()],
               'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
               'Last 7 Days': [moment().subtract(6, 'days'), moment()],
               'Last 30 Days': [moment().subtract(29, 'days'), moment()],
               'This Month': [moment().startOf('month'), moment().endOf('month')],
               'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
            }
        }, cb);

        $('#reportrange2').daterangepicker({
            startDate: start,
            endDate: end,
            ranges: {
               'Today': [moment(), moment()],
               'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
               'Last 7 Days': [moment().subtract(6, 'days'), moment()],
               'Last 30 Days': [moment().subtract(29, 'days'), moment()],
               'This Month': [moment().startOf('month'), moment().endOf('month')],
               'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
            }
        }, cb);
    
        cb(start, end);

    })

    