<?php
/**
 * Created by PhpStorm.
 * User: DEV-14
 * Date: 7/9/2018
 * Time: 4:58 AM
 */

defined('BASEPATH') OR exit('No direct script access allowed');

class TaskModel extends CI_Model
{
    function __construct()
    {
        parent::__construct();
        $this->load->database();
    }

    function getTasks($id){
        $this->db->select('*');
        $this->db->from('tasks');
        $this->db->where('token_id', $id);
        $query = $this->db->get();
        return $query->result();
    }
    function addTasks($data){
        $this->db->insert('tasks', $data);
        $this->db->insert_id();
    }
    function editTasks($id, $data){
        $this->db->where('id', $id);
        $this->db->update('tasks', $data);
    }
    function deleteTasks($id){
        $this->db->where('id', $id);
        $this->db->delete('tasks');
    }
    function deleteAll($token_id){
        $this->db->where('token_id', $token_id);
        $this->db->delete('tasks');
    }
}