<?php
/**
 * Created by PhpStorm.
 * User: DEV-14
 * Date: 6/24/2018
 * Time: 9:19 PM
 */

?>
<!DOCTYPE html>
<!--[if lt IE 7]><html class="no-js lt-ie9 lt-ie8 lt-ie7"> <![endif]-->
<!--[if IE 7]><html class="no-js lt-ie9 lt-ie8"> <![endif]-->
<!--[if IE 8]><html class="no-js lt-ie9"> <![endif]-->
<!--[if gt IE 8]><!--><html class="no-js"> <!--<![endif]-->
<head>
    <title>AutoTask/Billings</title>
    <link rel="stylesheet" href="<?php echo site_url('assets/loader/css/main.css')?>">
    <link rel="stylesheet" href="<?php echo site_url('assets/bootstrap-3.3.7/css/bootstrap.min.css')?>">
    <link rel="stylesheet" href="<?php echo site_url('assets/datepicker/css/bootstrap-datetimepicker.min.css')?>" media="screen">
    <link rel="stylesheet" href="<?php echo site_url('assets/css/custom.css')?>">
    <script src="<?php echo site_url('assets/loader/js/modernizr-2.6.2.min.js')?>"></script>
    <script src="<?php echo site_url('assets/js/jquery_3.3.1.js')?>"></script>
    <script src="<?php echo site_url('assets/bootstrap-3.3.7/js/bootstrap.min.js')?>"></script>
    <script src="<?php echo site_url('assets/datepicker/js/bootstrap-datetimepicker.js"')?>" charset="UTF-8"></script>
</head>
<body>
<div id="loader-wrapper">
    <div id="loader"></div>
    <div class="loader-section section-left"></div>
    <div class="loader-section section-right"></div>
