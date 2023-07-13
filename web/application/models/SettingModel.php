<?php
/**
 * Created by PhpStorm.
 * User: DEV-14
 * Date: 7/9/2018
 * Time: 4:58 AM
 */

defined('BASEPATH') OR exit('No direct script access allowed');

class SettingModel extends CI_Model
{
    function __construct()
    {
        parent::__construct();
        $this->load->database();
    }
    function get_token($id){
        $this->db->select('*');
        $this->db->from('token');
        $this->db->where('id', $id);
        $query = $this->db->get();
        return $query->result();
    }
    function check_token_id($id){
        $this->db->where('id', $id);
        $query = $this->db->get('token');
        if ($query->num_rows() > 0){
            return true;
        }else{
            return false;
        }
    }
    function get_settings($token_id){
        $this->db->select('*');
        $this->db->from('setting');
        $this->db->where('token_id', $token_id);
        $query = $this->db->get();
        return $query->result();
    }
    function check_settings($token_id){
        $this->db->where('token_id', $token_id);
        $query = $this->db->get('setting');
        if ($query->num_rows() > 0){
            return true;
        }else{
            return false;
        }
    }
    function save_settings($data){
        if ($this->check_settings($data['token_id'])){
            $this->db->where('token_id', $data['token_id']);
            $this->db->update('setting', $data);
        } else {
            $this->db->insert('setting', $data);
        }
    }
}