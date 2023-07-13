<?php
/**
 * Created by PhpStorm.
 * User: DEV-14
 * Date: 6/24/2018
 * Time: 9:14 PM
 */

defined('BASEPATH') OR exit('No direct script access allowed');
class Proxy extends CI_Controller{

    public function __construct()
    {
        parent::__construct();
        $this->load->helper(array('form', 'url', 'html'));
        $this->load->database();
    }
    public function index(){
        echo "<h1 style='text-align: center'>No Customer</h1>";
    }
    public function autotask($id){
        $this->load->view('proxy');
    }
}