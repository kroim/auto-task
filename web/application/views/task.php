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
    <title>AutoTask/Tasks</title>
    <link rel="stylesheet" href="<?php echo site_url('assets/js/select2/select2.css')?>">
    <link rel="stylesheet" href="<?php echo site_url('assets/loader/css/main.css')?>">
    <link rel="stylesheet" href="<?php echo site_url('assets/bootstrap-3.3.7/css/bootstrap.min.css')?>">
    <link rel="stylesheet" href="<?php echo site_url('assets/css/custom.css')?>">
    <!--<link rel="stylesheet" href="<?php echo site_url('assets/chosen_v1.8.7/chosen.css')?>">-->
    <script src="<?php echo site_url('assets/js/jquery_3.3.1.js')?>"></script>
    <script src="<?php echo site_url('assets/bootstrap-3.3.7/js/bootstrap.min.js')?>"></script>
    <script src="<?php echo site_url('assets/loader/js/modernizr-2.6.2.min.js')?>"></script>
</head>
<body>
<div id="loader-wrapper">
    <div id="loader"></div>
    <div class="loader-section section-left"></div>
    <div class="loader-section section-right"></div>
</div>
<div class="container">
    <input type="hidden" id="token-id" value="<?php echo $token_id; ?>">
    <div class="content">
        <div class="table-responsive" style="height: 90%;">
            <table class="table" id="task">
                <thead>
                <tr>
                    <th style="width: 3%;">ID</th>
                    <th style="width: 10%;">Retailer</th>
                    <th style="width: 20%;">Product</th>
                    <th style="width: 3%;">Size</th>
                    <th style="width: 15%;">Start Time</th>
                    <th style="width: 8%;">Profile</th>
                    <th style="width: 16%;">Proxy</th>
                    <th style="width: 13%;">Status</th>
                    <th style="width: 12%;">Action</th>
                </tr>
                </thead>
                <tbody>
                <?php
                $task_len = sizeof($task_data);
                for($i = 0; $i < $task_len; $i++){ ?>
                    <tr id="taskId-<?php echo $task_data[$i]->id; ?>">
                        <td><?php echo $task_data[$i]->id; ?></td>
                        <td id="retailer-<?php echo $task_data[$i]->id; ?>"><?php echo $task_data[$i]->retailer; ?></td>
                        <td id="product-<?php echo $task_data[$i]->id; ?>"><?php
                            $task_products = unserialize($task_data[$i]->product);
                            $products = "";
                            foreach ($task_products as $task_product){
                                $products .= $task_product.", ";
                            }
                            $product_str = rtrim($products,", ");
                            echo $product_str; ?></td>
                        <td id="size-<?php echo $task_data[$i]->id; ?>"><?php echo $task_data[$i]->size; ?></td>
                        <td id="schedule-<?php echo $task_data[$i]->id; ?>"><?php
                            if ($task_data[$i]->schedule == "0000-00-00 00:00:00") echo "manual";
                            else echo $task_data[$i]->schedule; ?></td>
                        <td id="profile-<?php echo $task_data[$i]->id; ?>"><?php echo $task_data[$i]->profile; ?></td>
                        <td id="proxy-<?php echo $task_data[$i]->id; ?>"><?php echo $task_data[$i]->proxy; ?></td>
                        <td id="status-<?php echo $task_data[$i]->id; ?>"><?php echo $task_data[$i]->status; ?></td>
                        <td id="color-<?php echo $task_data[$i]->id; ?>" style="display: none"><?php echo $task_data[$i]->color; ?></td>
                        <td id="category-<?php echo $task_data[$i]->id; ?>" style="display: none"><?php
                            $task_categories = unserialize($task_data[$i]->category);
                            $categories = "";
                            foreach ($task_categories as $task_category){
                                $categories .= $task_category.", ";
                            }
                            $category_str = rtrim($categories,", ");
                            echo $category_str; ?></td>
                        <td id="amount-<?php echo $task_data[$i]->id; ?>" style="display: none"><?php echo $task_data[$i]->amount; ?></td>
                        <td>
                            <button onclick="play_task('<?php echo $task_data[$i]->id; ?>')"><span class="glyphicon glyphicon-play" id="play-<?php echo $task_data[$i]->id; ?>" style="color: green;"></span></button>
                            <button onclick="edit_task('<?php echo $task_data[$i]->id; ?>')"><span class="glyphicon glyphicon-edit" id="edit-<?php echo $task_data[$i]->id; ?>" style="color: orange;"></span></button>
                            <button onclick="remove_task('<?php echo $task_data[$i]->id; ?>')"><span class="glyphicon glyphicon-trash" id="trash-<?php echo $task_data[$i]->id; ?>" style="color: red;"></span></button>
                        </td>
                    </tr>
                <?php }
                ?>
                </tbody>
            </table>
        </div>
        <div id="task-action" style="padding: 10px 15px;">
            <div class="col-md-4">
                <button type="button" class="btn btn-success" id="add-task-modal" onclick="add_task_modal()"><span class="glyphicon glyphicon-plus" style="font-size:16px;"></span> Add Task</button>
                <button type="button" class="btn btn-danger" id="remove-all-task-modal" data-toggle="modal" data-target="#removeAllTaskModal"><span class="glyphicon glyphicon-remove" style="font-size:16px;"></span> Clear All Tasks</button>
            </div>
            <div class="col-md-4" style="text-align: center;">
                <button type="button" class="btn btn-info" onclick="start_all_tasks()"><span class="glyphicon glyphicon-road" style="font-size:16px;"></span> Start All Task</button>
                <button type="button" class="btn btn-warning" onclick="stop_all_tasks()"><span class="glyphicon glyphicon-off" style="font-size:16px;"></span> Stop All Tasks</button>
            </div>
            <div class="col-md-4" style="text-align: right">
                <button type="button" class="btn btn-default"><span class="glyphicon glyphicon-th-large" style="font-size:16px;"></span> Open Captcha Queue</button>
                <button type="button" class="btn btn-default"><span class="glyphicon glyphicon-link" style="font-size:16px;"></span> Link Change</button>
            </div>
        </div>
    </div>
