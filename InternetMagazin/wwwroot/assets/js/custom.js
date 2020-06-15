
(function ($) {
    'use strict';
    $(document).on('click', '#login_btn', function () {
        $('#onload-popup').modal('show');
    });
    $(document).on('change', '#remember', function () {
        var oldval = $(this).val();
        (oldval == 0) ? $(this).val(1) : $(this).val(0);
    });

    $(document).on('click', '#registration_btn', function () {
        $('#registration_user_modal').modal('show');
        $('#onload-popup').modal('hide');
    });

    
    
}) (jQuery);