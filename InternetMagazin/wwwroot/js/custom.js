(function ($) {
    "use strict";


    function ajaxReq(url, method='GET', callback,  data=null, errorElementID= 'null') {
        $.ajax({
            url: url,
            data: data,
            type: method,
            contentType: false,
            cache: false,
            processData: false,
            //dataType: 'json',
            success: function( data ) {
                callback(data);
            },
            error: function( data ) {
                console.log(data);
                if (errorElementID === 'null') {

                        console.log(data);
                }
                else if (errorElementID === 'window.alert') {
                    let a;
                    $.each(data.responseJSON.errors, function (key, value) {
                        a += value[0];
                    });
                    //alert(a);
                }
                else {
                        $('#' + errorElementID).removeClass('d-none');
                        $.each(data.responseJSON.errors, function (key, value) {
                            $('#' + errorElementID).append(value[0]+'<br>');
                        });
                    }

            }
        });
    }

    function req(url, method='GET', callback,  data=null, errorElementID= 'null') {
        $.ajaxSetup({
            headers: {
                'X-CSRF-Token': $('meta[name=csrf-token]').attr('content')
            }
        });
        $.ajax({
            url: url,
            data: data,
            type: method,
            contentType: false,
            cache: false,
            processData: false,
            //dataType: 'json',
            success: function( data ) {
                callback(data);
            },
            error: function( data ) {
                //console.log(data);
                if (errorElementID === 'null') {
                    console.log(data);
                } else {
                    $('#' + errorElementID).removeClass('d-none');
                    $.each(data.responseJSON.errors, function (key, value) {
                        $('#' + errorElementID).append(value[0]+'<br>');
                    });
                }
            }
        });
    }

    function translit(str) {
        var space = '-';
        var link = '';
        var transl = {
            'а': 'a', 'б': 'b', 'в': 'v', 'г': 'g', 'д': 'd', 'е': 'e', 'ё': 'e', 'ж': 'zh',
            'з': 'z', 'и': 'i', 'й': 'j', 'к': 'k', 'л': 'l', 'м': 'm', 'н': 'n',
            'о': 'o', 'п': 'p', 'р': 'r','с': 's', 'т': 't', 'у': 'u', 'ф': 'f', 'х': 'h',
            'ц': 'c', 'ч': 'ch', 'ш': 'sh', 'щ': 'sh','ъ': '',
            'ы': 'y', 'ь': '', 'э': 'e', 'ю': 'yu', 'я': 'ya'
        }
        if (str != '')
            str = str.toLowerCase();

        for (var i = 0; i < str.length; i++){
            if (/[а-яё]/.test(str.charAt(i))){ // заменяем символы на русском
                link += transl[str.charAt(i)];
            } else if (/[a-z0-9]/.test(str.charAt(i))){ // символы на анг. оставляем как есть
                link += str.charAt(i);
            } else {
                if (link.slice(-1) !== space) link += space; // прочие символы заменяем на space
            }
        }
        return link;
    };




    //customer 


    $(document).on('click', '#make_order', function (e) {
        e.preventDefault();
        let formData = new FormData();
        formData.append('firstname', $('#billing_first_name').val());
        formData.append('lastname', $('#billing_last_name').val());
        formData.append('address', $('#billing_address').val());
        formData.append('city', $('#billing_city').val());
        formData.append('phone', $('#billing_phone').val());
        formData.append('email', $('#billing_email').val());
        formData.append('delivery_type', $('#shipping_cost').attr('data-id'));
        formData.append('payment_type', $('#payment_method').val());

        ajaxReq('/Customer/Make_order', 'POST', (data) => {
            $('.content-body').html(data);
        }, formData);
    });


    

    $(document).on('click', '#I_orders', function (e) {
        e.preventDefault();
        let id = $(this).attr('data-id');
        ajaxReq('/Customer/Get_I_orders/'+id, 'GET', (data) => {
            $('.content-body').html(data);
        });
    });



    $(document).on('click', '#view_order_items', function (e) {
        e.preventDefault();
        let id = $(this).attr('data-id');
        ajaxReq('/Customer/Get_order_items/' + id, 'GET', (data) => {
            $('.content-body').html(data);
        });
    });

    






    $(document).on('click', '#checkout_order_btn', function (e) {
        e.preventDefault();
        let id = $(this).attr('data-id');
        ajaxReq('/Customer/Checkout_order', 'GET', (data) => {
            $('.content-body').html(data);
        });
    });


    $(document).on('click', '#_plus', function (e) {
        e.preventDefault();
        let id = $(this).attr('data-id');
        ajaxReq('/Customer/Quantity_plus/' + id, 'GET', (data) => {
            $('#table_item_cart_' + id).html(data);
        });
    });


    $(document).on('click', '#_minus', function () {
        let id = $(this).attr('data-id');
        ajaxReq('/Customer/Quantity_minus/' + id, 'GET', (data) => {
            $('#table_item_cart_' + id).html(data);
        });
    });



    $(document).on('click', '#save_registration_user', function (e) {
        e.preventDefault();
        let lastname = $('#last_name').val();
        let firstname = $('#first_name').val();
        let middlename = $('#middle_name').val();
        let phone = $('#phone').val();
        let email = $('#email').val();
        let password = $('#password').val();
        let city = $('#city').val();
        let addres = $('#address').val();
        let image = $('#image').prop('files')[0];
        let fD = new FormData();
        fD.append('lastname', lastname);
        fD.append('firstname', firstname);
        fD.append('middlename', middlename);
        fD.append('phone', phone);
        fD.append('email', email);
        fD.append('password', password);
        fD.append('city', city);
        fD.append('addres', addres);
        fD.append('image', image);
        $.ajax({
            url: '/Home/Registr_user',
            data: fD,
            type: 'POST',
            contentType: false,
            processData: false,
            cache: false,
            success: function (data) {
                $('#registration_user_modal').modal('hide');
                alert(data);
                $('#onload-popup').modal('show');
            },
            error: function (data) {
                console.log(data);
            }
        });
    });


    $(document).on('click', '#registration_btn', function () {
        $('#registration_user_modal').modal('show');
        $('#input_modal').modal('hide');
    });

    $(document).on('click', '#edit_custom', function (e) {
        e.preventDefault();
        let id = $(this).attr('data-id');
        ajaxReq('/Customer/Edit/' + id, ...[,], (data) => {
            $('#edit_custom_modal_body').html(data);
            $('#edit_custom_modal').modal('show');
        });
    });

    $(document).on('click', '#log__in', function () {
                $('#input_modal').modal('show');
    });


    $(document).on('click', '#save_edit_custom', function (e) {
        e.preventDefault();
        let id = $(this).attr('data-id');
        let lastname = $('#last_name_edit').val();
        let firstname = $('#first_name_edit').val();
        let middlename = $('#middle_name_edit').val();
        let phone = $('#phone_edit').val();
        let email = $('#email_edit').val();
        let password = $('#password_edit').val();
        let city = $('#city_edit').val();
        let addres = $('#address_edit').val();
        let image = $('#image_edit').prop('files')[0];
        let fD = new FormData();
        fD.append('id', id);
        fD.append('lastname', lastname);
        fD.append('firstname', firstname);
        fD.append('middlename', middlename);
        fD.append('phone', phone);
        fD.append('email', email);
        fD.append('password', password);
        fD.append('city', city);
        fD.append('addres', addres);
        fD.append('image', image);
        ajaxReq('/Customer/Save_edit', 'POST', (data) => {
            alert(data);
            $('#edit_custom_modal').modal('hide');
        }, fD);
    });


    
    $(document).on('click', '#show_products_custom', function () {
        let id = $(this).attr('data-id');
        ajaxReq('/Home/Index_product/' + id, 'GET', (data) => {
            $('.content-body').html(data);
        });
    });


    $(document).on('click', '#show_products_customer', function () {
        let id = $(this).attr('data-id');
        ajaxReq('/Customer/Index_product/' + id, 'GET', (data) => {
            $('.content-body').html(data);
        });
    });

    

    $(document).on('click', '#add_to_wish', function (e) {
        e.preventDefault();
        let id = $(this).attr('data-id');
        ajaxReq('/Customer/Add_to_wishlist/' + id, 'POST', (data) => {
            alert(data);
        });
    });




    $(document).on('click', '#I_wishlist', function (e) {
        e.preventDefault();
        let id = $(this).attr('data-id');
        ajaxReq('/Customer/GetWishlist/' + id, 'GET', (data) => {
            $('.content-body').html(data);
        });
    });
    

    $(document).on('click', '#delete_product_wishlist', function (e) {
        e.preventDefault();
        let id = $(this).attr('data-id');
        ajaxReq('/Customer/Delete_item_wishlist/' + id, 'GET', (data) => {
            $('#table_item_cus_' + id).remove();      
        });
    });
    




    $(document).on('click', '#I_cart', function (e) {
        e.preventDefault();
        let id = $(this).attr('data-id');
        ajaxReq('/Customer/GetItemCart/' + id, 'GET', (data) => {
            $('.content-body').html(data);
        });
    });


    $(document).on('click', '#delete_product_cart', function (e) {
        e.preventDefault();
        let id = $(this).attr('data-id');
        ajaxReq('/Customer/Delete_item_cart/' + id, 'GET', (data) => {
            $('#table_item_cart_' + id).remove();
        });
    });






    $(document).on('click', '#add_to_cart', function (e) {
        e.preventDefault();
        let id = $(this).attr('data-id');
        ajaxReq('/Customer/Add_to_cart/' + id, 'POST', (data) => {
            alert(data);
        });
    });

    








    $(document).on('click', '#login_admin_btn', function (e) {

e.preventDefault();
let phone = $('#phone').val();
let password = $('#password').val();
let r=0;
if($('#remember'). prop("checked") == true){ r=1;}


    var form_data = new FormData();
    form_data.append('phone', phone);
    form_data.append('password', password);
    form_data.append('r', r);

    $.ajaxSetup({
        headers: {
            'X-CSRF-Token': $('meta[name=csrf-token]').attr('content')
        }
    });
    $.ajax({
        url: '/admin/login',
        data: form_data,
        type: 'POST',
        contentType: false,
        cache: false,
        processData: false,
        dataType: 'json',
        success: function( data ) {
            console.log(data);
            if (data.err == 0){
                location.href = '/admin'
            }
            else{
                $('#error').html(data.msg).removeClass('d-none');
            }

        },
        error: function( data ) {
            console.log(data);
        }
    });
});



$(document).on('click', '#ad_cat_btn', function () {
$('#add_category_modal').modal('show');
});

$(document).on('click', '#save_category', function (e) {
e.preventDefault();
    let title = $('#title_new').val();
    let image = $('#image').prop('files')[0];
    let parentid = $(this).attr('data-id');
    let form_data = new FormData();
    form_data.append('title', title);
    form_data.append('parentid', parentid);
    form_data.append('image', image);
    $.ajax({
        url: '/Admin/Create_category',
        data: form_data,
        type: 'POST',
        contentType: false,
        cache: false,
        processData: false,
        success: function (data) {
            $('#table-adm').append(' <tr id="table_item_adm_'+data+'">' +
                '<td class="text-center" style="vertical-align: middle">0</td>' +
                ' <td class="text-center" style="vertical-align: middle">' + title + '</td>' +
                '<td width="170" class="text-center act" style="vertical-align: middle">' +
                ' <span data-id="' + data + '" id="delete_category" class="ti-trash delete-item"></span>' +
                '</td>' +
                '</tr>');
            $('#add_category_modal').modal('hide');
        },
        error: function (data) {
            console.log(data);
        }
    });
});



$(document).on('click', '#delete_category', function () {
let id = $(this).attr('data-id');
ajaxReq('/Admin/Delete_category/'+id, 'GET', (data)=>{
    $('#cat_side_bar_'+id).remove();
    $('#table_item_adm_'+id).remove();      
});
});


    $(document).on('click', '#index_user', function () {
        ajaxReq('/Admin/Index_users', 'GET', (data) => {
            $('.content-body').html(data);
        });
    });


    $(document).on('click', '#show_parent_category', function () {
let id = $(this).attr('data-id');
ajaxReq('/Admin/categories/'+id, 'GET', (data)=>{
    $('.content-body').html(data);
});
    });



    $(document).on('click', '#show_products', function () {
        let id = $(this).attr('data-id');
        ajaxReq('/Admin/Index_product/' + id, 'GET', (data) => {
            $('.content-body').html(data);
        });
    });






$(document).on('click', '#ad_product_btn', function () {
$('#add_product_modal').modal('show');
});


    var imageProduct = [];
    $(document).on('click', '#upload_temp_btn', function (e) {
        e.preventDefault();
        let file = $('#image_to_temp').prop('files')[0];
        let folderName = "temp";
        let formdata = new FormData();
        formdata.append('file', file);
        formdata.append('folderName', folderName);
        $.ajaxSetup({
            headers: {}
        });
        $.ajax({
            url: "/Admin/AddImageProduct",
            data: formdata,
            type: "POST",
            contentType: false,
            cache: false,
            processData: false,
            //dataType: 'json',
            success: function (data) {
                $('#images_product').append('<div class="col-3 mb-15">\n' +
                    '                                                <img src="/uploads/temp/'+data+'" alt="">\n' +
                    '                                            </div>');
                imageProduct.push(data);
            },
            error: function (data) {
                console.log(data);
                }
        });
    });


    $(document).on('click', '#upload_temp_edit_btn', function (e) {
        e.preventDefault();
        let file = $('#image_to_temp_edit').prop('files')[0];
        let folderName =$(this).attr('data-id').toString();
        let folderproductsName = "products\\";
        let formdata = new FormData();
        formdata.append('file', file);
        formdata.append('folderName', folderName);
        formdata.append('folderproductsName', folderproductsName);
        $.ajaxSetup({
            headers: {}
        });
        $.ajax({
            url: "/Admin/AddImageProduct",
            data: formdata,
            type: "POST",
            contentType: false,
            cache: false,
            processData: false,
            //dataType: 'json',
            success: function (data) {
                $('#images_product_edit').append('<div class="col-3 mb-15">\n' +
                    '                                                <img src="/uploads/products/' + data + '" alt="">\n' +
                    '                                            </div>');
            },
            error: function (data) {
                console.log(data);
            }
        });
    });



    $(document).on('click', '#save_product', function () {
        let categoryId = $(this).attr('data-id');
        let title = $('#title_new').val();
        let articul = $('#articul_new').val();
        let price = $('#price_new').val();
        let price_discount = $('#price_discount_new').val();
        let quontity = $('#quontity_new').val();
        let description = $('#description_new').summernote('code');

        let is_sale = ($('#is_sale_new').prop('checked') == true) ? '1' : '0';
        let is_new = ($('#is_new_new').prop('checked') == true) ? '1' : '0';
        price_discount = (is_sale == '0') ? 0.00 : price_discount;

        let data = new FormData();
        data.append('categoryId', categoryId);
        data.append('title', title);
        data.append('articul', articul);
        data.append('price', price);
        data.append('price_discount', price_discount);
        data.append('quontity', quontity);
        data.append('description', description);
        data.append('imageProduct', imageProduct.toString());
        data.append('is_sale', is_sale);
        data.append('is_new', is_new);

        $.ajax({
            url: "/Admin/Create_product",
            data: data,
            type: "POST",
            contentType:false,
            cache: false,
            processData: false,
            success: function (data) {
                $('#table_adm').append(data);
                $('#add_product_modal').modal('hide');
                $('#title_new').val('');
                $('#articul_new').val('');
                $('#price_new').val('');
                $('#photo_new').val('');
                $('#price_discount_new').val('');
                $('#quontity_new').val('');
                $('#description_new').val('');
                $('#is_sale_new').prop('checked', false);
                $('#is_new_new').prop('checked', false);
                $('#images_product').html('');
                imageProduct = [];
                alert("Успешно добавлен!");
            },
            error: function (data) {
                console.log(data);
            }
        });
    });


$(document).on('click', '#delete_product', function (e) {
e.preventDefault();
    let id = $(this).attr('data-id');
        $.ajax({
            url: "/Admin/Delete_product/" + id,
            data: null,
            type: "GET",
            contentType: false,
            cache: false,
            processData: false,
            //dataType: 'json',
            success: function (data) {
                $('#table_item_adm_'+id).remove();
            },
            error: function (data) {
                console.log(data);
            }
        });
});

$(document).on('click', '#edit_product', function (e) {
e.preventDefault();
let id = $(this).attr('data-id');
    ajaxReq('/Admin/Edit_product/'+id, 'GET', (data)=>{
    $('#edit_product_modal_body').html(data);
    $('#edit_product_modal').modal('show');
});
});


    $(document).on('click', '#save_edit_product', function () {
        let id = $(this).attr('data-id');
        let title = $('#title_edit').val();
        let articul = $('#articul_edit').val();
        let price = $('#price_edit').val();
        let price_discount = $('#price_discount_edit').val();
        let quontity = $('#quontity_edit').val();
        let Description = $('#Description_edit').summernote('code');

        let is_sale = ($('#is_sale_edit').prop('checked')== true)? '1':'0';
        let is_new = ($('#is_new_edit').prop('checked')== true)? '1':'0';
        price_discount = (is_sale == 0)? 0.00: price_discount;

        let data = new FormData();
        data.append('id', id);
        data.append('title', title);
        data.append('articul', articul);
        data.append('price', price);
        data.append('price_discount', price_discount);
        data.append('quontity', quontity);
        data.append('Description', Description);
        data.append('is_sale', is_sale);
        data.append('is_new', is_new);
        ajaxReq('/Admin/Save_edit_product', 'POST', (data) => {
            $('#table_item_adm_' + id).remove();
            $('#table_adm').prepend(data);
            $('#edit_product_modal').modal('hide');
            $('#title_edit').val('');
            $('#articul_edit').val('');
            $('#price_edit').val('');
            $('#price_discount_edit').val('');
            $('#quontity_edit').val('');
            $('#Description_edit').val('');
        }, data)
    });



$(document).on('click', '#delete_galery_item', function (e) {
e.preventDefault();
let id = $(this).attr('data-id');
    ajaxReq('/Admin/DeleteImage/'+id, "GET", (data)=>{
    $('#galery_item_'+id).remove();
});
});



    


$(document).on('click', '#ad_usr_btn', function (e) {
        e.preventDefault();
        $('#add_user_modal').modal('show');
});



$(document).on('click', '#save_user', function (e) {
e.preventDefault();
let lastname = $('#lastname_new').val();
let rollesId = $('#role_new').val();
let firstname = $('#firstname_new').val();
let middlename = $('#middlename_new').val();
let phone = $('#phone_new').val();
let email = $('#email_new').val();
let password = $('#password_new').val();
let city = $('#city_new').val();
let addres = $('#address_new').val();
let image = $('#image_new').prop('files')[0];
let fD = new FormData();
fD.append('rollesId', rollesId);
fD.append('lastname', lastname);
fD.append('firstname', firstname);
fD.append('middlename', middlename);
fD.append('phone', phone);
fD.append('email', email);
fD.append('password', password);
fD.append('city', city);
fD.append('addres', addres);
fD.append('image', image);
    ajaxReq('/Admin/Create_user', 'POST', (data)=>{
        $('#table-adm_user').append(data);
        $('#lastname_new').val('');
        $('#role_new').val('');
        $('#firstname_new').val('');
        $('#middlename_new').val('');
        $('#phone_new').val('');
        $('#email_new').val('');
        $('#password_new').val('');
        $('#city_new').val('');
        $('#address_new').val('');
        $('#image_new').val('');
        $('#add_user_modal').modal('hide');
    },fD);
});




    $(document).on('click', '#delete_user', function (e) {
        e.preventDefault();
        let id= $(this).attr('data-id');
        ajaxReq('/Admin/Delete_user/' + id, ...[,],(data)=>{
            $('#table_item_adm_'+id).remove();
        });
    });


$(document).on('click', '#edit_user', function (e) {
    e.preventDefault();
    let id = $(this).attr('data-id');
    ajaxReq('/Admin/Edit_user/'+id, ...[,], (data)=>{
        $('#edit_user_modal_body').html(data);
        $('#edit_user_modal').modal('show');
    });
});



    $(document).on('click', '#save_edit_user', function (e) {
        e.preventDefault();
        let id = $(this).attr('data-id');
        let lastname = $('#last_name_edit').val();
        let rollesid = $('#role_edit').val();
        let firstname = $('#first_name_edit').val();
        let middlename = $('#middle_name_edit').val();
        let phone = $('#phone_edit').val();
        let email = $('#email_edit').val();
        let password = $('#password_edit').val();
        let city = $('#city_edit').val();
        let addres = $('#address_edit').val();
        let image = $('#image_edit').prop('files')[0];
        let fD = new FormData();
        fD.append('id', id);
        fD.append('rollesid', rollesid);
        fD.append('lastname', lastname);
        fD.append('firstname', firstname);
        fD.append('middlename', middlename);
        fD.append('phone', phone);
        fD.append('email', email);
        fD.append('password', password);
        fD.append('city', city);
        fD.append('addres', addres);
        fD.append('image', image);
        ajaxReq('/Admin/Save_edit_user', 'POST', (data)=>{
            console.log(data);
                $('#table_item_adm_'+id).html(data);
            $('#last_name_edit').val('');
                $('#role_edit').val('');
            $('#first_name_edit').val('');
            $('#middle_name_edit').val('');
                $('#phone_edit').val('');
                $('#email_edit').val('');
                $('#password_edit').val('');
                $('#city_edit').val('');
                $('#address_edit').val('');
                $('#image_edit').val('');
                $('#edit_user_modal').modal('hide');
            },fD);
    });

$(document).on('click', '#edit_site_property', function (e) {
e.preventDefault();
$('#site_name').prop('readonly', false);
$('#telegram_link').prop('readonly', false);
$('#youtube_link').prop('readonly', false);
$('#instagram_link').prop('readonly', false);
$('#fb_link').prop('readonly', false);
$('#email').prop('readonly', false);
$('#phone_two').prop('readonly', false);
$('#phone_one').prop('readonly', false);
$('#address').prop('readonly', false);
$('#edit_site_property').toggleClass('d-none');
$('#save_site_property').toggleClass('d-none');

});

$(document).on('click', '#save_site_property', function (e) {
e.preventDefault();
let fd = new FormData();
    fd.append('site_name', $('#site_name').val());
    fd.append('telegram_link', $('#telegram_link').val());
    fd.append('youtube_link', $('#youtube_link').val());
    fd.append('instagram_link', $('#instagram_link').val());
    fd.append('fb_link', $('#fb_link').val());
    fd.append('email', $('#email').val());
    fd.append('phone_two', $('#phone_two').val());
    fd.append('phone_one', $('#phone_one').val());
    fd.append('address', $('#address').val());

    ajaxReq('/admin/site-property/update', 'POST', (data)=>{
        showToast('Сохранено');
        $('#site_name').prop('readonly', true);
        $('#telegram_link').prop('readonly', true);
        $('#youtube_link').prop('readonly', true);
        $('#instagram_link').prop('readonly', true);
        $('#fb_link').prop('readonly', true);
        $('#email').prop('readonly', true);
        $('#phone_two').prop('readonly', true);
        $('#phone_one').prop('readonly', true);
        $('#address').prop('readonly', true);
        $('#edit_site_property').toggleClass('d-none');
        $('#save_site_property').toggleClass('d-none');

    }, fd);


});

var recomendProducts = [];
var recomendProductsEdit = [];
$(document).on('click', '#r_prod_btn', function (e) {
e.preventDefault();
    let id = $('#rec_prod_select').val();
    $('#rec_prod_select').val('');
    req('/add-recomend-product/'+id, ...[,], (data)=>{
        //console.log(data);
        $('#recomendes_product').append(data);
        recomendProducts.push(id);
    });
});

$(document).on('click', '#r_prod_btn-edit', function (e) {
e.preventDefault();
    let id = $('#rec_prod_select-edit').val();
    $('#rec_prod_select-edit').val('');
    req('/add-recomend-product-save/'+id +'/'+ $(this).attr('data-id') , ...[,], (data)=>{
        //console.log(data);
        $('#recomendes_product-edit').append(data);
        recomendProductsEdit.push(id);
    });
});

$(document).on('click', '#delete_item_prod_rec_new', function (e) {
e.preventDefault();
let id = $(this).attr('data-id');

$('#item_r_prod_'+id).remove();
    const i = recomendProducts.indexOf(id);
    if (i > -1) {
        recomendProducts.splice(i, 1);
    }
   // console.log(recomendProducts);


});
$(document).on('click', '#delete_item_prod_rec_edit', function (e) {
e.preventDefault();
let rID = $(this).attr('data-id');
let pID = $('#recomendes_product-edit').attr('data-id');

    const i = recomendProductsEdit.indexOf(rID);
    if (i > -1) {
        recomendProductsEdit.splice(i, 1);
    }
   // console.log(recomendProducts);
    req('/delete-recomend-prod/'+rID+'/'+pID,...[,], (data)=>{
        $('#item_r_prod_'+rID).remove();
    });


});

$(document).on('click', '#save_delivery_property', function (e) {
e.preventDefault();
let form_data = new FormData();
form_data.append('city', $('#city').val());
form_data.append('nocity', $('#nocity').val());

req('/admin/delivery-change', "POST", (data)=>{

    //console.log(data);
    $('#succes').toggleClass('d-none').html('Успешно сохранен !!!');
    setTimeout(function () {
        $('#succes').fadeOut(500).toggleClass('d-none');
    }, 2500);
},form_data);
});


$(document).on('click', '#load_more_products', function (e) {
e.preventDefault();
let cid = $(this).attr('data-id');
let page = $(this).attr('data-page');

$(this).prop('disabled', true).html('Загружаеться ...');

let formData = new FormData();
formData.append('cid', cid);
formData.append('page', page);
req('/admin/products/load-more', 'POST', (data)=>{
    //console.log(data);
    if(data.info.qnt == 0){
      $('.load-more-products').remove();
    }
    else{
        $('#table-adm').append(data.html);
        page++;
        $('#load_more_products').prop('disabled', false).html('Загрузить ещё').attr('data-page', page);

    }
},formData);

});

$(document).on('click', '#save_catHome', function (e) {
e.preventDefault();
let one = $('#one').val();
let two = $('#two').val();

let formData = new FormData();
formData.append('one', one);
formData.append('two', two);
req('/admin/home-cats-update', 'POST', (data)=>{
    //console.log(data);
    $('#succes').toggleClass('d-none').html('Успешно сохранен !!!');
    setTimeout(function () {
        $('#succes').fadeOut(500).toggleClass('d-none');
    }, 2500);
}, formData, 'error');
});


var orderStatuses = {
    '1':'<span class="badge badge-round badge-danger">Новый заказ</span>',
    '2':'<span class="badge badge-round badge-primary">Обработан</span>',
    '3':'<span class="badge badge-round badge-warning">Отказ</span>',
    '4':'<span class="badge badge-round badge-success">Доставлен</span>',
}

$(document).on('click', '#change_status_order', function () {
    let sts = $(this).attr('data-sts');
    $('#save_sts_order').attr('data-id', $(this).attr('data-id')).attr('data-sts', sts);
    $('#current_sts').html(orderStatuses[sts]);
    jQuery("#new_sts_order option:selected").removeAttr("selected");
    jQuery("#new_sts_order option[value='"+sts +"']").attr('selected', 'selected');

    $('#change_sts_order_modal').modal('show');
});

$(document).on('click', '#save_sts_order', function (e) {
e.preventDefault();
let id = $(this).attr('data-id');
let sts = $('#new_sts_order').val();
    console.log(id);
    console.log(sts);

if(sts=>1 && sts<=4){
    let formData = new FormData();
    formData.append('id', id);
    formData.append('sts', sts);
    req('/admin/order-change-status', "POST", (data)=>{
        //console.log(data);
        $('.order-status-'+id).html(orderStatuses[data]);
        $('#change_sts_order_modal').modal('hide');

    }, formData);
}
})

































































































































































































































































































            var i = -1;
            var toastCount = 0;
            var $toastlast;

            var getMessage = function () {
                var msgs = [
                    'Have fun storming the castle!'
                ];
                i++;
                if (i === msgs.length) {
                    i = 0;
                }

                return msgs[i];
            };


            $('#closeButton').click(function() {
                if($(this).is(':checked')) {
                    $('#addBehaviorOnToastCloseClick').prop('disabled', false);
                } else {
                    $('#addBehaviorOnToastCloseClick').prop('disabled', true);
                    $('#addBehaviorOnToastCloseClick').prop('checked', false);
                }
            });

function showToast(msg) {

                toastr.options = {
                    "closeButton": true,
                    "debug": false,
                    "newestOnTop": false,
                    "progressBar": false,
                    "rtl": false,
                    "positionClass": "toast-top-right",
                    "preventDuplicates": false,
                    "onclick": null,
                    "showDuration": 300,
                    "hideDuration": 1000,
                    "timeOut": 5000,
                    "extendedTimeOut": 100,
                    "showEasing": "swing",
                    "hideEasing": "linear",
                    "showMethod": "fadeIn",
                    "hideMethod": "fadeOut"
                }

                if ($('#addBehaviorOnToastClick').prop('checked')) {
                    toastr.options.onclick = function () {
                        alert('You can perform some custom action after a toast goes away');
                    };
                }

                if ($('#addBehaviorOnToastCloseClick').prop('checked')) {
                    toastr.options.onCloseClick = function () {
                        alert('You can perform some custom action when the close button is clicked');
                    };
                }

                //var $toast = toastr[shortCutFunction](msg, title); // Wire up an event handler to a button in the toast, if it exists
                var $toast = toastr["success"](msg); // Wire up an event handler to a button in the toast, if it exists
                $toastlast = $toast;

                if(typeof $toast === 'undefined'){
                    return;
                }

                if ($toast.find('#okBtn').length) {
                    $toast.delegate('#okBtn', 'click', function () {
                        alert('you clicked me. i was toast #' + toastIndex + '. goodbye!');
                        $toast.remove();
                    });
                }
                if ($toast.find('#surpriseBtn').length) {
                    $toast.delegate('#surpriseBtn', 'click', function () {
                        alert('Surprise! you clicked me. i was toast #' + toastIndex + '. You could perform an action here.');
                    });
                }
                if ($toast.find('.clear').length) {
                    $toast.delegate('.clear', 'click', function () {
                        toastr.clear($toast, { force: true });
                    });
                }
            }

            function getLastToast(){
                return $toastlast;
            }
            $('#clearlasttoast').click(function () {
                toastr.clear(getLastToast());
            });
            $('#cleartoasts').click(function () {
                toastr.clear();
            });











})(jQuery);
