<?php
/**
 * Created by PhpStorm.
 * User: DEV-14
 * Date: 7/9/2018
 * Time: 4:58 AM
 */

defined('BASEPATH') OR exit('No direct script access allowed');

class BillingModel extends CI_Model
{
    function __construct()
    {
        parent::__construct();
        $this->load->database();
    }
    function getBillings($id){
        $this->db->select('*');
        $this->db->from('billing');
        $this->db->where('token_id', $id);
        $query = $this->db->get();
        return $query->result();
    }
    function getBillingInfo($name, $token_id){
        $this->db->select('*');
        $this->db->from('billing');
        $this->db->where('name', $name);
        $this->db->where('token_id', $token_id);
        $query = $this->db->get();
        return $query->result();
    }
    function addBillings($data){
        $this->db->insert('billing', $data);
        $this->db->insert_id();
    }
    function editBillings($data){
        $this->db->where('name', $data['name']);
        $this->db->where('token_id', $data['token_id']);
        $this->db->update('billing', $data);
    }
    function deleteBillings($name, $token_id){
        $this->db->where('name', $name);
        $this->db->where('token_id', $token_id);
        $this->db->delete('billing');
    }
    function profile_exists($name, $token_id){
        $this->db->where('token_id',$token_id);
        $this->db->where('name', $name);
        $query = $this->db->get('billing');
        if ($query->num_rows() > 0){
            return true;
        }else{
            return false;
        }
    }
//    function deleteAll($token_id){
//        $this->db->where('token_id', $token_id);
//        $this->db->delete('tasks');
//    }
}