</div>
<!-- Add Task Modal -->
<div class="modal fade" id="addTaskModal" role="dialog">
    <div class="modal-dialog">
        <!-- Modal content-->
        <div class="modal-content" style="padding-top: 30px;">
            <form>
                <div class="modal-body" >
                    <div class="row">
                        <div class="col-md-6 col-sm-6">
                            <div class="row">
                                <div class="col-md-4 col-sm-4"><h5 style="color: orangered;"> Site </h5></div>
                                <div class="col-md-8 col-sm-8">
                                    <select class="form-control" id="add-task-retailer" style="border: none">
                                        <option value="Supreme"> Supreme</option>
                                        <option value="12amrun"> 12amrun</option>
                                        <option value="A-Ma-Maniere"> A-Ma-Maniere</option>
                                        <option value="APBStore"> APBStore</option>
                                        <option value="AddictMiami"> AddictMiami</option>
                                        <option value="AntiSocialSocialClub"> AntiSocialSocialClub</option>
                                        <option value="Attic"> Attic</option>
                                        <option value="BBCIceCream"> BBCIceCream</option>
                                        <option value="Bape"> Bape</option>
                                        <option value="Beatniconline"> Beatniconline</option>
                                        <option value="BlackMarketUS"> BlackMarketUS</option>
                                        <option value="Blends"> Blends</option>
                                        <option value="Bodega"> Bodega</option>
                                        <option value="BowsAndArrows"> BowsAndArrows</option>
                                        <option value="BurnRubber"> BurnRubber</option>
                                        <option value="Commonwealth"> Commonwealth</option>
                                        <option value="Concepts"> Concepts</option>
                                        <option value="CrtsdSnkrs"> CrtsdSnkrs</option>
                                        <option value="DreamTown"> DreamTown</option>
                                        <option value="DSM-US"> DSM-US</option>
                                        <option value="Notre"> Notre</option>
                                        <option value="ObeyGiant"> ObeyGiant</option>
                                        <option value="OctobersVeryOwnCA"> OctobersVeryOwnCA</option>
                                        <option value="OctobersVeryOwnUS"> OctobersVeryOwnUS</option>
                                        <option value="OffTheHook"> OffTheHook</option>
                                        <option value="Oipolloi"> Oipolloi</option>
                                        <option value="Omocat"> Omocat</option>
                                        <option value="Oneness287"> Oneness287</option>
                                        <option value="PackerShoes"> PackerShoes</option>
                                        <option value="PalaceUS"> PalaceUS</option>
                                        <option value="PalaceUK"> PalaceUK</option>
                                        <option value="Par5MilanoYeezy"> Par5MilanoYeezy</option>
                                        <option value="Premier"> Premier</option>
                                        <option value="ProperLBC"> ProperLBC</option>
                                        <option value="RSVPGallery"> RSVPGallery</option>
                                        <option value="ReigningChamp"> ReigningChamp</option>
                                        <option value="Renarts"> Renarts</option>
                                        <option value="RimeNYC"> RimeNYC</option>
                                        <option value="Rise45"> Rise45</option>
                                        <option value="DSM-EU"> DSM-EU</option>
                                        <option value="Exclucity"> Exclucity</option>
                                        <option value="ExtraButter"> ExtraButter</option>
                                        <option value="Feature"> Feature</option>
                                        <option value="FunkoShop"> FunkoShop</option>
                                        <option value="GraffitiPrints"> GraffitiPrints</option>
                                        <option value="Haven"> Haven</option>
                                        <option value="HighsAndLows"> HighsAndLows</option>
                                        <option value="HistoryOfNY"> HistoryOfNY</option>
                                        <option value="Hotoveli"> Hotoveli</option>
                                        <option value="Kith"> Kith</option>
                                        <option value="KylieCosmetics"> KylieCosmetics</option>
                                        <option value="Livestock"> Livestock</option>
                                        <option value="Machus"> Machus</option>
                                        <option value="MarathonSports"> MarathonSports</option>
                                        <option value="MiniShopMadrid"> MiniShopMadrid</option>
                                        <option value="NRML"> NRML</option>
                                        <option value="Noirfonce"> Noirfonce</option>
                                        <option value="Nomad"> Nomad</option>
                                        <option value="RockCityKicks"> RockCityKicks</option>
                                        <option value="RonnieFieg"> RonnieFieg</option>
                                        <option value="RooneyShop"> RooneyShop</option>
                                        <option value="SaintAlfred"> SaintAlfred</option>
                                        <option value="SamTabak"> SamTabak</option>
                                        <option value="ShoeGalleryMiami"> ShoeGalleryMiami</option>
                                        <option value="ShopNiceKicks"> ShopNiceKicks</option>
                                        <option value="SneakerPolitics"> SneakerPolitics</option>
                                        <option value="SneakerWorldShop"> SneakerWorldShop</option>
                                        <option value="SocialStatusPGH"> SocialStatusPGH</option>
                                        <option value="Solefly"> Solefly</option>
                                        <option value="Soleheaven"> Soleheaven</option>
                                        <option value="StoneIsland"> StoneIsland</option>
                                        <option value="Suede"> Suede</option>
                                        <option value="TrophyRoom"> TrophyRoom</option>
                                        <option value="Undefeated"> Undefeated</option>
                                        <option value="Unknwn"> Unknwn</option>
                                        <option value="Vlone"> Vlone</option>
                                        <option value="WishATL"> WishATL</option>
                                        <option value="Xhibition"> Xhibition</option>
                                        <option value="YeezySupply"> YeezySupply</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6 col-sm-6">
                            <div class="row">
                                <div class="col-md-4 col-sm-4"><h5 style="color: orangered;"> Size </h5></div>
                                <div class="col-md-8 col-sm-8">
                                    <select class="form-control" id="add-task-size" style="border: none">
                                        <option value="3"> 3</option>
                                        <option value="3.5"> 3.5</option>
                                        <option value="4"> 4</option>
                                        <option value="4.5"> 4.5</option>
                                        <option value="5"> 5</option>
                                        <option value="5.5"> 5.5</option>
                                        <option value="6"> 6</option>
                                        <option value="6.5"> 6.5</option>
                                        <option value="7"> 7</option>
                                        <option value="7.5"> 7.5</option>
                                        <option value="8"> 8</option>
                                        <option value="8.5"> 8.5</option>
                                        <option value="9"> 9</option>
                                        <option value="9.5"> 9.5</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12 col-sm-12">
                            <div class="row">
                                <div class="col-md-2 col-sm-2"><h5 style="color: orangered">Keywords</h5></div>
                                <div class="col-md-10 col-sm-10">
                                    <select id="add-task-keyword" class="form-control select2 select2-hidden-accessible" multiple tabindex="4" style="width: 100%;">
                                        <option value=""></option>
                                        <option value="t-shirt">t-shirt</option>
                                        <option value="reverso">reverso</option>
                                        <option value="black">black</option>
                                        <option value="navy">navy</option>
                                        <option value="red">red</option>
                                        <option value="tan">tan</option>
                                        <option value="blue">blue</option>
                                        <option value="white">white</option>
                                        <option value="yellow">yellow</option>
                                        <option value="life">life</option>
                                        <option value="embossed">embossed</option>
                                        <option value="white">white</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5 col-sm-5">
                            <div class="row">
                                <div class="col-md-2 col-sm-2"><h5 style="color: orangered;">Color</h5></div>
                                <div class="col-md-10 col-sm-10"><input type="text" class="form-control" id="add-task-color" style="border: none;"></div>
                            </div>
                        </div>
                        <div class="col-md-7 col-sm-7">
                            <div class="row">
                                <div class="col-md-3 col-sm-3">
                                    <h5 style="color: orangered;">Category</h5>
                                </div>
                                <div class="col-md-9 col-sm-9">
                                    <select id="add-task-category" data-placeholder="Choose a Keywords"
                                            class="form-control select2 select2-hidden-accessible" multiple tabindex="4"
                                            style="width: 100%;" >
                                        <option value=""></option>
                                        <option value="new">new</option>
                                        <option value="jackets">Jackets</option>
                                        <option value="shirts">Shirts</option>
                                        <option value="sweat">Sweatshirts</option>
                                        <option value="t-shirt">T-Shirts</option>
                                        <option value="pants">Pants</option>
                                        <option value="shorts">Shorts</option>
                                        <option value="hats">Hats</option>
                                        <option value="bags">Bags</option>
                                        <option value="accessories">Accessories</option>
                                        <option value="skate">Skate</option>
                                        <option value="shoes">Shoes</option>
                                    </select>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-7 col-sm-7">
                            <div class="row">
                                <div class="col-md-5"><h5 style="color: orangered;">Checkout Profile</h5></div>
                                <div class="col-md-7">
                                    <select class="form-control" id="add-task-profile" style="border: none;">
                                        <option disabled selected value>-- select checkout --</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-5 col-sm-5">
                            <div class="row">
                                <div class="col-md-4 col-sm-4"><h5 style="color: orangered;">Amount</h5></div>
                                <div class="col-md-8 col-sm-8"><input class="form-control" id="add-task-amount" style="border: none;" type="number"></div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-4 col-sm-4"><h5 style="color: orangered;">Specific Proxy</h5></div>
                        <div class="col-md-8 col-sm-8"><input type="text" class="form-control" id="add-task-proxy" style="border: none;" placeholder="IP:PORT:USER:PASSWORD"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-4 col-sm-4"><h5 style="color: orangered;">Scheduled Start</h5></div>
                        <div class="col-md-8 col-sm-8">
                            <input type="datetime-local" class="form-control" id="add-task-schedule" style="border: none">
                        </div>
                    </div>
                    <div class="row" >
                        <div class="col-md-12 col-sm-12">
                            <h4 id="add-task-require-modal" style="color: red; text-align: center; display: none"></h4>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-info" onclick="add_task_btn()" style="background: rgb(85, 153, 255);"><span class="glyphicon glyphicon-plus" style="font-size:14px;"></span> Add Task</button>
                    <button type="button" class="btn btn-success" onclick="add_task_done_btn()"><span class="glyphicon glyphicon-thumbs-up" style="font-size:14px;"></span> Done</button>
                </div>
            </form>
        </div>

    </div>