</div>
<div class="container">
    <form>
    <div class="row">
        <div class="col-md-6 col-sm-6" style="padding-right: 5px">
            <div class="content billing">
                <div class="row">
                    <div class="col-md-12" style="text-align: right">
                        <button type="button" class="btn btn-success" onclick="billing_save()"><span class="glyphicon glyphicon-floppy-save"></span> SAVE</button>
                        <button type="button" class="btn btn-danger" onclick="billing_delete()"><span class="glyphicon glyphicon-floppy-remove"></span> DELETE</button>
                        <button type="button" class="btn btn-info" onclick="billing_load()"><span class="glyphicon glyphicon-floppy-open"></span> LOAD</button>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class="billing-cols">
                            <span class="glyphicon glyphicon-user"></span>&nbsp;&nbsp;<input type="text" id="profile-name" placeholder="Profile Name" autocomplete="off" required>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <h3 style="color: green"><span class="glyphicon glyphicon-usd"></span> PAYMENT DETAILS</h3>
                    </div>
                </div>
                <div class="row billing-rows">
                    <div class="col-md-12">
                        <div class="billing-cols">
                            <span class="glyphicon glyphicon-envelope"></span>&nbsp;&nbsp;<input type="email" id="payment-details-email" placeholder="Email" autocomplete="off" required>
                        </div>
                    </div>
                </div>
                <div class="row billing-rows">
                    <div class="col-md-12">
                        <div class="billing-cols">
                            <span class="glyphicon glyphicon-phone"></span>&nbsp;&nbsp;<input type="text" id="payment-details-phone" placeholder="Phone" autocomplete="off" required>
                        </div>
                    </div>
                </div>
                <div class="row billing-rows">
                    <div class="col-md-12">
                        <div class="billing-cols">
                            <span class="glyphicon glyphicon-baby-formula"></span>&nbsp;&nbsp;<input type="text" id="payment-details-name" placeholder="Card Name" autocomplete="off" required>
                        </div>
                    </div>
                </div>
                <div class="row billing-rows">
                    <div class="col-md-12">
                        <div class="billing-cols">
                            <span class="glyphicon glyphicon-credit-card"></span>&nbsp;&nbsp;<input type="text" id="payment-details-card" placeholder="Card Number" autocomplete="off" required>
                        </div>
                    </div>
                </div>
                <div class="row billing-rows">
                    <div class="col-md-12">
                        <div class="billing-cols">
                            <div class="input-group date form_date" data-date="" data-date-format="MM yyyy" data-link-field="dtp_input2" data-link-format="yyyy-mm">
                                <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></span>
                                <input class="form-control" id="billing-expiry-date1" size="16" type="text" value="" placeholder="Expiry Date" autocomplete="off" required>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row billing-rows">
                    <div class="col-md-12">
                        <div class="billing-cols">
                            <span class="glyphicon glyphicon-credit-card"></span>&nbsp;&nbsp;<input type="text" id="payment-details-cvv" placeholder="CVV" autocomplete="off" required>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12 col-sm-12" style="text-align: right">
                        <button type="button" class="btn btn-primary" onclick="billing_new()"><span class="glyphicon glyphicon-repeat"></span> NEW</button>
                    </div>
                </div>
            </div>

        </div>
        <div class="col-md-6 col-sm-6" style="padding-left: 5px">
            <div class="content billing">
                <div id="delivery-details-content">
                    <div class="row">
                        <div class="col-md-12 col-sm-12">
                            <h3 style="color: green"><span class="glyphicon glyphicon-th-list"></span> DELIVERY DETAILS</h3>
                        </div>
                    </div>
                    <div class="row billing-rows">
                        <div class="col-md-6 col-sm-6">
                            <div class="billing-cols billing-detail">
                                <span class="glyphicon glyphicon-user"></span><input type="text" id="delivery-details-f-name" placeholder="First Name" autocomplete="off" required>
                            </div>
                        </div>
                        <div class="col-md-6 col-sm-6">
                            <div class="billing-cols billing-detail">
                                <span class="glyphicon glyphicon-user"></span><input type="text" id="delivery-details-l-name" placeholder="Last Name" autocomplete="off" required>
                            </div>
                        </div>
                    </div>
                    <div class="row billing-rows">
                        <div class="col-md-6 col-sm-6">
                            <div class="billing-cols billing-detail">
                                <span class="glyphicon glyphicon-map-marker"></span><input type="text" id="delivery-details-address1" placeholder="Address1" autocomplete="off" required>
                            </div>
                        </div>
                        <div class="col-md-6 col-sm-6">
                            <div class="billing-cols billing-detail">
                                <span class="glyphicon glyphicon-map-marker"></span><input type="text" id="delivery-details-address2" placeholder="Address2" autocomplete="off" required>
                            </div>
                        </div>
                    </div>
                    <div class="row billing-rows">
                        <div class="col-md-6 col-sm-6">
                            <div class="billing-cols billing-detail">
                                <span class="glyphicon glyphicon-compressed"></span><input type="text" id="delivery-details-zipcode" placeholder="Zip Code" autocomplete="off" required>
                            </div>
                        </div>
                        <div class="col-md-6 col-sm-6">
                            <div class="billing-cols billing-detail">
                                <span class="glyphicon glyphicon-bed"></span><input type="text" id="delivery-details-city" placeholder="City" autocomplete="off" required>
                            </div>
                        </div>
                    </div>
                    <div class="row billing-rows">
                        <div class="col-md-6 col-sm-6">
                            <div class="billing-cols billing-detail">
                                <span class="glyphicon glyphicon-globe"></span><input type="text" id="delivery-details-country" placeholder="Country" autocomplete="off" required>
                            </div>
                        </div>
                        <div class="col-md-6 col-sm-6">
                            <div class="billing-cols billing-detail">
                                <span class="glyphicon glyphicon-globe"></span><input type="text" id="delivery-details-state" placeholder="State/Province" autocomplete="off" required>
                            </div>
                        </div>
                    </div>
                </div>

                <div id="billing-details-content">
                    <div class="row">
                        <div class="col-md-8 col-sm-8">
                            <h3 style="color: green"><span class="glyphicon glyphicon-list-alt"></span> BILLING DETAILS</h3>
                        </div>
                        <div class="col-md-4 col-sm-4" style="text-align: right; padding-top: 20px;">
                            <label class="autotak-switch">
                                <input type="checkbox" id="billing-switch" onchange="billing_details_switch()" checked>
                                <span class="autotak-slider"></span>
                            </label>
                        </div>
                    </div>
                    <div class="row billing-rows">
                        <div class="col-md-6 col-sm-6">
                            <div class="billing-cols billing-detail">
                                <span class="glyphicon glyphicon-user"></span><input type="text" id="billing-details-f-name" placeholder="First Name" autocomplete="off" required>
                            </div>
                        </div>
                        <div class="col-md-6 col-sm-6">
                            <div class="billing-cols billing-detail">
                                <span class="glyphicon glyphicon-user"></span><input type="text" id="billing-details-l-name" placeholder="Last Name" autocomplete="off" required>
                            </div>
                        </div>
                    </div>
                    <div class="row billing-rows">
                        <div class="col-md-6 col-sm-6">
                            <div class="billing-cols billing-detail">
                                <span class="glyphicon glyphicon-map-marker"></span><input type="text" id="billing-details-address1" placeholder="Address1" autocomplete="off" required>
                            </div>
                        </div>
                        <div class="col-md-6 col-sm-6">
                            <div class="billing-cols billing-detail">
                                <span class="glyphicon glyphicon-map-marker"></span><input type="text" id="billing-details-address2" placeholder="Address2" autocomplete="off" required>
                            </div>
                        </div>
                    </div>
                    <div class="row billing-rows">
                        <div class="col-md-6 col-sm-6">
                            <div class="billing-cols billing-detail">
                                <span class="glyphicon glyphicon-compressed"></span><input type="text" id="billing-details-zipcode" placeholder="Zip Code" autocomplete="off" required>
                            </div>
                        </div>
                        <div class="col-md-6 col-sm-6">
                            <div class="billing-cols billing-detail">
                                <span class="glyphicon glyphicon-bed"></span><input type="text" id="billing-details-city" placeholder="City" autocomplete="off" required>
                            </div>
                        </div>
                    </div>
                    <div class="row billing-rows">
                        <div class="col-md-6 col-sm-6">
                            <div class="billing-cols billing-detail">
                                <span class="glyphicon glyphicon-globe"></span><input type="text" id="billing-details-country" placeholder="Country" autocomplete="off" required>
                            </div>
                        </div>
                        <div class="col-md-6 col-sm-6">
                            <div class="billing-cols billing-detail">
                                <span class="glyphicon glyphicon-globe"></span><input type="text" id="billing-details-state" placeholder="State/Province" autocomplete="off" required>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
        <input type="submit" id="billing-submit" style="display: none" value="submit">
    </form>
