$(document).ready(function() {

    $(".dropdown-button").dropdown();

    $(".revClear").click(function(){
        $('#textarea1').val('');
    });
    $('#textarea1').trigger('autoresize');

    $('.modal-trigger').leanModal({
        dismissible: true, // Modal can be dismissed by clicking outside of the modal
        opacity: .8, // Opacity of modal background
        in_duration: 200, // Transition in duration
        out_duration: 200  
    });


    $(".comSave").hide();
    $(".RevSave").hide();
 

    $(".RevEdit").on("click", function () {
        var RevText = $(".RevFlex").text();
        $(".RevFlex").html("<textarea class='materialize-textarea'>" + RevText + "</textarea>");
        $(".RevSave").show();
        $(".RevEdit").hide();

    });

    $(".RevSave").on('click', function () {
        var comNText = $(".RevFlex textarea").val();
        $(".RevFlex").html(comNText);
        $(".RevSave").hide();
        $(".RevEdit").show();
    });


    $(".comEdit").on("click", function(){
        var comText = $(".comFlex").text();
        $(".comFlex").html("<textarea class='materialize-textarea'>" + comText + "</textarea>");
        $(".comSave").show();

        $(".comEdit").hide();

    });

    $(".comSave").on('click', function(){
        var comNText = $(".comFlex textarea").val();
        $(".comFlex").html(comNText);
        $(".comSave").hide();

        $(".comEdit").show();
    });


});