</div>
<!-- Edit Task Modal -->
<div class="modal fade" id="editTaskModal" role="dialog">
    <div class="modal-dialog">
        <!-- Modal content-->
        <div class="modal-content" style="padding-top: 30px;">
            <form>
                <div class="modal-body" >
                    <input type="hidden" id="edit-task-id" value="">
                    <div class="row">
                        <div class="col-md-6 col-sm-6">
                            <div class="row">
                                <div class="col-md-4 col-sm-4"><h5 style="color: orangered;"> Site </h5></div>
                                <div class="col-md-8 col-sm-8">
                                    <select class="form-control" id="edit-task-retailer" style="border: none">
                                        <option value="Supreme"> Supreme</option>
                                        <option value="12amrun"> 12amrun</option>
                                        <option value="A-Ma-Maniere"> A-Ma-Maniere</option>
                                        <option value="APBStore"> APBStore</option>
                                        <option value="AddictMiami"> AddictMiami</option>
                                        <option value="AntiSocialSocialClub"> AntiSocialSocialClub</option>
                                        <option value="Attic"> Attic</option>
                                        <option value="BBCIceCream"> BBCIceCream</option>
                                        <option value="Bape"> Bape</option>
                                        <option value="Beatniconline"> Beatniconline</option>
                                        <option value="BlackMarketUS"> BlackMarketUS</option>
                                        <option value="Blends"> Blends</option>
                                        <option value="Bodega"> Bodega</option>
                                        <option value="BowsAndArrows"> BowsAndArrows</option>
                                        <option value="BurnRubber"> BurnRubber</option>
                                        <option value="Commonwealth"> Commonwealth</option>
                                        <option value="Concepts"> Concepts</option>
                                        <option value="CrtsdSnkrs"> CrtsdSnkrs</option>
                                        <option value="DreamTown"> DreamTown</option>
                                        <option value="DSM-US"> DSM-US</option>
                                        <option value="Notre"> Notre</option>
                                        <option value="ObeyGiant"> ObeyGiant</option>
                                        <option value="OctobersVeryOwnCA"> OctobersVeryOwnCA</option>
                                        <option value="OctobersVeryOwnUS"> OctobersVeryOwnUS</option>
                                        <option value="OffTheHook"> OffTheHook</option>
                                        <option value="Oipolloi"> Oipolloi</option>
                                        <option value="Omocat"> Omocat</option>
                                        <option value="Oneness287"> Oneness287</option>
                                        <option value="PackerShoes"> PackerShoes</option>
                                        <option value="PalaceUS"> PalaceUS</option>
                                        <option value="PalaceUK"> PalaceUK</option>
                                        <option value="Par5MilanoYeezy"> Par5MilanoYeezy</option>
                                        <option value="Premier"> Premier</option>
                                        <option value="ProperLBC"> ProperLBC</option>
                                        <option value="RSVPGallery"> RSVPGallery</option>
                                        <option value="ReigningChamp"> ReigningChamp</option>
                                        <option value="Renarts"> Renarts</option>
                                        <option value="RimeNYC"> RimeNYC</option>
                                        <option value="Rise45"> Rise45</option>
                                        <option value="DSM-EU"> DSM-EU</option>
                                        <option value="Exclucity"> Exclucity</option>
                                        <option value="ExtraButter"> ExtraButter</option>
                                        <option value="Feature"> Feature</option>
                                        <option value="FunkoShop"> FunkoShop</option>
                                        <option value="GraffitiPrints"> GraffitiPrints</option>
                                        <option value="Haven"> Haven</option>
                                        <option value="HighsAndLows"> HighsAndLows</option>
                                        <option value="HistoryOfNY"> HistoryOfNY</option>
                                        <option value="Hotoveli"> Hotoveli</option>
                                        <option value="Kith"> Kith</option>
                                        <option value="KylieCosmetics"> KylieCosmetics</option>
                                        <option value="Livestock"> Livestock</option>
                                        <option value="Machus"> Machus</option>
                                        <option value="MarathonSports"> MarathonSports</option>
                                        <option value="MiniShopMadrid"> MiniShopMadrid</option>
                                        <option value="NRML"> NRML</option>
                                        <option value="Noirfonce"> Noirfonce</option>
                                        <option value="Nomad"> Nomad</option>
                                        <option value="RockCityKicks"> RockCityKicks</option>
                                        <option value="RonnieFieg"> RonnieFieg</option>
                                        <option value="RooneyShop"> RooneyShop</option>
                                        <option value="SaintAlfred"> SaintAlfred</option>
                                        <option value="SamTabak"> SamTabak</option>
                                        <option value="ShoeGalleryMiami"> ShoeGalleryMiami</option>
                                        <option value="ShopNiceKicks"> ShopNiceKicks</option>
                                        <option value="SneakerPolitics"> SneakerPolitics</option>
                                        <option value="SneakerWorldShop"> SneakerWorldShop</option>
                                        <option value="SocialStatusPGH"> SocialStatusPGH</option>
                                        <option value="Solefly"> Solefly</option>
                                        <option value="Soleheaven"> Soleheaven</option>
                                        <option value="StoneIsland"> StoneIsland</option>
                                        <option value="Suede"> Suede</option>
                                        <option value="TrophyRoom"> TrophyRoom</option>
                                        <option value="Undefeated"> Undefeated</option>
                                        <option value="Unknwn"> Unknwn</option>
                                        <option value="Vlone"> Vlone</option>
                                        <option value="WishATL"> WishATL</option>
                                        <option value="Xhibition"> Xhibition</option>
                                        <option value="YeezySupply"> YeezySupply</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6 col-sm-6">
                            <div class="row">
                                <div class="col-md-4 col-sm-4"><h5 style="color: orangered;"> Size </h5></div>
                                <div class="col-md-8 col-sm-8">
                                    <select class="form-control" id="edit-task-size" style="border: none">
                                        <option value="3"> 3</option>
                                        <option value="3.5"> 3.5</option>
                                        <option value="4"> 4</option>
                                        <option value="4.5"> 4.5</option>
                                        <option value="5"> 5</option>
                                        <option value="5.5"> 5.5</option>
                                        <option value="6"> 6</option>
                                        <option value="6.5"> 6.5</option>
                                        <option value="7"> 7</option>
                                        <option value="7.5"> 7.5</option>
                                        <option value="8"> 8</option>
                                        <option value="8.5"> 8.5</option>
                                        <option value="9"> 9</option>
                                        <option value="9.5"> 9.5</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12 col-sm-12">
                            <div class="row">
                                <div class="col-md-2 col-sm-2"><h5 style="color: orangered">Keywords</h5></div>
                                <div class="col-md-10 col-sm-10">
                                    <select id="edit-task-keyword" class="form-control select2 select2-hidden-accessible" multiple tabindex="4" style="width: 100%;">
                                        <option value=""></option>
                                        <option value="t-shirt">t-shirt</option>
                                        <option value="reverso">reverso</option>
                                        <option value="black">black</option>
                                        <option value="navy">navy</option>
                                        <option value="red">red</option>
                                        <option value="tan">tan</option>
                                        <option value="blue">blue</option>
                                        <option value="white">white</option>
                                        <option value="yellow">yellow</option>
                                        <option value="life">life</option>
                                        <option value="embossed">embossed</option>
                                        <option value="white">white</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5 col-sm-5">
                            <div class="row">
                                <div class="col-md-2 col-sm-2"><h5 style="color: orangered;">Color</h5></div>
                                <div class="col-md-10 col-sm-10"><input type="text" class="form-control" id="edit-task-color" style="border: none;"></div>
                            </div>
                        </div>
                        <div class="col-md-7 col-sm-7">
                            <div class="row">
                                <div class="col-md-3 col-sm-3">
                                    <h5 style="color: orangered;">Category</h5>
                                </div>
                                <div class="col-md-9 col-sm-9">
                                    <select id="edit-task-category" data-placeholder="Choose a Keywords"
                                            class="form-control select2 select2-hidden-accessible" multiple tabindex="4"
                                            style="width: 100%;" >
                                        <option value=""></option>
                                        <option value="new">new</option>
                                        <option value="jackets">Jackets</option>
                                        <option value="shirts">Shirts</option>
                                        <option value="sweat">Sweatshirts</option>
                                        <option value="t-shirt">T-Shirts</option>
                                        <option value="pants">Pants</option>
                                        <option value="shorts">Shorts</option>
                                        <option value="hats">Hats</option>
                                        <option value="bags">Bags</option>
                                        <option value="accessories">Accessories</option>
                                        <option value="skate">Skate</option>
                                        <option value="shoes">Shoes</option>
                                    </select>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-7 col-sm-7">
                            <div class="row">
                                <div class="col-md-5 col-sm-5"><h5 style="color: orangered;">Checkout Profile</h5></div>
                                <div class="col-md-7 col-sm-7">
                                    <select class="form-control" id="edit-task-profile" style="border: none;">
                                        <option disabled selected value>-- select checkout --</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-5 col-sm-5">
                            <div class="row">
                                <div class="col-md-4 col-sm-4"><h5 style="color: orangered;">Amount</h5></div>
                                <div class="col-md-8 col-sm-8"><input class="form-control" id="edit-task-amount" style="border: none;" type="number"></div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-4 col-sm-4"><h5 style="color: orangered;">Specific Proxy</h5></div>
                        <div class="col-md-8 col-sm-8"><input type="text" class="form-control" id="edit-task-proxy" style="border: none;" placeholder="IP:PORT:USER:PASSWORD"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-4 col-sm-4"><h5 style="color: orangered;">Scheduled Start</h5></div>
                        <div class="col-md-8 col-sm-8">
                            <input type="datetime-local" class="form-control" id="edit-task-schedule" style="border: none">
                        </div>
                    </div>
                    <div class="row" >
                        <div class="col-md-12 col-sm-12">
                            <h4 id="edit-task-require-modal" style="color: red; text-align: center; display: none"></h4>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-info" onclick="edit_task_btn()" style="background: rgb(85, 153, 255);"><span class="glyphicon glyphicon-check" style="font-size:14px;"></span> Edit Task</button>
                    <button type="button" class="btn btn-success" onclick="add_task_done_btn()"><span class="glyphicon glyphicon-thumbs-up" style="font-size:14px;"></span> Done</button>
                </div>
            </form>
        </div>

    </div>