</div>

<!-- Load Profile Names Modal -->
<div class="modal fade" id="loadAllBillingsModal" role="dialog" style="margin-top: 150px;">
    <div class="modal-dialog">
        <!-- Modal content-->
        <div class="modal-content" style="padding-top: 30px;">
            <form>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-md-12 col-sm-12" style="text-align: center">
                            <h3> Load Billing Profile </h3>
                        </div>
                    </div>
                    <div class="row" style="padding: 30px 0">
                        <div class="col-md-2"></div>
                        <div class="col-md-3">
                            <h5 style="color: orangered">Profile Names</h5>
                        </div>
                        <div class="col-md-5">
                            <select class="form-control" id="road-profile-names">
                                <option disabled selected value> -- select a name -- </option>
                                <option value="test">test</option>
                            </select>
                        </div>
                        <div class="col-md-2"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-12" style="text-align: right">
                            <button type="button" class="btn btn-success" data-dismiss="modal" onclick="load_profile_name()">Load</button>
                            <button type="button" class="btn btn-danger" data-dismiss="modal">Cancel</button>
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </div>
</div>
<!-- Save Success Modal -->
<div class="modal fade" id="savedSuccessBillingModal" role="dialog" style="margin-top: 150px;">
    <div class="modal-dialog">
        <!-- Modal content-->
        <div class="modal-content" style="padding-top: 30px;">
            <form>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-md-12 col-sm-12" style="text-align: center">
                            <span class="glyphicon glyphicon-ok-sign" style="font-size: 50px; color: green"></span>
                        </div>
                    </div>
                    <h3 style="text-align: center; color: orangered">SUCCESS!</h3>
                    <div class="row">
                        <div class="col-md-12" style="text-align: right">
                            <button type="button" class="btn btn-success" data-dismiss="modal"> OK ! </button>
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </div>
</div>
<script src="<?php echo site_url('assets/loader/js/main.js')?>"></script>
<!--<script src="--><?php //echo site_url('assets/js/custom.js')?><!--"></script>-->
<script>
    $('.form_date').datetimepicker({
        weekStart: 1,
        todayBtn:  1,
        autoclose: 1,
        todayHighlight: 1,
        startView: 2,
        minView: 2,
        forceParse: 0
    });

    function billing_details_switch() {
        if(!$("#billing-switch").prop("checked")){
            $("#billing-details-content").css("color", "gray");
            $("input[id^='billing-details-']").prop("disabled", true);
        } else {
            $("#billing-details-content").css("color", "green");
            $("input[id^='billing-details-']").prop("disabled", false);
        }
    }

    function billing_new() {
        $("#profile-name").val("");
        $("#payment-details-email").val("");
        $("#payment-details-phone").val("");
        $("#payment-details-name").val("");
        $("#payment-details-card").val("");
        $("#billing-expiry-date1").val("");
        $("#payment-details-cvv").val("");
        $("#delivery-details-f-name").val("");
        $("#delivery-details-l-name").val("");
        $("#delivery-details-address1").val("");
        $("#delivery-details-address2").val("");
        $("#delivery-details-zipcode").val("");
        $("#delivery-details-city").val("");
        $("#delivery-details-country").val("");
        $("#delivery-details-state").val("");
        if($("#billing-switch").prop("checked")){
            $("#billing-details-f-name").val("");
            $("#billing-details-l-name").val("");
            $("#billing-details-address1").val("");
            $("#billing-details-address2").val("");
            $("#billing-details-zipcode").val("");
            $("#billing-details-city").val("");
            $("#billing-details-country").val("");
            $("#billing-details-state").val("");
        }
    }
    
    function billing_save() {
        var submit_flag = true;
        var profile_name = $("#profile-name").val();
        var payment_emil = $("#payment-details-email").val();
        var payment_phone = $("#payment-details-phone").val();
        var payment_name = $("#payment-details-name").val();
        var payment_card = $("#payment-details-card").val();
        var payment_expiry = $("#billing-expiry-date1").val();
        var payment_cvv = $("#payment-details-cvv").val();
        var delivery_f_name = $("#delivery-details-f-name").val();
        var delivery_l_name = $("#delivery-details-l-name").val();
        var delivery_address1 = $("#delivery-details-address1").val();
        var delivery_address2 = $("#delivery-details-address2").val();
        var delivery_zipcode = $("#delivery-details-zipcode").val();
        var delivery_city = $("#delivery-details-city").val();
        var delivery_country = $("#delivery-details-country").val();
        var delivery_state = $("#delivery-details-state").val();
        if (profile_name == "" || payment_emil == "" || payment_phone == "" || payment_name == "" ||
        payment_card == "" || payment_expiry == "" || payment_cvv == "" || delivery_f_name == "" ||
        delivery_l_name == "" || delivery_address1 == "" || delivery_address2 == "" || delivery_zipcode == "" ||
        delivery_city == "" || delivery_country == "" || delivery_state == ""){
            $("#billing-submit").click();
            submit_flag = false;
        }
        var billing_f_name = "";
        var billing_l_name = "";
        var billing_address1 = "";
        var billing_address2 = "";
        var billing_zipcode = "";
        var billing_city = "";
        var billing_country = "";
        var billing_state = "";
        if($("#billing-switch").prop("checked")){
            billing_f_name = $("#billing-details-f-name").val();
            billing_l_name = $("#billing-details-l-name").val();
            billing_address1 = $("#billing-details-address1").val();
            billing_address2 = $("#billing-details-address2").val();
            billing_zipcode = $("#billing-details-zipcode").val();
            billing_city = $("#billing-details-city").val();
            billing_country = $("#billing-details-country").val();
            billing_state = $("#billing-details-state").val();
            if (billing_f_name == "" || billing_l_name == "" || billing_address1 == "" ||
                billing_address2 == "" || billing_zipcode == "" || billing_city == "" ||
                billing_country == "" || billing_state == ""){
                $("#billing-submit").click();
                submit_flag = false;
            }
        }
        if (submit_flag){
            $.ajax({
                type: "POST",
                data: {
                    token_id: "<?php echo $token_id; ?>",
                    name: profile_name,
                    email: payment_emil,
                    phone: payment_phone,
                    cardName: payment_name,
                    cardNum: payment_card,
                    expiry: payment_expiry,
                    cvv: payment_cvv,
                    f_name: delivery_f_name,
                    l_name: delivery_l_name,
                    address1: delivery_address1,
                    address2: delivery_address2,
                    zipcode: delivery_zipcode,
                    city: delivery_city,
                    country: delivery_country,
                    state: delivery_state,
                    bf_name: billing_f_name,
                    bl_name: billing_l_name,
                    b_address1: billing_address1,
                    b_address2: billing_address2,
                    b_zipcode: billing_zipcode,
                    b_city: billing_city,
                    b_country: billing_country,
                    b_state: billing_state,
                    type: "add"
                },
                url: "<?php echo base_url(); ?>billing/add_billing",
                success: function (msg) {
                    local_cache = [];
                    if (localStorage.getItem("profile_names")){
                        console.log("Exist Local Storage");
                        local_cache = JSON.parse(localStorage.getItem("profile_names"));
                    }
                    var index = local_cache.indexOf(msg);
                    if(index === -1){
                        local_cache.push(msg);
                    }
                    localStorage.setItem("profile_names", JSON.stringify(local_cache));
                    console.log(localStorage.getItem("profile_names"));
                    $("#savedSuccessBillingModal").modal();
                }
            });
        }
    }

    function billing_delete() {
        var submit_flag = true;
        var profile_name = $("#profile-name").val();
        if (profile_name === ""){
            $("#billing-submit").click();
            submit_flag = false;
        }
        if (submit_flag){
            $.ajax({
                type: "POST",
                data: {
                    token_id: "<?php echo $token_id; ?>",
                    name: profile_name,
                    type: "remove"
                },
                url: "<?php echo base_url(); ?>billing/remove_billing",
                success: function (msg) {
                    local_cache = [];
                    if (localStorage.getItem("profile_names")){
                        console.log("Exist Local Storage");
                        local_cache = JSON.parse(localStorage.getItem("profile_names"));
                    }
                    var index = local_cache.indexOf(msg);
                    if(index !== -1){
                        local_cache.splice(index, 1);
                    }
                    localStorage.setItem("profile_names", JSON.stringify(local_cache));
                    console.log(localStorage.getItem("profile_names"));
                }
            });
            billing_new();
        }
    }

    function billing_load() {
        $.ajax({
            type: "POST",
            data: {
                token_id: "<?php echo $token_id; ?>",
                type: "get_billing_names"
            },
            url: "<?php echo base_url(); ?>billing/get_billings",
            success: function (res) {
                var billing_names = $.parseJSON(res);
                $("#road-profile-names").find('option').remove().end().append('<option disabled selected value>-- select a name --</option>');
                $.each(billing_names, function(k, v) {
                    $('<option>').val(v.name).text(v.name).appendTo('#road-profile-names');
                });
            }
        });
        $("#loadAllBillingsModal").modal();
    }

    function load_profile_name() {
        var profile_name = $("#road-profile-names").val();
        if (profile_name !== null){
            $.ajax({
                type: "POST",
                data: {
                    token_id: "<?php echo $token_id; ?>",
                    profile_name: profile_name,
                    type: "get_billing"
                },
                url: "<?php echo base_url(); ?>billing/get_billings",
                success: function (res) {
                    var billings = $.parseJSON(res);
                    $("#profile-name").val(billings["name"]);
                    $("#payment-details-email").val(billings["email"]);
                    $("#payment-details-phone").val(billings["phone"]);
                    $("#payment-details-name").val(billings["cardName"]);
                    $("#payment-details-card").val(billings["cardNum"]);
                    $("#billing-expiry-date1").val(billings["expiry"]);
                    $("#payment-details-cvv").val(billings["cvv"]);
                    $("#delivery-details-f-name").val(billings["f_name"]);
                    $("#delivery-details-l-name").val(billings["l_name"]);
                    $("#delivery-details-address1").val(billings["address1"]);
                    $("#delivery-details-address2").val(billings["address2"]);
                    $("#delivery-details-zipcode").val(billings["zipcode"]);
                    $("#delivery-details-city").val(billings["city"]);
                    $("#delivery-details-country").val(billings["country"]);
                    $("#delivery-details-state").val(billings["state"]);
                    $("#billing-details-f-name").val(billings["bf_name"]);
                    $("#billing-details-l-name").val(billings["bl_name"]);
                    $("#billing-details-address1").val(billings["b_address1"]);
                    $("#billing-details-address2").val(billings["b_address2"]);
                    $("#billing-details-zipcode").val(billings["b_zipcode"]);
                    $("#billing-details-city").val(billings["b_city"]);
                    $("#billing-details-country").val(billings["b_country"]);
                    $("#billing-details-state").val(billings["b_state"]);
                }
            });
        }

    }
</script>
</body>
</html>

