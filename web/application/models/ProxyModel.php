<?php
/**
 * Created by PhpStorm.
 * User: DEV-14
 * Date: 7/9/2018
 * Time: 4:58 AM
 */

defined('BASEPATH') OR exit('No direct script access allowed');

class ProxyModel extends CI_Model
{
    function __construct()
    {
        parent::__construct();
        $this->load->database();
    }
}