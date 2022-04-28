var from = 10;
let count = 10;
$(window).resize(function(){
   firstLoads();
   $(window).resize(function(){});
});
$(document).ready(function () {
    firstLoads();
});
function firstLoads()
{
    let blockHeight = document.querySelector('.masks').offsetHeight;
    let windowHeight = window.innerHeight;
    if (blockHeight < windowHeight) {
        GetAdditionalMasks(from, count);
        from += count;
    }
}
window.addEventListener('scroll', onScroll)

function onScroll() {
    let nowScroll = window.scrollY
    let maxScroll = document.documentElement.scrollHeight - window.innerHeight
    if (maxScroll - nowScroll < 10) {
        //alert("scrolled")
        window.removeEventListener('scroll', onScroll)
        GetAdditionalMasks(from, count)
        from += count
    }
}

function GetAdditionalMasks(from, count) {
    var formdata = new FormData()
    formdata.append('from', from)
    formdata.append('count', count)

    $.ajax({
        url: "/Home/GetAdditionalMasks",
        data: formdata,
        cache: false,
        contentType: false,
        processData: false,
        type: "POST",
        success: function (response) {
            if (response.length < 10) {
                return;
            }
            firstLoads();
            $(window).resize(function(){
                firstLoads();
                $(window).resize(function(){});
             });
            $(".masks").html($(".masks").html() + response)
            window.addEventListener('scroll', onScroll)
        },
        error: function (xhr, ajaxOptions, thrownError) {
        }
    })
}
