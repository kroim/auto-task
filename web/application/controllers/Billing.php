<?php
/**
 * Created by PhpStorm.
 * User: DEV-14
 * Date: 6/24/2018
 * Time: 9:14 PM
 */

defined('BASEPATH') OR exit('No direct script access allowed');
class Billing extends CI_Controller{

    public function __construct()
    {
        parent::__construct();
        $this->load->helper(array('form', 'url', 'html'));
        $this->load->database();
        $this->load->model('BillingModel');
    }
    public function index(){
        echo "<h1 style='text-align: center'>No Customer</h1>";
    }
    public function autotask($id){
        $data = array();
        $data['token_id'] = $id;
        $data['billing_data'] = $this->BillingModel->getBillings($id);
        $this->load->view('billing', $data);
    }
    public function add_billing(){
        $type = $this->input->post('type');
        if ($type == "add") {
            $name = $this->input->post('name');
            $token_id = $this->input->post('token_id');
            $billing_data = array(
                'name' => $this->input->post('name'),
                'email' => $this->input->post('email'),
                'phone' => $this->input->post('phone'),
                'cardName' => $this->input->post('cardName'),
                'cardNum' => $this->input->post('cardNum'),
                'expiry' => $this->input->post('expiry'),
                'cvv' => $this->input->post('cvv'),
                'f_name' => $this->input->post('f_name'),
                'l_name' => $this->input->post('l_name'),
                'address1' => $this->input->post('address1'),
                'address2' => $this->input->post('address2'),
                'zipcode' => $this->input->post('zipcode'),
                'city' => $this->input->post('city'),
                'country' => $this->input->post('country'),
                'state' => $this->input->post('state'),
                'bf_name' => $this->input->post('bf_name'),
                'bl_name' => $this->input->post('bl_name'),
                'b_address1' => $this->input->post('b_address1'),
                'b_address2' => $this->input->post('b_address2'),
                'b_zipcode' => $this->input->post('b_zipcode'),
                'b_city' => $this->input->post('b_city'),
                'b_country' => $this->input->post('b_country'),
                'b_state' => $this->input->post('b_state'),
                'token_id' => $this->input->post('token_id')
            );
            if ($this->BillingModel->profile_exists($name, $token_id)){
                $this->BillingModel->editBillings($billing_data);
            }else{
                $this->BillingModel->addBillings($billing_data);
            }
            echo $name;
        }
    }
    function remove_billing(){
        $type = $this->input->post('type');
        if ($type == "remove") {
            $name = $this->input->post('name');
            $token_id = $this->input->post('token_id');
            $this->BillingModel->deleteBillings($name, $token_id);
            echo $name;
        }
    }
    function get_billings(){
        $type = $this->input->post('type');
        if ($type == "get_billing_names") {
            $token_id = $this->input->post('token_id');
            $billing_data = $this->BillingModel->getBillings($token_id);
            echo json_encode($billing_data);
        } elseif ($type == "get_billing"){
            $token_id = $this->input->post('token_id');
            $name = $this->input->post('profile_name');
            $billingIfo = $this->BillingModel->getBillingInfo($name, $token_id);
            echo json_encode($billingIfo[0]);
        }
    }
}