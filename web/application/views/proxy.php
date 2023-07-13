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
    <title>AutoTask/Proxies</title>
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
        <div class="table-responsive" style="height: 90%;">
            <table class="table" id="task">
                <thead>
                <tr>
                    <th>ID</th>
                    <th>IP</th>
                    <th>Port</th>
                    <th>User</th>
                    <th>Password</th>
                    <th>Website</th>
                    <th>Speed</th>
                    <th>Action</th>
                </tr>
                </thead>
                <tbody>
                <tr>
                    <td>1</td>
                    <td>233.25.45.48</td>
                    <td>22347</td>
                    <td>user1</td>
                    <td>pass</td>
                    <td>Supreme</td>
                    <td>244ms</td>
                    <td>
                        <button><span class="glyphicon glyphicon-time"></span></button>
                        <button><span class="glyphicon glyphicon-trash"></span></button>
                    </td>
                </tr>
                </tbody>
            </table>
        </div>
        <div id="task-action" style="padding: 10px 15px;">
            <div class="col-md-4">
                <button type="button" class="btn btn-success"><span class="glyphicon glyphicon-plus" style="font-size:16px;"></span> Add Proxy</button>
            </div>
            <div class="col-md-4" style="text-align: center;">
                <button type="button" class="btn btn-info"><span class="glyphicon glyphicon-road" style="font-size:16px;"></span> Start All Proxies</button>
            </div>
            <div class="col-md-4" style="text-align: right">
                <button type="button" class="btn btn-danger"><span class="glyphicon glyphicon-remove" style="font-size:16px;"></span> Clear All Proxies</button>
            </div>
        </div>
    </div>
</div>
<script src="<?php echo site_url('assets/loader/js/main.js')?>"></script>
<script src="<?php echo site_url('assets/js/custom.js')?>"></script>
</body>
</html>

