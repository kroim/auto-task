<?php
/**
 * Created by PhpStorm.
 * User: DEV-14
 * Date: 6/24/2018
 * Time: 9:19 PM
 */
$settings_flag = false;
if (sizeof($setting_data) > 0){
    $settings_flag = true;
}
?>
<!DOCTYPE html>
<!--[if lt IE 7]><html class="no-js lt-ie9 lt-ie8 lt-ie7"> <![endif]-->
<!--[if IE 7]><html class="no-js lt-ie9 lt-ie8"> <![endif]-->
<!--[if IE 8]><html class="no-js lt-ie9"> <![endif]-->
<!--[if gt IE 8]><!--><html class="no-js"> <!--<![endif]-->
<head>
    <title>AutoTask/Settings</title>
    <link rel="stylesheet" href="<?php echo site_url('assets/loader/css/main.css')?>">
    <link rel="stylesheet" href="<?php echo site_url('assets/bootstrap-3.3.7/css/bootstrap.min.css')?>">
    <link rel="stylesheet" href="<?php echo site_url('assets/css/custom.css')?>">
    <script src="<?php echo site_url('assets/loader/js/modernizr-2.6.2.min.js')?>"></script>
    <script src="<?php echo site_url('assets/js/jquery_3.3.1.js')?>"></script>
    <script src="<?php echo site_url('assets/bootstrap-3.3.7/js/bootstrap.min.js')?>"></script>

</head>
<body>
<div id="loader-wrapper">
    <div id="loader"></div>
    <div class="loader-section section-left"></div>
    <div class="loader-section section-right"></div>
</div>
<div class="container">
    <div class="content">
        <div class="billing" style="padding: 2% 8%;">
            <div class="row billing-rows">
                <div class="col-md-12">
                    <div class="billing-cols">
                        <span class="glyphicon glyphicon-cd"></span>&nbsp;&nbsp;
                        <input type="password" id="settings-key" placeholder="Licence Key" autocomplete="off" value="<?php echo $token; ?>">
                    </div>
                </div>
            </div>
            <div class="row billing-rows">
                <div class="col-md-12" style="text-align: right">
                    <button class="btn btn-success" id="settings-show-btn" onclick="show_key()"><span class="glyphicon glyphicon-eye-open"></span> Show Key</button>
                </div>
            </div>
            <div class="row billing-rows">
                <div class="col-md-12">
                    <div class="billing-cols">
                        <span class="glyphicon glyphicon-dashboard"></span>&nbsp;&nbsp;
                        <span>Global Delay (ms): </span>&nbsp;&nbsp;
                        <input type="text" id="settings-global" autocomplete="off"
                               value="<?php if ($settings_flag){
                                   echo $setting_data[0]->global_delay;
                               } else {
                                   echo "";
                               } ?>">
                    </div>
                </div>
            </div>
            <div class="row billing-rows">
                <div class="col-md-12">
                    <div class="billing-cols">
                        <span class="glyphicon glyphicon-lamp"></span>&nbsp;&nbsp;
                        <span>Monitor Delay (ms): </span>&nbsp;&nbsp;
                        <input type="text" id="settings-monitor" autocomplete="off"
                               value="<?php if ($settings_flag){
                                   echo $setting_data[0]->monitor_delay;
                               } else {
                                   echo "";
                               } ?>">
                    </div>
                </div>
            </div>
            <div class="row billing-rows">
                <div class="col-md-12">
                    <div class="billing-cols">
                        <span class="glyphicon glyphicon-bell"></span>&nbsp;&nbsp;
                        <span>Current Version: </span>&nbsp;&nbsp;
                        <input type="text" id="settings-version" autocomplete="off" readonly
                               value="<?php if ($settings_flag){
                                   echo $setting_data[0]->version;
                               } else {
                                   echo "";
                               } ?>">
                    </div>
                </div>
            </div>
            <div class="row billing-rows">
                <div class="col-md-12">
                    <div class="billing-cols">
                        <span class="glyphicon glyphicon-sunglasses"></span>&nbsp;&nbsp;
                        <span>Discord Webhook: </span>&nbsp;&nbsp;
                        <input type="text" id="settings-discord" autocomplete="off"
                               value="<?php if ($settings_flag){
                                   echo $setting_data[0]->discord;
                               } else {
                                   echo "";
                               } ?>">
                    </div>
                </div>
            </div>
            <div class="row billing-rows">
                <div class="col-md-12" style="text-align: right">
                    <button class="btn btn-success" id="settings-save" onclick="save_settings();"><span class="glyphicon glyphicon-saved"></span> Save Settings</button>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- Saved Modal -->
<div class="modal fade" id="savedSuccessSettingModal" role="dialog" style="margin-top: 150px;">
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
    function show_key() {
        if ($("#settings-key").attr("type") === "password"){
            $("#settings-key").attr("type", "text");
            $("#settings-show-btn").html("<span class=\"glyphicon glyphicon-eye-close\"></span> Hide Key");
        } else {
            $("#settings-key").attr("type", "password");
            $("#settings-show-btn").html("<span class=\"glyphicon glyphicon-eye-open\"></span> Show Key");
        }

    }
    function save_settings() {
        var global = $("#settings-global").val();
        var monitor = $("#settings-monitor").val();
        var discord = $("#settings-discord").val();
        $.ajax({
            type: "POST",
            data: {
                token_id: "<?php echo $token_id; ?>",
                global: global,
                monitor: monitor,
                discord: discord,
                type: "save_settings"
            },
            url: "<?php echo base_url(); ?>setting/save_settings",
            success: function (res) {
                $("#savedSuccessSettingModal").modal();
            }
        });
    }
</script>
</body>
</html>

