<?php
/**
 * Created by PhpStorm.
 * User: DEV-14
 * Date: 6/24/2018
 * Time: 9:14 PM
 */

defined('BASEPATH') OR exit('No direct script access allowed');
class Setting extends CI_Controller{

    public function __construct()
    {
        parent::__construct();
        $this->load->helper(array('form', 'url', 'html'));
        $this->load->database();
        $this->load->model('SettingModel');
    }
    public function index(){
        echo "<h1 style='text-align: center'>No Customer</h1>";
    }
    public function autotask($id){
        $data = array();
        $data['token_id'] = $id;
        if ($this->SettingModel->check_token_id($id)){
            $data['token'] = $this->SettingModel->get_token($id)[0]->token;
        } else {
            redirect('setting/index');
        }
        $data['setting_data'] = $this->SettingModel->get_settings($id);
        $this->load->view('setting', $data);
    }
    public function save_settings(){
        $type = $this->input->post('type');
        if ($type == "save_settings"){
            $settings_data = array(
                'token_id' => $this->input->post('token_id'),
                'global_delay' => $this->input->post('global'),
                'monitor_delay' => $this->input->post('monitor'),
                'version' => "1.0.0",
                'discord' => $this->input->post('discord')
            );
            $this->SettingModel->save_settings($settings_data);
            echo "success";
        }
    }
}