</div>
<!--Remove All Tasks-->
<div class="modal fade" id="removeAllTaskModal" role="dialog" style="margin-top: 150px;">
    <div class="modal-dialog">
        <!-- Modal content-->
        <div class="modal-content" style="padding-top: 30px;">
            <form>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-md-12 col-sm-12" style="text-align: center">
                            <span class="glyphicon glyphicon-warning-sign" style="font-size: 50px; color: orangered"></span>
                        </div>
                    </div>
                    <h3 style="text-align: center; color: orangered">Are you sure?</h3>
                    <h5 style="text-align: center;">This will delete all of your tasks!</h5>
                    <div class="row">
                        <div class="col-md-12" style="text-align: right">
                            <button type="button" class="btn btn-success" onclick="remove_all_task()">Yes</button>
                            <button type="button" class="btn btn-danger" data-dismiss="modal">Cancel</button>
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </div>
</div>

<script src="<?php echo site_url('assets/js/select2/select2.js')?>"></script>
<script src="<?php echo site_url('assets/loader/js/main.js')?>"></script>
<!--<script src="--><?php //echo site_url('assets/js/custom.js')?><!--"></script>-->
<script>
    $('#add-task-keyword').select2();
    $('#add-task-category').select2();
    $('#edit-task-keyword').select2();
    $('#edit-task-category').select2();
    // Add Task Modal
    function add_task_modal() {
        $.ajax({
            type: "POST",
            data: {
                token_id: "<?php echo $token_id; ?>",
                type: "get_billing_names"
            },
            url: "<?php echo base_url(); ?>billing/get_billings",
            success: function (res) {
                var billing_names = $.parseJSON(res);
                $("#add-task-profile").find('option').remove().end().append('<option disabled selected value>-- select checkout --</option>');
                $.each(billing_names, function(k, v) {
                    $('<option>').val(v.name).text(v.name).appendTo('#add-task-profile');
                });
            }
        });
        $("#addTaskModal").modal();
    }
    // Add Task Function
    function add_task_btn() {
        var add_retailer = $("#add-task-retailer").val();
        var add_size = $("#add-task-size").val();
        var add_keyword = $("#add-task-keyword").val();
        var add_color = $("#add-task-color").val();
        var add_category = $("#add-task-category").val();
        var add_profile = $("#add-task-profile").val();
        var add_amount = $("#add-task-amount").val();
        var add_proxy = $("#add-task-proxy").val();
        var add_schedule = $("#add-task-schedule").val();
        if (add_keyword == ""){
            $("#add-task-require-modal").text("Keyword is required !");
            $("#add-task-require-modal").css("display", "inherit");
        }else if(add_category == ""){
            $("#add-task-require-modal").text("Category is required !");
            $("#add-task-require-modal").css("display", "inherit");
        }else if(add_profile == ""){
            $("#add-task-require-modal").text("Profile is required !");
            $("#add-task-require-modal").css("display", "inherit");
        }else{
            $.ajax({
                type: "POST",
                data: {
                    retailer: add_retailer,
                    size: add_size,
                    keyword: add_keyword,
                    color: add_color,
                    category: add_category,
                    profile: add_profile,
                    amount: add_amount,
                    proxy: add_proxy,
                    schedule: add_schedule,
                    token_id: "<?php echo $token_id; ?>",
                    type: "add"
                },
                url: "<?php echo base_url(); ?>task/add_task",
                success: function(msg){
                    $("#add-task-require-modal").text("Saved Successfully!");
                    $("#add-task-require-modal").css({"display": "inherit", "color": "blue"});
                }
            });
        }
    }
    function add_task_done_btn() {
        location.reload();
    }
    // Play Task Function
    function play_task(id) {
        console.log("#play-"+id);
        if ($("#play-"+id).css('color') == 'rgb(255, 0, 0)'){
            $("#play-"+id).attr('class', 'glyphicon glyphicon-play');
            $("#play-"+id).css('color', 'green');
            $("#status-"+id).text("Stopped");
            $("#status-"+id).css('color', 'red');
        } else {
            $("#play-"+id).attr('class', 'glyphicon glyphicon-stop');
            $("#play-"+id).css('color', 'red');
            $("#status-"+id).text("Looking product");
            $("#status-"+id).css('color', 'green');
        }
    }
    // Edit Task Function
    function edit_task(id) {
        var profile = $("#profile-"+id).text();
        $.ajax({
            type: "POST",
            data: {
                token_id: "<?php echo $token_id; ?>",
                type: "get_billing_names"
            },
            url: "<?php echo base_url(); ?>billing/get_billings",
            success: function (res) {
                var billing_names = $.parseJSON(res);
                $("#edit-task-profile").find('option').remove().end().append('<option disabled selected value>-- select checkout --</option>');
                $.each(billing_names, function(k, v) {
                    if (v.name === profile){
                        $('<option selected>').val(v.name).text(v.name).appendTo('#edit-task-profile');
                    } else {
                        $('<option>').val(v.name).text(v.name).appendTo('#edit-task-profile');
                    }
                });
            }
        });
        console.log(profile);
        $("#edit-task-id").val(id);
        $("#edit-task-retailer").val($("#retailer-"+id).text());
        $("#edit-task-size").val($("#size-"+id).text());
        var keywords = $("#product-"+id).text().split(", ");
        $("#edit-task-keyword").val(keywords);
        $('.select2').select2();
        $("#edit-task-color").val($("#color-"+id).val());
        var categories = $("#category-"+id).text().split(", ");
        $("#edit-task-category").val(categories);
        $('.select2').select2();
//        $("#edit-task-profile").val($("#profile-"+id).text());
        $("#edit-task-amount").val($("#amount-"+id).text());
        var proxy = $("#proxy-"+id).text();
        if (proxy === "auto"){
            $("#edit-task-proxy").val("");
        } else {
            $("#edit-task-proxy").val($("#proxy-"+id).text());
        }
        $("#edit-task-schedule").val($("#schedule-"+id).text());
        console.log($("#schedule-"+id).text());
        $("#editTaskModal").modal();
    }
    function edit_task_btn() {
        var edit_id = $("#edit-task-id").val();
        var edit_retailer = $("#edit-task-retailer").val();
        var edit_size = $("#add-task-size").val();
        var edit_keyword = $("#edit-task-keyword").val();
        var edit_color = $("#edit-task-color").val();
        var edit_category = $("#edit-task-category").val();
        var edit_profile = $("#edit-task-profile").val();
        var edit_amount = $("#edit-task-amount").val();
        var edit_proxy = $("#edit-task-proxy").val();
        var edit_schedule = $("#edit-task-schedule").val();
        if (edit_keyword == ""){
            $("#edit-task-require-modal").text("Keyword is required !");
            $("#edit-task-require-modal").css("display", "inherit");
        }else if(edit_category == ""){
            $("#edit-task-require-modal").text("Category is required !");
            $("#edit-task-require-modal").css("display", "inherit");
        }else if(edit_profile == ""){
            $("#edit-task-require-modal").text("Profile is required !");
            $("#edit-task-require-modal").css("display", "inherit");
        }else{
            $.ajax({
                type: "POST",
                data: {
                    id: edit_id,
                    retailer: edit_retailer,
                    size: edit_size,
                    keyword: edit_keyword,
                    color: edit_color,
                    category: edit_category,
                    profile: edit_profile,
                    amount: edit_amount,
                    proxy: edit_proxy,
                    schedule: edit_schedule,
                    token_id: "<?php echo $token_id; ?>",
                    type: "edit"
                },
                url: "<?php echo base_url(); ?>task/edit_task",
                success: function(msg){
                    $("#edit-task-require-modal").text("Editing Done!");
                    $("#edit-task-require-modal").css({"display": "inherit", "color": "blue"});
                }
            });
        }
    }
    // Remove Task Function
    function remove_task(id) {
        $.ajax({
            type: "POST",
            data: {
                id: id,
                token_id: "<?php echo $token_id; ?>",
                type: "remove"
            },
            url: "<?php echo base_url(); ?>task/remove_task",
            success: function (msg) {
                $("#taskId-"+id).remove();
            }
        });
    }
    // Remove All Tasks
    function remove_all_task() {
        $.ajax({
            type: "POST",
            data: {
                token_id: "<?php echo $token_id; ?>",
                type: "remove_all"
            },
            url: "<?php echo base_url(); ?>task/remove_all",
            success: function (msg) {
                location.reload();
            }
        });
    }
    // Start All Tasks
    function start_all_tasks() {
        $("span[id^='play-']").attr('class', 'glyphicon glyphicon-stop');
        $("span[id^='play-']").css('color','red');
        $("td[id^='status-']").text("Looking product");
        $("td[id^='status-']").css('color', 'green');
    }
    // Stop All Tasks
    function stop_all_tasks() {
        $("span[id^='play-']").attr('class', 'glyphicon glyphicon-play');
        $("span[id^='play-']").css('color','green');
        $("td[id^='status-']").text("Stopped");
        $("td[id^='status-']").css('color', 'red');
    }

</script>
</body>
</html>

